namespace PdfTool
{
    partial class PDFTool
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.genetePdfBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.base64Txt = new System.Windows.Forms.RichTextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.openContainingBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base64";
            // 
            // genetePdfBtn
            // 
            this.genetePdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genetePdfBtn.Location = new System.Drawing.Point(464, 268);
            this.genetePdfBtn.Name = "genetePdfBtn";
            this.genetePdfBtn.Size = new System.Drawing.Size(116, 23);
            this.genetePdfBtn.TabIndex = 2;
            this.genetePdfBtn.Text = "Generate PDF";
            this.genetePdfBtn.UseVisualStyleBackColor = true;
            this.genetePdfBtn.Click += new System.EventHandler(this.genetePdfBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(596, 268);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBtn.Size = new System.Drawing.Size(116, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // base64Txt
            // 
            this.base64Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base64Txt.Location = new System.Drawing.Point(15, 32);
            this.base64Txt.Name = "base64Txt";
            this.base64Txt.Size = new System.Drawing.Size(697, 216);
            this.base64Txt.TabIndex = 4;
            this.base64Txt.Text = "";
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(15, 297);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(697, 209);
            this.browser.TabIndex = 5;
            // 
            // openContainingBtn
            // 
            this.openContainingBtn.Enabled = false;
            this.openContainingBtn.Location = new System.Drawing.Point(15, 268);
            this.openContainingBtn.Name = "openContainingBtn";
            this.openContainingBtn.Size = new System.Drawing.Size(142, 23);
            this.openContainingBtn.TabIndex = 6;
            this.openContainingBtn.Text = "Open Containing Folder";
            this.openContainingBtn.UseVisualStyleBackColor = true;
            this.openContainingBtn.Click += new System.EventHandler(this.openContainingBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBtn.Location = new System.Drawing.Point(352, 268);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(94, 23);
            this.previewBtn.TabIndex = 7;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // PDFTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(724, 518);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.openContainingBtn);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.base64Txt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.genetePdfBtn);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(740, 557);
            this.Name = "PDFTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFTool";
            this.Load += new System.EventHandler(this.PDFTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genetePdfBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RichTextBox base64Txt;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button openContainingBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}

