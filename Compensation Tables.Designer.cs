namespace PAP
{
    partial class Compentbls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papDataSet2 = new PAP.papDataSet();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.dataTableTableAdapter1 = new PAP.papDataSetTableAdapters.DataTableTableAdapter();
            this.tableAdapterManager1 = new PAP.papDataSetTableAdapters.TableAdapterManager();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papDataSet2)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.DataGridView);
            this.groupBox9.Location = new System.Drawing.Point(12, 127);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(367, 488);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // DataGridView
            // 
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.FName,
            this.LName});
            this.DataGridView.DataSource = this.dataTableBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(22, 39);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(300, 220);
            this.DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PAPid";
            this.dataGridViewTextBoxColumn4.HeaderText = "PAPid";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "FName";
            this.FName.Name = "FName";
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "LName";
            this.LName.Name = "LName";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.papDataSet2;
            // 
            // papDataSet2
            // 
            this.papDataSet2.DataSetName = "papDataSet";
            this.papDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox17);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(359, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(753, 742);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox9);
            this.groupBox17.Controls.Add(this.textBox17);
            this.groupBox17.Controls.Add(this.textBox16);
            this.groupBox17.Controls.Add(this.textBox15);
            this.groupBox17.Controls.Add(this.textBox14);
            this.groupBox17.Controls.Add(this.textBox13);
            this.groupBox17.Controls.Add(this.textBox12);
            this.groupBox17.Controls.Add(this.textBox11);
            this.groupBox17.Location = new System.Drawing.Point(473, 246);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(264, 484);
            this.groupBox17.TabIndex = 2;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "groupBox17";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(123, 250);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(122, 20);
            this.textBox9.TabIndex = 12;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(123, 125);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(122, 20);
            this.textBox17.TabIndex = 11;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(123, 158);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(122, 20);
            this.textBox16.TabIndex = 10;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(123, 191);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(122, 20);
            this.textBox15.TabIndex = 9;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(123, 224);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(122, 20);
            this.textBox14.TabIndex = 8;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(123, 92);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(122, 20);
            this.textBox13.TabIndex = 7;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(123, 59);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(122, 20);
            this.textBox12.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(154, 19);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(91, 20);
            this.textBox11.TabIndex = 5;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox15);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Location = new System.Drawing.Point(20, 103);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(411, 639);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "groupBox12";
            // 
            // groupBox15
            // 
            this.groupBox15.Location = new System.Drawing.Point(18, 334);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(357, 305);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "groupBox15";
            // 
            // groupBox14
            // 
            this.groupBox14.Location = new System.Drawing.Point(18, 134);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(357, 277);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "groupBox14";
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(18, 26);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(339, 268);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "groupBox13";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button10);
            this.groupBox11.Controls.Add(this.button9);
            this.groupBox11.Controls.Add(this.button8);
            this.groupBox11.Controls.Add(this.textBox8);
            this.groupBox11.Controls.Add(this.textBox7);
            this.groupBox11.Location = new System.Drawing.Point(19, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(518, 76);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "groupBox11";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(295, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(204, 22);
            this.button10.TabIndex = 4;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(398, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(295, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.TextChanged += new System.EventHandler(this.button1_Click);
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(185, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(91, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(37, 22);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(91, 20);
            this.textBox7.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.textBox2);
            this.groupBox16.Controls.Add(this.textBox1);
            this.groupBox16.Location = new System.Drawing.Point(18, 25);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(312, 95);
            this.groupBox16.TabIndex = 7;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "groupBox16";
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DataTable3TableAdapter = null;
            this.tableAdapterManager1.DataTable4TableAdapter = null;
            this.tableAdapterManager1.DataTable5TableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PAP.papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Compentbls
            // 
            this.ClientSize = new System.Drawing.Size(1124, 747);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Name = "Compentbls";
            this.Load += new System.EventHandler(this.Compentbls_Load);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papDataSet2)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       
        
        private papDataSet papDataSet;
        
        private papDataSetTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.Button back;
       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private papDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private papDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private papDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private papDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label tenu_sizlabel;
        private System.Windows.Forms.TextBox tentextBox;
        private System.Windows.Forms.Label tenulabel;
        private System.Windows.Forms.TextBox tenutextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Arealabel;
        private System.Windows.Forms.Label strulabel;
        private System.Windows.Forms.TextBox stru_antextBox;
        private System.Windows.Forms.TextBox strutextBox;
        private System.Windows.Forms.Label crpnolabel;
        private System.Windows.Forms.TextBox crpnotextBox;
        private System.Windows.Forms.TextBox crp_atextBox;
        private System.Windows.Forms.TextBox crptextBox;
        private System.Windows.Forms.Label Crop_agelabel;
        private System.Windows.Forms.TextBox c_atextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAPidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable6BindingSource;
        private papDataSetTableAdapters.DataTable6TableAdapter dataTable6TableAdapter;
        private papDataSet papDataSet1;
        private System.Windows.Forms.DataGridView dataTable3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView Joinery;
        private System.Windows.Forms.BindingSource dataTable6BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource fKDataTable3DataTable6BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox strtxt;
        private System.Windows.Forms.TextBox Award;
        private System.Windows.Forms.TextBox DAtxt;
        private System.Windows.Forms.TextBox Crp;
        private System.Windows.Forms.TextBox landtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DBR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox16;
        private papDataSet papDataSet2;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private papDataSetTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private papDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.TextBox textBox9;
       
        
    }
}