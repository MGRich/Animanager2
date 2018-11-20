namespace do_you_ever_A
{
    partial class MangaReader
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
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.leftNum = new System.Windows.Forms.Label();
            this.rightNum = new System.Windows.Forms.Label();
            this.fullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.pageNum = new System.Windows.Forms.NumericUpDown();
            this.zoomBox = new System.Windows.Forms.PictureBox();
            this.zoomNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(12, 36);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(399, 426);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left.TabIndex = 0;
            this.left.TabStop = false;
            this.left.Click += new System.EventHandler(this.zoom);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(409, 36);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(389, 426);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right.TabIndex = 1;
            this.right.TabStop = false;
            this.right.Click += new System.EventHandler(this.zoom);
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.Location = new System.Drawing.Point(66, 7);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(29, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.next);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(31, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.prev);
            // 
            // selectButton
            // 
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectButton.Location = new System.Drawing.Point(684, 7);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(114, 23);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Select Image Folder";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.select);
            // 
            // leftNum
            // 
            this.leftNum.AutoSize = true;
            this.leftNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftNum.Location = new System.Drawing.Point(406, 12);
            this.leftNum.Name = "leftNum";
            this.leftNum.Size = new System.Drawing.Size(13, 13);
            this.leftNum.TabIndex = 5;
            this.leftNum.Text = "2";
            // 
            // rightNum
            // 
            this.rightNum.AutoSize = true;
            this.rightNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightNum.Location = new System.Drawing.Point(505, 12);
            this.rightNum.Name = "rightNum";
            this.rightNum.Size = new System.Drawing.Size(13, 13);
            this.rightNum.TabIndex = 6;
            this.rightNum.Text = "1";
            this.rightNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fullscreenCheckBox
            // 
            this.fullscreenCheckBox.AutoSize = true;
            this.fullscreenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscreenCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullscreenCheckBox.Location = new System.Drawing.Point(607, 10);
            this.fullscreenCheckBox.Name = "fullscreenCheckBox";
            this.fullscreenCheckBox.Size = new System.Drawing.Size(71, 17);
            this.fullscreenCheckBox.TabIndex = 7;
            this.fullscreenCheckBox.Text = "Fullscreen";
            this.fullscreenCheckBox.UseVisualStyleBackColor = true;
            this.fullscreenCheckBox.CheckedChanged += new System.EventHandler(this.fullscreenToggle);
            // 
            // pageNum
            // 
            this.pageNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pageNum.Location = new System.Drawing.Point(140, 10);
            this.pageNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(55, 20);
            this.pageNum.TabIndex = 9;
            this.pageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNum.ValueChanged += new System.EventHandler(this.pageClick);
            // 
            // zoomBox
            // 
            this.zoomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomBox.Location = new System.Drawing.Point(12, 36);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(125, 125);
            this.zoomBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zoomBox.TabIndex = 10;
            this.zoomBox.TabStop = false;
            this.zoomBox.Visible = false;
            // 
            // zoomNumber
            // 
            this.zoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zoomNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zoomNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zoomNumber.Location = new System.Drawing.Point(274, 10);
            this.zoomNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zoomNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zoomNumber.Name = "zoomNumber";
            this.zoomNumber.Size = new System.Drawing.Size(55, 20);
            this.zoomNumber.TabIndex = 11;
            this.zoomNumber.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Page:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(201, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zoom Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(330, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "(px by px)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MangaReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(810, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoomNumber);
            this.Controls.Add(this.zoomBox);
            this.Controls.Add(this.pageNum);
            this.Controls.Add(this.fullscreenCheckBox);
            this.Controls.Add(this.rightNum);
            this.Controls.Add(this.leftNum);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MangaReader";
            this.ResizeEnd += new System.EventHandler(this.endResize);
            this.Resize += new System.EventHandler(this.formResize);
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label leftNum;
        private System.Windows.Forms.Label rightNum;
        private System.Windows.Forms.CheckBox fullscreenCheckBox;
        private System.Windows.Forms.NumericUpDown pageNum;
        private System.Windows.Forms.PictureBox zoomBox;
        private System.Windows.Forms.NumericUpDown zoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

