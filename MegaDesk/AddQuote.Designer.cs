namespace MegaDesk
{
    partial class AddQuote
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
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.depthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfDrawersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.shippingSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.shippingSpeedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surfaceMaterialSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.shippingPriceTextLabel = new System.Windows.Forms.Label();
            this.shippingPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceAmountLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawersNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(136, 294);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(115, 40);
            this.cancelQuoteButton.TabIndex = 8;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.CancelQuoteButton_Click);
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.Location = new System.Drawing.Point(257, 294);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(115, 40);
            this.getQuoteButton.TabIndex = 7;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            this.getQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthNumericUpDown.Location = new System.Drawing.Point(174, 51);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(198, 26);
            this.widthNumericUpDown.TabIndex = 2;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(69, 6);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(303, 26);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // depthNumericUpDown
            // 
            this.depthNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthNumericUpDown.Location = new System.Drawing.Point(174, 83);
            this.depthNumericUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumericUpDown.Name = "depthNumericUpDown";
            this.depthNumericUpDown.Size = new System.Drawing.Size(198, 26);
            this.depthNumericUpDown.TabIndex = 3;
            this.depthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numberOfDrawersNumericUpDown
            // 
            this.numberOfDrawersNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDrawersNumericUpDown.Location = new System.Drawing.Point(174, 115);
            this.numberOfDrawersNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numberOfDrawersNumericUpDown.Name = "numberOfDrawersNumericUpDown";
            this.numberOfDrawersNumericUpDown.Size = new System.Drawing.Size(198, 26);
            this.numberOfDrawersNumericUpDown.TabIndex = 4;
            // 
            // shippingSelectionComboBox
            // 
            this.shippingSelectionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.shippingSelectionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.shippingSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shippingSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingSelectionComboBox.FormattingEnabled = true;
            this.shippingSelectionComboBox.Items.AddRange(new object[] {
            "Rush: 3 days",
            "Rush: 5 days",
            "Rush: 7 days",
            "Standard: 14 days"});
            this.shippingSelectionComboBox.Location = new System.Drawing.Point(174, 181);
            this.shippingSelectionComboBox.Name = "shippingSelectionComboBox";
            this.shippingSelectionComboBox.Size = new System.Drawing.Size(198, 28);
            this.shippingSelectionComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.AutoSize = true;
            this.deskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLabel.Location = new System.Drawing.Point(12, 53);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(110, 20);
            this.deskWidthLabel.TabIndex = 12;
            this.deskWidthLabel.Text = "Width (inches)";
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(12, 117);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(146, 20);
            this.numDrawersLabel.TabIndex = 14;
            this.numDrawersLabel.Text = "Number of Drawers";
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.AutoSize = true;
            this.deskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLabel.Location = new System.Drawing.Point(12, 85);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(113, 20);
            this.deskDepthLabel.TabIndex = 13;
            this.deskDepthLabel.Text = "Depth (inches)";
            // 
            // shippingSpeedLabel
            // 
            this.shippingSpeedLabel.AutoSize = true;
            this.shippingSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingSpeedLabel.Location = new System.Drawing.Point(12, 184);
            this.shippingSpeedLabel.Name = "shippingSpeedLabel";
            this.shippingSpeedLabel.Size = new System.Drawing.Size(122, 20);
            this.shippingSpeedLabel.TabIndex = 18;
            this.shippingSpeedLabel.Text = "Shipping Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Surface Material";
            // 
            // surfaceMaterialSelectionComboBox
            // 
            this.surfaceMaterialSelectionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.surfaceMaterialSelectionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.surfaceMaterialSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialSelectionComboBox.FormattingEnabled = true;
            this.surfaceMaterialSelectionComboBox.Location = new System.Drawing.Point(174, 147);
            this.surfaceMaterialSelectionComboBox.Name = "surfaceMaterialSelectionComboBox";
            this.surfaceMaterialSelectionComboBox.Size = new System.Drawing.Size(198, 28);
            this.surfaceMaterialSelectionComboBox.TabIndex = 5;
            // 
            // shippingPriceTextLabel
            // 
            this.shippingPriceTextLabel.AutoSize = true;
            this.shippingPriceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingPriceTextLabel.Location = new System.Drawing.Point(12, 212);
            this.shippingPriceTextLabel.Name = "shippingPriceTextLabel";
            this.shippingPriceTextLabel.Size = new System.Drawing.Size(110, 20);
            this.shippingPriceTextLabel.TabIndex = 23;
            this.shippingPriceTextLabel.Text = "Shipping Price";
            this.shippingPriceTextLabel.Visible = false;
            // 
            // shippingPriceLabel
            // 
            this.shippingPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shippingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingPriceLabel.Location = new System.Drawing.Point(174, 212);
            this.shippingPriceLabel.Name = "shippingPriceLabel";
            this.shippingPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shippingPriceLabel.Size = new System.Drawing.Size(198, 20);
            this.shippingPriceLabel.TabIndex = 24;
            this.shippingPriceLabel.Text = "$0.00";
            this.shippingPriceLabel.Visible = false;
            // 
            // totalPriceAmountLabel
            // 
            this.totalPriceAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceAmountLabel.Location = new System.Drawing.Point(174, 250);
            this.totalPriceAmountLabel.Name = "totalPriceAmountLabel";
            this.totalPriceAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceAmountLabel.Size = new System.Drawing.Size(198, 26);
            this.totalPriceAmountLabel.TabIndex = 43;
            this.totalPriceAmountLabel.Text = "$200.00";
            this.totalPriceAmountLabel.Visible = false;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(11, 250);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(115, 26);
            this.totalPriceLabel.TabIndex = 42;
            this.totalPriceLabel.Text = "Total Price";
            this.totalPriceLabel.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 346);
            this.Controls.Add(this.totalPriceAmountLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.shippingPriceLabel);
            this.Controls.Add(this.shippingPriceTextLabel);
            this.Controls.Add(this.surfaceMaterialSelectionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shippingSpeedLabel);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shippingSelectionComboBox);
            this.Controls.Add(this.numberOfDrawersNumericUpDown);
            this.Controls.Add(this.depthNumericUpDown);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.cancelQuoteButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 385);
            this.MinimumSize = new System.Drawing.Size(400, 385);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Quote";
            this.Deactivate += new System.EventHandler(this.CancelQuoteButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawersNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.NumericUpDown depthNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberOfDrawersNumericUpDown;
        private System.Windows.Forms.ComboBox shippingSelectionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.Label shippingSpeedLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox surfaceMaterialSelectionComboBox;
        private System.Windows.Forms.Label shippingPriceTextLabel;
        private System.Windows.Forms.Label shippingPriceLabel;
        private System.Windows.Forms.Label totalPriceAmountLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}