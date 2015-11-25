using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAP
{
    public partial class GetStarted : Form
    {
        tables tbl = new tables();
        PersonForm pp = new PersonForm();
        CompenRates comrate = new CompenRates();
       
        public GetStarted()
        {
            
            InitializeComponent();
        }

        private void papBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            pp.Show();
        }

        private void pap_fnbtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            tbl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            comrate.Show();
        }
    }
}
