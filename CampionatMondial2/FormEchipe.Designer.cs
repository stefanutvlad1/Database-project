namespace CampionatMondial2
{
    partial class FormEchipe
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEchipa = new System.Windows.Forms.ComboBox();
            this.LabelEchipa = new System.Windows.Forms.Label();
            this.LabelCoechipieri = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PierderiEchipa = new System.Windows.Forms.Label();
            this.CastiguriEchipa = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(375, 310);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 13);
            this.StatusLabel.TabIndex = 48;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(375, 352);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 47;
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 21);
            this.button2.TabIndex = 46;
            this.button2.Text = "Modifica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 21);
            this.button3.TabIndex = 45;
            this.button3.Text = "Sterge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Castiguri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nume";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 332);
            this.flowLayoutPanel1.TabIndex = 40;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Meciuri inscrise:";
            // 
            // comboBoxEchipa
            // 
            this.comboBoxEchipa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEchipa.FormattingEnabled = true;
            this.comboBoxEchipa.Location = new System.Drawing.Point(46, 71);
            this.comboBoxEchipa.Name = "comboBoxEchipa";
            this.comboBoxEchipa.Size = new System.Drawing.Size(259, 21);
            this.comboBoxEchipa.TabIndex = 53;
            this.comboBoxEchipa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEchipa_SelectedIndexChanged);
            // 
            // LabelEchipa
            // 
            this.LabelEchipa.AutoSize = true;
            this.LabelEchipa.Location = new System.Drawing.Point(43, 55);
            this.LabelEchipa.Name = "LabelEchipa";
            this.LabelEchipa.Size = new System.Drawing.Size(43, 13);
            this.LabelEchipa.TabIndex = 54;
            this.LabelEchipa.Text = "Echipa:";
            this.LabelEchipa.Click += new System.EventHandler(this.label7_Click);
            // 
            // LabelCoechipieri
            // 
            this.LabelCoechipieri.AutoSize = true;
            this.LabelCoechipieri.Location = new System.Drawing.Point(43, 121);
            this.LabelCoechipieri.Name = "LabelCoechipieri";
            this.LabelCoechipieri.Size = new System.Drawing.Size(62, 13);
            this.LabelCoechipieri.TabIndex = 55;
            this.LabelCoechipieri.Text = "Coechipieri:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 21);
            this.button1.TabIndex = 56;
            this.button1.Text = "Coechipier nou...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Pierderi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Antrenor";
            // 
            // PierderiEchipa
            // 
            this.PierderiEchipa.AutoSize = true;
            this.PierderiEchipa.Location = new System.Drawing.Point(43, 108);
            this.PierderiEchipa.Name = "PierderiEchipa";
            this.PierderiEchipa.Size = new System.Drawing.Size(75, 13);
            this.PierderiEchipa.TabIndex = 59;
            this.PierderiEchipa.Text = "PierderiEchipa";
            this.PierderiEchipa.Click += new System.EventHandler(this.PierderiEchipa_Click);
            // 
            // CastiguriEchipa
            // 
            this.CastiguriEchipa.AutoSize = true;
            this.CastiguriEchipa.Location = new System.Drawing.Point(43, 95);
            this.CastiguriEchipa.Name = "CastiguriEchipa";
            this.CastiguriEchipa.Size = new System.Drawing.Size(80, 13);
            this.CastiguriEchipa.TabIndex = 60;
            this.CastiguriEchipa.Text = "CastiguriEchipa";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(516, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 21);
            this.button5.TabIndex = 62;
            this.button5.Text = "Echipa noua...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 22);
            this.button4.TabIndex = 61;
            this.button4.Text = "Inapoi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(616, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 21);
            this.button6.TabIndex = 63;
            this.button6.Text = "Sterge echipa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 64;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 65;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 20);
            this.textBox3.TabIndex = 66;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(418, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 20);
            this.textBox4.TabIndex = 67;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 68;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(418, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 21);
            this.comboBox2.TabIndex = 69;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Nr. rezultate:";
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.Location = new System.Drawing.Point(253, 6);
            this.numericUpDownFind.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFind.Name = "numericUpDownFind";
            this.numericUpDownFind.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownFind.TabIndex = 113;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(253, 31);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(52, 22);
            this.buttonFind.TabIndex = 112;
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
            "Castiguri (totale, crescator)",
            "Castiguri (totale, descrescator)",
            "Castiguri (curente, crescator)",
            "Castiguri (curente, descrescator)",
            "Pierderi (totale, crescator)",
            "Pierderi (totale, descrescator)",
            "Pierderi (curente, crescator)",
            "Pierderi (curente, descrescator)",
            "Nume detinator (alfabetic crescator)",
            "Nume detinator (alfabetic descrescator)"});
            this.comboBoxFind.Location = new System.Drawing.Point(46, 31);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(201, 21);
            this.comboBoxFind.TabIndex = 111;
            // 
            // FormEchipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CastiguriEchipa);
            this.Controls.Add(this.PierderiEchipa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelCoechipieri);
            this.Controls.Add(this.LabelEchipa);
            this.Controls.Add(this.comboBoxEchipa);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormEchipe";
            this.Text = "FormEchipe";
            this.Load += new System.EventHandler(this.FormEchipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEchipa;
        private System.Windows.Forms.Label LabelEchipa;
        private System.Windows.Forms.Label LabelCoechipieri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PierderiEchipa;
        private System.Windows.Forms.Label CastiguriEchipa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxFind;
    }
}