namespace CampionatMondial2
{
    partial class FormCampionate
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
            this.flowLayoutPanelCampionate = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelStadioane = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddStadion = new System.Windows.Forms.Button();
            this.buttonRemoveStadion = new System.Windows.Forms.Button();
            this.comboBoxStadioane = new System.Windows.Forms.ComboBox();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonAdaugaCampionat = new System.Windows.Forms.Button();
            this.buttonStergeCampionat = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.buttonModifyCampionat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCampionate
            // 
            this.flowLayoutPanelCampionate.AutoScroll = true;
            this.flowLayoutPanelCampionate.Location = new System.Drawing.Point(12, 55);
            this.flowLayoutPanelCampionate.Name = "flowLayoutPanelCampionate";
            this.flowLayoutPanelCampionate.Size = new System.Drawing.Size(250, 285);
            this.flowLayoutPanelCampionate.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Campionate:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(387, 29);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(255, 20);
            this.textBoxNume.TabIndex = 66;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Nume";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(387, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Data inceperii:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(387, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker2.TabIndex = 70;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Data finalizarii:";
            // 
            // flowLayoutPanelStadioane
            // 
            this.flowLayoutPanelStadioane.AutoScroll = true;
            this.flowLayoutPanelStadioane.Location = new System.Drawing.Point(387, 132);
            this.flowLayoutPanelStadioane.Name = "flowLayoutPanelStadioane";
            this.flowLayoutPanelStadioane.Size = new System.Drawing.Size(258, 208);
            this.flowLayoutPanelStadioane.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Stadioane selectate:";
            // 
            // buttonAddStadion
            // 
            this.buttonAddStadion.Location = new System.Drawing.Point(387, 375);
            this.buttonAddStadion.Name = "buttonAddStadion";
            this.buttonAddStadion.Size = new System.Drawing.Size(257, 22);
            this.buttonAddStadion.TabIndex = 72;
            this.buttonAddStadion.Text = "Adauga stadion";
            this.buttonAddStadion.UseVisualStyleBackColor = true;
            this.buttonAddStadion.Click += new System.EventHandler(this.buttonAddStadion_Click);
            // 
            // buttonRemoveStadion
            // 
            this.buttonRemoveStadion.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveStadion.Location = new System.Drawing.Point(386, 403);
            this.buttonRemoveStadion.Name = "buttonRemoveStadion";
            this.buttonRemoveStadion.Size = new System.Drawing.Size(259, 22);
            this.buttonRemoveStadion.TabIndex = 73;
            this.buttonRemoveStadion.Text = "Sterge stadion";
            this.buttonRemoveStadion.UseVisualStyleBackColor = true;
            this.buttonRemoveStadion.Click += new System.EventHandler(this.buttonRemoveStadion_Click);
            // 
            // comboBoxStadioane
            // 
            this.comboBoxStadioane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStadioane.FormattingEnabled = true;
            this.comboBoxStadioane.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxStadioane.Location = new System.Drawing.Point(387, 346);
            this.comboBoxStadioane.Name = "comboBoxStadioane";
            this.comboBoxStadioane.Size = new System.Drawing.Size(257, 21);
            this.comboBoxStadioane.TabIndex = 74;
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(574, 444);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(91, 22);
            this.buttonInapoi.TabIndex = 75;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // buttonAdaugaCampionat
            // 
            this.buttonAdaugaCampionat.Location = new System.Drawing.Point(12, 345);
            this.buttonAdaugaCampionat.Name = "buttonAdaugaCampionat";
            this.buttonAdaugaCampionat.Size = new System.Drawing.Size(250, 22);
            this.buttonAdaugaCampionat.TabIndex = 76;
            this.buttonAdaugaCampionat.Text = "Adauga campionat";
            this.buttonAdaugaCampionat.UseVisualStyleBackColor = true;
            this.buttonAdaugaCampionat.Click += new System.EventHandler(this.buttonAdaugaCampionat_Click);
            // 
            // buttonStergeCampionat
            // 
            this.buttonStergeCampionat.ForeColor = System.Drawing.Color.Red;
            this.buttonStergeCampionat.Location = new System.Drawing.Point(12, 401);
            this.buttonStergeCampionat.Name = "buttonStergeCampionat";
            this.buttonStergeCampionat.Size = new System.Drawing.Size(250, 22);
            this.buttonStergeCampionat.TabIndex = 77;
            this.buttonStergeCampionat.Text = "Sterge campionat";
            this.buttonStergeCampionat.UseVisualStyleBackColor = true;
            this.buttonStergeCampionat.Click += new System.EventHandler(this.buttonStergeCampionat_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(12, 426);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 13);
            this.StatusLabel.TabIndex = 99;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 453);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 98;
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxTip.Location = new System.Drawing.Point(386, 107);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(257, 21);
            this.comboBoxTip.TabIndex = 100;
            // 
            // buttonModifyCampionat
            // 
            this.buttonModifyCampionat.Location = new System.Drawing.Point(12, 373);
            this.buttonModifyCampionat.Name = "buttonModifyCampionat";
            this.buttonModifyCampionat.Size = new System.Drawing.Size(250, 22);
            this.buttonModifyCampionat.TabIndex = 101;
            this.buttonModifyCampionat.Text = "Modifica campionat";
            this.buttonModifyCampionat.UseVisualStyleBackColor = true;
            this.buttonModifyCampionat.Click += new System.EventHandler(this.buttonModifyCampionat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Tip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Nr. rezultate:";
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.Location = new System.Drawing.Point(207, 5);
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
            this.buttonFind.Location = new System.Drawing.Point(207, 30);
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
            "Nume (alfabetic crescator)",
            "Nume (alfabetic descrescator)",
            "Data inceperii (alfabetic crescator)",
            "Data inceperii (alfabetic descrescator)",
            "Data finalizarii (alfabetic crescator)",
            "Data finalizarii (alfabetic descrescator)",
            "Stadioane participante (crescator)",
            "Stadioane participante (descrescator)"});
            this.comboBoxFind.Location = new System.Drawing.Point(12, 30);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(189, 21);
            this.comboBoxFind.TabIndex = 103;
            // 
            // FormCampionate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 474);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonModifyCampionat);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.buttonStergeCampionat);
            this.Controls.Add(this.buttonAdaugaCampionat);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.comboBoxStadioane);
            this.Controls.Add(this.buttonRemoveStadion);
            this.Controls.Add(this.buttonAddStadion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanelStadioane);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelCampionate);
            this.Name = "FormCampionate";
            this.Text = "FormCampionate";
            this.Load += new System.EventHandler(this.FormCampionate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCampionate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStadioane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddStadion;
        private System.Windows.Forms.Button buttonRemoveStadion;
        private System.Windows.Forms.ComboBox comboBoxStadioane;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonAdaugaCampionat;
        private System.Windows.Forms.Button buttonStergeCampionat;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Button buttonModifyCampionat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxFind;
    }
}