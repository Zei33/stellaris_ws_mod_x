namespace stellaris_ws_mod_x
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ModFolderSelect = new MetroFramework.Controls.MetroButton();
            this.ModFolderLocationText = new MetroFramework.Controls.MetroTextBox();
            this.ModZipFileSelect = new MetroFramework.Controls.MetroButton();
            this.ModZipFileLocationText = new MetroFramework.Controls.MetroTextBox();
            this.InstallModButton = new MetroFramework.Controls.MetroButton();
            this.CreatedByLabel = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // ModFolderSelect
            // 
            this.ModFolderSelect.Location = new System.Drawing.Point(23, 87);
            this.ModFolderSelect.Name = "ModFolderSelect";
            this.ModFolderSelect.Size = new System.Drawing.Size(147, 23);
            this.ModFolderSelect.TabIndex = 3;
            this.ModFolderSelect.Text = "Select Mod Folder";
            this.ModFolderSelect.Click += new System.EventHandler(this.ModFolderSelect_Click);
            // 
            // ModFolderLocationText
            // 
            this.ModFolderLocationText.Location = new System.Drawing.Point(177, 87);
            this.ModFolderLocationText.Name = "ModFolderLocationText";
            this.ModFolderLocationText.ReadOnly = true;
            this.ModFolderLocationText.Size = new System.Drawing.Size(282, 23);
            this.ModFolderLocationText.TabIndex = 4;
            // 
            // ModZipFileSelect
            // 
            this.ModZipFileSelect.Location = new System.Drawing.Point(23, 117);
            this.ModZipFileSelect.Name = "ModZipFileSelect";
            this.ModZipFileSelect.Size = new System.Drawing.Size(147, 23);
            this.ModZipFileSelect.TabIndex = 5;
            this.ModZipFileSelect.Text = "Select Mod Zip File";
            this.ModZipFileSelect.Click += new System.EventHandler(this.ModZipFileSelect_Click);
            // 
            // ModZipFileLocationText
            // 
            this.ModZipFileLocationText.Location = new System.Drawing.Point(177, 117);
            this.ModZipFileLocationText.Name = "ModZipFileLocationText";
            this.ModZipFileLocationText.Size = new System.Drawing.Size(282, 23);
            this.ModZipFileLocationText.TabIndex = 6;
            // 
            // InstallModButton
            // 
            this.InstallModButton.Location = new System.Drawing.Point(23, 147);
            this.InstallModButton.Name = "InstallModButton";
            this.InstallModButton.Size = new System.Drawing.Size(436, 26);
            this.InstallModButton.TabIndex = 7;
            this.InstallModButton.Text = "Install Mod";
            this.InstallModButton.Click += new System.EventHandler(this.InstallModButton_Click);
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.CreatedByLabel.Location = new System.Drawing.Point(362, 179);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(97, 23);
            this.CreatedByLabel.TabIndex = 8;
            this.CreatedByLabel.Text = "Created by Zei";
            this.CreatedByLabel.Click += new System.EventHandler(this.CreatedByLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 220);
            this.Controls.Add(this.CreatedByLabel);
            this.Controls.Add(this.InstallModButton);
            this.Controls.Add(this.ModZipFileLocationText);
            this.Controls.Add(this.ModZipFileSelect);
            this.Controls.Add(this.ModFolderLocationText);
            this.Controls.Add(this.ModFolderSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Stellaris Workshop Mod Converter";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton ModFolderSelect;
        private MetroFramework.Controls.MetroTextBox ModFolderLocationText;
        private MetroFramework.Controls.MetroButton ModZipFileSelect;
        private MetroFramework.Controls.MetroTextBox ModZipFileLocationText;
        private MetroFramework.Controls.MetroButton InstallModButton;
        private MetroFramework.Controls.MetroLink CreatedByLabel;
    }
}

