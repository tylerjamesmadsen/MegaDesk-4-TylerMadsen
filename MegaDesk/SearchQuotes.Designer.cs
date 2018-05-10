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
            this.surfaceMaterialSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 312);
            this.dataGridView1.TabIndex = 6;
            // 
            // surfaceMaterialSelectionComboBox
            // 
            this.surfaceMaterialSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialSelectionComboBox.FormattingEnabled = true;
            this.surfaceMaterialSelectionComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterialSelectionComboBox.Location = new System.Drawing.Point(174, 6);
            this.surfaceMaterialSelectionComboBox.Name = "surfaceMaterialSelectionComboBox";
            this.surfaceMaterialSelectionComboBox.Size = new System.Drawing.Size(113, 28);
            this.surfaceMaterialSelectionComboBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Surface Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 410);
            this.Controls.Add(this.surfaceMaterialSelectionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitSearchQuotesButton);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.Deactivate += new System.EventHandler(this.exitSearchQuotesButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitSearchQuotesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox surfaceMaterialSelectionComboBox;
        private System.Windows.Forms.Label label3;
    }
}