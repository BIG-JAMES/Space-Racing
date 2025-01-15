namespace Space_Racing
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
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.player1sp = new System.Windows.Forms.PictureBox();
            this.player2sp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2sp)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // player1sp
            // 
            this.player1sp.Image = ((System.Drawing.Image)(resources.GetObject("player1sp.Image")));
            this.player1sp.Location = new System.Drawing.Point(90, 107);
            this.player1sp.Name = "player1sp";
            this.player1sp.Size = new System.Drawing.Size(70, 70);
            this.player1sp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player1sp.TabIndex = 0;
            this.player1sp.TabStop = false;
            // 
            // player2sp
            // 
            this.player2sp.Image = ((System.Drawing.Image)(resources.GetObject("player2sp.Image")));
            this.player2sp.Location = new System.Drawing.Point(436, 121);
            this.player2sp.Name = "player2sp";
            this.player2sp.Size = new System.Drawing.Size(70, 70);
            this.player2sp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player2sp.TabIndex = 1;
            this.player2sp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.player2sp);
            this.Controls.Add(this.player1sp);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2sp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox player1sp;
        private System.Windows.Forms.PictureBox player2sp;
    }
}

