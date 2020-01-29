using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_XMLassignment
{
    public partial class UpdateTea : Form
    {
        public UpdateTea()
        {
            InitializeComponent();
        }

        private void UpdateTea_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string seloption = ddOptions.selectedValue;
            string newval = tbNewValue.Text;
            string xmlFile = "teacherdata.xml";
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load(xmlFile);
            xmlDoc.SelectSingleNode("StaffInfo/Teacher/" + seloption).InnerText = newval;
            xmlDoc.Save(xmlFile);
            MessageBox.Show("" + seloption + " updated successfully!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
