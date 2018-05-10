namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.exitViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitViewAllQuotesButton
            // 
            this.exitViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitViewAllQuotesButton.Location = new System.Drawing.Point(12, 184);
            this.exitViewAllQuotesButton.Name = "exitViewAllQuotesButton";
            this.exitViewAllQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.exitViewAllQuotesButton.TabIndex = 4;
            this.exitViewAllQuotesButton.Text = "Back";
            this.exitViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.exitViewAllQuotesButton.Click += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.exitViewAllQuotesButton);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Deactivate += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitViewAllQuotesButton;
    }
}