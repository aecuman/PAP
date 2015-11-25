using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Odbc;
using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace PAP
{
    public partial class Dev_Form : Form
    {

        Navigation qp = new Navigation();
        OdbcConnection cn = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcCommand cmd;
        List<String> items = new List<String>();
        List<String> strid = new List<String>();
        List<String> Structure = new List<String>();
        List<String> rid = new List<String>();
        List<String> raid = new List<String>();

        public delegate void passdata(TextBox Text);


        public Dev_Form()
        {

            InitializeComponent();
            btnDel.Visible = false;
            foreach (DataGridViewRow item in this.dataGrid_Dev.SelectedRows)
                btnDel.Visible = true;

            cn.Open();
            using (cmd = new OdbcCommand("select strid,Structure from structure", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    strid.Add("");
                    Structure.Add("");
                    while (reader.Read())
                    {
                        strid.Add(reader.GetString(0));
                        Structure.Add(reader.GetString(1));
                    }
                }
            }
            //structures.DataSource = items;
            this.structures.Items.AddRange(Structure.ToArray());
            // structures.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            structures.AutoCompleteSource = AutoCompleteSource.ListItems;
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(structures.Text))
            {
                MessageBox.Show("Select a Development.");
                return;
            }
            if (string.IsNullOrEmpty(AreaTextbox.Text))
            {
                MessageBox.Show("insert area or number of Develoment selected.");
                return;
            }
            dataGrid_Dev.Rows.Add(structures.SelectedItem, AreaTextbox.Text);
            structures.SelectedIndex = 0;
            AreaTextbox.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {/*
                foreach (DataGridViewRow rw in this.dataGrid_Dev.Rows)
                {
                    for (int i = 0; i < rw.Cells.Count; i++)
                    {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value)
                        {
                            // here is your message box...
                            MessageBox.Show(" Developments Table is empty");
                            button6.Visible = true;
                            
                            return;
                        }
                    }
                }*/
                var confirmResult = MessageBox.Show("Are you sure ??",
                            "Confirm Save!!",
                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    cn.Open();
                    foreach (DataGridViewRow Datarow in dataGrid_Dev.Rows)
                    {
                        if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                        {
                            long sid = Int64.Parse(strid[Structure.IndexOf(Datarow.Cells[0].Value.ToString())]);
                            decimal aid = Decimal.Parse(Datarow.Cells[1].Value.ToString());
                            
                           
                            {
                                String pap = (textBox1.Text).Split('-')[0];
                                
                                using (cmd = new OdbcCommand("INSERT INTO `pap`.`pap_str_area` (`psaid`, `papid`, `struid`, `Area`) VALUES (NULL, '" + pap + "', '" + sid + "', '" + aid + "')", cn))
                                    
                                    cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    
                    cn.Close();
                    passdata pd = new passdata(qp.person);
                    pd(this.textBox1);

                    this.Hide();
                    qp.Show();
                }
                else
                {
                    return;
                }
            }

           // }
        }
        public void person(TextBox textb)
        {

            textBox1.Text = textb.Text;
        }
        private void validateTextDouble(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains(','))
                        throw X;
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGrid_Dev.SelectedRows)
            {
                dataGrid_Dev.Rows.RemoveAt(item.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            dataGrid_Dev.CurrentRow.SetValues(structures.SelectedItem, AreaTextbox.Text);
            structures.SelectedIndex = 0;
            AreaTextbox.Text = "";
            button2.Visible = false;
            button3.Visible = true;
        }

        private void dataGrid_Dev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = true;
            btnDel.Visible = false;
            button3.Visible = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid_Dev.Rows[e.RowIndex];

                structures.Text = row.Cells["Column1"].Value.ToString();

                AreaTextbox.Text = row.Cells["Column2"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(strutextBox.Text))
            {
                MessageBox.Show("Insert New Structure.");
                return;
            }
            cn.Open();
            String pidd = null;
            using (cmd = new OdbcCommand("Select Structure from `pap`.`structure` where  Structure='" + strutextBox.Text + "'", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        pidd = reader.GetString(0);
                    }
                    reader.Close();
                }
                if (pidd != null)
                {
                    MessageBox.Show("The New Semi Permanent Structure Already Exists");
                    return;

                }
                using (cmd = new OdbcCommand("INSERT INTO  `pap`.`structure` (`Strid` ,`Structure` ,`Rate`)VALUES (NULL ,  '" + strutextBox.Text + "', '0');", cn))
                    cmd.ExecuteNonQuery();
                strutextBox.Text = "";
                cn.Close();

            }


        }

        private void dataGrid_Dev_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnDel.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure ??",
                        "Confirm Exit!!",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                passdata pd = new passdata(qp.person);
                pd(this.textBox1);

                this.Hide();
                qp.Show();
            }
            else
            {
                return;
            }
        }
    }
}
