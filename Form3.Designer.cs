namespace Build2
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FormTimer = new System.Windows.Forms.Timer(this.components);
            this.greenBin = new System.Windows.Forms.PictureBox();
            this.yellowBin = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlCongrats = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pnlTryAgain = new System.Windows.Forms.Panel();
            this.btnBackGame = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.btnHelpExit = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textbox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.greenBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBin)).BeginInit();
            this.pnlCongrats.SuspendLayout();
            this.pnlTryAgain.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Pink;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(680, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "statement 1/6";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTimer
            // 
            this.FormTimer.Enabled = true;
            this.FormTimer.Interval = 20;
            this.FormTimer.Tick += new System.EventHandler(this.FormTimerEvent);
            // 
            // greenBin
            // 
            this.greenBin.BackColor = System.Drawing.Color.Transparent;
            this.greenBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenBin.BackgroundImage")));
            this.greenBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenBin.Location = new System.Drawing.Point(261, 114);
            this.greenBin.Name = "greenBin";
            this.greenBin.Size = new System.Drawing.Size(192, 108);
            this.greenBin.TabIndex = 2;
            this.greenBin.TabStop = false;
            this.greenBin.Visible = false;
            this.greenBin.DragOver += new System.Windows.Forms.DragEventHandler(this.FormDragOver);
            // 
            // yellowBin
            // 
            this.yellowBin.BackColor = System.Drawing.Color.Transparent;
            this.yellowBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowBin.BackgroundImage")));
            this.yellowBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowBin.Location = new System.Drawing.Point(432, 124);
            this.yellowBin.Name = "yellowBin";
            this.yellowBin.Size = new System.Drawing.Size(169, 106);
            this.yellowBin.TabIndex = 3;
            this.yellowBin.TabStop = false;
            this.yellowBin.Visible = false;
            this.yellowBin.DragOver += new System.Windows.Forms.DragEventHandler(this.FormDragOver);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Khaki;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(743, 401);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 37);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlCongrats
            // 
            this.pnlCongrats.BackColor = System.Drawing.Color.MistyRose;
            this.pnlCongrats.Controls.Add(this.btnHome);
            this.pnlCongrats.Controls.Add(this.textBox1);
            this.pnlCongrats.Controls.Add(this.textBox6);
            this.pnlCongrats.Location = new System.Drawing.Point(119, 51);
            this.pnlCongrats.Name = "pnlCongrats";
            this.pnlCongrats.Size = new System.Drawing.Size(594, 336);
            this.pnlCongrats.TabIndex = 15;
            this.pnlCongrats.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Pink;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(209, 210);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 35);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "BACK TO GAMES";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(116, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "The Floor is Looking Clean!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.MistyRose;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(105, 102);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(385, 47);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "CONGRATULATIONS!";
            // 
            // pnlTryAgain
            // 
            this.pnlTryAgain.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTryAgain.Controls.Add(this.btnBackGame);
            this.pnlTryAgain.Controls.Add(this.textBox2);
            this.pnlTryAgain.Controls.Add(this.textBox3);
            this.pnlTryAgain.Location = new System.Drawing.Point(122, 48);
            this.pnlTryAgain.Name = "pnlTryAgain";
            this.pnlTryAgain.Size = new System.Drawing.Size(594, 336);
            this.pnlTryAgain.TabIndex = 18;
            this.pnlTryAgain.Visible = false;
            // 
            // btnBackGame
            // 
            this.btnBackGame.BackColor = System.Drawing.Color.Pink;
            this.btnBackGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackGame.Location = new System.Drawing.Point(205, 203);
            this.btnBackGame.Name = "btnBackGame";
            this.btnBackGame.Size = new System.Drawing.Size(175, 35);
            this.btnBackGame.TabIndex = 17;
            this.btnBackGame.Text = "BACK TO GAMES";
            this.btnBackGame.UseVisualStyleBackColor = false;
            this.btnBackGame.Click += new System.EventHandler(this.btnBackGame_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MistyRose;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(88, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 19);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Uh Oh! Something\'s Gone in the Wrong Bin!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MistyRose;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(194, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 47);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "BAD LUCK!";
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlHelp.Controls.Add(this.btnHelpExit);
            this.pnlHelp.Controls.Add(this.textBox9);
            this.pnlHelp.Controls.Add(this.textbox8);
            this.pnlHelp.Location = new System.Drawing.Point(90, 48);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(681, 347);
            this.pnlHelp.TabIndex = 19;
            this.pnlHelp.Visible = false;
            // 
            // btnHelpExit
            // 
            this.btnHelpExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnHelpExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpExit.ForeColor = System.Drawing.Color.White;
            this.btnHelpExit.Location = new System.Drawing.Point(615, 11);
            this.btnHelpExit.Name = "btnHelpExit";
            this.btnHelpExit.Size = new System.Drawing.Size(41, 29);
            this.btnHelpExit.TabIndex = 2;
            this.btnHelpExit.Text = "x";
            this.btnHelpExit.UseVisualStyleBackColor = false;
            this.btnHelpExit.Click += new System.EventHandler(this.btnHelpExit_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(29, 117);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(627, 160);
            this.textBox9.TabIndex = 1;
            this.textBox9.Text = resources.GetString("textBox9.Text");
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox8
            // 
            this.textbox8.BackColor = System.Drawing.Color.Cornsilk;
            this.textbox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14F, System.Drawing.FontStyle.Bold);
            this.textbox8.ForeColor = System.Drawing.Color.Black;
            this.textbox8.Location = new System.Drawing.Point(298, 34);
            this.textbox8.Name = "textbox8";
            this.textbox8.Size = new System.Drawing.Size(104, 33);
            this.textbox8.TabIndex = 0;
            this.textbox8.Text = "HELP:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHelp);
            this.Controls.Add(this.pnlCongrats);
            this.Controls.Add(this.pnlTryAgain);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.yellowBin);
            this.Controls.Add(this.greenBin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.greenBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBin)).EndInit();
            this.pnlCongrats.ResumeLayout(false);
            this.pnlCongrats.PerformLayout();
            this.pnlTryAgain.ResumeLayout(false);
            this.pnlTryAgain.PerformLayout();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer FormTimer;
        private System.Windows.Forms.PictureBox greenBin;
        private System.Windows.Forms.PictureBox yellowBin;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlCongrats;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTryAgain;
        private System.Windows.Forms.Button btnBackGame;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Button btnHelpExit;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textbox8;
    }
}