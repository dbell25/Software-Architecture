namespace PA_4_GUI
{
    partial class uxCreateRebate
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
            this.rebate_Title = new System.Windows.Forms.Label();
            this.rebate_EnterReceiptLabel = new System.Windows.Forms.Label();
            this.rebate_ReceiptVal = new System.Windows.Forms.NumericUpDown();
            this.rebate_GenerateRebate = new System.Windows.Forms.Button();
            this.rebate_DateVal = new System.Windows.Forms.DateTimePicker();
            this.rebate_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rebate_ReceiptVal)).BeginInit();
            this.SuspendLayout();
            // 
            // rebate_Title
            // 
            this.rebate_Title.AutoSize = true;
            this.rebate_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebate_Title.Location = new System.Drawing.Point(12, 9);
            this.rebate_Title.Name = "rebate_Title";
            this.rebate_Title.Size = new System.Drawing.Size(134, 21);
            this.rebate_Title.TabIndex = 2;
            this.rebate_Title.Text = "Create A Rebate";
            // 
            // rebate_EnterReceiptLabel
            // 
            this.rebate_EnterReceiptLabel.AutoSize = true;
            this.rebate_EnterReceiptLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebate_EnterReceiptLabel.Location = new System.Drawing.Point(13, 39);
            this.rebate_EnterReceiptLabel.Name = "rebate_EnterReceiptLabel";
            this.rebate_EnterReceiptLabel.Size = new System.Drawing.Size(99, 15);
            this.rebate_EnterReceiptLabel.TabIndex = 4;
            this.rebate_EnterReceiptLabel.Text = "Enter a Receipt #";
            // 
            // rebate_ReceiptVal
            // 
            this.rebate_ReceiptVal.Location = new System.Drawing.Point(119, 38);
            this.rebate_ReceiptVal.Name = "rebate_ReceiptVal";
            this.rebate_ReceiptVal.Size = new System.Drawing.Size(155, 20);
            this.rebate_ReceiptVal.TabIndex = 5;
            // 
            // rebate_GenerateRebate
            // 
            this.rebate_GenerateRebate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebate_GenerateRebate.Location = new System.Drawing.Point(287, 38);
            this.rebate_GenerateRebate.Name = "rebate_GenerateRebate";
            this.rebate_GenerateRebate.Size = new System.Drawing.Size(155, 50);
            this.rebate_GenerateRebate.TabIndex = 8;
            this.rebate_GenerateRebate.Text = "Generate Rebate";
            this.rebate_GenerateRebate.UseVisualStyleBackColor = true;
            this.rebate_GenerateRebate.Click += new System.EventHandler(this.rebate_GenerateRebate_Click);
            // 
            // rebate_DateVal
            // 
            this.rebate_DateVal.Location = new System.Drawing.Point(93, 68);
            this.rebate_DateVal.Name = "rebate_DateVal";
            this.rebate_DateVal.Size = new System.Drawing.Size(181, 20);
            this.rebate_DateVal.TabIndex = 11;
            // 
            // rebate_DateLabel
            // 
            this.rebate_DateLabel.AutoSize = true;
            this.rebate_DateLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebate_DateLabel.Location = new System.Drawing.Point(13, 68);
            this.rebate_DateLabel.Name = "rebate_DateLabel";
            this.rebate_DateLabel.Size = new System.Drawing.Size(75, 15);
            this.rebate_DateLabel.TabIndex = 12;
            this.rebate_DateLabel.Text = "Enter a Date";
            // 
            // uxCreateRebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 106);
            this.Controls.Add(this.rebate_DateLabel);
            this.Controls.Add(this.rebate_DateVal);
            this.Controls.Add(this.rebate_GenerateRebate);
            this.Controls.Add(this.rebate_ReceiptVal);
            this.Controls.Add(this.rebate_EnterReceiptLabel);
            this.Controls.Add(this.rebate_Title);
            this.Name = "uxCreateRebate";
            this.Text = "Create Rebate";
            ((System.ComponentModel.ISupportInitialize)(this.rebate_ReceiptVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rebate_Title;
        private System.Windows.Forms.Label rebate_EnterReceiptLabel;
        private System.Windows.Forms.NumericUpDown rebate_ReceiptVal;
        private System.Windows.Forms.Button rebate_GenerateRebate;
        private System.Windows.Forms.DateTimePicker rebate_DateVal;
        private System.Windows.Forms.Label rebate_DateLabel;
    }
}