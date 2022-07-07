namespace Car
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Progress = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.prog = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Progress)).BeginInit();
            this.prog.SuspendLayout();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.Image = ((System.Drawing.Image)(resources.GetObject("Progress.Image")));
            this.Progress.ImageRotate = 0F;
            this.Progress.Location = new System.Drawing.Point(60, 51);
            this.Progress.Name = "Progress";
            this.Progress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Progress.Size = new System.Drawing.Size(144, 112);
            this.Progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Progress.TabIndex = 0;
            this.Progress.TabStop = false;
            this.Progress.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // prog
            // 
            this.prog.Controls.Add(this.Progress);
            this.prog.FillColor = System.Drawing.Color.LightSkyBlue;
            this.prog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prog.ForeColor = System.Drawing.Color.White;
            this.prog.Location = new System.Drawing.Point(219, 61);
            this.prog.Minimum = 0;
            this.prog.Name = "prog";
            this.prog.ProgressColor = System.Drawing.Color.White;
            this.prog.ProgressColor2 = System.Drawing.Color.White;
            this.prog.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prog.Size = new System.Drawing.Size(267, 267);
            this.prog.TabIndex = 1;
            this.prog.Text = "guna2CircleProgressBar1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOWROOM SBY";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(706, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Progress)).EndInit();
            this.prog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Progress;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

