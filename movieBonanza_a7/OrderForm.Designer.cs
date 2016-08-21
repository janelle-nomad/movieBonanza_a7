namespace movieBonanza_a7
{
    partial class OrderForm
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
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.orderCheckBox = new System.Windows.Forms.CheckBox();
            this.dvdcostTextBox = new System.Windows.Forms.TextBox();
            this.DVDCostLabel = new System.Windows.Forms.Label();
            this.grandtotalTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.salestaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MovieSelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.YourOrderGroupBox.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieSelectedPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.orderCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.dvdcostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.DVDCostLabel);
            this.YourOrderGroupBox.Controls.Add(this.grandtotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.salestaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.subtotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.costTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(193, 26);
            this.YourOrderGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.YourOrderGroupBox.Size = new System.Drawing.Size(279, 298);
            this.YourOrderGroupBox.TabIndex = 13;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // orderCheckBox
            // 
            this.orderCheckBox.AutoSize = true;
            this.orderCheckBox.Location = new System.Drawing.Point(8, 275);
            this.orderCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderCheckBox.Name = "orderCheckBox";
            this.orderCheckBox.Size = new System.Drawing.Size(226, 17);
            this.orderCheckBox.TabIndex = 18;
            this.orderCheckBox.Text = "Order the DVD (adds $10.00 to your order)";
            this.orderCheckBox.UseVisualStyleBackColor = true;
            // 
            // dvdcostTextBox
            // 
            this.dvdcostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dvdcostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdcostTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dvdcostTextBox.Location = new System.Drawing.Point(140, 76);
            this.dvdcostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dvdcostTextBox.Name = "dvdcostTextBox";
            this.dvdcostTextBox.ReadOnly = true;
            this.dvdcostTextBox.Size = new System.Drawing.Size(88, 26);
            this.dvdcostTextBox.TabIndex = 17;
            this.dvdcostTextBox.Text = "$10.00";
            this.dvdcostTextBox.Visible = false;
            // 
            // DVDCostLabel
            // 
            this.DVDCostLabel.AutoSize = true;
            this.DVDCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVDCostLabel.Location = new System.Drawing.Point(60, 78);
            this.DVDCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DVDCostLabel.Name = "DVDCostLabel";
            this.DVDCostLabel.Size = new System.Drawing.Size(81, 20);
            this.DVDCostLabel.TabIndex = 16;
            this.DVDCostLabel.Text = "DVD Cost";
            this.DVDCostLabel.Visible = false;
            // 
            // grandtotalTextBox
            // 
            this.grandtotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.grandtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grandtotalTextBox.Location = new System.Drawing.Point(140, 228);
            this.grandtotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.grandtotalTextBox.Name = "grandtotalTextBox";
            this.grandtotalTextBox.ReadOnly = true;
            this.grandtotalTextBox.Size = new System.Drawing.Size(88, 26);
            this.grandtotalTextBox.TabIndex = 15;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(43, 230);
            this.GrandTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(93, 20);
            this.GrandTotalLabel.TabIndex = 14;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // salestaxTextBox
            // 
            this.salestaxTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.salestaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salestaxTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salestaxTextBox.Location = new System.Drawing.Point(140, 178);
            this.salestaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.salestaxTextBox.Name = "salestaxTextBox";
            this.salestaxTextBox.ReadOnly = true;
            this.salestaxTextBox.Size = new System.Drawing.Size(88, 26);
            this.salestaxTextBox.TabIndex = 13;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(16, 180);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(124, 20);
            this.SalesTaxLabel.TabIndex = 12;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.subtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.subtotalTextBox.Location = new System.Drawing.Point(140, 128);
            this.subtotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(88, 26);
            this.subtotalTextBox.TabIndex = 11;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(60, 131);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(73, 20);
            this.SubTotalLabel.TabIndex = 10;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // costTextBox
            // 
            this.costTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.costTextBox.Location = new System.Drawing.Point(140, 26);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(88, 26);
            this.costTextBox.TabIndex = 9;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(95, 28);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 8;
            this.CostLabel.Text = "Cost";
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.categoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.titleTextbox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieSelectedPictureBox);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(3, 26);
            this.MovieSelectedGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(186, 351);
            this.MovieSelectedGroupBox.TabIndex = 12;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "MovieSelected";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.categoryTextBox.Location = new System.Drawing.Point(8, 87);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(158, 26);
            this.categoryTextBox.TabIndex = 7;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(4, 64);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(73, 20);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category";
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titleTextbox.Location = new System.Drawing.Point(8, 37);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.ReadOnly = true;
            this.titleTextbox.Size = new System.Drawing.Size(158, 26);
            this.titleTextbox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(4, 15);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // MovieSelectedPictureBox
            // 
            this.MovieSelectedPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.MovieSelectedPictureBox.Location = new System.Drawing.Point(5, 116);
            this.MovieSelectedPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieSelectedPictureBox.Name = "MovieSelectedPictureBox";
            this.MovieSelectedPictureBox.Size = new System.Drawing.Size(161, 230);
            this.MovieSelectedPictureBox.TabIndex = 0;
            this.MovieSelectedPictureBox.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(8, 410);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(86, 30);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // streamButton
            // 
            this.streamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamButton.Location = new System.Drawing.Point(193, 342);
            this.streamButton.Margin = new System.Windows.Forms.Padding(2);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(279, 30);
            this.streamButton.TabIndex = 10;
            this.streamButton.Text = "Stream";
            this.streamButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(386, 410);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 30);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 462);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieSelectedPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.CheckBox orderCheckBox;
        private System.Windows.Forms.TextBox dvdcostTextBox;
        private System.Windows.Forms.Label DVDCostLabel;
        private System.Windows.Forms.TextBox grandtotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox salestaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox MovieSelectedPictureBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button streamButton;
        private System.Windows.Forms.Button CancelButton;
    }
}