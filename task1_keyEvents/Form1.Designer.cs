namespace task1_keyEvents
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.leftPaddle = new System.Windows.Forms.PictureBox();
            this.rightPaddle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // leftPaddle
            // 
            this.leftPaddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftPaddle.Location = new System.Drawing.Point(12, 156);
            this.leftPaddle.Name = "leftPaddle";
            this.leftPaddle.Size = new System.Drawing.Size(17, 76);
            this.leftPaddle.TabIndex = 0;
            this.leftPaddle.TabStop = false;
            // 
            // rightPaddle
            // 
            this.rightPaddle.BackColor = System.Drawing.Color.Black;
            this.rightPaddle.Location = new System.Drawing.Point(771, 156);
            this.rightPaddle.Name = "rightPaddle";
            this.rightPaddle.Size = new System.Drawing.Size(17, 76);
            this.rightPaddle.TabIndex = 1;
            this.rightPaddle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightPaddle);
            this.Controls.Add(this.leftPaddle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox leftPaddle;
        private System.Windows.Forms.PictureBox rightPaddle;
    }
}

