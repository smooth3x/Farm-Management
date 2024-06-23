namespace FarmManagement
{
    partial class LoadApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.bCreateFarm = new System.Windows.Forms.Button();
            this.tFarmName = new System.Windows.Forms.TextBox();
            this.tOwnerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbLoadFile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pbUploadImage = new System.Windows.Forms.PictureBox();
            this.pbV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(379, 92);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם החווה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bCreateFarm
            // 
            this.bCreateFarm.BackColor = System.Drawing.Color.Honeydew;
            this.bCreateFarm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateFarm.Location = new System.Drawing.Point(249, 197);
            this.bCreateFarm.Name = "bCreateFarm";
            this.bCreateFarm.Size = new System.Drawing.Size(195, 29);
            this.bCreateFarm.TabIndex = 1;
            this.bCreateFarm.Text = "התחל ניהול חווה";
            this.bCreateFarm.UseVisualStyleBackColor = false;
            this.bCreateFarm.Click += new System.EventHandler(this.bCreateFarm_Click);
            // 
            // tFarmName
            // 
            this.tFarmName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tFarmName.Location = new System.Drawing.Point(249, 96);
            this.tFarmName.MaxLength = 30;
            this.tFarmName.Name = "tFarmName";
            this.tFarmName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tFarmName.Size = new System.Drawing.Size(124, 25);
            this.tFarmName.TabIndex = 2;
            this.tFarmName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFarmName_KeyPress);
            // 
            // tOwnerName
            // 
            this.tOwnerName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tOwnerName.Location = new System.Drawing.Point(249, 125);
            this.tOwnerName.MaxLength = 30;
            this.tOwnerName.Name = "tOwnerName";
            this.tOwnerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tOwnerName.Size = new System.Drawing.Size(124, 25);
            this.tOwnerName.TabIndex = 4;
            this.tOwnerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tOwnerName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(379, 121);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "בעל החווה";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(321, 160);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "צילום החווה מלמעלה";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(255, 42);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "חווה חדשה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(29, 81);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(157, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "העלה חווה מקובץ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(218, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 140);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pbLoadFile
            // 
            this.pbLoadFile.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadFile.BackgroundImage = global::FarmManagement.Properties.Resources.UploadIcon;
            this.pbLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLoadFile.Location = new System.Drawing.Point(73, 118);
            this.pbLoadFile.Name = "pbLoadFile";
            this.pbLoadFile.Size = new System.Drawing.Size(59, 50);
            this.pbLoadFile.TabIndex = 38;
            this.pbLoadFile.TabStop = false;
            this.pbLoadFile.Click += new System.EventHandler(this.pbLoadFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FarmManagement.Properties.Resources.FarmLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(376, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 61);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox2.Location = new System.Drawing.Point(250, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 3);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox4.Location = new System.Drawing.Point(27, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 3);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox5.Location = new System.Drawing.Point(29, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(155, 3);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox6.Location = new System.Drawing.Point(383, 114);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(62, 2);
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox7.Location = new System.Drawing.Point(383, 143);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(62, 2);
            this.pictureBox7.TabIndex = 44;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox8.Location = new System.Drawing.Point(323, 182);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 2);
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // pbUploadImage
            // 
            this.pbUploadImage.BackColor = System.Drawing.Color.Transparent;
            this.pbUploadImage.BackgroundImage = global::FarmManagement.Properties.Resources.UploadImage;
            this.pbUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUploadImage.Location = new System.Drawing.Point(277, 154);
            this.pbUploadImage.Name = "pbUploadImage";
            this.pbUploadImage.Size = new System.Drawing.Size(38, 31);
            this.pbUploadImage.TabIndex = 46;
            this.pbUploadImage.TabStop = false;
            this.pbUploadImage.Click += new System.EventHandler(this.pbUploadImage_Click);
            // 
            // pbV
            // 
            this.pbV.BackColor = System.Drawing.Color.Transparent;
            this.pbV.BackgroundImage = global::FarmManagement.Properties.Resources.V_Icon;
            this.pbV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbV.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbV.Location = new System.Drawing.Point(451, 166);
            this.pbV.Name = "pbV";
            this.pbV.Size = new System.Drawing.Size(20, 15);
            this.pbV.TabIndex = 47;
            this.pbV.TabStop = false;
            this.pbV.Visible = false;
            // 
            // LoadApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::FarmManagement.Properties.Resources.bg_load;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.Controls.Add(this.pbV);
            this.Controls.Add(this.pbUploadImage);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLoadFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tOwnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tFarmName);
            this.Controls.Add(this.bCreateFarm);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "LoadApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "אפליקציית ניהול חווה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCreateFarm;
        private System.Windows.Forms.TextBox tFarmName;
        private System.Windows.Forms.TextBox tOwnerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbLoadFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pbUploadImage;
        private System.Windows.Forms.PictureBox pbV;
    }
}