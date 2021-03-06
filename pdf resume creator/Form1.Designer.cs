namespace pdf_resume_creator
{
    partial class PDFcreator
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
            this.lbl_generate = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_jsontest = new System.Windows.Forms.Button();
            this.txt_displayread = new System.Windows.Forms.TextBox();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_generate
            // 
            this.lbl_generate.AutoSize = true;
            this.lbl_generate.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_generate.Location = new System.Drawing.Point(130, 21);
            this.lbl_generate.Name = "lbl_generate";
            this.lbl_generate.Size = new System.Drawing.Size(414, 29);
            this.lbl_generate.TabIndex = 0;
            this.lbl_generate.Text = "Click \"GO\" to generate PDF file.";
            this.lbl_generate.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_go.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go.ForeColor = System.Drawing.Color.Teal;
            this.btn_go.Location = new System.Drawing.Point(12, 12);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(112, 43);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "GO";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_read.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.Color.Teal;
            this.btn_read.Location = new System.Drawing.Point(79, 421);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(150, 43);
            this.btn_read.TabIndex = 2;
            this.btn_read.Text = "DISPLAY";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_jsontest
            // 
            this.btn_jsontest.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_jsontest.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jsontest.ForeColor = System.Drawing.Color.Teal;
            this.btn_jsontest.Location = new System.Drawing.Point(575, 505);
            this.btn_jsontest.Name = "btn_jsontest";
            this.btn_jsontest.Size = new System.Drawing.Size(177, 43);
            this.btn_jsontest.TabIndex = 3;
            this.btn_jsontest.Text = "JSON TEST";
            this.btn_jsontest.UseVisualStyleBackColor = false;
            this.btn_jsontest.Click += new System.EventHandler(this.btn_jsontest_Click);
            // 
            // txt_displayread
            // 
            this.txt_displayread.Location = new System.Drawing.Point(235, 93);
            this.txt_displayread.Multiline = true;
            this.txt_displayread.Name = "txt_displayread";
            this.txt_displayread.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_displayread.Size = new System.Drawing.Size(309, 371);
            this.txt_displayread.TabIndex = 4;
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_write.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.Color.Teal;
            this.btn_write.Location = new System.Drawing.Point(104, 93);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(125, 43);
            this.btn_write.TabIndex = 5;
            this.btn_write.Text = "WRITE";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_clear.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Teal;
            this.btn_clear.Location = new System.Drawing.Point(622, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 43);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // PDFcreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(758, 560);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.txt_displayread);
            this.Controls.Add(this.btn_jsontest);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.lbl_generate);
            this.Name = "PDFcreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_generate;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_jsontest;
        private System.Windows.Forms.TextBox txt_displayread;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_clear;
    }
}

