namespace Selenium_custom
{
    partial class Form1
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
            this.btnOpenProfile = new System.Windows.Forms.Button();
            this.btnCloseProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListTag = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnSyncTag = new System.Windows.Forms.Button();
            this.btnCreateProfileDefault = new System.Windows.Forms.Button();
            this.btnUpdateNote = new System.Windows.Forms.Button();
            this.btnCreateProfileCustomize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckingProfile = new System.Windows.Forms.Button();
            this.lb_remote = new System.Windows.Forms.Label();
            this.pn_show = new System.Windows.Forms.Panel();
            this.btnGetProfileByUuid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateProxy = new System.Windows.Forms.Button();
            this.btnUpdateProfileProxy = new System.Windows.Forms.Button();
            this.btnListProfile = new System.Windows.Forms.Button();
            this.listProfile_CT = new Selenium_custom.action.ListProfile();
            this.getProfileByUid_CT = new Selenium_custom.action.GetProfileByUid();
            this.listStatus_CT = new Selenium_custom.action.listStatus();
            this.listTagCT = new Selenium_custom.action.ListTag();
            this.deleteProfileCT = new Selenium_custom.action.DeleteProfile();
            this.changeStatusCT = new Selenium_custom.action.ChangeStatus();
            this.syncTagCT = new Selenium_custom.action.SyncTag();
            this.updateNameCT = new Selenium_custom.action.UpdateName();
            this.updateNoteCT = new Selenium_custom.action.UpdateNote();
            this.createProfileCustomizeCT = new Selenium_custom.action.CreateProfileCustomize();
            this.createProfileByDefaultCT = new Selenium_custom.action.CreateProfileByDefault();
            this.test_script1 = new Selenium_custom.action.Test_script();
            this.listConfigCT = new Selenium_custom.action.ListConfig();
            this.checkingProfileCT = new Selenium_custom.action.CheckingProfile();
            this.closeProfileCT = new Selenium_custom.action.CloseProfile();
            this.openProfileCT = new Selenium_custom.action.OpenProfile();
            this.panel1.SuspendLayout();
            this.pn_show.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenProfile
            // 
            this.btnOpenProfile.Location = new System.Drawing.Point(21, 26);
            this.btnOpenProfile.Name = "btnOpenProfile";
            this.btnOpenProfile.Size = new System.Drawing.Size(127, 23);
            this.btnOpenProfile.TabIndex = 0;
            this.btnOpenProfile.Text = "Open profile";
            this.btnOpenProfile.UseVisualStyleBackColor = true;
            this.btnOpenProfile.Click += new System.EventHandler(this.btnOpenProfile_Click);
            // 
            // btnCloseProfile
            // 
            this.btnCloseProfile.Location = new System.Drawing.Point(21, 55);
            this.btnCloseProfile.Name = "btnCloseProfile";
            this.btnCloseProfile.Size = new System.Drawing.Size(127, 22);
            this.btnCloseProfile.TabIndex = 1;
            this.btnCloseProfile.Text = "Close profile";
            this.btnCloseProfile.UseVisualStyleBackColor = true;
            this.btnCloseProfile.Click += new System.EventHandler(this.btnCloseProfile_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnListProfile);
            this.panel1.Controls.Add(this.btnUpdateProfileProxy);
            this.panel1.Controls.Add(this.btnUpdateProxy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGetProfileByUuid);
            this.panel1.Controls.Add(this.btnListTag);
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnDeleteProfile);
            this.panel1.Controls.Add(this.btnUpdateName);
            this.panel1.Controls.Add(this.btnChangeStatus);
            this.panel1.Controls.Add(this.btnSyncTag);
            this.panel1.Controls.Add(this.btnCreateProfileDefault);
            this.panel1.Controls.Add(this.btnUpdateNote);
            this.panel1.Controls.Add(this.btnCreateProfileCustomize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnListConfig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpenProfile);
            this.panel1.Controls.Add(this.btnCheckingProfile);
            this.panel1.Controls.Add(this.lb_remote);
            this.panel1.Controls.Add(this.btnCloseProfile);
            this.panel1.Location = new System.Drawing.Point(16, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 685);
            this.panel1.TabIndex = 2;
            // 
            // btnListTag
            // 
            this.btnListTag.Location = new System.Drawing.Point(21, 269);
            this.btnListTag.Name = "btnListTag";
            this.btnListTag.Size = new System.Drawing.Size(127, 25);
            this.btnListTag.TabIndex = 15;
            this.btnListTag.Text = "List config tag";
            this.btnListTag.UseVisualStyleBackColor = true;
            this.btnListTag.Click += new System.EventHandler(this.btnListTag_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(21, 237);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(127, 25);
            this.btnStatus.TabIndex = 14;
            this.btnStatus.Text = "List config status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(21, 113);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(127, 23);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test Script";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(21, 554);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(127, 24);
            this.btnDeleteProfile.TabIndex = 12;
            this.btnDeleteProfile.Text = "Delete profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(21, 467);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateName.TabIndex = 9;
            this.btnUpdateName.Text = "Update name";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(21, 524);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(127, 24);
            this.btnChangeStatus.TabIndex = 11;
            this.btnChangeStatus.Text = "Change status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnSyncTag
            // 
            this.btnSyncTag.Location = new System.Drawing.Point(21, 496);
            this.btnSyncTag.Name = "btnSyncTag";
            this.btnSyncTag.Size = new System.Drawing.Size(127, 22);
            this.btnSyncTag.TabIndex = 10;
            this.btnSyncTag.Text = "Sync tag";
            this.btnSyncTag.UseVisualStyleBackColor = true;
            // 
            // btnCreateProfileDefault
            // 
            this.btnCreateProfileDefault.Location = new System.Drawing.Point(21, 380);
            this.btnCreateProfileDefault.Name = "btnCreateProfileDefault";
            this.btnCreateProfileDefault.Size = new System.Drawing.Size(127, 23);
            this.btnCreateProfileDefault.TabIndex = 6;
            this.btnCreateProfileDefault.Text = "Create profile by default";
            this.btnCreateProfileDefault.UseVisualStyleBackColor = true;
            this.btnCreateProfileDefault.Click += new System.EventHandler(this.btnCreateProfileDefault_Click);
            // 
            // btnUpdateNote
            // 
            this.btnUpdateNote.Location = new System.Drawing.Point(21, 437);
            this.btnUpdateNote.Name = "btnUpdateNote";
            this.btnUpdateNote.Size = new System.Drawing.Size(127, 24);
            this.btnUpdateNote.TabIndex = 8;
            this.btnUpdateNote.Text = "Update note";
            this.btnUpdateNote.UseVisualStyleBackColor = true;
            this.btnUpdateNote.Click += new System.EventHandler(this.btnUpdateNote_Click);
            // 
            // btnCreateProfileCustomize
            // 
            this.btnCreateProfileCustomize.Location = new System.Drawing.Point(21, 409);
            this.btnCreateProfileCustomize.Name = "btnCreateProfileCustomize";
            this.btnCreateProfileCustomize.Size = new System.Drawing.Size(127, 22);
            this.btnCreateProfileCustomize.TabIndex = 7;
            this.btnCreateProfileCustomize.Text = "Create profile customize";
            this.btnCreateProfileCustomize.UseVisualStyleBackColor = true;
            this.btnCreateProfileCustomize.Click += new System.EventHandler(this.btnCreateProfileCustomize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Interact profile";
            // 
            // btnListConfig
            // 
            this.btnListConfig.Location = new System.Drawing.Point(21, 206);
            this.btnListConfig.Name = "btnListConfig";
            this.btnListConfig.Size = new System.Drawing.Size(127, 25);
            this.btnListConfig.TabIndex = 3;
            this.btnListConfig.Text = "List config default";
            this.btnListConfig.UseVisualStyleBackColor = true;
            this.btnListConfig.Click += new System.EventHandler(this.btnListConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Get profile";
            // 
            // btnCheckingProfile
            // 
            this.btnCheckingProfile.Location = new System.Drawing.Point(21, 83);
            this.btnCheckingProfile.Name = "btnCheckingProfile";
            this.btnCheckingProfile.Size = new System.Drawing.Size(127, 24);
            this.btnCheckingProfile.TabIndex = 2;
            this.btnCheckingProfile.Text = "Checking profile";
            this.btnCheckingProfile.UseVisualStyleBackColor = true;
            this.btnCheckingProfile.Click += new System.EventHandler(this.btnCheckingProfile_Click);
            // 
            // lb_remote
            // 
            this.lb_remote.AutoSize = true;
            this.lb_remote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remote.Location = new System.Drawing.Point(5, 5);
            this.lb_remote.Name = "lb_remote";
            this.lb_remote.Size = new System.Drawing.Size(105, 18);
            this.lb_remote.TabIndex = 3;
            this.lb_remote.Text = "Remote profile";
            // 
            // pn_show
            // 
            this.pn_show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_show.Controls.Add(this.listProfile_CT);
            this.pn_show.Controls.Add(this.getProfileByUid_CT);
            this.pn_show.Controls.Add(this.listStatus_CT);
            this.pn_show.Controls.Add(this.listTagCT);
            this.pn_show.Controls.Add(this.deleteProfileCT);
            this.pn_show.Controls.Add(this.changeStatusCT);
            this.pn_show.Controls.Add(this.syncTagCT);
            this.pn_show.Controls.Add(this.updateNameCT);
            this.pn_show.Controls.Add(this.updateNoteCT);
            this.pn_show.Controls.Add(this.createProfileCustomizeCT);
            this.pn_show.Controls.Add(this.createProfileByDefaultCT);
            this.pn_show.Controls.Add(this.test_script1);
            this.pn_show.Controls.Add(this.listConfigCT);
            this.pn_show.Controls.Add(this.checkingProfileCT);
            this.pn_show.Controls.Add(this.closeProfileCT);
            this.pn_show.Controls.Add(this.openProfileCT);
            this.pn_show.Location = new System.Drawing.Point(282, 21);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(714, 669);
            this.pn_show.TabIndex = 3;
            // 
            // btnGetProfileByUuid
            // 
            this.btnGetProfileByUuid.Location = new System.Drawing.Point(21, 300);
            this.btnGetProfileByUuid.Name = "btnGetProfileByUuid";
            this.btnGetProfileByUuid.Size = new System.Drawing.Size(127, 23);
            this.btnGetProfileByUuid.TabIndex = 16;
            this.btnGetProfileByUuid.Text = "Get profile by uuid";
            this.btnGetProfileByUuid.UseVisualStyleBackColor = true;
            this.btnGetProfileByUuid.Click += new System.EventHandler(this.btnGetProfileByUuid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Proxy";
            // 
            // btnUpdateProxy
            // 
            this.btnUpdateProxy.Location = new System.Drawing.Point(21, 611);
            this.btnUpdateProxy.Name = "btnUpdateProxy";
            this.btnUpdateProxy.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateProxy.TabIndex = 18;
            this.btnUpdateProxy.Text = "Updadte proxy";
            this.btnUpdateProxy.UseVisualStyleBackColor = true;
            this.btnUpdateProxy.Click += new System.EventHandler(this.btnUpdateProxy_Click);
            // 
            // btnUpdateProfileProxy
            // 
            this.btnUpdateProfileProxy.Location = new System.Drawing.Point(21, 640);
            this.btnUpdateProfileProxy.Name = "btnUpdateProfileProxy";
            this.btnUpdateProfileProxy.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateProfileProxy.TabIndex = 19;
            this.btnUpdateProfileProxy.Text = "Update profile proxy";
            this.btnUpdateProfileProxy.UseVisualStyleBackColor = true;
            this.btnUpdateProfileProxy.Click += new System.EventHandler(this.btnUpdateProfileProxy_Click);
            // 
            // btnListProfile
            // 
            this.btnListProfile.Location = new System.Drawing.Point(21, 177);
            this.btnListProfile.Name = "btnListProfile";
            this.btnListProfile.Size = new System.Drawing.Size(127, 23);
            this.btnListProfile.TabIndex = 20;
            this.btnListProfile.Text = "List profile";
            this.btnListProfile.UseVisualStyleBackColor = true;
            this.btnListProfile.Click += new System.EventHandler(this.btnListProfile_Click);
            // 
            // listProfile_CT
            // 
            this.listProfile_CT.Location = new System.Drawing.Point(-2, -2);
            this.listProfile_CT.Name = "listProfile_CT";
            this.listProfile_CT.Size = new System.Drawing.Size(604, 639);
            this.listProfile_CT.TabIndex = 15;
            this.listProfile_CT.Visible = false;
            // 
            // getProfileByUid_CT
            // 
            this.getProfileByUid_CT.Location = new System.Drawing.Point(-2, -2);
            this.getProfileByUid_CT.Name = "getProfileByUid_CT";
            this.getProfileByUid_CT.Size = new System.Drawing.Size(610, 428);
            this.getProfileByUid_CT.TabIndex = 14;
            this.getProfileByUid_CT.Visible = false;
            // 
            // listStatus_CT
            // 
            this.listStatus_CT.Location = new System.Drawing.Point(-2, 0);
            this.listStatus_CT.Name = "listStatus_CT";
            this.listStatus_CT.Size = new System.Drawing.Size(582, 411);
            this.listStatus_CT.TabIndex = 13;
            this.listStatus_CT.Visible = false;
            // 
            // listTagCT
            // 
            this.listTagCT.Location = new System.Drawing.Point(-2, -2);
            this.listTagCT.Name = "listTagCT";
            this.listTagCT.Size = new System.Drawing.Size(596, 383);
            this.listTagCT.TabIndex = 12;
            this.listTagCT.Visible = false;
            // 
            // deleteProfileCT
            // 
            this.deleteProfileCT.Location = new System.Drawing.Point(-2, -2);
            this.deleteProfileCT.Name = "deleteProfileCT";
            this.deleteProfileCT.Size = new System.Drawing.Size(411, 248);
            this.deleteProfileCT.TabIndex = 11;
            this.deleteProfileCT.Visible = false;
            // 
            // changeStatusCT
            // 
            this.changeStatusCT.Location = new System.Drawing.Point(-2, -2);
            this.changeStatusCT.Name = "changeStatusCT";
            this.changeStatusCT.Size = new System.Drawing.Size(409, 275);
            this.changeStatusCT.TabIndex = 10;
            this.changeStatusCT.Visible = false;
            // 
            // syncTagCT
            // 
            this.syncTagCT.Location = new System.Drawing.Point(-2, -2);
            this.syncTagCT.Name = "syncTagCT";
            this.syncTagCT.Size = new System.Drawing.Size(444, 266);
            this.syncTagCT.TabIndex = 9;
            this.syncTagCT.Visible = false;
            // 
            // updateNameCT
            // 
            this.updateNameCT.Location = new System.Drawing.Point(-2, -2);
            this.updateNameCT.Name = "updateNameCT";
            this.updateNameCT.Size = new System.Drawing.Size(440, 263);
            this.updateNameCT.TabIndex = 8;
            this.updateNameCT.Visible = false;
            // 
            // updateNoteCT
            // 
            this.updateNoteCT.Location = new System.Drawing.Point(-2, -2);
            this.updateNoteCT.Name = "updateNoteCT";
            this.updateNoteCT.Size = new System.Drawing.Size(451, 265);
            this.updateNoteCT.TabIndex = 7;
            this.updateNoteCT.Visible = false;
            // 
            // createProfileCustomizeCT
            // 
            this.createProfileCustomizeCT.Location = new System.Drawing.Point(-2, -2);
            this.createProfileCustomizeCT.Name = "createProfileCustomizeCT";
            this.createProfileCustomizeCT.Size = new System.Drawing.Size(497, 458);
            this.createProfileCustomizeCT.TabIndex = 6;
            this.createProfileCustomizeCT.Visible = false;
            // 
            // createProfileByDefaultCT
            // 
            this.createProfileByDefaultCT.Location = new System.Drawing.Point(-2, -2);
            this.createProfileByDefaultCT.Name = "createProfileByDefaultCT";
            this.createProfileByDefaultCT.Size = new System.Drawing.Size(602, 413);
            this.createProfileByDefaultCT.TabIndex = 5;
            this.createProfileByDefaultCT.Visible = false;
            // 
            // test_script1
            // 
            this.test_script1.Location = new System.Drawing.Point(-2, -2);
            this.test_script1.Name = "test_script1";
            this.test_script1.Size = new System.Drawing.Size(532, 337);
            this.test_script1.TabIndex = 4;
            this.test_script1.Visible = false;
            // 
            // listConfigCT
            // 
            this.listConfigCT.Location = new System.Drawing.Point(-2, -2);
            this.listConfigCT.Name = "listConfigCT";
            this.listConfigCT.Size = new System.Drawing.Size(600, 400);
            this.listConfigCT.TabIndex = 3;
            this.listConfigCT.Visible = false;
            // 
            // checkingProfileCT
            // 
            this.checkingProfileCT.Location = new System.Drawing.Point(-2, -2);
            this.checkingProfileCT.Name = "checkingProfileCT";
            this.checkingProfileCT.Size = new System.Drawing.Size(400, 200);
            this.checkingProfileCT.TabIndex = 2;
            this.checkingProfileCT.Visible = false;
            // 
            // closeProfileCT
            // 
            this.closeProfileCT.Location = new System.Drawing.Point(-2, -2);
            this.closeProfileCT.Name = "closeProfileCT";
            this.closeProfileCT.Size = new System.Drawing.Size(476, 207);
            this.closeProfileCT.TabIndex = 1;
            this.closeProfileCT.Visible = false;
            this.closeProfileCT.Load += new System.EventHandler(this.closeProfileCT_Load);
            // 
            // openProfileCT
            // 
            this.openProfileCT.Location = new System.Drawing.Point(-2, -2);
            this.openProfileCT.Name = "openProfileCT";
            this.openProfileCT.Size = new System.Drawing.Size(497, 191);
            this.openProfileCT.TabIndex = 0;
            this.openProfileCT.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 718);
            this.Controls.Add(this.pn_show);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_show.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProfile;
        private System.Windows.Forms.Button btnCloseProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckingProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnSyncTag;
        private System.Windows.Forms.Button btnCreateProfileDefault;
        private System.Windows.Forms.Button btnUpdateNote;
        private System.Windows.Forms.Button btnCreateProfileCustomize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_remote;
        private System.Windows.Forms.Panel pn_show;
        private action.OpenProfile openProfileCT;
        private action.CloseProfile closeProfileCT;
        private action.CheckingProfile checkingProfileCT;
        private action.ListConfig listConfigCT;
        private System.Windows.Forms.Button btnTest;
        private action.Test_script test_script1;
        private action.CreateProfileByDefault createProfileByDefaultCT;
        private action.CreateProfileCustomize createProfileCustomizeCT;
        private action.UpdateNote updateNoteCT;
        private action.SyncTag syncTagCT;
        private action.UpdateName updateNameCT;
        private action.ChangeStatus changeStatusCT;
        private action.DeleteProfile deleteProfileCT;
        private action.listStatus listStatusCT;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnListTag;
        private action.ListTag listTagCT;
        private action.listStatus listStatus_CT;
        private System.Windows.Forms.Button btnGetProfileByUuid;
        private action.GetProfileByUid getProfileByUid_CT;
        private System.Windows.Forms.Button btnUpdateProfileProxy;
        private System.Windows.Forms.Button btnUpdateProxy;
        private System.Windows.Forms.Label label3;
        private action.ListProfile listProfile_CT;
        private System.Windows.Forms.Button btnListProfile;
    }
}

