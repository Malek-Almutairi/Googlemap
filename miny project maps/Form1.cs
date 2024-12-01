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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location=textBox1.Text+" "+textBox2.Text+" " + textBox3.Text;
            try
            {
                StringBuilder addres = new StringBuilder();
                addres.Append("http://maps.google.com/maps?q=");
                addres.Append(location + ", " + "+");
                webBrowser1.Navigate(addres.ToString());
                cooinates ID = new cooinates();
                ID.Show();
                
                




            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"eror");

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
