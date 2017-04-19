namespace Bubbles
{
    partial class Bubbles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bubbles));
            this.tipTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tipTextbox
            // 
            this.tipTextbox.BackColor = System.Drawing.SystemColors.Desktop;
            this.tipTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tipTextbox.Enabled = false;
            this.tipTextbox.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipTextbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tipTextbox.Location = new System.Drawing.Point(12, 12);
            this.tipTextbox.Multiline = true;
            this.tipTextbox.Name = "tipTextbox";
            this.tipTextbox.ReadOnly = true;
            this.tipTextbox.Size = new System.Drawing.Size(477, 91);
            this.tipTextbox.TabIndex = 0;
            // 
            // Bubbles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(498, 115);
            this.ControlBox = false;
            this.Controls.Add(this.tipTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bubbles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bubbles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bubbles_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tipTextbox;
    }
}