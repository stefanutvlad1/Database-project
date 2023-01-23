namespace CampionatMondial2
{
    partial class FormStadioane
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
            this.buttonStergeCampionat = new System.Windows.Forms.Button();
            this.buttonAdaugaCampionat = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.comboBoxCampionate = new System.Windows.Forms.ComboBox();
            this.buttonRemoveStadion = new System.Windows.Forms.Button();
            this.buttonAddStadion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCampionate = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelStadioane = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonModifyStadion = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStergeCampionat
            // 
            this.buttonStergeCampionat.ForeColor = System.Drawing.Color.Red;
            this.buttonStergeCampionat.Location = new System.Drawing.Point(389, 400);
            this.buttonStergeCampionat.Name = "buttonStergeCampionat";
            this.buttonStergeCampionat.Size = new System.Drawing.Size(307, 22);
            this.buttonStergeCampionat.TabIndex = 93;
            this.buttonStergeCampionat.Text = "Sterge campionat";
            this.buttonStergeCampionat.UseVisualStyleBackColor = true;
            this.buttonStergeCampionat.Click += new System.EventHandler(this.buttonStergeCampionat_Click);
            // 
            // buttonAdaugaCampionat
            // 
            this.buttonAdaugaCampionat.Location = new System.Drawing.Point(389, 372);
            this.buttonAdaugaCampionat.Name = "buttonAdaugaCampionat";
            this.buttonAdaugaCampionat.Size = new System.Drawing.Size(307, 22);
            this.buttonAdaugaCampionat.TabIndex = 92;
            this.buttonAdaugaCampionat.Text = "Adauga campionat";
            this.buttonAdaugaCampionat.UseVisualStyleBackColor = true;
            this.buttonAdaugaCampionat.Click += new System.EventHandler(this.buttonAdaugaCampionat_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(605, 450);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(91, 22);
            this.buttonInapoi.TabIndex = 91;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // comboBoxCampionate
            // 
            this.comboBoxCampionate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampionate.FormattingEnabled = true;
            this.comboBoxCampionate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCampionate.Location = new System.Drawing.Point(390, 345);
            this.comboBoxCampionate.Name = "comboBoxCampionate";
            this.comboBoxCampionate.Size = new System.Drawing.Size(306, 21);
            this.comboBoxCampionate.TabIndex = 90;
            this.comboBoxCampionate.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampionate_SelectedIndexChanged);
            // 
            // buttonRemoveStadion
            // 
            this.buttonRemoveStadion.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveStadion.Location = new System.Drawing.Point(11, 427);
            this.buttonRemoveStadion.Name = "buttonRemoveStadion";
            this.buttonRemoveStadion.Size = new System.Drawing.Size(251, 22);
            this.buttonRemoveStadion.TabIndex = 89;
            this.buttonRemoveStadion.Text = "Sterge stadion";
            this.buttonRemoveStadion.UseVisualStyleBackColor = true;
            this.buttonRemoveStadion.Click += new System.EventHandler(this.buttonRemoveStadion_Click);
            // 
            // buttonAddStadion
            // 
            this.buttonAddStadion.Location = new System.Drawing.Point(13, 372);
            this.buttonAddStadion.Name = "buttonAddStadion";
            this.buttonAddStadion.Size = new System.Drawing.Size(249, 22);
            this.buttonAddStadion.TabIndex = 88;
            this.buttonAddStadion.Text = "Adauga stadion";
            this.buttonAddStadion.UseVisualStyleBackColor = true;
            this.buttonAddStadion.Click += new System.EventHandler(this.buttonAddStadion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Campionate gazduite:";
            // 
            // flowLayoutPanelCampionate
            // 
            this.flowLayoutPanelCampionate.AllowDrop = true;
            this.flowLayoutPanelCampionate.Location = new System.Drawing.Point(389, 87);
            this.flowLayoutPanelCampionate.Name = "flowLayoutPanelCampionate";
            this.flowLayoutPanelCampionate.Size = new System.Drawing.Size(307, 252);
            this.flowLayoutPanelCampionate.TabIndex = 79;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(390, 35);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(307, 20);
            this.textBoxNume.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Stadioane:";
            // 
            // flowLayoutPanelStadioane
            // 
            this.flowLayoutPanelStadioane.AllowDrop = true;
            this.flowLayoutPanelStadioane.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanelStadioane.Name = "flowLayoutPanelStadioane";
            this.flowLayoutPanelStadioane.Size = new System.Drawing.Size(250, 305);
            this.flowLayoutPanelStadioane.TabIndex = 78;
            this.flowLayoutPanelStadioane.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(390, 61);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(307, 20);
            this.textBoxAdresa.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Adresa";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(274, 436);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 13);
            this.StatusLabel.TabIndex = 97;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(274, 459);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 96;
            this.ErrorLabel.Text = "ErrorLabel";
            this.ErrorLabel.Click += new System.EventHandler(this.ErrorLabel_Click);
            // 
            // buttonModifyStadion
            // 
            this.buttonModifyStadion.Location = new System.Drawing.Point(12, 399);
            this.buttonModifyStadion.Name = "buttonModifyStadion";
            this.buttonModifyStadion.Size = new System.Drawing.Size(249, 22);
            this.buttonModifyStadion.TabIndex = 98;
            this.buttonModifyStadion.Text = "Modifica";
            this.buttonModifyStadion.UseVisualStyleBackColor = true;
            this.buttonModifyStadion.Click += new System.EventHandler(this.buttonModifyStadion_Click);
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFind.FormattingEnabled = true;
            this.comboBoxFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxFind.Items.AddRange(new object[] {
            "Nume (alfabetic crescator)",
            "Nume (alfabetic descrescator)",
            "Adresa (alfabetic crescator)",
            "Adresa (alfabetic descrescator)",
            "Meciuri gazduite (crescator)",
            "Meciuri gazduite (descrescator)",
            "Campionate gazduite (crescator)",
            "Campionate gazuite (descrescator)"});
            this.comboBoxFind.Location = new System.Drawing.Point(15, 34);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(189, 21);
            this.comboBoxFind.TabIndex = 99;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(210, 34);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(52, 22);
            this.buttonFind.TabIndex = 100;
            this.buttonFind.Text = "Cauta";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.Location = new System.Drawing.Point(210, 9);
            this.numericUpDownFind.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFind.Name = "numericUpDownFind";
            this.numericUpDownFind.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownFind.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Nr. rezultate:";
            // 
            // FormStadioane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.buttonModifyStadion);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonStergeCampionat);
            this.Controls.Add(this.buttonAdaugaCampionat);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.comboBoxCampionate);
            this.Controls.Add(this.buttonRemoveStadion);
            this.Controls.Add(this.buttonAddStadion);
            this.Controls.Add(this.flowLayoutPanelCampionate);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelStadioane);
            this.Name = "FormStadioane";
            this.Text = "FormStadioane";
            this.Load += new System.EventHandler(this.FormStadioane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStergeCampionat;
        private System.Windows.Forms.Button buttonAdaugaCampionat;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.ComboBox comboBoxCampionate;
        private System.Windows.Forms.Button buttonRemoveStadion;
        private System.Windows.Forms.Button buttonAddStadion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCampionate;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStadioane;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonModifyStadion;
        private System.Windows.Forms.ComboBox comboBoxFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
        private System.Windows.Forms.Label label5;
    }
}