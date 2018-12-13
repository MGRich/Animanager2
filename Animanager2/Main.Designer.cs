namespace Animanager2
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fileTree = new System.Windows.Forms.TreeView();
            this.animeBar = new System.Windows.Forms.ProgressBar();
            this.animeLabel = new System.Windows.Forms.Label();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.seasonBar = new System.Windows.Forms.ProgressBar();
            this.animePercent = new System.Windows.Forms.Label();
            this.seasonPercent = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.episodeRB = new System.Windows.Forms.RadioButton();
            this.seasonRB = new System.Windows.Forms.RadioButton();
            this.animeRB = new System.Windows.Forms.RadioButton();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.imageButton = new System.Windows.Forms.Button();
            this.imageText = new System.Windows.Forms.TextBox();
            this.imageIDNum = new System.Windows.Forms.NumericUpDown();
            this.imageIDButton = new System.Windows.Forms.Button();
            this.imageIDLabel = new System.Windows.Forms.Label();
            this.generalMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.addBox.SuspendLayout();
            this.infoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageIDNum)).BeginInit();
            this.generalMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileTree
            // 
            this.fileTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTree.LabelEdit = true;
            this.fileTree.Location = new System.Drawing.Point(12, 34);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(185, 452);
            this.fileTree.TabIndex = 3;
            this.fileTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.rename);
            this.fileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.selectNode);
            this.fileTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeContextMenu);
            this.fileTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeDoubleClick);
            // 
            // animeBar
            // 
            this.animeBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.animeBar.Location = new System.Drawing.Point(209, 34);
            this.animeBar.Name = "animeBar";
            this.animeBar.Size = new System.Drawing.Size(375, 23);
            this.animeBar.Step = 20;
            this.animeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.animeBar.TabIndex = 5;
            // 
            // animeLabel
            // 
            this.animeLabel.AutoSize = true;
            this.animeLabel.Location = new System.Drawing.Point(592, 34);
            this.animeLabel.Name = "animeLabel";
            this.animeLabel.Size = new System.Drawing.Size(36, 13);
            this.animeLabel.TabIndex = 14;
            this.animeLabel.Text = "Anime";
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Location = new System.Drawing.Point(591, 64);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(43, 13);
            this.seasonLabel.TabIndex = 15;
            this.seasonLabel.Text = "Season";
            // 
            // seasonBar
            // 
            this.seasonBar.Location = new System.Drawing.Point(209, 64);
            this.seasonBar.Name = "seasonBar";
            this.seasonBar.Size = new System.Drawing.Size(376, 23);
            this.seasonBar.Step = 20;
            this.seasonBar.TabIndex = 6;
            // 
            // animePercent
            // 
            this.animePercent.AutoSize = true;
            this.animePercent.Location = new System.Drawing.Point(592, 47);
            this.animePercent.Name = "animePercent";
            this.animePercent.Size = new System.Drawing.Size(21, 13);
            this.animePercent.TabIndex = 17;
            this.animePercent.Text = "0%";
            // 
            // seasonPercent
            // 
            this.seasonPercent.AutoSize = true;
            this.seasonPercent.Location = new System.Drawing.Point(592, 77);
            this.seasonPercent.Name = "seasonPercent";
            this.seasonPercent.Size = new System.Drawing.Size(21, 13);
            this.seasonPercent.TabIndex = 18;
            this.seasonPercent.Text = "0%";
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.okButton);
            this.addBox.Controls.Add(this.addText);
            this.addBox.Controls.Add(this.episodeRB);
            this.addBox.Controls.Add(this.seasonRB);
            this.addBox.Controls.Add(this.animeRB);
            this.addBox.Location = new System.Drawing.Point(204, 392);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(206, 94);
            this.addBox.TabIndex = 19;
            this.addBox.TabStop = false;
            this.addBox.Text = "Add";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(167, 62);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(33, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.add);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(59, 18);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(140, 20);
            this.addText.TabIndex = 3;
            // 
            // episodeRB
            // 
            this.episodeRB.AutoSize = true;
            this.episodeRB.Location = new System.Drawing.Point(6, 65);
            this.episodeRB.Name = "episodeRB";
            this.episodeRB.Size = new System.Drawing.Size(161, 17);
            this.episodeRB.TabIndex = 2;
            this.episodeRB.Text = "Episode (to selected season)";
            this.episodeRB.UseVisualStyleBackColor = true;
            // 
            // seasonRB
            // 
            this.seasonRB.AutoSize = true;
            this.seasonRB.Location = new System.Drawing.Point(6, 42);
            this.seasonRB.Name = "seasonRB";
            this.seasonRB.Size = new System.Drawing.Size(153, 17);
            this.seasonRB.TabIndex = 1;
            this.seasonRB.Text = "Season (to selected anime)";
            this.seasonRB.UseVisualStyleBackColor = true;
            // 
            // animeRB
            // 
            this.animeRB.AutoSize = true;
            this.animeRB.Checked = true;
            this.animeRB.Location = new System.Drawing.Point(6, 19);
            this.animeRB.Name = "animeRB";
            this.animeRB.Size = new System.Drawing.Size(54, 17);
            this.animeRB.TabIndex = 0;
            this.animeRB.TabStop = true;
            this.animeRB.Text = "Anime";
            this.animeRB.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.infoLabel3);
            this.infoBox.Controls.Add(this.infoLabel2);
            this.infoBox.Controls.Add(this.infoLabel1);
            this.infoBox.Location = new System.Drawing.Point(416, 392);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(216, 94);
            this.infoBox.TabIndex = 21;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.Location = new System.Drawing.Point(6, 66);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(0, 13);
            this.infoLabel3.TabIndex = 2;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Location = new System.Drawing.Point(6, 43);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(0, 13);
            this.infoLabel2.TabIndex = 1;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Location = new System.Drawing.Point(6, 20);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(90, 13);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "Nothing selected.";
            // 
            // imageButton
            // 
            this.imageButton.Enabled = false;
            this.imageButton.Location = new System.Drawing.Point(536, 365);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(90, 22);
            this.imageButton.TabIndex = 22;
            this.imageButton.Text = "Set Image Path";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Visible = false;
            this.imageButton.Click += new System.EventHandler(this.setImagePath);
            // 
            // imageText
            // 
            this.imageText.Location = new System.Drawing.Point(467, 366);
            this.imageText.Name = "imageText";
            this.imageText.Size = new System.Drawing.Size(63, 20);
            this.imageText.TabIndex = 23;
            this.imageText.Visible = false;
            // 
            // imageIDNum
            // 
            this.imageIDNum.Location = new System.Drawing.Point(364, 366);
            this.imageIDNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.imageIDNum.Name = "imageIDNum";
            this.imageIDNum.Size = new System.Drawing.Size(40, 20);
            this.imageIDNum.TabIndex = 24;
            this.imageIDNum.Visible = false;
            // 
            // imageIDButton
            // 
            this.imageIDButton.Enabled = false;
            this.imageIDButton.Location = new System.Drawing.Point(409, 365);
            this.imageIDButton.Name = "imageIDButton";
            this.imageIDButton.Size = new System.Drawing.Size(52, 22);
            this.imageIDButton.TabIndex = 25;
            this.imageIDButton.Text = "Set ID";
            this.imageIDButton.UseVisualStyleBackColor = true;
            this.imageIDButton.Visible = false;
            this.imageIDButton.Click += new System.EventHandler(this.setID);
            // 
            // imageIDLabel
            // 
            this.imageIDLabel.AutoSize = true;
            this.imageIDLabel.Location = new System.Drawing.Point(207, 368);
            this.imageIDLabel.Name = "imageIDLabel";
            this.imageIDLabel.Size = new System.Drawing.Size(151, 13);
            this.imageIDLabel.TabIndex = 26;
            this.imageIDLabel.Text = "(ID is used for selecting image)";
            this.imageIDLabel.Visible = false;
            // 
            // generalMenu
            // 
            this.generalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuButton,
            this.renameMenuButton});
            this.generalMenu.Name = "contextMenuStrip1";
            this.generalMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // deleteMenuButton
            // 
            this.deleteMenuButton.Name = "deleteMenuButton";
            this.deleteMenuButton.Size = new System.Drawing.Size(117, 22);
            this.deleteMenuButton.Text = "Delete";
            this.deleteMenuButton.Click += new System.EventHandler(this.delete);
            // 
            // renameMenuButton
            // 
            this.renameMenuButton.Name = "renameMenuButton";
            this.renameMenuButton.Size = new System.Drawing.Size(117, 22);
            this.renameMenuButton.Text = "Rename";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.aboutButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(639, 24);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.saveAsButton});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(37, 20);
            this.fileButton.Text = "File";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(180, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.open);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(180, 22);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.saveAs);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 20);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutClick);
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox.Location = new System.Drawing.Point(209, 99);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(417, 259);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 20;
            this.imageBox.TabStop = false;
            this.imageBox.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 496);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.imageIDLabel);
            this.Controls.Add(this.imageIDButton);
            this.Controls.Add(this.imageIDNum);
            this.Controls.Add(this.imageText);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.seasonPercent);
            this.Controls.Add(this.animePercent);
            this.Controls.Add(this.seasonLabel);
            this.Controls.Add(this.animeLabel);
            this.Controls.Add(this.seasonBar);
            this.Controls.Add(this.animeBar);
            this.Controls.Add(this.fileTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Animanager2";
            this.ResizeEnd += new System.EventHandler(this.tests);
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageIDNum)).EndInit();
            this.generalMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.ProgressBar animeBar;
        private System.Windows.Forms.Label animeLabel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.ProgressBar seasonBar;
        private System.Windows.Forms.Label animePercent;
        private System.Windows.Forms.Label seasonPercent;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.RadioButton episodeRB;
        private System.Windows.Forms.RadioButton seasonRB;
        private System.Windows.Forms.RadioButton animeRB;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.TextBox imageText;
        private System.Windows.Forms.NumericUpDown imageIDNum;
        private System.Windows.Forms.Button imageIDButton;
        private System.Windows.Forms.Label imageIDLabel;
        private System.Windows.Forms.ContextMenuStrip generalMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuButton;
        private System.Windows.Forms.ToolStripMenuItem renameMenuButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
    }
}

