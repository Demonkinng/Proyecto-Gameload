namespace Gameload_2
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.pcbDeveloper = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeveloper)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbDeveloper
            // 
            this.pcbDeveloper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbDeveloper.Image = ((System.Drawing.Image)(resources.GetObject("pcbDeveloper.Image")));
            this.pcbDeveloper.Location = new System.Drawing.Point(164, 213);
            this.pcbDeveloper.Name = "pcbDeveloper";
            this.pcbDeveloper.Size = new System.Drawing.Size(265, 201);
            this.pcbDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDeveloper.TabIndex = 3;
            this.pcbDeveloper.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(5, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(582, 190);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 426);
            this.Controls.Add(this.pcbDeveloper);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInfo";
            this.Text = "FrmInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeveloper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbDeveloper;
        private System.Windows.Forms.Label lblInfo;
    }
}