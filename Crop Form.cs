using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace PAP
{
    public partial class Crpform : Form
    {
        OdbcConnection cn = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcConnection cn2 = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcCommand cmd;
        OdbcCommand cmd2;
        OdbcCommand cmd3;
        OdbcCommand cmd4;
        List<String> croptypeid = new List<String>();
        List<String> crop = new List<String>();
        List<String> Ageid = new List<String>();
        List<String> Age = new List<String>();
        List<String> raid = new List<String>();
        List<String> rate = new List<String>();
        Navigation sf = new Navigation();
        public delegate void passdata(TextBox Text);



        public Crpform()
        {
            InitializeComponent();


            button1.Visible = false;

            cn.Open();
            using (cmd = new OdbcCommand("select croptypid,crop from croptype", cn))
            {

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    croptypeid.Add("");
                    crop.Add("");
                    while (reader.Read())
                    {
                        croptypeid.Add(reader.GetString(0));
                        crop.Add(reader.GetString(1));
                    }
                }
            }
            // comboBox1.DataSource = items;
            this.comboBox1.Items.AddRange(crop.ToArray());
            // comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            cn.Close();
            {
                cn.Open();
                OdbcCommand cmd2;
                using (cmd2 = new OdbcCommand("select Ageid,Age from age", cn))
                {
                    using (OdbcDataReader reader = cmd2.ExecuteReader())
                    {
                        Ageid.Add("");
                        Age.Add("");
                        while (reader.Read())
                        {
                            Ageid.Add(reader.GetString(0));
                            Age.Add(reader.GetString(1));
                        }
                    }
                }
                this.comboBox2.Items.AddRange(Age.ToArray());
                cn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)

        {
           /* foreach (DataGridViewRow rw in this.dataGrid_crop.Rows)
{
  for (int i = 0; i < rw.Cells.Count; i++)
  {
    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value)
    {
      // here is your message box...
        MessageBox.Show(" Crop Table is empty");
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
                  
             
             
            foreach (DataGridViewRow Datarow in dataGrid_crop.Rows)
            {
                
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value!= null)
                {
                    
                    long crpid = Int64.Parse(croptypeid[crop.IndexOf(Datarow.Cells[0].Value.ToString())]);
                    long agid = Int64.Parse(Ageid[Age.IndexOf(Datarow.Cells[1].Value.ToString())]);

                    {
                        cn.Open();                  
                        // long rate = Int64.Parse(Datarow.Cells[2].Value.ToString());
                        using (cmd = new OdbcCommand("INSERT INTO `crop_age` (`C_Aid`, `croptype`,`Age`, `Rate`)"
                             + "VALUES (NULL, '" + crpid + "','" + agid + "','0')", cn))
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show(agid.ToString());
                        cn.Close();
                   }

                    cn.Open();
                    String cid = null;

                    using (cmd = new OdbcCommand("SELECT C_Aid FROM `crop_age`", cn))
                    {

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cid = reader.GetString(0);
                            }
                            reader.Close();
                        }
                    } MessageBox.Show(cid);
                     cn.Close();
                    
                    cn.Open();
                    long nid = Int64.Parse(Datarow.Cells[2].Value.ToString());
                    String pap = (textBox1.Text).Split('-')[0];                        
                   using (cmd3 = new OdbcCommand("INSERT INTO `pap_crtyp_age_rate` (`PCAid`, `pap`, `crop_age`, `Crop Number`) VALUES (NULL,'" + pap + "','" + cid + "','"+ nid + "')", cn))
                   

                    cmd3.ExecuteNonQuery();
                    cn.Close();
                }

            }
            
            }
            else
            {
                return;
            }
           
           
            /* cn.Open();
              for (int x = 0; x < dataGrid_crop.ColumnCount; x++)
              {

                  long agid = Int64.Parse(Ageid[Age.IndexOf(Convert.ToString((dataGrid_crop.items.[x].ToString())))]);
                 long crpid = Int64.Parse(croptypeid[crop.IndexOf(Convert.ToString(listBox1.Items[x].ToString()))]);
                  {
                      using (cmd = new OdbcCommand("INSERT INTO `crop_age` (`C_Aid`, `croptype`,`Age`, `Rate`)"
                          + "VALUES (NULL, '" + crpid + "','" + agid + "',NULL)", cn))
                       cmd.ExecuteNonQuery();
                      }
                      String cid = Convert.ToString(1);
                      using (cmd = new OdbcCommand("SELECT C_Aid FROM `crop_age`", cn))
                      {

                          using (OdbcDataReader reader = cmd.ExecuteReader())
                          {
                              while (reader.Read())
                              {
                                  cid = reader.GetString(0);
                              }
                              reader.Close();
                          }
                      }
                      String pap = (textBox1.Text).Split('-')[0];
                      cmd = new OdbcCommand("INSERT INTO `pap_crtyp_age_rate` (`PCAid`, `pap`, `crop_age`, `Crop Number`) VALUES (NULL,'" + pap + "','" + cid + "','" + textBox2.Text + "')", cn);

                      cmd.ExecuteNonQuery();                   
              }
                
            cn.Close();                  
               
                for (int rows = 0; rows < dataGrid_crop.Rows.Count; rows++)
                {

                    for (int col = 0; col < dataGrid_crop.Rows[rows].Cells.Count; col++)
                    {
                        string value = dataGrid_crop.Rows[0].Cells[0].Value.ToString();
                        textBox2.Text = textBox2.Text + " " + value;
                    }
                    
            }*/
            passdata pd = new passdata(sf.person);
            pd(this.textBox1);
            this.Hide();
            sf.Show();
        }



        public void person(TextBox textb)
        {

            textBox1.Text = textb.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select Crop.");
                return;
            }

            else if (comboBox2.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select Age Description.");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Insert Number of Crop.");
                return;
            }
            if (comboBox1.Text.ToString().Equals(dataGrid_crop.Columns[0].Equals(comboBox1.Text)))
            {
                MessageBox.Show("Crop already listed.");
                return;
            }
            button2.Visible = true;
            dataGrid_crop.Rows.Add(comboBox1.SelectedItem, comboBox2.SelectedItem, textBox2.Text);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox2.Text = "";
        }





        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
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
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                        "Confirm Delete!!",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                {
                    foreach (DataGridViewRow item in this.dataGrid_crop.SelectedRows)
                    {
                        dataGrid_crop.Rows.RemoveAt(item.Index);
                    }
                }
            }
            else
            {
                return;
            }
        }
        private void dataGrid_crop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = false;
            btnDel.Visible = false;
         /*   if (textBox2.Text != "") 
            
                DialogResult result;
                result = MessageBox.Show("Are You sure want to Delete?", "Conformation", MessageBoxButtons.YesNo);*/
                button4.Visible = true;
            
                {


                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dataGrid_crop.Rows[e.RowIndex];

                        comboBox1.Text = row.Cells["Column1"].Value.ToString();
                        comboBox2.Text = row.Cells["Column2"].Value.ToString();
                        textBox2.Text = row.Cells["Column3"].Value.ToString();
                    }
                }
            
            }
        
            


        private void button4_Click(object sender, EventArgs e)
        {
          
            dataGrid_crop.CurrentRow.SetValues(comboBox1.SelectedItem, comboBox2.SelectedItem, textBox2.Text);
           
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox2.Text = "";
            button4.Visible = false;
            button2.Visible = true;
            btnDel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(crptextBox.Text))
            {
                MessageBox.Show("Type New Crop");
               
                return;
            }
            cn.Open();
            String pidd = null;
            using (cmd = new OdbcCommand("Select Crop from `pap`.`croptype` where  Crop='" + crptextBox.Text + "'", cn))
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
                    MessageBox.Show("The New Crop Already Exists");
                    return;

                }
            using (cmd = new OdbcCommand("INSERT INTO `pap`.`croptype` (`croptypid`, `Crop`) VALUES (NULL,  '" + crptextBox.Text + "');", cn))
                cmd.ExecuteNonQuery();
            crptextBox.Text = "";            
           
            }
            cn.Close();
        }

        private void dataGrid_crop_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                passdata pd = new passdata(sf.person);
                pd(this.textBox1);
                this.Hide();
                sf.Show();
            }
            else
            {
                return;
            }
           
        }
    }
}