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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitViewAllQuotesButton
            // 
            this.exitViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitViewAllQuotesButton.Location = new System.Drawing.Point(395, 362);
            this.exitViewAllQuotesButton.Name = "exitViewAllQuotesButton";
            this.exitViewAllQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.exitViewAllQuotesButton.TabIndex = 4;
            this.exitViewAllQuotesButton.Text = "Back";
            this.exitViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.exitViewAllQuotesButton.Click += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitViewAllQuotesButton);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Deactivate += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitViewAllQuotesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}