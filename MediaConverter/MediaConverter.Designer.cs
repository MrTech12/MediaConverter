﻿
namespace MediaConverter
{
    partial class MediaConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolderBT = new System.Windows.Forms.Button();
            this.extractAudioBT = new System.Windows.Forms.Button();
            this.filesListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.clearListBT = new System.Windows.Forms.Button();
            this.audioFiletypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFolderBT
            // 
            this.selectFolderBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.selectFolderBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderBT.Location = new System.Drawing.Point(41, 34);
            this.selectFolderBT.Name = "selectFolderBT";
            this.selectFolderBT.Size = new System.Drawing.Size(93, 23);
            this.selectFolderBT.TabIndex = 0;
            this.selectFolderBT.Text = "Select folder";
            this.selectFolderBT.UseVisualStyleBackColor = false;
            this.selectFolderBT.Click += new System.EventHandler(this.selectFolderBT_Click);
            // 
            // extractAudioBT
            // 
            this.extractAudioBT.BackColor = System.Drawing.Color.Lime;
            this.extractAudioBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractAudioBT.Location = new System.Drawing.Point(677, 52);
            this.extractAudioBT.Name = "extractAudioBT";
            this.extractAudioBT.Size = new System.Drawing.Size(92, 23);
            this.extractAudioBT.TabIndex = 1;
            this.extractAudioBT.Text = "Extract audio";
            this.extractAudioBT.UseVisualStyleBackColor = false;
            this.extractAudioBT.Click += new System.EventHandler(this.extractAudioBT_Click);
            // 
            // filesListView
            // 
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(12, 257);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(776, 181);
            this.filesListView.TabIndex = 2;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matched file(s)";
            // 
            // clearListBT
            // 
            this.clearListBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearListBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearListBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearListBT.Location = new System.Drawing.Point(41, 78);
            this.clearListBT.Name = "clearListBT";
            this.clearListBT.Size = new System.Drawing.Size(93, 23);
            this.clearListBT.TabIndex = 4;
            this.clearListBT.Text = "Clear list";
            this.clearListBT.UseVisualStyleBackColor = false;
            this.clearListBT.Click += new System.EventHandler(this.clearListBT_Click);
            // 
            // audioFiletypeCB
            // 
            this.audioFiletypeCB.FormattingEnabled = true;
            this.audioFiletypeCB.Items.AddRange(new object[] {
            "wav",
            "mp3"});
            this.audioFiletypeCB.Location = new System.Drawing.Point(531, 52);
            this.audioFiletypeCB.Name = "audioFiletypeCB";
            this.audioFiletypeCB.Size = new System.Drawing.Size(106, 23);
            this.audioFiletypeCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose audio type";
            // 
            // MediaConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.audioFiletypeCB);
            this.Controls.Add(this.clearListBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.extractAudioBT);
            this.Controls.Add(this.selectFolderBT);
            this.Name = "MediaConverter";
            this.Text = "MediaConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderBT;
        private System.Windows.Forms.Button extractAudioBT;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearListBT;
        private System.Windows.Forms.ComboBox audioFiletypeCB;
        private System.Windows.Forms.Label label2;
    }
}

