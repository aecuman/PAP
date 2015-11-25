using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Odbc;
using System.Text;
using System.Windows.Forms;

namespace PAP
{
    public partial class tables : Form
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
        String ten = null;
        String sz = null;
        String crp = null;
        String des = null;
        String num = null;
        String ar = null;
        String str = null;
        String pid = null;
        String CropVal = null;
                    String DevVal = null;
                    String LndVal = null;
                    String DB = null;
                    String DBA = null;


        OdbcConnection cn = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcCommand cmd;
        public tables()
        {
            InitializeComponent();
        }

        private void tables_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'papDataSet.DataTable' table. You can move, or remove it, as needed.
            this.dataTableTableAdapter.Fill(this.papDataSet.DataTable);

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

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];

                textBox4.Text = row.Cells["FName"].Value.ToString();
                textBox3.Text = row.Cells["PAPid"].Value.ToString();
                textBox5.Text = row.Cells["LName"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Select a PAP from PAP list.");
                return;
            }
            if (string.IsNullOrEmpty(DBR.Text))
            {
                MessageBox.Show("Insert Disturbance Allowance");
                return;
            }
            this.lnddataGridView.Rows.Clear();
            this.strdataGridView.Rows.Clear();
            this.grpdataGridView.Rows.Clear();

            cn.Open();

            using (cmd = new OdbcCommand("Select l.Lid, t.Tenure, l.`Size` from pap p join land l on l.Papid = p.PAPid"
                + " join tenure t on  l.Tenure = t.Tid and l.Lid='" + textBox3.Text + "'", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {

                    lnddataGridView.ColumnCount = 2;
                   // lnddataGridView.Columns[0].Name = "pid";
                    lnddataGridView.Columns[0].Name = "Tenure";
                    lnddataGridView.Columns[1].Name = "Size";
                    lnddataGridView.Columns[0].MinimumWidth=220;
                    DataGridViewRow row = new DataGridViewRow();
                    while (reader.Read())
                    {
                      //  pid = reader.GetString(0);
                        ten = reader.GetString(1);
                        sz = reader.GetString(2);
                        lnddataGridView.Rows.Add(new string[] { ten, sz });
                        // pidd=Convert.ToString( Int32.Parse(reader.GetString(1)) * Int32.Parse(reader.GetString(2))); 
                    }

                    reader.Close();
                     // using (cmd = new OdbcCommand("Select PAPid from pap  where (FName='" + textBox4.Text + "' AND LName='" + textBox3.Text + "');", cn))
                    

                }
                        using (cmd = new OdbcCommand("Select pcgr.pap, ct.Crop, a.Age, pcgr.`Crop Number` from crop_age ca, age a, croptype ct, pap_crtyp_age_rate pcgr, pap p where ca.Age = a.Ageid AND ca.croptype = ct.croptypid AND ca.C_Aid = pcgr.crop_age AND pcgr.pap = p.PAPid AND pcgr.pap= '" + textBox3.Text + "'", cn))
                        {
                            using (OdbcDataReader reader5 = cmd.ExecuteReader())
                            {

                                grpdataGridView.ColumnCount = 3;                                
                                // grpdataGridView.Columns[0].Name = "pap";
                                grpdataGridView.Columns[0].Name = "Crop";
                                grpdataGridView.Columns[1].Name = "Description";
                                grpdataGridView.Columns[2].Name = "Number";
                                grpdataGridView.Columns[2].MinimumWidth=120;
                             //   DataGridViewRow row = new DataGridViewRow();
                                while (reader5.Read())
                                {
                                    crp = reader5.GetString(1);
                                    des = reader5.GetString(2);
                                    num = reader5.GetString(3);


                                    grpdataGridView.Rows.Add(new string[] { crp, des, num });
                                    // pidd=Convert.ToString( Int32.Parse(reader.GetString(1)) * Int32.Parse(reader.GetString(2))); 
                                }

                                reader5.Close();

                            }
                            using (cmd = new OdbcCommand("Select psa.papid, str.structure, psa.Area from  pap p, pap_str_area psa, structure str where p.PAPid = psa.papid AND psa.struid = str.Strid and psa.papid= '" + textBox3.Text + "'", cn))
                            {
                                using (OdbcDataReader reader6 = cmd.ExecuteReader())
                                {

                                    strdataGridView.ColumnCount = 2;
                                    // grpdataGridView.Columns[0].Name = "pap";
                                    strdataGridView.Columns[0].Name = "Structure";
                                    strdataGridView.Columns[1].Name = "Area / Number";
                                    strdataGridView.Columns[0].MinimumWidth = 220;

                                //    DataGridViewRow row = new DataGridViewRow();
                                    while (reader6.Read())
                                    {
                                        str = reader6.GetString(1);
                                        ar = reader6.GetString(2);



                                        strdataGridView.Rows.Add(new string[] { str, ar });
                                        // pidd=Convert.ToString( Int32.Parse(reader.GetString(1)) * Int32.Parse(reader.GetString(2))); 
                                    }

                                    reader6.Close();

                                }
                            }
                            using (cmd = new OdbcCommand("SELECT DISTINCT pcar.`Crop Number` * ca.Rate FROM pap_crtyp_age_rate pcar, crop_age ca, croptype ct, age a, pap p, land l, pap_str_area psa, structure st WHERE pcar.crop_age = ca.C_Aid AND ca.croptype = ct.croptypid AND ca.Age = a.Ageid AND pcar.pap = p.PAPid AND p.PAPid = l.Papid AND p.PAPid = psa.papid AND psa.struid = st.Strid AND (p.FName='" + textBox4.Text + "' AND p.LName='" + textBox5.Text + "');", cn))
                            {
                                using (OdbcDataReader reader2 = cmd.ExecuteReader())
                                {
                                    while (reader2.Read())
                                    {
                                        CropVal = reader2.GetString(0);


                                    }
                                    reader2.Close();

                                }

                            }
                            using (cmd = new OdbcCommand("SELECT DISTINCT psa.Area, st.Rate, psa.Area * st.Rate FROM pap_crtyp_age_rate pcar, crop_age ca, croptype ct, age a, pap p, land l, pap_str_area psa, structure st WHERE pcar.crop_age = ca.C_Aid AND ca.croptype = ct.croptypid AND ca.Age = a.Ageid AND pcar.pap = p.PAPid AND p.PAPid = l.Papid AND p.PAPid = psa.papid AND psa.struid = st.Strid AND (p.FName='" + textBox4.Text + "' AND p.LName='" + textBox5.Text + "');", cn))
                            {
                                using (OdbcDataReader reader3 = cmd.ExecuteReader())
                                {
                                    while (reader3.Read())
                                    {
                                        DevVal = reader3.GetString(2);
                                    }
                                    reader3.Close();
                                }
                            }
                            using (cmd = new OdbcCommand("SELECT DISTINCT l.`Size` * l.Rate FROM pap_crtyp_age_rate pcar, crop_age ca, croptype ct, age a, pap p, land l, pap_str_area psa, structure st WHERE pcar.crop_age = ca.C_Aid AND ca.croptype = ct.croptypid AND ca.Age = a.Ageid AND pcar.pap = p.PAPid AND p.PAPid = l.Papid AND p.PAPid = psa.papid AND psa.struid = st.Strid AND (p.FName='" + textBox4.Text + "' AND p.LName='" + textBox5.Text + "');", cn))
                            {
                                using (OdbcDataReader reader4 = cmd.ExecuteReader())
                                {
                                    while (reader4.Read())
                                    {
                                        LndVal = reader4.GetString(0);
                                    }
                                    reader4.Close();
                                }
                            }

                            // cn.Close();
                            //  landtxt.Text = Convert.ToString(Decimal.Parse(LndVal));
                            // landtxt.Text = Convert.ToString(Int32.Parse(LndVal));
                            landtxt.Text = Convert.ToString(LndVal);
                            Crpp.Text = Convert.ToString(Int32.Parse(CropVal));
                            strtxt.Text = Convert.ToString(Decimal.Parse(DevVal));
                            DB = DBR.Text;
                            DAtxt.Text = (Convert.ToString((Int32.Parse(CropVal) + Decimal.Parse(DevVal) + Decimal.Parse(LndVal)) * Decimal.Parse(DB)));
                            DBA = DAtxt.Text;
                            Award.Text = (Convert.ToString((Int32.Parse(CropVal) + Decimal.Parse(DevVal) + Decimal.Parse(LndVal) + Decimal.Parse(DBA))));
                            Total.Text = (Convert.ToString(Int32.Parse(CropVal) + Decimal.Parse(DevVal) + Decimal.Parse(LndVal)));
                            MessageBox.Show("Complete Value");
                            cn.Close();
                        }
                    }
                }

        private void button4_Click(object sender, EventArgs e)
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
            }
        }
   

    
