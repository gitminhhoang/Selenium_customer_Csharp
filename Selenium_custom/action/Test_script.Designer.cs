namespace Selenium_custom.action
{
    partial class Test_script
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenScriptCT = new System.Windows.Forms.Button();
            this.txtUidProfileCT = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOpenScriptCT
            // 
            this.btnOpenScriptCT.Location = new System.Drawing.Point(12, 53);
            this.btnOpenScriptCT.Name = "btnOpenScriptCT";
            this.btnOpenScriptCT.Size = new System.Drawing.Size(97, 22);
            this.btnOpenScriptCT.TabIndex = 5;
            this.btnOpenScriptCT.Text = "Start";
            this.btnOpenScriptCT.UseVisualStyleBackColor = true;
            this.btnOpenScriptCT.Click += new System.EventHandler(this.btnOpenScriptCT_Click);
            // 
            // txtUidProfileCT
            // 
            this.txtUidProfileCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUidProfileCT.Location = new System.Drawing.Point(12, 12);
            this.txtUidProfileCT.Multiline = true;
            this.txtUidProfileCT.Name = "txtUidProfileCT";
            this.txtUidProfileCT.Size = new System.Drawing.Size(315, 30);
            this.txtUidProfileCT.TabIndex = 4;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 99);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(464, 213);
            this.rtbLog.TabIndex = 6;
            this.rtbLog.Text = "";
            // 
            // Test_script
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnOpenScriptCT);
            this.Controls.Add(this.txtUidProfileCT);
            this.Name = "Test_script";
            this.Size = new System.Drawing.Size(532, 337);
            this.Load += new System.EventHandler(this.Test_script_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenScriptCT;
        private System.Windows.Forms.TextBox txtUidProfileCT;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}
