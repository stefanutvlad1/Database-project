namespace CampionatMondial2
{
    partial class FormScoruri
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
            this.flowLayoutPanelMeciuri = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMarcari = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMeciuri = new System.Windows.Forms.Label();
            this.labelMarcari = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMarcareNoua = new System.Windows.Forms.Button();
            this.comboBoxMarcant = new System.Windows.Forms.ComboBox();
            this.labelMarcant = new System.Windows.Forms.Label();
            this.numericPuncte = new System.Windows.Forms.NumericUpDown();
            this.labelPuncte = new System.Windows.Forms.Label();
            this.timeMarcare = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonScorDelete = new System.Windows.Forms.Button();
            this.buttonAddScor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelScor = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPuncte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMeciuri
            // 
            this.flowLayoutPanelMeciuri.AutoScroll = true;
            this.flowLayoutPanelMeciuri.Location = new System.Drawing.Point(12, 55);
            this.flowLayoutPanelMeciuri.Name = "flowLayoutPanelMeciuri";
            this.flowLayoutPanelMeciuri.Size = new System.Drawing.Size(248, 178);
            this.flowLayoutPanelMeciuri.TabIndex = 21;
            this.flowLayoutPanelMeciuri.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMeciuri_Paint);
            // 
            // flowLayoutPanelMarcari
            // 
            this.flowLayoutPanelMarcari.AutoScroll = true;
            this.flowLayoutPanelMarcari.Location = new System.Drawing.Point(266, 29);
            this.flowLayoutPanelMarcari.Name = "flowLayoutPanelMarcari";
            this.flowLayoutPanelMarcari.Size = new System.Drawing.Size(249, 404);
            this.flowLayoutPanelMarcari.TabIndex = 22;
            // 
            // labelMeciuri
            // 
            this.labelMeciuri.AutoSize = true;
            this.labelMeciuri.Location = new System.Drawing.Point(12, 13);
            this.labelMeciuri.Name = "labelMeciuri";
            this.labelMeciuri.Size = new System.Drawing.Size(44, 13);
            this.labelMeciuri.TabIndex = 23;
            this.labelMeciuri.Text = "Meciuri:";
            // 
            // labelMarcari
            // 
            this.labelMarcari.AutoSize = true;
            this.labelMarcari.Location = new System.Drawing.Point(263, 13);
            this.labelMarcari.Name = "labelMarcari";
            this.labelMarcari.Size = new System.Drawing.Size(45, 13);
            this.labelMarcari.TabIndex = 24;
            this.labelMarcari.Text = "Marcari:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(685, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 22);
            this.button4.TabIndex = 62;
            this.button4.Text = "Inapoi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMarcareNoua
            // 
            this.buttonMarcareNoua.Location = new System.Drawing.Point(585, 471);
            this.buttonMarcareNoua.Name = "buttonMarcareNoua";
            this.buttonMarcareNoua.Size = new System.Drawing.Size(94, 23);
            this.buttonMarcareNoua.TabIndex = 63;
            this.buttonMarcareNoua.Text = "Marcare noua";
            this.buttonMarcareNoua.UseVisualStyleBackColor = true;
            this.buttonMarcareNoua.Click += new System.EventHandler(this.buttonMarcareNoua_Click);
            // 
            // comboBoxMarcant
            // 
            this.comboBoxMarcant.AllowDrop = true;
            this.comboBoxMarcant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcant.FormattingEnabled = true;
            this.comboBoxMarcant.IntegralHeight = false;
            this.comboBoxMarcant.Location = new System.Drawing.Point(521, 55);
            this.comboBoxMarcant.Name = "comboBoxMarcant";
            this.comboBoxMarcant.Size = new System.Drawing.Size(258, 21);
            this.comboBoxMarcant.TabIndex = 65;
            this.comboBoxMarcant.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelMarcant
            // 
            this.labelMarcant.AutoSize = true;
            this.labelMarcant.Location = new System.Drawing.Point(519, 39);
            this.labelMarcant.Name = "labelMarcant";
            this.labelMarcant.Size = new System.Drawing.Size(49, 13);
            this.labelMarcant.TabIndex = 64;
            this.labelMarcant.Text = "Marcator";
            // 
            // numericPuncte
            // 
            this.numericPuncte.Location = new System.Drawing.Point(521, 103);
            this.numericPuncte.Name = "numericPuncte";
            this.numericPuncte.Size = new System.Drawing.Size(120, 20);
            this.numericPuncte.TabIndex = 66;
            // 
            // labelPuncte
            // 
            this.labelPuncte.AutoSize = true;
            this.labelPuncte.Location = new System.Drawing.Point(521, 84);
            this.labelPuncte.Name = "labelPuncte";
            this.labelPuncte.Size = new System.Drawing.Size(82, 13);
            this.labelPuncte.TabIndex = 67;
            this.labelPuncte.Text = "Puncte obtinute";
            // 
            // timeMarcare
            // 
            this.timeMarcare.AllowDrop = true;
            this.timeMarcare.CustomFormat = "HH:mm:ss";
            this.timeMarcare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeMarcare.Location = new System.Drawing.Point(521, 149);
            this.timeMarcare.Name = "timeMarcare";
            this.timeMarcare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeMarcare.ShowUpDown = true;
            this.timeMarcare.Size = new System.Drawing.Size(120, 20);
            this.timeMarcare.TabIndex = 68;
            this.timeMarcare.Value = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            this.timeMarcare.ValueChanged += new System.EventHandler(this.timeMarcare_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(521, 133);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 13);
            this.labelTime.TabIndex = 69;
            this.labelTime.Text = "Ora marcarii";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(585, 190);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(94, 23);
            this.buttonModify.TabIndex = 71;
            this.buttonModify.Text = "Modfica";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(685, 190);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 22);
            this.buttonDelete.TabIndex = 70;
            this.buttonDelete.Text = "Sterge";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(521, 252);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 13);
            this.StatusLabel.TabIndex = 73;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(521, 294);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 72;
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // buttonScorDelete
            // 
            this.buttonScorDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonScorDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonScorDelete.Location = new System.Drawing.Point(12, 468);
            this.buttonScorDelete.Name = "buttonScorDelete";
            this.buttonScorDelete.Size = new System.Drawing.Size(248, 25);
            this.buttonScorDelete.TabIndex = 77;
            this.buttonScorDelete.Text = "Sterge scor";
            this.buttonScorDelete.UseVisualStyleBackColor = false;
            this.buttonScorDelete.Click += new System.EventHandler(this.buttonScorDelete_Click);
            // 
            // buttonAddScor
            // 
            this.buttonAddScor.Location = new System.Drawing.Point(12, 439);
            this.buttonAddScor.Name = "buttonAddScor";
            this.buttonAddScor.Size = new System.Drawing.Size(248, 25);
            this.buttonAddScor.TabIndex = 76;
            this.buttonAddScor.Text = "Scor nou";
            this.buttonAddScor.UseVisualStyleBackColor = true;
            this.buttonAddScor.Click += new System.EventHandler(this.buttonAddScor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Scoruri:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanelScor
            // 
            this.flowLayoutPanelScor.AutoScroll = true;
            this.flowLayoutPanelScor.Location = new System.Drawing.Point(12, 252);
            this.flowLayoutPanelScor.Name = "flowLayoutPanelScor";
            this.flowLayoutPanelScor.Size = new System.Drawing.Size(248, 181);
            this.flowLayoutPanelScor.TabIndex = 74;
            this.flowLayoutPanelScor.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "Nr. rezultate:";
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.Location = new System.Drawing.Point(207, 4);
            this.numericUpDownFind.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFind.Name = "numericUpDownFind";
            this.numericUpDownFind.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownFind.TabIndex = 109;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(207, 29);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(52, 22);
            this.buttonFind.TabIndex = 108;
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
            this.comboBoxFind.Location = new System.Drawing.Point(12, 29);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(189, 21);
            this.comboBoxFind.TabIndex = 107;
            // 
            // FormScoruri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.buttonScorDelete);
            this.Controls.Add(this.buttonAddScor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelScor);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.timeMarcare);
            this.Controls.Add(this.labelPuncte);
            this.Controls.Add(this.numericPuncte);
            this.Controls.Add(this.labelMarcant);
            this.Controls.Add(this.comboBoxMarcant);
            this.Controls.Add(this.buttonMarcareNoua);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelMarcari);
            this.Controls.Add(this.labelMeciuri);
            this.Controls.Add(this.flowLayoutPanelMarcari);
            this.Controls.Add(this.flowLayoutPanelMeciuri);
            this.Name = "FormScoruri";
            this.Text = "FormScoruri";
            this.Load += new System.EventHandler(this.FormScoruri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPuncte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMeciuri;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMarcari;
        private System.Windows.Forms.Label labelMeciuri;
        private System.Windows.Forms.Label labelMarcari;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMarcareNoua;
        private System.Windows.Forms.Label labelMarcant;
        private System.Windows.Forms.ComboBox comboBoxMarcant;
        private System.Windows.Forms.NumericUpDown numericPuncte;
        private System.Windows.Forms.Label labelPuncte;
        private System.Windows.Forms.DateTimePicker timeMarcare;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonScorDelete;
        private System.Windows.Forms.Button buttonAddScor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelScor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxFind;
    }
}