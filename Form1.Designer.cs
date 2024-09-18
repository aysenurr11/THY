namespace THY_PROJE_ODEVİ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            girisyap = new Button();
            kayıtol = new Button();
            satıcıgiris = new Button();
            checkin = new Button();
            ucusdurum = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 42);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 70);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(130, 24);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 1;
            label1.Text = "TURKISH AİRLINES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1167, 375);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // girisyap
            // 
            girisyap.BackColor = Color.Snow;
            girisyap.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisyap.Location = new Point(156, 491);
            girisyap.Name = "girisyap";
            girisyap.Size = new Size(168, 41);
            girisyap.TabIndex = 0;
            girisyap.Text = "GİRİŞ YAP";
            girisyap.UseVisualStyleBackColor = false;
            girisyap.Click += girisyap_Click;
            // 
            // kayıtol
            // 
            kayıtol.BackColor = Color.White;
            kayıtol.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kayıtol.Location = new Point(4, 491);
            kayıtol.Name = "kayıtol";
            kayıtol.Size = new Size(137, 41);
            kayıtol.TabIndex = 1;
            kayıtol.Text = "KAYIT OL";
            kayıtol.UseVisualStyleBackColor = false;
            kayıtol.Click += kayıtol_Click;
            // 
            // satıcıgiris
            // 
            satıcıgiris.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satıcıgiris.Location = new Point(342, 491);
            satıcıgiris.Name = "satıcıgiris";
            satıcıgiris.Size = new Size(150, 41);
            satıcıgiris.TabIndex = 3;
            satıcıgiris.Text = "SATICI GİRİŞ";
            satıcıgiris.UseVisualStyleBackColor = true;
            satıcıgiris.Click += satıcıgiris_Click;
            // 
            // checkin
            // 
            checkin.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkin.Location = new Point(556, 491);
            checkin.Name = "checkin";
            checkin.Size = new Size(132, 41);
            checkin.TabIndex = 5;
            checkin.Text = "CHECKİN";
            checkin.UseVisualStyleBackColor = true;
            checkin.Click += checkin_Click;
            // 
            // ucusdurum
            // 
            ucusdurum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ucusdurum.Location = new Point(730, 491);
            ucusdurum.Name = "ucusdurum";
            ucusdurum.Size = new Size(112, 41);
            ucusdurum.TabIndex = 6;
            ucusdurum.Text = "UÇUŞ";
            ucusdurum.UseVisualStyleBackColor = true;
            ucusdurum.Click += ucusdurum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 589);
            Controls.Add(ucusdurum);
            Controls.Add(checkin);
            Controls.Add(satıcıgiris);
            Controls.Add(kayıtol);
            Controls.Add(pictureBox2);
            Controls.Add(girisyap);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button girisyap;
        private Button kayıtol;
        private Button satıcıgiris;
        private Button checkin;
        private Button ucusdurum;
    }
}
