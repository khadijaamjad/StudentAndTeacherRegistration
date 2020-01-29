using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VP_XMLassignment
{
    public partial class ViewRecords : Form
    {
        public ViewRecords()
        {
            InitializeComponent();
        }

        private void ddType_onItemSelected(object sender, EventArgs e)
        {
           
            if(ddType.selectedIndex==1)
            {
                XmlReader xr = XmlReader.Create("teacherdata.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xr);
                dgRecords.DataSource = ds.Tables[0];
                dgRecords.Show();
            }
            if (ddType.selectedIndex == 2)
            {
                XmlReader xrs = XmlReader.Create("studentdata.xml", new XmlReaderSettings());
                DataSet dss = new DataSet();
                dss.ReadXml(xrs);
                dgRecords.DataSource = dss.Tables[0];
                dgRecords.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewRecords_Load(object sender, EventArgs e)
        {
            dgRecords.Hide();
        }
    }
}
