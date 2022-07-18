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
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_jsontest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_generate
            // 
            this.lbl_generate.AutoSize = true;
            this.lbl_generate.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_generate.Location = new System.Drawing.Point(230, 41);
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
            this.btn_go.Location = new System.Drawing.Point(70, 32);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(112, 43);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "GO";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_write.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.Color.Teal;
            this.btn_write.Location = new System.Drawing.Point(59, 136);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(132, 43);
            this.btn_write.TabIndex = 2;
            this.btn_write.Text = "WRITE";
            this.btn_write.UseVisualStyleBackColor = false;
            // 
            // btn_jsontest
            // 
            this.btn_jsontest.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_jsontest.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jsontest.ForeColor = System.Drawing.Color.Teal;
            this.btn_jsontest.Location = new System.Drawing.Point(503, 177);
            this.btn_jsontest.Name = "btn_jsontest";
            this.btn_jsontest.Size = new System.Drawing.Size(177, 43);
            this.btn_jsontest.TabIndex = 3;
            this.btn_jsontest.Text = "JSON TEST";
            this.btn_jsontest.UseVisualStyleBackColor = false;
            this.btn_jsontest.Click += new System.EventHandler(this.btn_jsontest_Click);
            // 
            // PDFcreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(692, 232);
            this.Controls.Add(this.btn_jsontest);
            this.Controls.Add(this.btn_write);
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
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_jsontest;
    }
}

