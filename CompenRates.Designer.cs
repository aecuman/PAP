namespace PAP
{
    partial class CompenRates
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label rateLabel;
            this.StruRateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papDataSet = new PAP.papDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.crptextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.strutextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataTable5DataGridView = new System.Windows.Forms.DataGridView();
            this.Crop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataTable4TableAdapter = new PAP.papDataSetTableAdapters.DataTable4TableAdapter();
            this.tableAdapterManager = new PAP.papDataSetTableAdapters.TableAdapterManager();
            this.dataTable3TableAdapter = new PAP.papDataSetTableAdapters.DataTable3TableAdapter();
            this.dataTable5TableAdapter = new PAP.papDataSetTableAdapters.DataTable5TableAdapter();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StruRateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 13);
            label1.TabIndex = 6;
            label1.Text = "New Structure";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 13);
            label2.TabIndex = 6;
            label2.Text = "New Crop";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(256, 19);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(33, 13);
            rateLabel.TabIndex = 11;
            rateLabel.Text = "Rate:";
            // 
            // StruRateDataGridView
            // 
            this.StruRateDataGridView.AllowUserToAddRows = false;
            this.StruRateDataGridView.AutoGenerateColumns = false;
            this.StruRateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StruRateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.StruRateDataGridView.DataSource = this.dataTable4BindingSource;
            this.StruRateDataGridView.Location = new System.Drawing.Point(123, 165);
            this.StruRateDataGridView.Name = "StruRateDataGridView";
            this.StruRateDataGridView.Size = new System.Drawing.Size(416, 429);
            this.StruRateDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Strid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Strid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Structure";
            this.dataGridViewTextBoxColumn2.HeaderText = "Structure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.papDataSet;
            // 
            // papDataSet
            // 
            this.papDataSet.DataSetName = "papDataSet";
            this.papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(rateLabel);
            this.groupBox1.Controls.Add(this.rateTextBox);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(81, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 675);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rateTextBox
            // 
            this.rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable3BindingSource, "Rate", true));
            this.rateTextBox.Location = new System.Drawing.Point(295, 16);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 12;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.papDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(425, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 19);
            this.button4.TabIndex = 11;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(33, 19);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 24);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(label2);
            this.groupBox5.Controls.Add(this.crptextBox);
            this.groupBox5.Location = new System.Drawing.Point(565, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 56);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add New Crop";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crptextBox
            // 
            this.crptextBox.Location = new System.Drawing.Point(95, 21);
            this.crptextBox.Name = "crptextBox";
            this.crptextBox.Size = new System.Drawing.Size(163, 20);
            this.crptextBox.TabIndex = 5;
            this.crptextBox.TextChanged += new System.EventHandler(this.validateTextCharacter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(label1);
            this.groupBox4.Controls.Add(this.strutextBox);
            this.groupBox4.Location = new System.Drawing.Point(40, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 56);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add New Structure";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // strutextBox
            // 
            this.strutextBox.Location = new System.Drawing.Point(95, 21);
            this.strutextBox.Name = "strutextBox";
            this.strutextBox.Size = new System.Drawing.Size(240, 20);
            this.strutextBox.TabIndex = 5;
            this.strutextBox.TextChanged += new System.EventHandler(this.validateTextCharacter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataTable5DataGridView);
            this.groupBox3.Location = new System.Drawing.Point(565, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 519);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compensation Rates for Crops";
            // 
            // dataTable5DataGridView
            // 
            this.dataTable5DataGridView.AllowUserToAddRows = false;
            this.dataTable5DataGridView.AutoGenerateColumns = false;
            this.dataTable5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable5DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Crop,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataTable5DataGridView.DataSource = this.dataTable5BindingSource;
            this.dataTable5DataGridView.Location = new System.Drawing.Point(6, 19);
            this.dataTable5DataGridView.Name = "dataTable5DataGridView";
            this.dataTable5DataGridView.Size = new System.Drawing.Size(360, 429);
            this.dataTable5DataGridView.TabIndex = 0;
            // 
            // Crop
            // 
            this.Crop.DataPropertyName = "Crop";
            this.Crop.HeaderText = "Crop";
            this.Crop.Name = "Crop";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn5.HeaderText = "Age";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataTable5BindingSource
            // 
            this.dataTable5BindingSource.DataMember = "DataTable5";
            this.dataTable5BindingSource.DataSource = this.papDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(33, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 519);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compensation Rates for Semi Permanent Structures";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 24);
            this.button5.TabIndex = 11;
            this.button5.Text = "Add Development Rates";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(822, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add Crop Rates";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DataTable3TableAdapter = null;
            this.tableAdapterManager.DataTable4TableAdapter = null;
            this.tableAdapterManager.DataTable5TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable5TableAdapter
            // 
            this.dataTable5TableAdapter.ClearBeforeFill = true;
            // 
            // CompenRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1088, 685);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StruRateDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompenRates";
            this.Text = "Compensation Rates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompenRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StruRateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private papDataSet papDataSet;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private papDataSetTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private papDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView StruRateDataGridView;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private papDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.BindingSource dataTable5BindingSource;
        private papDataSetTableAdapters.DataTable5TableAdapter dataTable5TableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox crptextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox strutextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.DataGridView dataTable5DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}