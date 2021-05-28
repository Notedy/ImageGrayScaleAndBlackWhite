
namespace Image_processing_blackwhite
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
            this.btnOrigin = new System.Windows.Forms.Button();
            this.openpicture = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnGray2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBlackWhite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnNagative = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrigin
            // 
            this.btnOrigin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrigin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnOrigin.Location = new System.Drawing.Point(34, 19);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(126, 83);
            this.btnOrigin.TabIndex = 0;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = false;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // openpicture
            // 
            this.openpicture.BackColor = System.Drawing.Color.BlueViolet;
            this.openpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openpicture.ForeColor = System.Drawing.SystemColors.MenuText;
            this.openpicture.Location = new System.Drawing.Point(205, 19);
            this.openpicture.Name = "openpicture";
            this.openpicture.Size = new System.Drawing.Size(133, 83);
            this.openpicture.TabIndex = 1;
            this.openpicture.Text = "open picture";
            this.openpicture.UseVisualStyleBackColor = false;
            this.openpicture.Click += new System.EventHandler(this.openpicture_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGray.Location = new System.Drawing.Point(372, 19);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(133, 83);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "Gray Scale1";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnGray2
            // 
            this.btnGray2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGray2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGray2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGray2.Location = new System.Drawing.Point(533, 19);
            this.btnGray2.Name = "btnGray2";
            this.btnGray2.Size = new System.Drawing.Size(133, 83);
            this.btnGray2.TabIndex = 3;
            this.btnGray2.Text = "Gray Scale2";
            this.btnGray2.UseVisualStyleBackColor = false;
            this.btnGray2.Click += new System.EventHandler(this.btnGray2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBlackWhite
            // 
            this.btnBlackWhite.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBlackWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlackWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackWhite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlackWhite.Location = new System.Drawing.Point(731, 115);
            this.btnBlackWhite.Name = "btnBlackWhite";
            this.btnBlackWhite.Size = new System.Drawing.Size(197, 88);
            this.btnBlackWhite.TabIndex = 5;
            this.btnBlackWhite.Text = "Black and White";
            this.btnBlackWhite.UseVisualStyleBackColor = false;
            this.btnBlackWhite.Click += new System.EventHandler(this.btnBlackWhite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(683, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threshold";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(799, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 28);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.btnBlackWhite_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnInsert.Location = new System.Drawing.Point(731, 307);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(197, 90);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnNagative
            // 
            this.btnNagative.BackColor = System.Drawing.Color.Teal;
            this.btnNagative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNagative.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNagative.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnNagative.Location = new System.Drawing.Point(731, 419);
            this.btnNagative.Name = "btnNagative";
            this.btnNagative.Size = new System.Drawing.Size(197, 91);
            this.btnNagative.TabIndex = 9;
            this.btnNagative.Text = "Nrgative";
            this.btnNagative.UseVisualStyleBackColor = false;
            this.btnNagative.Click += new System.EventHandler(this.btnNagative_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Location = new System.Drawing.Point(879, -1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(86, 76);
            this.Close.TabIndex = 10;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSave.Location = new System.Drawing.Point(731, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 91);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(965, 638);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnNagative);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlackWhite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGray2);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.openpicture);
            this.Controls.Add(this.btnOrigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button openpicture;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnGray2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBlackWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnNagative;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btnSave;
    }
}

