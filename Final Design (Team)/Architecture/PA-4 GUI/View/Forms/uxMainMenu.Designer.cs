namespace PA_4_GUI
{
    partial class uxMainMenu
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
            this.uxMenuTitle = new System.Windows.Forms.Label();
            this.uxCreateTransaction = new System.Windows.Forms.Button();
            this.uxGenerateChecks = new System.Windows.Forms.Button();
            this.uxCreateRebate = new System.Windows.Forms.Button();
            this.uxProcessReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMenuTitle
            // 
            this.uxMenuTitle.AutoSize = true;
            this.uxMenuTitle.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMenuTitle.Location = new System.Drawing.Point(12, 9);
            this.uxMenuTitle.Name = "uxMenuTitle";
            this.uxMenuTitle.Size = new System.Drawing.Size(113, 29);
            this.uxMenuTitle.TabIndex = 0;
            this.uxMenuTitle.Text = "Sales 501";
            // 
            // uxCreateTransaction
            // 
            this.uxCreateTransaction.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateTransaction.Location = new System.Drawing.Point(11, 50);
            this.uxCreateTransaction.Name = "uxCreateTransaction";
            this.uxCreateTransaction.Size = new System.Drawing.Size(178, 34);
            this.uxCreateTransaction.TabIndex = 1;
            this.uxCreateTransaction.Text = "Make a Purchase";
            this.uxCreateTransaction.UseVisualStyleBackColor = true;
            this.uxCreateTransaction.Click += new System.EventHandler(this.uxCreateTransaction_Click);
            // 
            // uxGenerateChecks
            // 
            this.uxGenerateChecks.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenerateChecks.Location = new System.Drawing.Point(195, 90);
            this.uxGenerateChecks.Name = "uxGenerateChecks";
            this.uxGenerateChecks.Size = new System.Drawing.Size(177, 34);
            this.uxGenerateChecks.TabIndex = 2;
            this.uxGenerateChecks.Text = "Generate Rebate Checks";
            this.uxGenerateChecks.UseVisualStyleBackColor = true;
            this.uxGenerateChecks.Click += new System.EventHandler(this.uxGenerateChecks_Click);
            // 
            // uxCreateRebate
            // 
            this.uxCreateRebate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateRebate.Location = new System.Drawing.Point(11, 90);
            this.uxCreateRebate.Name = "uxCreateRebate";
            this.uxCreateRebate.Size = new System.Drawing.Size(178, 34);
            this.uxCreateRebate.TabIndex = 4;
            this.uxCreateRebate.Text = "Create A Rebate";
            this.uxCreateRebate.UseVisualStyleBackColor = true;
            this.uxCreateRebate.Click += new System.EventHandler(this.uxCreateRebate_Click);
            // 
            // uxProcessReturn
            // 
            this.uxProcessReturn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProcessReturn.Location = new System.Drawing.Point(195, 50);
            this.uxProcessReturn.Name = "uxProcessReturn";
            this.uxProcessReturn.Size = new System.Drawing.Size(177, 34);
            this.uxProcessReturn.TabIndex = 3;
            this.uxProcessReturn.Text = "Make a Retun";
            this.uxProcessReturn.UseVisualStyleBackColor = true;
            this.uxProcessReturn.Click += new System.EventHandler(this.uxProcessReturn_Click);
            // 
            // uxMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.uxCreateRebate);
            this.Controls.Add(this.uxProcessReturn);
            this.Controls.Add(this.uxGenerateChecks);
            this.Controls.Add(this.uxCreateTransaction);
            this.Controls.Add(this.uxMenuTitle);
            this.Name = "uxMainMenu";
            this.Text = "Sales 501";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMenuTitle;
        private System.Windows.Forms.Button uxCreateTransaction;
        private System.Windows.Forms.Button uxGenerateChecks;
        private System.Windows.Forms.Button uxCreateRebate;
        private System.Windows.Forms.Button uxProcessReturn;
    }
}