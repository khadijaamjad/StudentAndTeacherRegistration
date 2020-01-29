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
using System.Xml.Linq;
using System.IO;

namespace VP_XMLassignment
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public void btnSignUp_Click(object sender, EventArgs e)
        {
            StudentCls sc = new StudentCls();
            sc.IntakeYear = Convert.ToInt32(tbIntakeYear.Text);
            sc.CNIC = tbCnic.Text.ToString();
            sc.Dept = ddDept.selectedValue;
            sc.Email = tbEmail.Text.ToString();
            sc.FName = tbFname.Text.ToString();
            sc.LName = tbLname.Text.ToString();
            sc.PhoneNo = tbContact.Text.ToString();
            sc.RegNo = Convert.ToInt32(tbRegNo.Text);
            sc.Password = tbPassword.Text.ToString();
            sc.UserName = tbUsername.Text.ToString();
            bool n = WriteInXML(sc);
            if (n == true)
                MessageBox.Show("Successful updation");
        }

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbFname.Text = "";
            tbLname.Text = "";
            tbCnic.Text = "";
            tbContact.Text = "";
            tbRegNo.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbIntakeYear.Text = "";
        }
        public bool WriteInXML(StudentCls s)
        {
            bool x = false;
            try
            {
                if (!File.Exists("studentdata.xml")) 
                {
                    XmlTextWriter w = new XmlTextWriter("studentdata.xml", System.Text.Encoding.UTF8);
                    w.WriteStartDocument();
                    w.WriteStartElement("StudentInfo");
                    w.WriteStartElement("Student");
                    w.WriteElementString("RegistrationNo", s.RegNo.ToString());
                    w.WriteElementString("FirstName", s.FName);
                    w.WriteElementString("LastName", s.LName);
                    w.WriteElementString("PhoneNo", s.PhoneNo);
                    w.WriteElementString("CNIC", s.CNIC);
                    w.WriteElementString("IntakeYear", s.IntakeYear.ToString());
                    w.WriteElementString("Department", s.Dept);
                    w.WriteElementString("Email", s.Email);
                    w.WriteElementString("Username", s.UserName);
                    w.WriteElementString("Password", s.Password);
                    w.WriteEndElement();
                    w.WriteEndElement();
                    w.WriteEndDocument();
                    w.Flush();
                    w.Close();
                }
                else
                {
                    XmlDocument xd = new XmlDocument();
                    xd.Load("studentdata.xml");
                    XmlElement subroot = xd.CreateElement("Student");
                    XmlElement ren = xd.CreateElement("RegistrationNo");
                    XmlText xt2 = xd.CreateTextNode(s.RegNo.ToString());
                    ren.AppendChild(xt2);
                    subroot.AppendChild(ren);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement fn=xd.CreateElement("FirstName");
                    XmlText xt = xd.CreateTextNode(s.FName);
                    fn.AppendChild(xt);
                    subroot.AppendChild(fn);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement ln = xd.CreateElement("LastName");
                    XmlText xt1 = xd.CreateTextNode(s.LName);
                    ln.AppendChild(xt1);
                    subroot.AppendChild(ln);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement ph = xd.CreateElement("PhoneNo");
                    XmlText xt3 = xd.CreateTextNode(s.PhoneNo);
                    ph.AppendChild(xt3);
                    subroot.AppendChild(ph);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement cn = xd.CreateElement("CNIC");
                    XmlText xt4 = xd.CreateTextNode(s.CNIC);
                    cn.AppendChild(xt4);
                    subroot.AppendChild(cn);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement iy = xd.CreateElement("IntakeYear");
                    XmlText xt5 = xd.CreateTextNode(s.IntakeYear.ToString());
                    iy.AppendChild(xt5);
                    subroot.AppendChild(iy);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement dep = xd.CreateElement("Department");
                    XmlText xt6 = xd.CreateTextNode(s.Dept);
                    dep.AppendChild(xt6);
                    subroot.AppendChild(dep);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement em = xd.CreateElement("Email");
                    XmlText xt7 = xd.CreateTextNode(s.Email);
                    em.AppendChild(xt7);
                    subroot.AppendChild(em);
                    xd.DocumentElement.AppendChild(subroot); 
                    XmlElement un = xd.CreateElement("Username");
                    XmlText xt8 = xd.CreateTextNode(s.UserName);
                    un.AppendChild(xt8);
                    subroot.AppendChild(un);
                    xd.DocumentElement.AppendChild(subroot);
                    XmlElement pw = xd.CreateElement("Password");
                    XmlText xt9 = xd.CreateTextNode(s.Password);
                    pw.AppendChild(xt9);
                    subroot.AppendChild(pw);
                    xd.DocumentElement.AppendChild(subroot);
                    xd.Save("studentdata.xml");
                }
            
            x = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing student data to file");
            }
            
            return x;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
