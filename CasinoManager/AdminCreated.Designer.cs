namespace CasinoManager
{
    partial class AdminCreated
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCasino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(134, 26);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(212, 13);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "If you\'re seeing this, something went wrong.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(106, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your Full Name";
            // 
            // lblCasino
            // 
            this.lblCasino.AutoSize = true;
            this.lblCasino.Location = new System.Drawing.Point(294, 85);
            this.lblCasino.Name = "lblCasino";
            this.lblCasino.Size = new System.Drawing.Size(100, 13);
            this.lblCasino.TabIndex = 2;
            this.lblCasino.Text = "Name of the Casino";
            // 
            // AdminCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 222);
            this.Controls.Add(this.lblCasino);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGreeting);
            this.Name = "AdminCreated";
            this.Text = "Admin Account Created";
            this.Load += new System.EventHandler(this.AdminCreated_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCasino;
    }
}