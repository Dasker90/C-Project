namespace Loop_DASKER
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ForLoop = new System.Windows.Forms.Button();
            this.txt_ForLoop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lst_ForLoop = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_ForLoop);
            this.panel1.Controls.Add(this.txt_ForLoop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(372, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("SF Distant Galaxy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.Location = new System.Drawing.Point(317, 213);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(71, 67);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ForLoop
            // 
            this.btn_ForLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ForLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ForLoop.Font = new System.Drawing.Font("SF Distant Galaxy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ForLoop.Location = new System.Drawing.Point(13, 286);
            this.btn_ForLoop.Name = "btn_ForLoop";
            this.btn_ForLoop.Size = new System.Drawing.Size(375, 120);
            this.btn_ForLoop.TabIndex = 2;
            this.btn_ForLoop.Text = "For Loop";
            this.btn_ForLoop.UseVisualStyleBackColor = true;
            this.btn_ForLoop.Click += new System.EventHandler(this.btn_ForLoop_Click);
            // 
            // txt_ForLoop
            // 
            this.txt_ForLoop.BackColor = System.Drawing.Color.LightCoral;
            this.txt_ForLoop.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ForLoop.Location = new System.Drawing.Point(13, 127);
            this.txt_ForLoop.Name = "txt_ForLoop";
            this.txt_ForLoop.Size = new System.Drawing.Size(375, 71);
            this.txt_ForLoop.TabIndex = 1;
            this.txt_ForLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Commodore 64 Angled", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lst_ForLoop);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 426);
            this.panel2.TabIndex = 1;
            // 
            // lst_ForLoop
            // 
            this.lst_ForLoop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lst_ForLoop.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_ForLoop.FormattingEnabled = true;
            this.lst_ForLoop.ItemHeight = 24;
            this.lst_ForLoop.Location = new System.Drawing.Point(3, 7);
            this.lst_ForLoop.Name = "lst_ForLoop";
            this.lst_ForLoop.Size = new System.Drawing.Size(329, 388);
            this.lst_ForLoop.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("SF Distant Galaxy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(240, 213);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(71, 67);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Loop Dasker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ListBox lst_ForLoop;
        private Button btn_ForLoop;
        private TextBox txt_ForLoop;
        private Button btn_Clear;
        private Button btn_exit;
    }
}