namespace PA_4_GUI
{
    partial class uxGenerateChecks
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
            this.grc_Title = new System.Windows.Forms.Label();
            this.grc_GenerateChecks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grc_Title
            // 
            this.grc_Title.AutoSize = true;
            this.grc_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_Title.Location = new System.Drawing.Point(12, 9);
            this.grc_Title.Name = "grc_Title";
            this.grc_Title.Size = new System.Drawing.Size(196, 21);
            this.grc_Title.TabIndex = 2;
            this.grc_Title.Text = "Generate Rebate Checks";
            // 
            // grc_GenerateChecks
            // 
            this.grc_GenerateChecks.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_GenerateChecks.Location = new System.Drawing.Point(16, 45);
            this.grc_GenerateChecks.Name = "grc_GenerateChecks";
            this.grc_GenerateChecks.Size = new System.Drawing.Size(192, 44);
            this.grc_GenerateChecks.TabIndex = 11;
            this.grc_GenerateChecks.Text = "Generate Checks";
            this.grc_GenerateChecks.UseVisualStyleBackColor = true;
            this.grc_GenerateChecks.Click += new System.EventHandler(this.grc_GenerateChecks_Click);
            // 
            // uxGenerateChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 101);
            this.Controls.Add(this.grc_GenerateChecks);
            this.Controls.Add(this.grc_Title);
            this.Name = "uxGenerateChecks";
            this.Text = "Generate Rebate Checks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grc_Title;
        private System.Windows.Forms.Button grc_GenerateChecks;
    }
}