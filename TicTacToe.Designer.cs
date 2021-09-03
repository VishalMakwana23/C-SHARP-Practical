
namespace assignment1
{
    partial class TicTacToe
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
            this.playbox = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playbox
            // 
            this.playbox.BackColor = System.Drawing.Color.White;
            this.playbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playbox.Location = new System.Drawing.Point(0, 48);
            this.playbox.Name = "playbox";
            this.playbox.Size = new System.Drawing.Size(668, 522);
            this.playbox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "make it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(163, 14);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(46, 22);
            this.txtsize.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "enter size of game box";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 570);
            this.Controls.Add(this.playbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.label1);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Label label1;
    }
}