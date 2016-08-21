namespace movieBonanza_a7
{
    partial class StreamForm
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
            this.userMovieSelectionLabel = new System.Windows.Forms.Label();
            this.balanceDueLabel = new System.Windows.Forms.Label();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userMovieSelectionLabel
            // 
            this.userMovieSelectionLabel.AutoSize = true;
            this.userMovieSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMovieSelectionLabel.Location = new System.Drawing.Point(83, 77);
            this.userMovieSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userMovieSelectionLabel.Name = "userMovieSelectionLabel";
            this.userMovieSelectionLabel.Size = new System.Drawing.Size(287, 20);
            this.userMovieSelectionLabel.TabIndex = 13;
            this.userMovieSelectionLabel.Text = "[Your Movie] will begin streaming shortly";
            // 
            // balanceDueLabel
            // 
            this.balanceDueLabel.AutoSize = true;
            this.balanceDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceDueLabel.Location = new System.Drawing.Point(75, 42);
            this.balanceDueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balanceDueLabel.Name = "balanceDueLabel";
            this.balanceDueLabel.Size = new System.Drawing.Size(305, 20);
            this.balanceDueLabel.TabIndex = 12;
            this.balanceDueLabel.Text = "Your Credit card will be charged [X dollars]";
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(45, 9);
            this.ThankYouLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(348, 24);
            this.ThankYouLabel.TabIndex = 11;
            this.ThankYouLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(196, 129);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(44, 30);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 188);
            this.Controls.Add(this.userMovieSelectionLabel);
            this.Controls.Add(this.balanceDueLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "StreamForm";
            this.Text = "StreamForm";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userMovieSelectionLabel;
        private System.Windows.Forms.Label balanceDueLabel;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Button OkButton;
    }
}