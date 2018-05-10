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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitSearchQuotesButton
            // 
            this.exitSearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSearchQuotesButton.Location = new System.Drawing.Point(408, 358);
            this.exitSearchQuotesButton.Name = "exitSearchQuotesButton";
            this.exitSearchQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.exitSearchQuotesButton.TabIndex = 4;
            this.exitSearchQuotesButton.Text = "Back";
            this.exitSearchQuotesButton.UseVisualStyleBackColor = true;
            this.exitSearchQuotesButton.Click += new System.EventHandler(this.exitSearchQuotesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitSearchQuotesButton);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.Deactivate += new System.EventHandler(this.exitSearchQuotesButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitSearchQuotesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}