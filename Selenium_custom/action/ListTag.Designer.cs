namespace Selenium_custom.action
{
    partial class ListTag
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
            this.rtbListTag = new System.Windows.Forms.RichTextBox();
            this.btnGetTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListTag
            // 
            this.rtbListTag.Location = new System.Drawing.Point(20, 54);
            this.rtbListTag.Name = "rtbListTag";
            this.rtbListTag.Size = new System.Drawing.Size(553, 312);
            this.rtbListTag.TabIndex = 1;
            this.rtbListTag.Text = "";
            // 
            // btnGetTag
            // 
            this.btnGetTag.Location = new System.Drawing.Point(20, 22);
            this.btnGetTag.Name = "btnGetTag";
            this.btnGetTag.Size = new System.Drawing.Size(114, 23);
            this.btnGetTag.TabIndex = 2;
            this.btnGetTag.Text = "Get Tag";
            this.btnGetTag.UseVisualStyleBackColor = true;
            this.btnGetTag.Click += new System.EventHandler(this.btnGetTag_Click);
            // 
            // ListTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetTag);
            this.Controls.Add(this.rtbListTag);
            this.Name = "ListTag";
            this.Size = new System.Drawing.Size(596, 383);
            this.Load += new System.EventHandler(this.ListTag_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListTag;
        private System.Windows.Forms.Button btnGetTag;
    }
}
