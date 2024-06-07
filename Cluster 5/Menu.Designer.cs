namespace Cluster_5
{
    partial class Menu
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
            this.Playbtn = new System.Windows.Forms.Button();
            this.HScorebtn = new System.Windows.Forms.Button();
            this.DHScorebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playbtn
            // 
            this.Playbtn.Location = new System.Drawing.Point(61, 202);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(689, 54);
            this.Playbtn.TabIndex = 0;
            this.Playbtn.Text = "Play Game";
            this.Playbtn.UseVisualStyleBackColor = true;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // HScorebtn
            // 
            this.HScorebtn.Location = new System.Drawing.Point(61, 262);
            this.HScorebtn.Name = "HScorebtn";
            this.HScorebtn.Size = new System.Drawing.Size(689, 49);
            this.HScorebtn.TabIndex = 1;
            this.HScorebtn.Text = "All Time High Score";
            this.HScorebtn.UseVisualStyleBackColor = true;
            // 
            // DHScorebtn
            // 
            this.DHScorebtn.Location = new System.Drawing.Point(61, 317);
            this.DHScorebtn.Name = "DHScorebtn";
            this.DHScorebtn.Size = new System.Drawing.Size(689, 53);
            this.DHScorebtn.TabIndex = 2;
            this.DHScorebtn.Text = "Daily High Scores";
            this.DHScorebtn.UseVisualStyleBackColor = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(61, 376);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(689, 62);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.DHScorebtn);
            this.Controls.Add(this.HScorebtn);
            this.Controls.Add(this.Playbtn);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button HScorebtn;
        private System.Windows.Forms.Button DHScorebtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

