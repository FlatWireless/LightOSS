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
    public partial class OSSChart : Form
    {
        private IMongoCollection<BsonDocument> _coll;
        private string _collection, _database, _xAxisKey;
        private List<string> _counters;
        private int _count;

        public OSSChart(MongoUrl mongoURL, string db,
            string collection, List<string> counters,
            string xAxisKey, int count = 144)
        {
            InitializeComponent();
            
            _database = db;
            _collection = collection;
            _counters = counters;
            _xAxisKey = xAxisKey;
            _count = count;

            _initializeDb(mongoURL);
            _initializeChart();
        }

        private void _initializeDb(MongoUrl url)
        {
            _coll = new MongoClient(url)
                .GetDatabase(_database)
                .GetCollection<BsonDocument>(_collection);
        }

        private void _initializeChart()
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd HH:mm";
            for (int i = 0; i < _counters.Count; i++)
            {
                chart1.Series.Add(_generateSeries(_counters[i]));
                _populateData(_counters[i]);
            }
            
            
        }

        private System.Windows.Forms.DataVisualization.Charting.Series _generateSeries(string counter)
        {
            return new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = counter,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime,
                BorderWidth = 3
            };
        }

        private async void _populateData(string counter)
        {
            var dataPoints = await _coll
                .Find<BsonDocument>(Builders<BsonDocument>.Filter.Empty)
                .SortByDescending(r => r[_xAxisKey])
                .Limit(144)
                .ToListAsync();

            foreach (var point in dataPoints)
            {
                try
                {
                    chart1
                  .Series[counter]
                  .Points
                  .AddXY(((DateTime)point[_xAxisKey]).ToLocalTime(), (long)point[counter]);
                } catch (InvalidCastException ex)
                {
                    chart1
                  .Series[counter]
                  .Points
                  .AddXY(((DateTime)point[_xAxisKey]).ToLocalTime(), (double)point[counter]);
                } 
            }
        }
    }
}
