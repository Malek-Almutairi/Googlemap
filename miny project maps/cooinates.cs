using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miny_project_maps
{
    public partial class cooinates : Form
    {
        public cooinates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(textBox1.Text);
            double longt = Convert.ToDouble(textBox2.Text);
            gMapControl1.Position = new GMap.NET.PointLatLng(lat, longt);
            gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 500;
            gMapControl1.Zoom = 20;

        }
    }
}
