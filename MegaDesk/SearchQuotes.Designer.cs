namespace MegaDesk
{
    partial class SearchQuotes
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
            this.exitSearchQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitSearchQuotesButton
            // 
            this.exitSearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSearchQuotesButton.Location = new System.Drawing.Point(12, 184);
            this.exitSearchQuotesButton.Name = "exitSearchQuotesButton";
            this.exitSearchQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.exitSearchQuotesButton.TabIndex = 4;
            this.exitSearchQuotesButton.Text = "Back";
            this.exitSearchQuotesButton.UseVisualStyleBackColor = true;
            this.exitSearchQuotesButton.Click += new System.EventHandler(this.exitSearchQuotesButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.exitSearchQuotesButton);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.Deactivate += new System.EventHandler(this.exitSearchQuotesButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitSearchQuotesButton;
    }
}