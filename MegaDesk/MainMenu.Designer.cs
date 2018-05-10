namespace MegaDesk
{
    partial class MainMenu
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
            this.openAddQuoteButton = new System.Windows.Forms.Button();
            this.openViewQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openSearchQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openAddQuoteButton
            // 
            this.openAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddQuoteButton.Location = new System.Drawing.Point(12, 12);
            this.openAddQuoteButton.Name = "openAddQuoteButton";
            this.openAddQuoteButton.Size = new System.Drawing.Size(150, 40);
            this.openAddQuoteButton.TabIndex = 0;
            this.openAddQuoteButton.Text = "Add New Quote";
            this.openAddQuoteButton.UseVisualStyleBackColor = true;
            this.openAddQuoteButton.Click += new System.EventHandler(this.openAddQuoteButton_Click);
            // 
            // openViewQuotesButton
            // 
            this.openViewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openViewQuotesButton.Location = new System.Drawing.Point(12, 58);
            this.openViewQuotesButton.Name = "openViewQuotesButton";
            this.openViewQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.openViewQuotesButton.TabIndex = 1;
            this.openViewQuotesButton.Text = "View Quotes";
            this.openViewQuotesButton.UseVisualStyleBackColor = true;
            this.openViewQuotesButton.Click += new System.EventHandler(this.openViewQuotesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openSearchQuotesButton
            // 
            this.openSearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSearchQuotesButton.Location = new System.Drawing.Point(12, 104);
            this.openSearchQuotesButton.Name = "openSearchQuotesButton";
            this.openSearchQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.openSearchQuotesButton.TabIndex = 2;
            this.openSearchQuotesButton.Text = "Search Quotes";
            this.openSearchQuotesButton.UseVisualStyleBackColor = true;
            this.openSearchQuotesButton.Click += new System.EventHandler(this.openSearchQuotesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openSearchQuotesButton);
            this.Controls.Add(this.openViewQuotesButton);
            this.Controls.Add(this.openAddQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAddQuoteButton;
        private System.Windows.Forms.Button openViewQuotesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openSearchQuotesButton;
    }
}

