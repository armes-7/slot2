namespace _2021
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.BtnDurdur = new System.Windows.Forms.Button();
            this.BtnJetonAt = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.lblKasa = new System.Windows.Forms.Label();
            this.Kasadakipara = new System.Windows.Forms.Label();
            this.lbDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1_org_zoom.jpg");
            this.ımageList1.Images.SetKeyName(1, "201681154251638537234067.jpg");
            this.ımageList1.Images.SetKeyName(2, "download.jpg");
            this.ımageList1.Images.SetKeyName(3, "elma.png");
            this.ımageList1.Images.SetKeyName(4, "images.jpg");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(186, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(377, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // BtnBasla
            // 
            this.BtnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBasla.Location = new System.Drawing.Point(2, 381);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(110, 41);
            this.BtnBasla.TabIndex = 3;
            this.BtnBasla.Text = "PLAY";
            this.BtnBasla.UseVisualStyleBackColor = false;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click_1);
            // 
            // BtnDurdur
            // 
            this.BtnDurdur.BackColor = System.Drawing.Color.Red;
            this.BtnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDurdur.Location = new System.Drawing.Point(130, 381);
            this.BtnDurdur.Name = "BtnDurdur";
            this.BtnDurdur.Size = new System.Drawing.Size(103, 41);
            this.BtnDurdur.TabIndex = 4;
            this.BtnDurdur.Text = "STOP";
            this.BtnDurdur.UseVisualStyleBackColor = false;
            this.BtnDurdur.Click += new System.EventHandler(this.BtnDurdur_Click_1);
            // 
            // BtnJetonAt
            // 
            this.BtnJetonAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnJetonAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJetonAt.Location = new System.Drawing.Point(256, 381);
            this.BtnJetonAt.Name = "BtnJetonAt";
            this.BtnJetonAt.Size = new System.Drawing.Size(106, 41);
            this.BtnJetonAt.TabIndex = 5;
            this.BtnJetonAt.Text = "JetonAt";
            this.BtnJetonAt.UseVisualStyleBackColor = false;
            this.BtnJetonAt.Click += new System.EventHandler(this.BtnJetonAt_Click_1);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Maroon;
            this.BtnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Location = new System.Drawing.Point(396, 381);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(99, 41);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "CLOSE";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click_1);
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.Location = new System.Drawing.Point(12, 249);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(81, 27);
            this.lblKasa.TabIndex = 7;
            this.lblKasa.Text = "KASA:";
            // 
            // Kasadakipara
            // 
            this.Kasadakipara.AutoSize = true;
            this.Kasadakipara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kasadakipara.ForeColor = System.Drawing.Color.Red;
            this.Kasadakipara.Location = new System.Drawing.Point(130, 249);
            this.Kasadakipara.Name = "Kasadakipara";
            this.Kasadakipara.Size = new System.Drawing.Size(24, 25);
            this.Kasadakipara.TabIndex = 8;
            this.Kasadakipara.Text = "0";
            // 
            // lbDurum
            // 
            this.lbDurum.AutoSize = true;
            this.lbDurum.BackColor = System.Drawing.Color.White;
            this.lbDurum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDurum.Location = new System.Drawing.Point(15, 206);
            this.lbDurum.Name = "lbDurum";
            this.lbDurum.Size = new System.Drawing.Size(77, 27);
            this.lbDurum.TabIndex = 9;
            this.lbDurum.Text = "Durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.lbDurum);
            this.Controls.Add(this.Kasadakipara);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnJetonAt);
            this.Controls.Add(this.BtnDurdur);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SLOTMACHİNE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Button BtnDurdur;
        private System.Windows.Forms.Button BtnJetonAt;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label Kasadakipara;
        private System.Windows.Forms.Label lbDurum;
    }
}

