namespace THY_PROJE_ODEVİ
{
    partial class adminislemleri
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

        private Label GetLabel2()
        {
            return label2;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Label label2)
        {
            groupBox1 = new GroupBox();
            epostatxt = new TextBox();
            tckimliktxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tarihtxt = new TextBox();
            yolcusayısıtxt = new TextBox();
            nereyetxt = new TextBox();
            neredentxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            musteri_ekle_button = new Button();
            musteri_sil_button = new Button();
            musteri_guncelle_button = new Button();
            bilet_ekle_button = new Button();
            bilet_sil_button = new Button();
            bilet_güncelle_button = new Button();
            musteri_listele_button = new Button();
            bilet_listele_button = new Button();
            label7 = new Label();
            label8 = new Label();
            adıtxt = new TextBox();
            soyadıtxt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(soyadıtxt);
            groupBox1.Controls.Add(adıtxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(epostatxt);
            groupBox1.Controls.Add(tckimliktxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "YOLCU İŞLEMLERİ";
            // 
            // epostatxt
            // 
            epostatxt.Location = new Point(143, 202);
            epostatxt.Name = "epostatxt";
            epostatxt.Size = new Size(125, 27);
            epostatxt.TabIndex = 3;
            // 
            // tckimliktxt
            // 
            tckimliktxt.Location = new Point(143, 130);
            tckimliktxt.Name = "tckimliktxt";
            tckimliktxt.Size = new Size(125, 27);
            tckimliktxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 202);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "E POSTA";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 133);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "TC KİMLİK";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tarihtxt);
            groupBox2.Controls.Add(yolcusayısıtxt);
            groupBox2.Controls.Add(nereyetxt);
            groupBox2.Controls.Add(neredentxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(35, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 330);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BİLET İŞLEMLERİ";
            // 
            // tarihtxt
            // 
            tarihtxt.Location = new Point(143, 228);
            tarihtxt.Name = "tarihtxt";
            tarihtxt.Size = new Size(125, 27);
            tarihtxt.TabIndex = 7;
            // 
            // yolcusayısıtxt
            // 
            yolcusayısıtxt.Location = new Point(143, 279);
            yolcusayısıtxt.Name = "yolcusayısıtxt";
            yolcusayısıtxt.Size = new Size(125, 27);
            yolcusayısıtxt.TabIndex = 6;
            // 
            // nereyetxt
            // 
            nereyetxt.Location = new Point(143, 163);
            nereyetxt.Name = "nereyetxt";
            nereyetxt.Size = new Size(125, 27);
            nereyetxt.TabIndex = 5;
            // 
            // neredentxt
            // 
            neredentxt.Location = new Point(143, 82);
            neredentxt.Name = "neredentxt";
            neredentxt.Size = new Size(125, 27);
            neredentxt.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 231);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 3;
            label6.Text = "TARİH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 279);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 2;
            label5.Text = "YOLCU SAYISI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 166);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 1;
            label4.Text = "NEREYE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 82);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "NEREDEN";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(440, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(378, 222);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(451, 340);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(397, 222);
            dataGridView2.TabIndex = 3;
            // 
            // musteri_ekle_button
            // 
            musteri_ekle_button.Location = new Point(932, 48);
            musteri_ekle_button.Name = "musteri_ekle_button";
            musteri_ekle_button.Size = new Size(124, 31);
            musteri_ekle_button.TabIndex = 4;
            musteri_ekle_button.Text = "Müşteri Ekle";
            musteri_ekle_button.UseVisualStyleBackColor = true;
            musteri_ekle_button.Click += button1_Click;
            // 
            // musteri_sil_button
            // 
            musteri_sil_button.Location = new Point(932, 109);
            musteri_sil_button.Name = "musteri_sil_button";
            musteri_sil_button.Size = new Size(124, 30);
            musteri_sil_button.TabIndex = 5;
            musteri_sil_button.Text = "Müşteri Sil";
            musteri_sil_button.UseVisualStyleBackColor = true;
            musteri_sil_button.Click += button2_Click;
            // 
            // musteri_guncelle_button
            // 
            musteri_guncelle_button.Location = new Point(932, 171);
            musteri_guncelle_button.Name = "musteri_guncelle_button";
            musteri_guncelle_button.Size = new Size(141, 34);
            musteri_guncelle_button.TabIndex = 6;
            musteri_guncelle_button.Text = "Müşteri Güncelle";
            musteri_guncelle_button.UseVisualStyleBackColor = true;
            musteri_guncelle_button.Click += button3_Click;
            // 
            // bilet_ekle_button
            // 
            bilet_ekle_button.Location = new Point(962, 388);
            bilet_ekle_button.Name = "bilet_ekle_button";
            bilet_ekle_button.Size = new Size(94, 29);
            bilet_ekle_button.TabIndex = 7;
            bilet_ekle_button.Text = "BİLET EKLE";
            bilet_ekle_button.UseVisualStyleBackColor = true;
            bilet_ekle_button.Click += button4_Click;
            // 
            // bilet_sil_button
            // 
            bilet_sil_button.Location = new Point(962, 460);
            bilet_sil_button.Name = "bilet_sil_button";
            bilet_sil_button.Size = new Size(94, 29);
            bilet_sil_button.TabIndex = 8;
            bilet_sil_button.Text = "BİLET SİL";
            bilet_sil_button.UseVisualStyleBackColor = true;
            // 
            // bilet_güncelle_button
            // 
            bilet_güncelle_button.Location = new Point(950, 533);
            bilet_güncelle_button.Name = "bilet_güncelle_button";
            bilet_güncelle_button.Size = new Size(159, 29);
            bilet_güncelle_button.TabIndex = 9;
            bilet_güncelle_button.Text = "BİLET GÜNCELLE";
            bilet_güncelle_button.UseVisualStyleBackColor = true;
            // 
            // musteri_listele_button
            // 
            musteri_listele_button.Location = new Point(950, 230);
            musteri_listele_button.Name = "musteri_listele_button";
            musteri_listele_button.Size = new Size(123, 40);
            musteri_listele_button.TabIndex = 10;
            musteri_listele_button.Text = "Müşteri Listele";
            musteri_listele_button.UseVisualStyleBackColor = true;
            // 
            // bilet_listele_button
            // 
            bilet_listele_button.Location = new Point(950, 599);
            bilet_listele_button.Name = "bilet_listele_button";
            bilet_listele_button.Size = new Size(106, 36);
            bilet_listele_button.TabIndex = 11;
            bilet_listele_button.Text = "Bilet Listele";
            bilet_listele_button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 46);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 4;
            label7.Text = "ADI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 87);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 5;
            label8.Text = "SOYADI";
            // 
            // adıtxt
            // 
            adıtxt.Location = new Point(143, 43);
            adıtxt.Name = "adıtxt";
            adıtxt.Size = new Size(125, 27);
            adıtxt.TabIndex = 6;
            // 
            // soyadıtxt
            // 
            soyadıtxt.Location = new Point(143, 84);
            soyadıtxt.Name = "soyadıtxt";
            soyadıtxt.Size = new Size(125, 27);
            soyadıtxt.TabIndex = 7;
            // 
            // adminislemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 721);
            Controls.Add(bilet_listele_button);
            Controls.Add(musteri_listele_button);
            Controls.Add(bilet_güncelle_button);
            Controls.Add(bilet_sil_button);
            Controls.Add(bilet_ekle_button);
            Controls.Add(musteri_guncelle_button);
            Controls.Add(musteri_sil_button);
            Controls.Add(musteri_ekle_button);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "adminislemleri";
            Text = "adminislemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label1;
        private TextBox epostatxt;
        private TextBox tckimliktxt;
        private Button musteri_ekle_button;
        private Button musteri_sil_button;
        private Button musteri_guncelle_button;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button bilet_ekle_button;
        private Button bilet_sil_button;
        private Button bilet_güncelle_button;
        private TextBox tarihtxt;
        private TextBox yolcusayısıtxt;
        private TextBox nereyetxt;
        private TextBox neredentxt;
        private Button musteri_listele_button;
        private Button bilet_listele_button;
        private TextBox soyadıtxt;
        private TextBox adıtxt;
        private Label label8;
        private Label label7;
    }
}