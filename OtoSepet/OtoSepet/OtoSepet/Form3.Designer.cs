namespace OtoSepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.siniflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet6 = new OtoSepet.OtoDatabaseDataSet6();
            this.textBoxMotorMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.viteslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet7 = new OtoSepet.OtoDatabaseDataSet7();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.yakitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet8 = new OtoSepet.OtoDatabaseDataSet8();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.markalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoDatabaseDataSet9 = new OtoSepet.OtoDatabaseDataSet9();
            this.siniflarTableAdapter = new OtoSepet.OtoDatabaseDataSet6TableAdapters.SiniflarTableAdapter();
            this.viteslerTableAdapter = new OtoSepet.OtoDatabaseDataSet7TableAdapters.ViteslerTableAdapter();
            this.yakitlarTableAdapter = new OtoSepet.OtoDatabaseDataSet8TableAdapters.YakitlarTableAdapter();
            this.markalarTableAdapter = new OtoSepet.OtoDatabaseDataSet9TableAdapters.MarkalarTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYilMin = new System.Windows.Forms.TextBox();
            this.textBoxYilMax = new System.Windows.Forms.TextBox();
            this.textBoxMotorMin = new System.Windows.Forms.TextBox();
            this.textBoxFiyatMax = new System.Windows.Forms.TextBox();
            this.textBoxFiyatMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viteslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siniflarBindingSource
            // 
            this.siniflarBindingSource.DataMember = "Siniflar";
            this.siniflarBindingSource.DataSource = this.otoDatabaseDataSet6;
            // 
            // otoDatabaseDataSet6
            // 
            this.otoDatabaseDataSet6.DataSetName = "OtoDatabaseDataSet6";
            this.otoDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxMotorMax
            // 
            this.textBoxMotorMax.Location = new System.Drawing.Point(201, 179);
            this.textBoxMotorMax.Name = "textBoxMotorMax";
            this.textBoxMotorMax.Size = new System.Drawing.Size(91, 20);
            this.textBoxMotorMax.TabIndex = 35;
            this.textBoxMotorMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMotorMax_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(13, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fiyat* :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(12, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 81);
            this.button1.TabIndex = 30;
            this.button1.Text = "Araç Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Motor Hacmi* :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vites Türü* :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yakıt Türü* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Model* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Marka* :";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.viteslerBindingSource;
            this.comboBox3.DisplayMember = "vitesAdi";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(104, 136);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(188, 21);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.ValueMember = "vitesKodu";
            // 
            // viteslerBindingSource
            // 
            this.viteslerBindingSource.DataMember = "Vitesler";
            this.viteslerBindingSource.DataSource = this.otoDatabaseDataSet7;
            // 
            // otoDatabaseDataSet7
            // 
            this.otoDatabaseDataSet7.DataSetName = "OtoDatabaseDataSet7";
            this.otoDatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.yakitlarBindingSource;
            this.comboBox2.DisplayMember = "yakitAdi";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "yakitKodu";
            // 
            // yakitlarBindingSource
            // 
            this.yakitlarBindingSource.DataMember = "Yakitlar";
            this.yakitlarBindingSource.DataSource = this.otoDatabaseDataSet8;
            // 
            // otoDatabaseDataSet8
            // 
            this.otoDatabaseDataSet8.DataSetName = "OtoDatabaseDataSet8";
            this.otoDatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.markalarBindingSource;
            this.comboBox1.DisplayMember = "marka";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "marka";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // markalarBindingSource
            // 
            this.markalarBindingSource.DataMember = "Markalar";
            this.markalarBindingSource.DataSource = this.otoDatabaseDataSet9;
            // 
            // otoDatabaseDataSet9
            // 
            this.otoDatabaseDataSet9.DataSetName = "OtoDatabaseDataSet9";
            this.otoDatabaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siniflarTableAdapter
            // 
            this.siniflarTableAdapter.ClearBeforeFill = true;
            // 
            // viteslerTableAdapter
            // 
            this.viteslerTableAdapter.ClearBeforeFill = true;
            // 
            // yakitlarTableAdapter
            // 
            this.yakitlarTableAdapter.ClearBeforeFill = true;
            // 
            // markalarTableAdapter
            // 
            this.markalarTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Yıl* :";
            // 
            // textBoxYilMin
            // 
            this.textBoxYilMin.Location = new System.Drawing.Point(104, 83);
            this.textBoxYilMin.MaxLength = 4;
            this.textBoxYilMin.Name = "textBoxYilMin";
            this.textBoxYilMin.Size = new System.Drawing.Size(91, 20);
            this.textBoxYilMin.TabIndex = 41;
            this.textBoxYilMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYilMin_KeyPress);
            // 
            // textBoxYilMax
            // 
            this.textBoxYilMax.Location = new System.Drawing.Point(201, 83);
            this.textBoxYilMax.MaxLength = 4;
            this.textBoxYilMax.Name = "textBoxYilMax";
            this.textBoxYilMax.Size = new System.Drawing.Size(91, 20);
            this.textBoxYilMax.TabIndex = 42;
            this.textBoxYilMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYilMax_KeyPress);
            // 
            // textBoxMotorMin
            // 
            this.textBoxMotorMin.Location = new System.Drawing.Point(104, 179);
            this.textBoxMotorMin.Name = "textBoxMotorMin";
            this.textBoxMotorMin.Size = new System.Drawing.Size(91, 20);
            this.textBoxMotorMin.TabIndex = 43;
            this.textBoxMotorMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMotorMin_KeyPress);
            // 
            // textBoxFiyatMax
            // 
            this.textBoxFiyatMax.Location = new System.Drawing.Point(201, 221);
            this.textBoxFiyatMax.Name = "textBoxFiyatMax";
            this.textBoxFiyatMax.Size = new System.Drawing.Size(91, 20);
            this.textBoxFiyatMax.TabIndex = 45;
            this.textBoxFiyatMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiyatMax_KeyPress);
            // 
            // textBoxFiyatMin
            // 
            this.textBoxFiyatMin.Location = new System.Drawing.Point(104, 221);
            this.textBoxFiyatMin.Name = "textBoxFiyatMin";
            this.textBoxFiyatMin.Size = new System.Drawing.Size(91, 20);
            this.textBoxFiyatMin.TabIndex = 44;
            this.textBoxFiyatMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiyatMin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(101, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(198, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(202, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(105, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(202, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(105, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Min";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(104, 39);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(188, 21);
            this.comboBox4.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(13, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "Tüm alanları doldurmak zorunludur*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1131, 513);
            this.dataGridView1.TabIndex = 54;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1441, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiyatMax);
            this.Controls.Add(this.textBoxFiyatMin);
            this.Controls.Add(this.textBoxMotorMin);
            this.Controls.Add(this.textBoxYilMax);
            this.Controls.Add(this.textBoxYilMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMotorMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "OtoSepet Araç Bul";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viteslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoDatabaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMotorMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private OtoDatabaseDataSet6 otoDatabaseDataSet6;
        private System.Windows.Forms.BindingSource siniflarBindingSource;
        private OtoDatabaseDataSet6TableAdapters.SiniflarTableAdapter siniflarTableAdapter;
        private OtoDatabaseDataSet7 otoDatabaseDataSet7;
        private System.Windows.Forms.BindingSource viteslerBindingSource;
        private OtoDatabaseDataSet7TableAdapters.ViteslerTableAdapter viteslerTableAdapter;
        private OtoDatabaseDataSet8 otoDatabaseDataSet8;
        private System.Windows.Forms.BindingSource yakitlarBindingSource;
        private OtoDatabaseDataSet8TableAdapters.YakitlarTableAdapter yakitlarTableAdapter;
        private OtoDatabaseDataSet9 otoDatabaseDataSet9;
        private System.Windows.Forms.BindingSource markalarBindingSource;
        private OtoDatabaseDataSet9TableAdapters.MarkalarTableAdapter markalarTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYilMin;
        private System.Windows.Forms.TextBox textBoxYilMax;
        private System.Windows.Forms.TextBox textBoxMotorMin;
        private System.Windows.Forms.TextBox textBoxFiyatMax;
        private System.Windows.Forms.TextBox textBoxFiyatMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}