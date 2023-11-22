namespace login
{
    partial class Form3
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
            this.pesan = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pesan
            // 
            this.pesan.AutoSize = true;
            this.pesan.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesan.Location = new System.Drawing.Point(27, 20);
            this.pesan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pesan.Name = "pesan";
            this.pesan.Size = new System.Drawing.Size(195, 23);
            this.pesan.TabIndex = 0;
            this.pesan.Text = "Yakin ingin Menghapus?";
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButton.Location = new System.Drawing.Point(43, 59);
            this.yesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(153, 27);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Ya (Hapus Dipilih)";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(43, 93);
            this.noButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(153, 27);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "Tidak (Hapus Semua)";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(231, 149);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.pesan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Konfirmasi";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pesan;
        private Button yesButton;
        private Button noButton;
    }
}