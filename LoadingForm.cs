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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            Student ss = new Student();
            ss.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ViewRecords vr = new ViewRecords();
            vr.Show();
        }

        private void btnEditStu_Click(object sender, EventArgs e)
        {
            UpdateStu su = new UpdateStu();
            su.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            UpdateTea ut = new UpdateTea();
            ut.Show();
        }
    }
}
