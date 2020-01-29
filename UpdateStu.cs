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
using System.IO;

namespace VP_XMLassignment
{
    public partial class UpdateStu : Form
    {
        public UpdateStu()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStu_Click(object sender, EventArgs e)
        {
            string seloption=ddOptions.selectedValue;
            string newval=tbNewValue.Text;
            string xmlFile = "studentdata.xml";
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load(xmlFile);
            xmlDoc.SelectSingleNode("StudentInfo/Student/"+seloption).InnerText = newval;
            xmlDoc.Save(xmlFile);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
