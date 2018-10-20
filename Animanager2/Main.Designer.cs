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
            this.openButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.fileTree = new System.Windows.Forms.TreeView();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.episodeRB = new System.Windows.Forms.RadioButton();
            this.seasonRB = new System.Windows.Forms.RadioButton();
            this.animeRB = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(203, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.open);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(203, 70);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 2;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAs);
            // 
            // fileTree
            // 
            this.fileTree.Location = new System.Drawing.Point(12, 12);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(185, 426);
            this.fileTree.TabIndex = 3;
            this.fileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.selectNode);
            this.fileTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeDoubleClick);
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar2.Location = new System.Drawing.Point(284, 12);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(301, 23);
            this.progressBar2.Step = 20;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(203, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Anime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Season";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(284, 41);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(301, 23);
            this.progressBar3.Step = 20;
            this.progressBar3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Progress Bars";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "0%";
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.button1);
            this.addBox.Controls.Add(this.addText);
            this.addBox.Controls.Add(this.episodeRB);
            this.addBox.Controls.Add(this.seasonRB);
            this.addBox.Controls.Add(this.animeRB);
            this.addBox.Location = new System.Drawing.Point(203, 348);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(206, 90);
            this.addBox.TabIndex = 19;
            this.addBox.TabStop = false;
            this.addBox.Text = "Add";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(203, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 234);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(416, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 89);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.fileTree);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.openButton);
            this.Name = "Main";
            this.Text = "Form1";
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.RadioButton episodeRB;
        private System.Windows.Forms.RadioButton seasonRB;
        private System.Windows.Forms.RadioButton animeRB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

