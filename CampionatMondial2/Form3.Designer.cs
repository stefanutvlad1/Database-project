namespace CampionatMondial2
{
    partial class Form3
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
            this.meciuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campionat_mondialDataSet = new CampionatMondial2.Campionat_mondialDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEchipa1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEchipa2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStadion1 = new System.Windows.Forms.Label();
            this.fillBy2ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.meciuriTableAdapter = new CampionatMondial2.Campionat_mondialDataSetTableAdapters.MeciuriTableAdapter();
            this.tableAdapterManager = new CampionatMondial2.Campionat_mondialDataSetTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.campionatmondialDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meciuriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Echipa1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Echipa2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stadion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meciuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionat_mondialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionatmondialDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meciuriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // meciuriBindingSource
            // 
            this.meciuriBindingSource.DataMember = "Meciuri";
            this.meciuriBindingSource.DataSource = this.campionat_mondialDataSet;
            // 
            // campionat_mondialDataSet
            // 
            this.campionat_mondialDataSet.DataSetName = "Campionat_mondialDataSet";
            this.campionat_mondialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alte meciuri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Urmatorul meci:";
            // 
            // labelEchipa1
            // 
            this.labelEchipa1.AutoSize = true;
            this.labelEchipa1.Location = new System.Drawing.Point(234, 138);
            this.labelEchipa1.Name = "labelEchipa1";
            this.labelEchipa1.Size = new System.Drawing.Size(35, 13);
            this.labelEchipa1.TabIndex = 4;
            this.labelEchipa1.Text = "label3";
            this.labelEchipa1.Click += new System.EventHandler(this.labelEchipa1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "-";
            // 
            // labelEchipa2
            // 
            this.labelEchipa2.AutoSize = true;
            this.labelEchipa2.Location = new System.Drawing.Point(507, 138);
            this.labelEchipa2.Name = "labelEchipa2";
            this.labelEchipa2.Size = new System.Drawing.Size(35, 13);
            this.labelEchipa2.TabIndex = 6;
            this.labelEchipa2.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Se joaca in:";
            // 
            // labelStadion1
            // 
            this.labelStadion1.AutoSize = true;
            this.labelStadion1.Location = new System.Drawing.Point(394, 191);
            this.labelStadion1.Name = "labelStadion1";
            this.labelStadion1.Size = new System.Drawing.Size(35, 13);
            this.labelStadion1.TabIndex = 8;
            this.labelStadion1.Text = "label7";
            // 
            // fillBy2ToolStrip1
            // 
            this.fillBy2ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip1.Name = "fillBy2ToolStrip1";
            this.fillBy2ToolStrip1.Size = new System.Drawing.Size(800, 25);
            this.fillBy2ToolStrip1.TabIndex = 12;
            this.fillBy2ToolStrip1.Text = "fillBy2ToolStrip1";
            // 
            // meciuriTableAdapter
            // 
            this.meciuriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampionateTableAdapter = null;
            this.tableAdapterManager.CoechipieriTableAdapter = null;
            this.tableAdapterManager.EchipeTableAdapter = null;
            this.tableAdapterManager.MarcariTableAdapter = null;
            this.tableAdapterManager.MeciuriTableAdapter = this.meciuriTableAdapter;
            this.tableAdapterManager.ScorTableAdapter = null;
            this.tableAdapterManager.Stadioane_CampionateTableAdapter = null;
            this.tableAdapterManager.StadioaneTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CampionatMondial2.Campionat_mondialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pe data de:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(394, 217);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(52, 13);
            this.labelData.TabIndex = 14;
            this.labelData.Text = "labelData";
            // 
            // campionatmondialDataSetBindingSource
            // 
            this.campionatmondialDataSetBindingSource.DataSource = this.campionat_mondialDataSet;
            this.campionatmondialDataSetBindingSource.Position = 0;
            // 
            // meciuriBindingSource1
            // 
            this.meciuriBindingSource1.DataMember = "Meciuri";
            this.meciuriBindingSource1.DataSource = this.campionatmondialDataSetBindingSource;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Echipa1,
            this.Echipa2,
            this.Stadion,
            this.Data});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(228, 332);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(314, 147);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Echipa1
            // 
            this.Echipa1.Text = "Echipa1";
            // 
            // Echipa2
            // 
            this.Echipa2.Text = "Echipa2";
            // 
            // Stadion
            // 
            this.Stadion.Text = "Stadion";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 135;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Meciuri...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Echipe...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 545);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Scoruri...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Campionate...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(180, 545);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Stadioane...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fillBy2ToolStrip1);
            this.Controls.Add(this.labelStadion1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEchipa2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelEchipa1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Meniu principal";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meciuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionat_mondialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionatmondialDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meciuriBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Campionat_mondialDataSet campionat_mondialDataSet;
        private System.Windows.Forms.BindingSource meciuriBindingSource;
        private Campionat_mondialDataSetTableAdapters.MeciuriTableAdapter meciuriTableAdapter;
        private Campionat_mondialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEchipa1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEchipa2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStadion1;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.BindingSource campionatmondialDataSetBindingSource;
        private System.Windows.Forms.BindingSource meciuriBindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Echipa1;
        private System.Windows.Forms.ColumnHeader Echipa2;
        private System.Windows.Forms.ColumnHeader Stadion;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}