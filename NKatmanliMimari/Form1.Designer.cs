namespace NKatmanliMimari
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGorev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dbPersonelDataSet = new NKatmanliMimari.DbPersonelDataSet();
            this.tBLBİLGİBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLBİLGİTableAdapter = new NKatmanliMimari.DbPersonelDataSetTableAdapters.TBLBİLGİTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEHIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gOREVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPersonelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBİLGİBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.sEHIRDataGridViewTextBoxColumn,
            this.gOREVDataGridViewTextBoxColumn,
            this.mAASDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLBİLGİBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(738, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(16, 8);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID : ";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(103, 6);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(134, 29);
            this.textbox1.TabIndex = 3;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(602, 3);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(152, 41);
            this.BtnListele.TabIndex = 4;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(103, 67);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(134, 29);
            this.TxtAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD : ";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(103, 133);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(134, 29);
            this.TxtSoyad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "SOYAD : ";
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(396, 136);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(134, 29);
            this.TxtSehir.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "ŞEHİR : ";
            // 
            // TxtGorev
            // 
            this.TxtGorev.Location = new System.Drawing.Point(396, 74);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Size = new System.Drawing.Size(134, 29);
            this.TxtGorev.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "GÖREV : ";
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(396, 12);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(134, 29);
            this.TxtMaas.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "MAAŞ :";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(602, 50);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(152, 41);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "EKLE";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(602, 97);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(152, 41);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(602, 144);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(152, 41);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dbPersonelDataSet
            // 
            this.dbPersonelDataSet.DataSetName = "DbPersonelDataSet";
            this.dbPersonelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLBİLGİBindingSource
            // 
            this.tBLBİLGİBindingSource.DataMember = "TBLBİLGİ";
            this.tBLBİLGİBindingSource.DataSource = this.dbPersonelDataSet;
            // 
            // tBLBİLGİTableAdapter
            // 
            this.tBLBİLGİTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            // 
            // sEHIRDataGridViewTextBoxColumn
            // 
            this.sEHIRDataGridViewTextBoxColumn.DataPropertyName = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.HeaderText = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.Name = "sEHIRDataGridViewTextBoxColumn";
            // 
            // gOREVDataGridViewTextBoxColumn
            // 
            this.gOREVDataGridViewTextBoxColumn.DataPropertyName = "GOREV";
            this.gOREVDataGridViewTextBoxColumn.HeaderText = "GOREV";
            this.gOREVDataGridViewTextBoxColumn.Name = "gOREVDataGridViewTextBoxColumn";
            // 
            // mAASDataGridViewTextBoxColumn
            // 
            this.mAASDataGridViewTextBoxColumn.DataPropertyName = "MAAS";
            this.mAASDataGridViewTextBoxColumn.HeaderText = "MAAS";
            this.mAASDataGridViewTextBoxColumn.Name = "mAASDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 403);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtSehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGorev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPersonelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBİLGİBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private DbPersonelDataSet dbPersonelDataSet;
        private System.Windows.Forms.BindingSource tBLBİLGİBindingSource;
        private DbPersonelDataSetTableAdapters.TBLBİLGİTableAdapter tBLBİLGİTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEHIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOREVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAASDataGridViewTextBoxColumn;
    }
}

