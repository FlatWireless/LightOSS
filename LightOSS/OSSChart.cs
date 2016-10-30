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
        private int _count, _pollIntervalMs = 60000;

        System.Timers.Timer poller = new System.Timers.Timer
        {
            Interval = 60000,
            Enabled = true
        };
        

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
        }

        private System.Windows.Forms.DataVisualization.Charting.Series _generateSeries(string counter)
        {
            return new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = counter,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime,
                BorderWidth = 3,
                ToolTip = string.Format("#SER{0}{1}: {3}{0}{2}: #VALY", 
                Environment.NewLine,
                _xAxisKey,
                counter,
                "#VALX{MM/dd HH:mm}")
            };
        }

        private async void _populateData()
        {
            this.Invoke(new MethodInvoker(delegate () { this.Text = "OSSChart - Last refreshed at " + DateTime.Now.ToString(); }));
            for (int i = 0; i < _counters.Count; i++)
            {
                this.Invoke(new MethodInvoker(delegate () { chart1.Series[_counters[i]].Points.Clear(); }));
                var dataPoints = await _coll
                    .Find<BsonDocument>(Builders<BsonDocument>.Filter.Empty)
                    .SortByDescending(r => r[_xAxisKey])
                    .Limit(_count)
                    .ToListAsync();

                
                foreach (var point in dataPoints)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        _addPoint(point, _counters[i], _xAxisKey);
                    }));
                }
                
            }
        }
        private void _addPoint(BsonDocument point, string counter, string xValKey)
        {
            dynamic xval, yval;
            try { xval = ((DateTime)point[xValKey]).ToLocalTime(); }
            catch (InvalidCastException ex) { xval = (string)point[xValKey]; }

            try { yval = (int)point[counter]; }
            catch (InvalidCastException ex) {
                try { yval = (long)point[counter]; }
                catch(InvalidCastException longCastEx)
                {
                    yval = (double)point[counter];
                }
            }
            finally
            {
                yval = point[counter].ToString();
            }

            chart1
                .Series[counter]
                .Points
                .AddXY(xval, yval);
        }

        private void _initializeDb(MongoUrl url)
        {
            _coll = new MongoClient(url)
                .GetDatabase(_database)
                .GetCollection<BsonDocument>(_collection);
        }

        private void _initializeChart()
        {
            chart1.Titles.Add(string.Format("{0} - {1}", _database, _collection));
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd HH:mm";
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            for (int i = 0; i < _counters.Count; i++)
            {
                chart1.Series.Add(_generateSeries(_counters[i]));
            }
        }

        #region Event Callbacks

        private void OSSChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            poller.Stop();
        }

        private void _timerCallback(object sender, EventArgs e)
        {
            _populateData();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text, out _pollIntervalMs))
            {
                MessageBox.Show("Refresh interval must be an integer value!\nExamples:\nValid: 10000 or 30000\nInvalid: 30.45");
            }
            poller.Interval = _pollIntervalMs;
        }

        private void OSSChart_Load(object sender, EventArgs e)
        {
            _initializeChart();
            _populateData();

            poller.Elapsed += new System.Timers.ElapsedEventHandler(_timerCallback);
        }

        #endregion
    }
}
