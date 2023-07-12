namespace Selenium_custom.action
{
    partial class CreateProfileByDefault
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnCreateByDefaultCT = new System.Windows.Forms.Button();
            this.txtConfigIdCT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(186, 106);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 15);
            this.lbStatus.TabIndex = 7;
            // 
            // btnCreateByDefaultCT
            // 
            this.btnCreateByDefaultCT.Location = new System.Drawing.Point(30, 101);
            this.btnCreateByDefaultCT.Name = "btnCreateByDefaultCT";
            this.btnCreateByDefaultCT.Size = new System.Drawing.Size(140, 27);
            this.btnCreateByDefaultCT.TabIndex = 6;
            this.btnCreateByDefaultCT.Text = "Create profile by default";
            this.btnCreateByDefaultCT.UseVisualStyleBackColor = true;
            this.btnCreateByDefaultCT.Click += new System.EventHandler(this.btnCreateByDefaultCT_Click);
            // 
            // txtConfigIdCT
            // 
            this.txtConfigIdCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigIdCT.Location = new System.Drawing.Point(30, 51);
            this.txtConfigIdCT.Multiline = true;
            this.txtConfigIdCT.Name = "txtConfigIdCT";
            this.txtConfigIdCT.Size = new System.Drawing.Size(315, 35);
            this.txtConfigIdCT.TabIndex = 5;
            this.txtConfigIdCT.Text = "249";
            // 
            // CreateProfileByDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCreateByDefaultCT);
            this.Controls.Add(this.txtConfigIdCT);
            this.Name = "CreateProfileByDefault";
            this.Size = new System.Drawing.Size(420, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnCreateByDefaultCT;
        private System.Windows.Forms.TextBox txtConfigIdCT;
    }
}
