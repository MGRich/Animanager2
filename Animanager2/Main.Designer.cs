﻿namespace Animanager2
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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.episodeRB = new System.Windows.Forms.RadioButton();
            this.seasonRB = new System.Windows.Forms.RadioButton();
            this.animeRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar2.Location = new System.Drawing.Point(209, 34);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(375, 23);
            this.progressBar2.Step = 20;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Anime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Season";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(209, 64);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(376, 23);
            this.progressBar3.Step = 20;
            this.progressBar3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "0%";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoLabel3);
            this.groupBox1.Controls.Add(this.infoLabel2);
            this.groupBox1.Controls.Add(this.infoLabel1);
            this.groupBox1.Location = new System.Drawing.Point(416, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 94);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
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
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(639, 24);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.open);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.save);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAs);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutClick);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.fileTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Animanager2";
            this.ResizeEnd += new System.EventHandler(this.tests);
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.RadioButton episodeRB;
        private System.Windows.Forms.RadioButton seasonRB;
        private System.Windows.Forms.RadioButton animeRB;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

