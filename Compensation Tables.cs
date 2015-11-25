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
    public partial class Compentbls : Form
    {
        String pidd = null;
       // List<String> pidd = new List<String>();
       // List<String> crppno = new List<String>();
       // List<String> crpprt = new List<String>();
        //List<String> strra = new List<String>();
       // List<String> Age = new List<String>();
            String crppno = null;
            String crpprt = null;
            String strra = null;
            String strrr = null;
        
                    
        OdbcConnection cn = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcCommand cmd;
        public Compentbls()
        {

            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           

            
            // TODO: This line of code loads data into the 'papDataSet.DataTable' table. You can move, or remove it, as needed.
           this.dataTableTableAdapter.Fill(this.papDataSet.DataTable);



        }

        private void back_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure ??",
                        "Confirm !!",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                GetStarted gs = new GetStarted();
                this.Hide();
                gs.Show();
            }
            else
            {
                return;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dv = new DataTable();
          dv = papDataSet.DataTable.Copy();
            dv.DefaultView.RowFilter = "FName like '%" + textBox1.Text + "%'";
            DataGridView.DataSource = dv;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable ds = new DataTable();
            ds = papDataSet.DataTable.Copy();
            ds.DefaultView.RowFilter = "LName like '%" + textBox2.Text + "%'";
            DataGridView.DataSource = ds;
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];

                textBox4.Text = row.Cells["fNameDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = row.Cells["lNameDataGridViewTextBoxColumn"].Value.ToString();
                textBox5.Text = row.Cells["pAPidDataGridViewTextBoxColumn"].Value.ToString();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Select a PAP from PAP list.");
                return;
            }
            if (string.IsNullOrEmpty(textBox11.Text))
            {
                MessageBox.Show("Insert Disturbance Allowance");
                return;
            }

            
          /*  this.dataTable1TableAdapter1.Fill(this.papDataSet.DataTable1);
            DataTable ds = new DataTable();
            ds = papDataSet.DataTable1.Copy();
            ds.DefaultView.RowFilter = " Convert (papid,'System.String') LIKE '%" + textBox5.Text + "%'";
            dataTable1DataGridView.DataSource = ds;
            this.dataTable3TableAdapter.Fill(this.papDataSet.DataTable3);
            DataTable dt = new DataTable();
            dt = papDataSet.DataTable3.Copy();
            dt.DefaultView.RowFilter = " Convert (papid,'System.String') LIKE '%" + textBox5.Text + "%'";
            dataTable3DataGridView.DataSource = dt;
            this.dataTable2TableAdapter.Fill(this.papDataSet.DataTable2);
            DataTable di = new DataTable();
            di = papDataSet.DataTable2.Copy();
            di.DefaultView.RowFilter = " Convert (papid,'System.String') LIKE '%" + textBox5.Text + "%'";
         //   dataTable2DataGridView.DataSource = di;*/
           

            cn.Open();
            String CropVal = null;
            String DevVal = null;
            String LndVal = null;
            String DB = null;
            String DBA = null;
            
            
           // using (cmd = new OdbcCommand("Select PAPid from pap  where (FName='" + textBox4.Text + "' AND LName='" + textBox3.Text + "');", cn))
            using (cmd = new OdbcCommand("SELECT p.PAPid, cp.`Crop Number` * ca.Rate AS Expr1, sa.Area * str.Rate AS Expr2, d.`Size` * d.Rate AS Expr3 FROM pap p, pap_crtyp_age_rate cp, pap_str_area sa, structure str, land d, age a, crop_age ca WHERE p.PAPid = cp.pap AND p.PAPid = sa.papid AND str.Strid = sa.struid AND d.Papid = p.PAPid AND a.Ageid = ca.Age AND (p.FName='" + textBox7.Text + "' AND p.LName='" + textBox8.Text + "');", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        CropVal = reader.GetString(1);
                        DevVal = reader.GetString(2);
                        LndVal = reader.GetString(3);
                    }
                    reader.Close();
                }
            }
            cn.Close();
            textBox12.Text = Convert.ToString(Decimal.Parse(LndVal));
            textBox13.Text = Convert.ToString(Int32.Parse(CropVal));
            textBox17.Text = Convert.ToString(Decimal.Parse(DevVal));
            DB = textBox11.Text;
            textBox15.Text = (Convert.ToString((Int32.Parse(CropVal) + Decimal.Parse(DevVal) + Decimal.Parse(LndVal)) * Decimal.Parse(DB)));
            DBA = textBox15.Text;
            textBox16.Text = (Convert.ToString((Int32.Parse(CropVal) + Decimal.Parse(DevVal) + Decimal.Parse(LndVal) + Decimal.Parse(DBA))));
            textBox9.Text = (Convert.ToString(Int32.Parse(CropVal) + Decimal.Parse(DevVal) + Decimal.Parse(LndVal)));
            MessageBox.Show("Complete Value");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Select a PAP from PAP list.");
                return;
            }
            if (string.IsNullOrEmpty(tentextBox.Text))
            {
                MessageBox.Show("Select Detail to  Edit.");
                return;
            }

            if (string.IsNullOrEmpty(crp_atextBox.Text))
            {
                MessageBox.Show("Select Detail to  Edit.");
                return;
            }


        }

        private void dataTable3DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tenulabel.Visible = true;
            tenutextBox.Visible = true;
            tenu_sizlabel.Visible = true;
            tentextBox.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row2 = this.dataTable3DataGridView.Rows[e.RowIndex];

                tenutextBox.Text = row2.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
                tentextBox.Text = row2.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
                // textBox5.Text = row.Cells["pAPidDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void dataTable2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            crp_atextBox.Visible = true;
            crpnotextBox.Visible = true;
            crptextBox.Visible = true;
            crpnolabel.Visible = true;
            
            Crop_agelabel.Visible = true;
            if (e.RowIndex >= 0)
            {
                /*DataGridViewRow row3 = this.dataTable2DataGridView.Rows[e.RowIndex];

                c_atextBox.Text = row3.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                crpnotextBox.Text = row3.Cells["dataGridViewTextBoxColumn4"].Value.ToString();*/
                // textBox5.Text = row.Cells["pAPidDataGridViewTextBoxColumn"].Value.ToString();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            tenutextBox.Text = "";
            tenutextBox.Text = "";
            tentextBox.Text = "";
            crp_atextBox.Text = "";
            crpnotextBox.Text = "";
            crptextBox.Text = "";
            stru_antextBox.Text = "";
            strutextBox.Text = "";
            tenulabel.Visible = false;
            tenutextBox.Visible = false;
            tenu_sizlabel.Visible = false;
            tentextBox.Visible = false;
            crp_atextBox.Visible = false;
            crpnotextBox.Visible = false;
            crptextBox.Visible = false;
            crpnolabel.Visible = false;
            
            Crop_agelabel.Visible = false;
            stru_antextBox.Visible = false;
            strulabel.Visible = false;
            strutextBox.Visible = false;
            Arealabel.Visible = false;

        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stru_antextBox.Visible = true;
            strulabel.Visible = true;
            strutextBox.Visible = true;
            Arealabel.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row4 = this.dataTable1DataGridView.Rows[e.RowIndex];

                strutextBox.Text = row4.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                stru_antextBox.Text = row4.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                // textBox5.Text = row.Cells["pAPidDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Select a PAP from PAP list.");
                return;
            }


            cn.Open();
            using (cmd = new OdbcCommand("UPDATE pap.land SET Lid = @Lid, Tenure = '" + tenutextBox.Text + "', size = '" + tentextBox.Text + "', Rate = @Rate,papid = @papid " +
      "WHERE papid = '" + textBox5.Text + "'", cn))
                cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Select a PAP from PAP list.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to delete this PAP Permanently ??",
                    "Confirm Delete!!",
                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                cn.Open();
                using (cmd = new OdbcCommand("DELETE FROM  `pap`.`pap` WHERE  `pap`.`PAPid` ='" + textBox5.Text + "';", cn))
                    cmd.ExecuteNonQuery();
                cn.Close();
                DataGridView.Refresh();
            }
            else
            {
                return;
            }
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            cn.Open();
            
            using (cmd = new OdbcCommand("Select p.PAPid,cp.`Crop Number`,ca.Rate,sa.Area,str.Rate from pap p join pap_crtyp_age_rate cp on p.PAPid=cp.pap"
                + " join crop_age ca on cp.crop_age=ca.C_Aid join pap_str_area sa on p.PAPid=sa.papid join `structure`str on str.strid=struid", cn))// where (FName='" + FName.Text + "' AND LName='" + LName.Text + "');", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                                        
                    Joinery.ColumnCount = 5;
                    Joinery.Columns[0].Name = "Person";
                    Joinery.Columns[1].Name = "CropNumber";
                    Joinery.Columns[2].Name = "CropRate";
                    Joinery.Columns[3].Name = "StructureRate";
                    Joinery.Columns[4].Name = "StructureArea";
                    DataGridViewRow row = new DataGridViewRow();
                    while (reader.Read())
                    {                      
                        pidd= reader.GetString(0);
                        crppno = reader.GetString(1);
                        crpprt = reader.GetString(2);
                        strra = reader.GetString(3);
                        strrr = reader.GetString(4);

                        Joinery.Rows.Add(new string[] { pidd, crppno, crpprt, strra, strrr });
                      // pidd=Convert.ToString( Int32.Parse(reader.GetString(1)) * Int32.Parse(reader.GetString(2))); 
                    }
                    
                    reader.Close();
                
                }

            }
            cn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Compentbls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'papDataSet2.DataTable' table. You can move, or remove it, as needed.
            this.dataTableTableAdapter1.Fill(this.papDataSet2.DataTable);
          

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}

