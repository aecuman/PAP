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
    public partial class CompenRates : Form
    {
        OdbcConnection cn = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcCommand cmd;
        
        
           
        public CompenRates()
        {         
           
            
            InitializeComponent();
        }

        private void CompenRates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'papDataSet1.DataTable5' table. You can move, or remove it, as needed.
            this.dataTable5TableAdapter.Fill(this.papDataSet.DataTable5);
            // TODO: This line of code loads data into the 'papDataSet.DataTable3' table. You can move, or remove it, as needed.
            this.dataTable3TableAdapter.Fill(this.papDataSet.DataTable3);
            // TODO: This line of code loads data into the 'papDataSet.DataTable4' table. You can move, or remove it, as needed.
            this.dataTable4TableAdapter.Fill(this.papDataSet.DataTable4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(strutextBox.Text))
            {
                MessageBox.Show("Insert New Structure.");
                return;
            }
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
                cn.Open();
                using (cmd = new OdbcCommand("INSERT INTO  `pap`.`structure` (`Strid` ,`Structure` ,`Rate`)VALUES (NULL ,  '" + strutextBox.Text + "', '0');", cn))
                    cmd.ExecuteNonQuery();
                strutextBox.Text = "";
                cn.Close();
            }

        }
        private void validateTextCharacter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {
                //Not Allowing Numbers
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3', 
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(crptextBox.Text))
            {
                MessageBox.Show("Insert New Crop");
                return;
            }
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
                cn.Open();
                using (cmd = new OdbcCommand("INSERT INTO `pap`.`croptype` (`croptypid`, `Crop`) VALUES (NULL,  '" + crptextBox.Text + "');", cn))
                    cmd.ExecuteNonQuery();
                crptextBox.Text = "";
                cn.Close();
            }
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
        
        private void button3_Click(object sender, EventArgs e)
        
            {
     //Update button update dataset after insertion,upadtion or deletion
     DialogResult dr = MessageBox.Show("Are you sure to Add the Crop Rates", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
     if (dr == DialogResult.Yes)
     {
            this.dataTable5TableAdapter.Update(this.papDataSet.DataTable5);
           
            MessageBox.Show("Record Updated");
     }
            }
                
        

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to Add that Land Rate", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                cn.Open();
                using (cmd = new OdbcCommand("UPDATE land SET Rate = '"+ rateTextBox.Text +"'", cn))
                    cmd.ExecuteNonQuery();                
                cn.Close();

               
                this.dataTable3TableAdapter.Update(this.papDataSet.DataTable3);
                 
                 MessageBox.Show("Record Updated");
     }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to Add that Develpment Rates", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.dataTable4TableAdapter.Update(this.papDataSet.DataTable4);
                
                MessageBox.Show("Record Updated");
            }
        }
        }
    }

