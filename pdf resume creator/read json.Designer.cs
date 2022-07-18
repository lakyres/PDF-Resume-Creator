namespace pdf_resume_creator
{
    partial class JSON
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
            this.txt_displayread = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_displayread
            // 
            this.txt_displayread.Location = new System.Drawing.Point(35, 77);
            this.txt_displayread.Multiline = true;
            this.txt_displayread.Name = "txt_displayread";
            this.txt_displayread.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_displayread.Size = new System.Drawing.Size(280, 286);
            this.txt_displayread.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.btn_read.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(125)))), ((int)(((byte)(127)))));
            this.btn_read.Location = new System.Drawing.Point(321, 128);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(108, 51);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "READ";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.btn_write.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(125)))), ((int)(((byte)(127)))));
            this.btn_write.Location = new System.Drawing.Point(321, 243);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(108, 51);
            this.btn_write.TabIndex = 2;
            this.btn_write.Text = "WRITE";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // JSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 434);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txt_displayread);
            this.Name = "JSON";
            this.Text = "JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_displayread;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
    }
}