namespace OtoSepet
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.markalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet1 = new OtoSepet.OtoDatabaseDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.yakitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet3 = new OtoSepet.OtoDatabaseDataSet3();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.viteslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet4 = new OtoSepet.OtoDatabaseDataSet4();
            this.otoDatabaseDataSet = new OtoSepet.OtoDatabaseDataSet();
            this.otoDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markalarTableAdapter = new OtoSepet.OtoDatabaseDataSet1TableAdapters.MarkalarTableAdapter();
            this.yakitlarTableAdapter = new OtoSepet.OtoDatabaseDataSet3TableAdapters.YakitlarTableAdapter();
            this.viteslerTableAdapter = new OtoSepet.OtoDatabaseDataSet4TableAdapters.ViteslerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.siniflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet5 = new OtoSepet.OtoDatabaseDataSet5();
            this.siniflarTableAdapter = new OtoSepet.OtoDatabaseDataSet5TableAdapters.SiniflarTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viteslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.markalarBindingSource;
            this.comboBox1.DisplayMember = "marka";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "marka";
            // 
            // markalarBindingSource
            // 
            this.markalarBindingSource.DataMember = "Markalar";
            this.markalarBindingSource.DataSource = this.otoDatabaseDataSet1;
            // 
            // otoDatabaseDataSet1
            // 
            this.otoDatabaseDataSet1.DataSetName = "OtoDatabaseDataSet1";
            this.otoDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.yakitlarBindingSource;
            this.comboBox2.DisplayMember = "yakitAdi";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(103, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "yakitKodu";
            // 
            // yakitlarBindingSource
            // 
            this.yakitlarBindingSource.DataMember = "Yakitlar";
            this.yakitlarBindingSource.DataSource = this.otoDatabaseDataSet3;
            // 
            // otoDatabaseDataSet3
            // 
            this.otoDatabaseDataSet3.DataSetName = "OtoDatabaseDataSet3";
            this.otoDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.viteslerBindingSource;
            this.comboBox3.DisplayMember = "vitesAdi";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(103, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(188, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "vitesAdi";
            // 
            // viteslerBindingSource
            // 
            this.viteslerBindingSource.DataMember = "Vitesler";
            this.viteslerBindingSource.DataSource = this.otoDatabaseDataSet4;
            // 
            // otoDatabaseDataSet4
            // 
            this.otoDatabaseDataSet4.DataSetName = "OtoDatabaseDataSet4";
            this.otoDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otoDatabaseDataSet
            // 
            this.otoDatabaseDataSet.DataSetName = "OtoDatabaseDataSet";
            this.otoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otoDatabaseDataSetBindingSource
            // 
            this.otoDatabaseDataSetBindingSource.DataSource = this.otoDatabaseDataSet;
            this.otoDatabaseDataSetBindingSource.Position = 0;
            // 
            // markalarTableAdapter
            // 
            this.markalarTableAdapter.ClearBeforeFill = true;
            // 
            // yakitlarTableAdapter
            // 
            this.yakitlarTableAdapter.ClearBeforeFill = true;
            // 
            // viteslerTableAdapter
            // 
            this.viteslerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yıl :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yakıt Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vites Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Motor Hacmi :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 12);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(15, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "Araç Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Günlük Fiyat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sınıf :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.siniflarBindingSource;
            this.comboBox5.DisplayMember = "sinifAdi";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(103, 224);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(188, 21);
            this.comboBox5.TabIndex = 18;
            this.comboBox5.ValueMember = "sinifKodu";
            // 
            // siniflarBindingSource
            // 
            this.siniflarBindingSource.DataMember = "Siniflar";
            this.siniflarBindingSource.DataSource = this.otoDatabaseDataSet5;
            // 
            // otoDatabaseDataSet5
            // 
            this.otoDatabaseDataSet5.DataSetName = "OtoDatabaseDataSet5";
            this.otoDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siniflarTableAdapter
            // 
            this.siniflarTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(103, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 315);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "OtoSepet Araç Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viteslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private OtoDatabaseDataSet otoDatabaseDataSet;
        private System.Windows.Forms.BindingSource otoDatabaseDataSetBindingSource;
        private OtoDatabaseDataSet1 otoDatabaseDataSet1;
        private System.Windows.Forms.BindingSource markalarBindingSource;
        private OtoDatabaseDataSet1TableAdapters.MarkalarTableAdapter markalarTableAdapter;
        private OtoDatabaseDataSet3 otoDatabaseDataSet3;
        private System.Windows.Forms.BindingSource yakitlarBindingSource;
        private OtoDatabaseDataSet3TableAdapters.YakitlarTableAdapter yakitlarTableAdapter;
        private OtoDatabaseDataSet4 otoDatabaseDataSet4;
        private System.Windows.Forms.BindingSource viteslerBindingSource;
        private OtoDatabaseDataSet4TableAdapters.ViteslerTableAdapter viteslerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private OtoDatabaseDataSet5 otoDatabaseDataSet5;
        private System.Windows.Forms.BindingSource siniflarBindingSource;
        private OtoDatabaseDataSet5TableAdapters.SiniflarTableAdapter siniflarTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
    }
}