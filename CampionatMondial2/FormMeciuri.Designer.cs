namespace CampionatMondial2
{
    partial class FormMeciuri
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
            this.campionat_mondialDataSet = new CampionatMondial2.Campionat_mondialDataSet();
            this.campionateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campionateTableAdapter = new CampionatMondial2.Campionat_mondialDataSetTableAdapters.CampionateTableAdapter();
            this.tableAdapterManager = new CampionatMondial2.Campionat_mondialDataSetTableAdapters.TableAdapterManager();
            this.meciuriTableAdapter = new CampionatMondial2.Campionat_mondialDataSetTableAdapters.MeciuriTableAdapter();
            this.meciuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.echipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.echipeTableAdapter = new CampionatMondial2.Campionat_mondialDataSetTableAdapters.EchipeTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.campionat_mondialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meciuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            this.SuspendLayout();
            // 
            // campionat_mondialDataSet
            // 
            this.campionat_mondialDataSet.DataSetName = "Campionat_mondialDataSet";
            this.campionat_mondialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campionateBindingSource
            // 
            this.campionateBindingSource.DataMember = "Campionate";
            this.campionateBindingSource.DataSource = this.campionat_mondialDataSet;
            // 
            // campionateTableAdapter
            // 
            this.campionateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampionateTableAdapter = this.campionateTableAdapter;
            this.tableAdapterManager.CoechipieriTableAdapter = null;
            this.tableAdapterManager.EchipeTableAdapter = null;
            this.tableAdapterManager.MarcariTableAdapter = null;
            this.tableAdapterManager.MeciuriTableAdapter = this.meciuriTableAdapter;
            this.tableAdapterManager.ScorTableAdapter = null;
            this.tableAdapterManager.Stadioane_CampionateTableAdapter = null;
            this.tableAdapterManager.StadioaneTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CampionatMondial2.Campionat_mondialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // meciuriTableAdapter
            // 
            this.meciuriTableAdapter.ClearBeforeFill = true;
            // 
            // meciuriBindingSource
            // 
            this.meciuriBindingSource.DataMember = "Meciuri";
            this.meciuriBindingSource.DataSource = this.campionat_mondialDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Meciuri inscrise:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 437);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Echipa1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Echpa2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stadion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Data";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 21);
            this.button2.TabIndex = 29;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 21);
            this.button3.TabIndex = 30;
            this.button3.Text = "Modifica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 21);
            this.button4.TabIndex = 31;
            this.button4.Text = "Meci nou...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(437, 399);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 32;
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(437, 357);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 13);
            this.StatusLabel.TabIndex = 33;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(503, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(503, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(258, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(503, 197);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(258, 21);
            this.comboBox3.TabIndex = 37;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // echipeBindingSource
            // 
            this.echipeBindingSource.DataMember = "Echipe";
            this.echipeBindingSource.DataSource = this.campionat_mondialDataSet;
            // 
            // echipeTableAdapter
            // 
            this.echipeTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Nr. rezultate:";
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.Location = new System.Drawing.Point(249, 27);
            this.numericUpDownFind.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFind.Name = "numericUpDownFind";
            this.numericUpDownFind.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownFind.TabIndex = 105;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(249, 52);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(52, 22);
            this.buttonFind.TabIndex = 104;
            this.buttonFind.Text = "Cauta";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFind.FormattingEnabled = true;
            this.comboBoxFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxFind.Items.AddRange(new object[] {
            "Data (crescator)",
            "Data (descrescator)",
            "Stadionul cel mai folosit",
            "Stadionul cel mai putin folosit",
            "Echipele cele mai castigatoare",
            "Echipele cele mai putin castigatoare",
            "Cele mai multe marcari ale unui coechipier",
            "Cele mai putine marcari ale unui coechipier"});
            this.comboBoxFind.Location = new System.Drawing.Point(54, 52);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(189, 21);
            this.comboBoxFind.TabIndex = 103;
            this.comboBoxFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxFind_SelectedIndexChanged);
            // 
            // FormMeciuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormMeciuri";
            this.Text = "Setari meciuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campionat_mondialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meciuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Campionat_mondialDataSet campionat_mondialDataSet;
        private System.Windows.Forms.BindingSource campionateBindingSource;
        private Campionat_mondialDataSetTableAdapters.CampionateTableAdapter campionateTableAdapter;
        private Campionat_mondialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Campionat_mondialDataSetTableAdapters.MeciuriTableAdapter meciuriTableAdapter;
        private System.Windows.Forms.BindingSource meciuriBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource echipeBindingSource;
        private Campionat_mondialDataSetTableAdapters.EchipeTableAdapter echipeTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxFind;
    }
}

