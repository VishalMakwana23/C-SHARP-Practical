
namespace assignment1
{
    partial class keyvowels
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
            this.lblq12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblq12
            // 
            this.lblq12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblq12.AutoSize = true;
            this.lblq12.Location = new System.Drawing.Point(298, 217);
            this.lblq12.Margin = new System.Windows.Forms.Padding(0);
            this.lblq12.Name = "lblq12";
            this.lblq12.Size = new System.Drawing.Size(133, 17);
            this.lblq12.TabIndex = 6;
            this.lblq12.Text = "Enter any character";
            this.lblq12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyvowels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.lblq12);
            this.Name = "keyvowels";
            this.Text = "keyvowels";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyvowels_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblq12;
    }
}