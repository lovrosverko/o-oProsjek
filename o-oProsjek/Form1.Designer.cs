namespace o_oProsjek
{
    partial class Form1
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
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeOdabir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUkupniProsjek = new System.Windows.Forms.Button();
            this.btnProsjekPredmeta = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lstBoxIspis = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(99, 71);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(176, 22);
            this.txtOcjena.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 199;
            this.label1.Text = "Ocjena";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matematika",
            "Fizika",
            "Programiranje",
            "Hrvatski jezik"});
            this.comboBox1.Location = new System.Drawing.Point(99, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Predmet";
            // 
            // dateTimeOdabir
            // 
            this.dateTimeOdabir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOdabir.Location = new System.Drawing.Point(99, 110);
            this.dateTimeOdabir.Name = "dateTimeOdabir";
            this.dateTimeOdabir.Size = new System.Drawing.Size(176, 22);
            this.dateTimeOdabir.TabIndex = 2;
            this.dateTimeOdabir.Value = new System.DateTime(2025, 1, 7, 18, 5, 22, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 599;
            this.label3.Text = "Datum";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(18, 134);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 42);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(99, 138);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 38);
            this.btnIzbrisi.TabIndex = 7;
            this.btnIzbrisi.TabStop = false;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUkupniProsjek
            // 
            this.btnUkupniProsjek.Location = new System.Drawing.Point(18, 182);
            this.btnUkupniProsjek.Name = "btnUkupniProsjek";
            this.btnUkupniProsjek.Size = new System.Drawing.Size(156, 52);
            this.btnUkupniProsjek.TabIndex = 4;
            this.btnUkupniProsjek.Text = "Izračunaj ukupni prosjek";
            this.btnUkupniProsjek.UseVisualStyleBackColor = true;
            this.btnUkupniProsjek.Click += new System.EventHandler(this.btnUkupniProsjek_Click);
            // 
            // btnProsjekPredmeta
            // 
            this.btnProsjekPredmeta.Location = new System.Drawing.Point(26, 72);
            this.btnProsjekPredmeta.Name = "btnProsjekPredmeta";
            this.btnProsjekPredmeta.Size = new System.Drawing.Size(215, 52);
            this.btnProsjekPredmeta.TabIndex = 6;
            this.btnProsjekPredmeta.Text = "Izračunaj prosjek predmeta";
            this.btnProsjekPredmeta.UseVisualStyleBackColor = true;
            this.btnProsjekPredmeta.Click += new System.EventHandler(this.btnProsjekPredmeta_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.comboBox2);
            this.grpBox.Controls.Add(this.btnProsjekPredmeta);
            this.grpBox.Location = new System.Drawing.Point(20, 240);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(255, 150);
            this.grpBox.TabIndex = 10;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Odaberi predmet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Matematika",
            "Fizika",
            "Programiranje",
            "Hrvatski jezik"});
            this.comboBox2.Location = new System.Drawing.Point(26, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // lstBoxIspis
            // 
            this.lstBoxIspis.FormattingEnabled = true;
            this.lstBoxIspis.ItemHeight = 16;
            this.lstBoxIspis.Location = new System.Drawing.Point(281, 32);
            this.lstBoxIspis.Name = "lstBoxIspis";
            this.lstBoxIspis.Size = new System.Drawing.Size(507, 356);
            this.lstBoxIspis.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Predmet",
            "Ocjena",
            "Datum"});
            this.comboBox3.Location = new System.Drawing.Point(200, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 24);
            this.comboBox3.TabIndex = 600;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(200, 196);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 38);
            this.btnSortiraj.TabIndex = 601;
            this.btnSortiraj.TabStop = false;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(200, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 20);
            this.checkBox1.TabIndex = 602;
            this.checkBox1.Text = "Desc";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lstBoxIspis);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnUkupniProsjek);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeOdabir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOcjena);
            this.Name = "Form1";
            this.Text = "Računanje prosjeka";
            this.grpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeOdabir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnUkupniProsjek;
        private System.Windows.Forms.Button btnProsjekPredmeta;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox lstBoxIspis;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

