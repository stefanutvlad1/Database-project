namespace CampionatMondial2
{
    partial class FormEchipaNoua
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
            this.textBoxPierderi = new System.Windows.Forms.TextBox();
            this.textBoxCastiguri = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.labelechnoua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPierderi
            // 
            this.textBoxPierderi.Location = new System.Drawing.Point(54, 96);
            this.textBoxPierderi.Name = "textBoxPierderi";
            this.textBoxPierderi.Size = new System.Drawing.Size(258, 20);
            this.textBoxPierderi.TabIndex = 86;
            // 
            // textBoxCastiguri
            // 
            this.textBoxCastiguri.Location = new System.Drawing.Point(55, 70);
            this.textBoxCastiguri.Name = "textBoxCastiguri";
            this.textBoxCastiguri.Size = new System.Drawing.Size(258, 20);
            this.textBoxCastiguri.TabIndex = 85;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(54, 44);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(258, 20);
            this.textBoxNume.TabIndex = 84;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Pierderi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Castiguri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nume";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(123, 314);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 22);
            this.buttonAdd.TabIndex = 91;
            this.buttonAdd.Text = "Adauga";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(223, 314);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 22);
            this.buttonBack.TabIndex = 90;
            this.buttonBack.Text = "Inapoi";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(12, 167);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 13);
            this.StatusLabel.TabIndex = 89;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 219);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 88;
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // labelechnoua
            // 
            this.labelechnoua.AutoSize = true;
            this.labelechnoua.Location = new System.Drawing.Point(13, 18);
            this.labelechnoua.Name = "labelechnoua";
            this.labelechnoua.Size = new System.Drawing.Size(109, 13);
            this.labelechnoua.TabIndex = 92;
            this.labelechnoua.Text = "Adauga echipa noua:";
            // 
            // FormEchipaNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 343);
            this.Controls.Add(this.labelechnoua);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.textBoxPierderi);
            this.Controls.Add(this.textBoxCastiguri);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "FormEchipaNoua";
            this.Text = "FormEchipaNoua";
            this.Load += new System.EventHandler(this.FormEchipaNoua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPierderi;
        private System.Windows.Forms.TextBox textBoxCastiguri;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label labelechnoua;
    }
}