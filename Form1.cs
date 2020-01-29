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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnSignUp_Click(object sender, EventArgs e)
        {
            TeacherCls tc = new TeacherCls();
            tc.FName = tbFname.Text.ToString();
            tc.LName = tbLname.Text.ToString();
            tc.CNIC = tbCnic.Text.ToString();  
            tc.Phone = tbContact.Text.ToString(); 
            tc.StaffID = Convert.ToInt32(tbStaffId.Text);
            tc.Email = tbEmail.Text.ToString();
            tc.UserName = tbUsername.Text.ToString();
            tc.Password = tbPassword.Text.ToString();     
            tc.Dept = ddDept.selectedValue;
            bool v = WriteInXML(tc);
            if (v == true)
                MessageBox.Show("Successful updation");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbFname.Text = "";
            tbLname.Text = "";
            tbCnic.Text = "";
            tbContact.Text = "";
            tbStaffId.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";

        }

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        public bool WriteInXML(TeacherCls t)
        {
            bool x = false;
            try
            {
                if(!File.Exists("teacherdata.xml"))
                {
                    XmlTextWriter w = new XmlTextWriter("teacherdata.xml", System.Text.Encoding.UTF8);
                    w.WriteStartDocument();
                    w.WriteStartElement("StaffInfo");
                    w.WriteStartElement("Teacher");
                    w.WriteElementString("StaffID", t.StaffID.ToString());
                    w.WriteElementString("FirstName", t.FName);
                    w.WriteElementString("LastName", t.LName);
                    w.WriteElementString("PhoneNo", t.Phone);
                    w.WriteElementString("CNIC", t.CNIC);
                    w.WriteElementString("Department", t.Dept);
                    w.WriteElementString("Email", t.Email);
                    w.WriteElementString("Username", t.UserName);
                    w.WriteElementString("Password", t.Password);
                    w.WriteEndElement();
                    w.WriteEndElement();
                    w.WriteEndDocument();
                    w.Flush();
                    w.Close();
                }
                else
                {
                    XmlDocument xd = new XmlDocument();
                    xd.Load("teacherdata.xml");
                    XmlElement subroot = xd.CreateElement("Teacher");
                    XmlElement ren = xd.CreateElement("StaffID");
                    XmlText xt2 = xd.CreateTextNode(t.StaffID.ToString());
                    ren.AppendChild(xt2);
                    subroot.AppendChild(ren);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement fn = xd.CreateElement("FirstName");
                    XmlText xt = xd.CreateTextNode(t.FName);
                    fn.AppendChild(xt);
                    subroot.AppendChild(fn);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement ln = xd.CreateElement("LastName");
                    XmlText xt1 = xd.CreateTextNode(t.LName);
                    ln.AppendChild(xt1);
                    subroot.AppendChild(ln);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement ph = xd.CreateElement("PhoneNo");
                    XmlText xt3 = xd.CreateTextNode(t.Phone);
                    ph.AppendChild(xt3);
                    subroot.AppendChild(ph);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement cn = xd.CreateElement("CNIC");
                    XmlText xt4 = xd.CreateTextNode(t.CNIC);
                    cn.AppendChild(xt4);
                    subroot.AppendChild(cn);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement dep = xd.CreateElement("Department");
                    XmlText xt6 = xd.CreateTextNode(t.Dept);
                    dep.AppendChild(xt6);
                    subroot.AppendChild(dep);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement em = xd.CreateElement("Email");
                    XmlText xt7 = xd.CreateTextNode(t.Email);
                    em.AppendChild(xt7);
                    subroot.AppendChild(em);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement un = xd.CreateElement("Username");
                    XmlText xt8 = xd.CreateTextNode(t.UserName);
                    un.AppendChild(xt8);
                    subroot.AppendChild(un);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement pw = xd.CreateElement("Password");
                    XmlText xt9 = xd.CreateTextNode(t.Password);
                    pw.AppendChild(xt9);
                    subroot.AppendChild(pw);
                    xd.DocumentElement.AppendChild(subroot);
                    xd.Save("teacherdata.xml");
                }
                x = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing staff data to file");
            }

            return x;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
