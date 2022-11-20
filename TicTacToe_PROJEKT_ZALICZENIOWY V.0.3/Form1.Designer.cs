namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbl_Napis_Glowny = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_New_Game = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPlayer0 = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lbl_Napis_PlayerO = new System.Windows.Forms.Label();
            this.lbl_Napis_PlayerX = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTic9 = new System.Windows.Forms.Button();
            this.btnTic8 = new System.Windows.Forms.Button();
            this.btnTic7 = new System.Windows.Forms.Button();
            this.btnTic6 = new System.Windows.Forms.Button();
            this.btnTic5 = new System.Windows.Forms.Button();
            this.btnTic4 = new System.Windows.Forms.Button();
            this.btnTic3 = new System.Windows.Forms.Button();
            this.btnTic2 = new System.Windows.Forms.Button();
            this.btnTic1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.lbl_Napis_Glowny);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("LED Sled Italic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtResult.Location = new System.Drawing.Point(23, 32);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(219, 40);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "00:00:00";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.UseSystemPasswordChar = true;
            // 
            // lbl_Napis_Glowny
            // 
            this.lbl_Napis_Glowny.AutoSize = true;
            this.lbl_Napis_Glowny.Font = new System.Drawing.Font("Abduction2002", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Napis_Glowny.Location = new System.Drawing.Point(301, 12);
            this.lbl_Napis_Glowny.Name = "lbl_Napis_Glowny";
            this.lbl_Napis_Glowny.Size = new System.Drawing.Size(697, 74);
            this.lbl_Napis_Glowny.TabIndex = 0;
            this.lbl_Napis_Glowny.Text = "Tic Tac Toe Game";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_color);
            this.panel2.Controls.Add(this.btn_info);
            this.panel2.Controls.Add(this.btn_pause);
            this.panel2.Controls.Add(this.btn_play);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(22, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 480);
            this.panel2.TabIndex = 1;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Gold;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_color.Font = new System.Drawing.Font("Commodore 64 Rounded", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(755, 222);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(81, 34);
            this.btn_color.TabIndex = 7;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Gold;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_info.Location = new System.Drawing.Point(687, 222);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(62, 34);
            this.btn_info.TabIndex = 6;
            this.btn_info.Text = "INFO";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Tomato;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pause.Location = new System.Drawing.Point(642, 222);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(39, 34);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "OFF";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_play.Location = new System.Drawing.Point(597, 222);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(39, 34);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "ON";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btn_New_Game);
            this.panel5.Controls.Add(this.btn_Exit);
            this.panel5.Controls.Add(this.btn_Reset);
            this.panel5.Location = new System.Drawing.Point(597, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 193);
            this.panel5.TabIndex = 3;
            // 
            // btn_New_Game
            // 
            this.btn_New_Game.BackColor = System.Drawing.Color.Gold;
            this.btn_New_Game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New_Game.Font = new System.Drawing.Font("Abduction2002", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New_Game.Location = new System.Drawing.Point(3, 8);
            this.btn_New_Game.Name = "btn_New_Game";
            this.btn_New_Game.Size = new System.Drawing.Size(594, 85);
            this.btn_New_Game.TabIndex = 11;
            this.btn_New_Game.Text = "NEW GAME";
            this.btn_New_Game.UseVisualStyleBackColor = false;
            this.btn_New_Game.Click += new System.EventHandler(this.btn_New_Game_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Gold;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Abduction2002", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(304, 99);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(293, 85);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Gold;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Abduction2002", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(3, 99);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(298, 85);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Turquoise;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblPlayer0);
            this.panel4.Controls.Add(this.lblPlayerX);
            this.panel4.Controls.Add(this.lbl_Napis_PlayerO);
            this.panel4.Controls.Add(this.lbl_Napis_PlayerX);
            this.panel4.Location = new System.Drawing.Point(597, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 193);
            this.panel4.TabIndex = 2;
            // 
            // lblPlayer0
            // 
            this.lblPlayer0.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblPlayer0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayer0.Font = new System.Drawing.Font("Alien Encounters", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer0.Location = new System.Drawing.Point(399, 99);
            this.lblPlayer0.Name = "lblPlayer0";
            this.lblPlayer0.Size = new System.Drawing.Size(181, 74);
            this.lblPlayer0.TabIndex = 4;
            this.lblPlayer0.Text = "1";
            this.lblPlayer0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayerX.Font = new System.Drawing.Font("Alien Encounters", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(399, 13);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(181, 74);
            this.lblPlayerX.TabIndex = 3;
            this.lblPlayerX.Text = "0";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Napis_PlayerO
            // 
            this.lbl_Napis_PlayerO.Font = new System.Drawing.Font("Abduction2002", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Napis_PlayerO.Location = new System.Drawing.Point(14, 99);
            this.lbl_Napis_PlayerO.Name = "lbl_Napis_PlayerO";
            this.lbl_Napis_PlayerO.Size = new System.Drawing.Size(421, 74);
            this.lbl_Napis_PlayerO.TabIndex = 2;
            this.lbl_Napis_PlayerO.Text = "Player O:";
            // 
            // lbl_Napis_PlayerX
            // 
            this.lbl_Napis_PlayerX.Font = new System.Drawing.Font("Abduction2002", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Napis_PlayerX.Location = new System.Drawing.Point(14, 13);
            this.lbl_Napis_PlayerX.Name = "lbl_Napis_PlayerX";
            this.lbl_Napis_PlayerX.Size = new System.Drawing.Size(421, 74);
            this.lbl_Napis_PlayerX.TabIndex = 1;
            this.lbl_Napis_PlayerX.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTic9);
            this.panel3.Controls.Add(this.btnTic8);
            this.panel3.Controls.Add(this.btnTic7);
            this.panel3.Controls.Add(this.btnTic6);
            this.panel3.Controls.Add(this.btnTic5);
            this.panel3.Controls.Add(this.btnTic4);
            this.panel3.Controls.Add(this.btnTic3);
            this.panel3.Controls.Add(this.btnTic2);
            this.panel3.Controls.Add(this.btnTic1);
            this.panel3.Location = new System.Drawing.Point(23, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 432);
            this.panel3.TabIndex = 1;
            // 
            // btnTic9
            // 
            this.btnTic9.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic9.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic9.Location = new System.Drawing.Point(357, 284);
            this.btnTic9.Name = "btnTic9";
            this.btnTic9.Size = new System.Drawing.Size(176, 139);
            this.btnTic9.TabIndex = 8;
            this.btnTic9.UseVisualStyleBackColor = false;
            this.btnTic9.Click += new System.EventHandler(this.btnTic9_Click);
            // 
            // btnTic8
            // 
            this.btnTic8.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic8.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic8.Location = new System.Drawing.Point(180, 284);
            this.btnTic8.Name = "btnTic8";
            this.btnTic8.Size = new System.Drawing.Size(176, 139);
            this.btnTic8.TabIndex = 7;
            this.btnTic8.UseVisualStyleBackColor = false;
            this.btnTic8.Click += new System.EventHandler(this.btnTic8_Click);
            // 
            // btnTic7
            // 
            this.btnTic7.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic7.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic7.Location = new System.Drawing.Point(3, 284);
            this.btnTic7.Name = "btnTic7";
            this.btnTic7.Size = new System.Drawing.Size(176, 139);
            this.btnTic7.TabIndex = 6;
            this.btnTic7.UseVisualStyleBackColor = false;
            this.btnTic7.Click += new System.EventHandler(this.btnTic7_Click);
            // 
            // btnTic6
            // 
            this.btnTic6.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic6.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic6.Location = new System.Drawing.Point(357, 143);
            this.btnTic6.Name = "btnTic6";
            this.btnTic6.Size = new System.Drawing.Size(176, 139);
            this.btnTic6.TabIndex = 5;
            this.btnTic6.UseVisualStyleBackColor = false;
            this.btnTic6.Click += new System.EventHandler(this.btnTic6_Click);
            // 
            // btnTic5
            // 
            this.btnTic5.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic5.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic5.Location = new System.Drawing.Point(180, 143);
            this.btnTic5.Name = "btnTic5";
            this.btnTic5.Size = new System.Drawing.Size(176, 139);
            this.btnTic5.TabIndex = 4;
            this.btnTic5.UseVisualStyleBackColor = false;
            this.btnTic5.Click += new System.EventHandler(this.btnTic5_Click);
            // 
            // btnTic4
            // 
            this.btnTic4.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic4.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic4.Location = new System.Drawing.Point(3, 143);
            this.btnTic4.Name = "btnTic4";
            this.btnTic4.Size = new System.Drawing.Size(176, 139);
            this.btnTic4.TabIndex = 3;
            this.btnTic4.UseVisualStyleBackColor = false;
            this.btnTic4.Click += new System.EventHandler(this.btnTic4_Click);
            // 
            // btnTic3
            // 
            this.btnTic3.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic3.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic3.Location = new System.Drawing.Point(357, 3);
            this.btnTic3.Name = "btnTic3";
            this.btnTic3.Size = new System.Drawing.Size(176, 139);
            this.btnTic3.TabIndex = 2;
            this.btnTic3.UseVisualStyleBackColor = false;
            this.btnTic3.Click += new System.EventHandler(this.btnTic3_Click);
            // 
            // btnTic2
            // 
            this.btnTic2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic2.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic2.Location = new System.Drawing.Point(180, 3);
            this.btnTic2.Name = "btnTic2";
            this.btnTic2.Size = new System.Drawing.Size(176, 139);
            this.btnTic2.TabIndex = 1;
            this.btnTic2.UseVisualStyleBackColor = false;
            this.btnTic2.Click += new System.EventHandler(this.btnTic2_Click);
            // 
            // btnTic1
            // 
            this.btnTic1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTic1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTic1.Font = new System.Drawing.Font("Abduction2002", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic1.Location = new System.Drawing.Point(3, 3);
            this.btnTic1.Name = "btnTic1";
            this.btnTic1.Size = new System.Drawing.Size(176, 139);
            this.btnTic1.TabIndex = 0;
            this.btnTic1.UseVisualStyleBackColor = false;
            this.btnTic1.Click += new System.EventHandler(this.btnTic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1261, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game v.0.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Napis_Glowny;
        private System.Windows.Forms.Button btnTic1;
        private System.Windows.Forms.Button btnTic9;
        private System.Windows.Forms.Button btnTic8;
        private System.Windows.Forms.Button btnTic7;
        private System.Windows.Forms.Button btnTic6;
        private System.Windows.Forms.Button btnTic5;
        private System.Windows.Forms.Button btnTic4;
        private System.Windows.Forms.Button btnTic3;
        private System.Windows.Forms.Button btnTic2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_New_Game;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Napis_PlayerO;
        private System.Windows.Forms.Label lbl_Napis_PlayerX;
        private System.Windows.Forms.Label lblPlayer0;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_color;
    }
}

