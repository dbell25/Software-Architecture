namespace PA_4_GUI
{
    partial class uxCreateTransaction
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
            this.trans_Title = new System.Windows.Forms.Label();
            this.trans_ItemNumVal = new System.Windows.Forms.NumericUpDown();
            this.trans_ItemEntryLabel = new System.Windows.Forms.Label();
            this.trans_QuantityLabel = new System.Windows.Forms.Label();
            this.trans_ItemQuantityVal = new System.Windows.Forms.NumericUpDown();
            this.trans_CreateTransaction = new System.Windows.Forms.Button();
            this.trans_FinishTransaction = new System.Windows.Forms.Button();
            this.trans_DisplayItems = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trans_ItemNumVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trans_ItemQuantityVal)).BeginInit();
            this.SuspendLayout();
            // 
            // trans_Title
            // 
            this.trans_Title.AutoSize = true;
            this.trans_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_Title.Location = new System.Drawing.Point(12, 9);
            this.trans_Title.Name = "trans_Title";
            this.trans_Title.Size = new System.Drawing.Size(144, 21);
            this.trans_Title.TabIndex = 1;
            this.trans_Title.Text = "Make a Purchase";
            // 
            // trans_ItemNumVal
            // 
            this.trans_ItemNumVal.Location = new System.Drawing.Point(12, 77);
            this.trans_ItemNumVal.Name = "trans_ItemNumVal";
            this.trans_ItemNumVal.Size = new System.Drawing.Size(214, 20);
            this.trans_ItemNumVal.TabIndex = 2;
            // 
            // trans_ItemEntryLabel
            // 
            this.trans_ItemEntryLabel.AutoSize = true;
            this.trans_ItemEntryLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_ItemEntryLabel.Location = new System.Drawing.Point(9, 59);
            this.trans_ItemEntryLabel.Name = "trans_ItemEntryLabel";
            this.trans_ItemEntryLabel.Size = new System.Drawing.Size(128, 15);
            this.trans_ItemEntryLabel.TabIndex = 3;
            this.trans_ItemEntryLabel.Text = "Enter an Item Number";
            // 
            // trans_QuantityLabel
            // 
            this.trans_QuantityLabel.AutoSize = true;
            this.trans_QuantityLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_QuantityLabel.Location = new System.Drawing.Point(12, 100);
            this.trans_QuantityLabel.Name = "trans_QuantityLabel";
            this.trans_QuantityLabel.Size = new System.Drawing.Size(132, 15);
            this.trans_QuantityLabel.TabIndex = 4;
            this.trans_QuantityLabel.Text = "Enter an Item Quantity";
            // 
            // trans_ItemQuantityVal
            // 
            this.trans_ItemQuantityVal.Location = new System.Drawing.Point(12, 118);
            this.trans_ItemQuantityVal.Name = "trans_ItemQuantityVal";
            this.trans_ItemQuantityVal.Size = new System.Drawing.Size(214, 20);
            this.trans_ItemQuantityVal.TabIndex = 5;
            // 
            // trans_CreateTransaction
            // 
            this.trans_CreateTransaction.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_CreateTransaction.Location = new System.Drawing.Point(12, 150);
            this.trans_CreateTransaction.Name = "trans_CreateTransaction";
            this.trans_CreateTransaction.Size = new System.Drawing.Size(214, 39);
            this.trans_CreateTransaction.TabIndex = 6;
            this.trans_CreateTransaction.Text = "Add To Cart";
            this.trans_CreateTransaction.UseVisualStyleBackColor = true;
            this.trans_CreateTransaction.Click += new System.EventHandler(this.trans_CreateTransaction_Click);
            // 
            // trans_FinishTransaction
            // 
            this.trans_FinishTransaction.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_FinishTransaction.Location = new System.Drawing.Point(12, 195);
            this.trans_FinishTransaction.Name = "trans_FinishTransaction";
            this.trans_FinishTransaction.Size = new System.Drawing.Size(214, 39);
            this.trans_FinishTransaction.TabIndex = 7;
            this.trans_FinishTransaction.Text = "Finish Transaction";
            this.trans_FinishTransaction.UseVisualStyleBackColor = true;
            this.trans_FinishTransaction.Click += new System.EventHandler(this.trans_FinishTransaction_Click);
            // 
            // trans_DisplayItems
            // 
            this.trans_DisplayItems.Location = new System.Drawing.Point(243, 12);
            this.trans_DisplayItems.Name = "trans_DisplayItems";
            this.trans_DisplayItems.Size = new System.Drawing.Size(229, 222);
            this.trans_DisplayItems.TabIndex = 8;
            this.trans_DisplayItems.Text = "";
            this.trans_DisplayItems.WordWrap = false;
            // 
            // uxCreateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 246);
            this.Controls.Add(this.trans_DisplayItems);
            this.Controls.Add(this.trans_FinishTransaction);
            this.Controls.Add(this.trans_CreateTransaction);
            this.Controls.Add(this.trans_ItemQuantityVal);
            this.Controls.Add(this.trans_QuantityLabel);
            this.Controls.Add(this.trans_ItemEntryLabel);
            this.Controls.Add(this.trans_ItemNumVal);
            this.Controls.Add(this.trans_Title);
            this.Name = "uxCreateTransaction";
            this.Text = "Create Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.trans_ItemNumVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trans_ItemQuantityVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label trans_Title;
        private System.Windows.Forms.NumericUpDown trans_ItemNumVal;
        private System.Windows.Forms.Label trans_ItemEntryLabel;
        private System.Windows.Forms.Label trans_QuantityLabel;
        private System.Windows.Forms.NumericUpDown trans_ItemQuantityVal;
        private System.Windows.Forms.Button trans_CreateTransaction;
        private System.Windows.Forms.Button trans_FinishTransaction;
        private System.Windows.Forms.RichTextBox trans_DisplayItems;
    }
}