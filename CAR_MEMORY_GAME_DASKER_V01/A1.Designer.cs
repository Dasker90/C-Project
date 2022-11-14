namespace CAR_MEMORY_GAME_DASKER_V01
{
    partial class A1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A1));
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_MAin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_Main.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox_Main.Image = global::CAR_MEMORY_GAME_DASKER_V01.Properties.Resources.main1;
            this.pictureBox_Main.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(381, 135);
            this.pictureBox_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Window;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Commodore 64", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_start.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_start.Location = new System.Drawing.Point(12, 218);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(381, 59);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.SystemColors.Window;
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Commodore 64", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_about.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_about.Location = new System.Drawing.Point(207, 283);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(186, 59);
            this.btn_about.TabIndex = 2;
            this.btn_about.Text = "ABOUT";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Window;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Commodore 64", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.Location = new System.Drawing.Point(12, 283);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 59);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // lbl_MAin
            // 
            this.lbl_MAin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MAin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_MAin.Font = new System.Drawing.Font("Commodore 64 Rounded", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MAin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_MAin.Location = new System.Drawing.Point(12, 150);
            this.lbl_MAin.Name = "lbl_MAin";
            this.lbl_MAin.Size = new System.Drawing.Size(381, 65);
            this.lbl_MAin.TabIndex = 4;
            this.lbl_MAin.Text = "CAR MEMORY GAME";
            this.lbl_MAin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MAin.Click += new System.EventHandler(this.label1_Click);
            // 
            // A1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(405, 356);
            this.Controls.Add(this.lbl_MAin);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pictureBox_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_MAin;
    }
}

