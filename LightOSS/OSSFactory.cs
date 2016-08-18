using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace LightOSS
{
    public partial class OSSFactory : Form
    {
        private IMongoClient _client;
        private string _xAxisKey, _db, _coll, _filterKey, _filter;
        private List<string> _counters = new List<string>();
        private MongoUrl _url;

        public OSSFactory()
        {
            InitializeComponent();
            _initPersistentSettings();
        }

        private void ossButton_Click(object sender, EventArgs e)
        {
            var host = server.Text.Contains("mongodb://") ? server.Text : "mongodb://" + server.Text;

            var url = new MongoUrlBuilder(host);
            
            if (!string.IsNullOrWhiteSpace(user.Text)) url.Username = user.Text;
            if (!string.IsNullOrWhiteSpace(pass.Text)) url.Password = pass.Text;

            _client = new MongoClient(url.ToMongoUrl());
            _populateDatabaseList();
            _url = url.ToMongoUrl();
        }

        private async void _populateDatabaseList()
        {
            databaseListBox.Items.Clear();
            var dbs = await _client.ListDatabasesAsync();
            await dbs.ForEachAsync(d =>
            {
                this.Invoke(new MethodInvoker(delegate () {
                    databaseListBox.Items.Add((string)d["name"]);
                }));
            });
        }

        private async void databaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            collectionsListBox.Items.Clear();
            var collections = await _client
                .GetDatabase((string)databaseListBox.SelectedItem)
                .ListCollectionsAsync();

            await collections.ForEachAsync(c =>
            {
                this.Invoke(new MethodInvoker(delegate () {
                    collectionsListBox.Items.Add((string)c["name"]);
                }));
            });
            _db = (string)databaseListBox.SelectedItem;
            _updateLabels();
        }

        private void _updateLabels()
        {
            if (!settingDBLabel.Text.Equals(_db)) settingDBLabel.Text = _db;
            if (!settingCollLabel.Text.Equals(_coll)) settingCollLabel.Text = _coll;
            if (!settingXAxisLabel.Text.Equals(_xAxisKey)) settingXAxisLabel.Text = _xAxisKey;
        }

        private void postCollection_Click(object sender, EventArgs e)
        {
            var oneDocument = _client
                .GetDatabase((string)databaseListBox.SelectedItem)
                .GetCollection<BsonDocument>((string)collectionsListBox.SelectedItem)
                .Find<BsonDocument>(Builders<BsonDocument>.Filter.Empty)
                .First()
                ;

            foreach(var doc in oneDocument.ToDictionary().Keys)
            {
                keyListBox.Items.Add(doc);
            }
            _coll = (string)collectionsListBox.SelectedItem;
            _updateLabels();
        }

        private void setAxisKey_Click(object sender, EventArgs e)
        {
            _xAxisKey = (string)keyListBox.SelectedItem;
            _updateLabels();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Server = server.Text;
            Settings.Default.User = user.Text;
            Settings.Default.Pass = pass.Text;
            Settings.Default.Save();
        }

        private void addCounter_Click(object sender, EventArgs e)
        {
            if (!_counters.Contains((string)keyListBox.SelectedItem)) _counters.Add((string)keyListBox.SelectedItem);
            _fillCountersBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OSSChart(_url, _db, _coll, _counters, _xAxisKey).Show();
        }

        private void removeCounter_Click(object sender, EventArgs e)
        {
            _counters.Remove((string)countersListBox.SelectedItem);
            _fillCountersBox();
        }

        private void setFilterKey_Click(object sender, EventArgs e)
        {
            _filterKey = (string)keyListBox.SelectedItem;
            _fillFilterValues();
        }

        private void _fillCountersBox()
        {
            countersListBox.Items.Clear();
            _counters.ForEach(c =>
            {
                countersListBox.Items.Add(c);
            });
        }

        private void _initPersistentSettings()
        {
            server.Text = Settings.Default.Server;
            user.Text = Settings.Default.User;
            pass.Text = Settings.Default.Pass;
        }

        private async void _fillFilterValues()
        {
            filterValues.Items.Clear();
            var values = await _client
                .GetDatabase(_db)
                .GetCollection<BsonDocument>(_coll)
                .Find(Builders<BsonDocument>.Filter.Empty)
                .Project(Builders<BsonDocument>.Projection.Include(d => (string)d[_filterKey]))
                .ToListAsync();

            foreach(var val in values.Distinct<BsonDocument>())
            {
                filterValues.Items.Add((string)val[_filterKey]);
            }
        }
    }
}
