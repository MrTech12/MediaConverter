namespace MediaManager
{
    partial class MediaManager
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
            this.selectFolderBT.Text = "Select Folder";
            this.selectFolderBT.UseVisualStyleBackColor = false;
            // 
            // extractAudioBT
            // 
            this.extractAudioBT.BackColor = System.Drawing.Color.Lime;
            this.extractAudioBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractAudioBT.Location = new System.Drawing.Point(41, 75);
            this.extractAudioBT.Name = "extractAudioBT";
            this.extractAudioBT.Size = new System.Drawing.Size(93, 23);
            this.extractAudioBT.TabIndex = 1;
            this.extractAudioBT.Text = "Extract audio";
            this.extractAudioBT.UseVisualStyleBackColor = false;
            // 
            // filesListView
            // 
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(41, 257);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(747, 181);
            this.filesListView.TabIndex = 2;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matched files:";
            // 
            // MediaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.extractAudioBT);
            this.Controls.Add(this.selectFolderBT);
            this.Name = "MediaManager";
            this.Text = "MediaManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderBT;
        private System.Windows.Forms.Button extractAudioBT;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Label label1;
    }
}

