namespace PA_4_GUI
{
    partial class uxProcessReturn
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
            this.return_Title = new System.Windows.Forms.Label();
            this.trans_ItemEntryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.return_ReceiptVal = new System.Windows.Forms.NumericUpDown();
            this.return_IDNumVal = new System.Windows.Forms.NumericUpDown();
            this.return_ItemAmount = new System.Windows.Forms.NumericUpDown();
            this.rebate_ItemQuantity = new System.Windows.Forms.Label();
            this.return_ProcessReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.return_ReceiptVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_IDNumVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_ItemAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // return_Title
            // 
            this.return_Title.AutoSize = true;
            this.return_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_Title.Location = new System.Drawing.Point(12, 9);
            this.return_Title.Name = "return_Title";
            this.return_Title.Size = new System.Drawing.Size(105, 21);
            this.return_Title.TabIndex = 2;
            this.return_Title.Text = "Return Item";
            // 
            // trans_ItemEntryLabel
            // 
            this.trans_ItemEntryLabel.AutoSize = true;
            this.trans_ItemEntryLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_ItemEntryLabel.Location = new System.Drawing.Point(13, 96);
            this.trans_ItemEntryLabel.Name = "trans_ItemEntryLabel";
            this.trans_ItemEntryLabel.Size = new System.Drawing.Size(135, 15);
            this.trans_ItemEntryLabel.TabIndex = 5;
            this.trans_ItemEntryLabel.Text = "Enter a Receipt Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter an Item ID Number";
            // 
            // return_ReceiptVal
            // 
            this.return_ReceiptVal.Location = new System.Drawing.Point(165, 96);
            this.return_ReceiptVal.Name = "return_ReceiptVal";
            this.return_ReceiptVal.Size = new System.Drawing.Size(165, 20);
            this.return_ReceiptVal.TabIndex = 7;
            // 
            // return_IDNumVal
            // 
            this.return_IDNumVal.Location = new System.Drawing.Point(165, 45);
            this.return_IDNumVal.Name = "return_IDNumVal";
            this.return_IDNumVal.Size = new System.Drawing.Size(165, 20);
            this.return_IDNumVal.TabIndex = 8;
            // 
            // return_ItemAmount
            // 
            this.return_ItemAmount.Location = new System.Drawing.Point(165, 70);
            this.return_ItemAmount.Name = "return_ItemAmount";
            this.return_ItemAmount.Size = new System.Drawing.Size(165, 20);
            this.return_ItemAmount.TabIndex = 11;
            // 
            // rebate_ItemQuantity
            // 
            this.rebate_ItemQuantity.AutoSize = true;
            this.rebate_ItemQuantity.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebate_ItemQuantity.Location = new System.Drawing.Point(13, 70);
            this.rebate_ItemQuantity.Name = "rebate_ItemQuantity";
            this.rebate_ItemQuantity.Size = new System.Drawing.Size(139, 15);
            this.rebate_ItemQuantity.TabIndex = 10;
            this.rebate_ItemQuantity.Text = "Enter a Product Amount";
            // 
            // return_ProcessReturn
            // 
            this.return_ProcessReturn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_ProcessReturn.Location = new System.Drawing.Point(16, 122);
            this.return_ProcessReturn.Name = "return_ProcessReturn";
            this.return_ProcessReturn.Size = new System.Drawing.Size(316, 46);
            this.return_ProcessReturn.TabIndex = 12;
            this.return_ProcessReturn.Text = "Process Return";
            this.return_ProcessReturn.UseVisualStyleBackColor = true;
            this.return_ProcessReturn.Click += new System.EventHandler(this.return_ProcessReturn_Click);
            // 
            // uxProcessReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.return_ProcessReturn);
            this.Controls.Add(this.return_ItemAmount);
            this.Controls.Add(this.rebate_ItemQuantity);
            this.Controls.Add(this.return_IDNumVal);
            this.Controls.Add(this.return_ReceiptVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trans_ItemEntryLabel);
            this.Controls.Add(this.return_Title);
            this.Name = "uxProcessReturn";
            this.Text = "Return Item";
            ((System.ComponentModel.ISupportInitialize)(this.return_ReceiptVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_IDNumVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_ItemAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label return_Title;
        private System.Windows.Forms.Label trans_ItemEntryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown return_ReceiptVal;
        private System.Windows.Forms.NumericUpDown return_IDNumVal;
        private System.Windows.Forms.NumericUpDown return_ItemAmount;
        private System.Windows.Forms.Label rebate_ItemQuantity;
        private System.Windows.Forms.Button return_ProcessReturn;
    }
}