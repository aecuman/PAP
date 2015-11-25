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
    public partial class Navigation : Form
    {
        
       
        public delegate void passdata(TextBox Text);        
        
        public Navigation()
        {
            InitializeComponent();
            
        }

        public void person(TextBox textb)
        {
            textBox1.Text = textb.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crpform cp = new Crpform();
            passdata pd = new passdata(cp.person);
            pd(this.textBox1); 
            this.Hide();
            cp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dev_Form dv = new Dev_Form();
            passdata pd1 = new passdata(dv.person);
            pd1(this.textBox1);     
            this.Hide();
            dv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonForm pn = new PersonForm();            
            this.Hide();
            pn.Show();

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            GetStarted gp = new GetStarted();
            this.Hide();
            gp.Show();
        }

        
    }
}
