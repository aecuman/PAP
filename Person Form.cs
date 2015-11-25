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
    public partial class PersonForm : Form
    {
        string word;
        OdbcConnection cn = new OdbcConnection("Dsn=tara;uid=root;server=localhost;database=pap;port=3306");
        OdbcCommand cmd;
        List<String> items = new List<String>();
        List<String> Tenid = new List<String>();
        List<String> Ten = new List<String>();
        String pid, pfname, plname;
        public delegate void passdata(TextBox Text);
        Navigation cf = new Navigation();
        
    

        public PersonForm()
        {
            InitializeComponent();
            cn.Open();
            using (cmd = new OdbcCommand("select Tid,Tenure from tenure", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    Tenid.Add("");
                    Ten.Add("");
                    while (reader.Read())
                    {
                        Tenid.Add(reader.GetString(0));
                       Ten.Add(reader.GetString(1));
                        
                    }
                }
            }
            //structures.DataSource = items;
            this.TenurecomboBox.Items.AddRange(Ten.ToArray());
            TenurecomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TenurecomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            cn.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(FName.Text))
            {
                MessageBox.Show("Enter a Person's Name");
                return;
            }
            if (string.IsNullOrEmpty(TenurecomboBox.Text))
            {
                MessageBox.Show("Select Appropriate Tenure");
                return;
            }
            if (string.IsNullOrEmpty(landsize_textBox.Text))
            {
                MessageBox.Show("Enter land Size");
                return;
            }
            cn.Open();
            String pidd = null;
            using (cmd = new OdbcCommand("Select PAPid from pap  where (FName='" + FName.Text + "' AND LName='" + LName.Text + "');", cn))
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
                    MessageBox.Show("The Name already Exists");
                    return;

                }
            }
            using (cmd = new OdbcCommand("INSERT INTO `pap`.`pap` (`PAPid`, `FName`, `LName`) VALUES (NULL, '" + FName.Text + "', '" + LName.Text + "');", cn))
                cmd.ExecuteNonQuery();
            using (cmd = new OdbcCommand("select PAPid,FName,LName from pap", cn))
            {
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pid = reader.GetString(0);
                        pfname = reader.GetString(1);
                        plname = reader.GetString(2);
                    }
                    reader.Close();
                }

                textBox1.Text = pid + "-" + pfname + "-" + plname;

                passdata pd = new passdata(cf.person);
                pd(this.textBox1);

                this.Hide();
                cf.Show();

            }
            {
                long tid = Int64.Parse(Tenid[Ten.IndexOf(Convert.ToString((TenurecomboBox.SelectedItem.ToString())))]);
                {
                    using (cmd = new OdbcCommand("INSERT INTO `pap`.`land` (`Lid`, `Tenure`, `size`, `Rate`, `papid`) VALUES (NULL, '" + tid + "', '" + landsize_textBox.Text + "', 'NULL','" + pid + "');", cn))
                        cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            GetStarted gn=new GetStarted();
            this.Hide();
            gn.Show();
        }

        }        
    }



  