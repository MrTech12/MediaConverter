
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
            selectFolderBT = new System.Windows.Forms.Button();
            convertBT = new System.Windows.Forms.Button();
            filesListView = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            clearListBT = new System.Windows.Forms.Button();
            convertOptionCB = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // selectFolderBT
            // 
            selectFolderBT.BackColor = System.Drawing.Color.FromArgb(236, 223, 70);
            selectFolderBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            selectFolderBT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            selectFolderBT.Location = new System.Drawing.Point(12, 20);
            selectFolderBT.Name = "selectFolderBT";
            selectFolderBT.Size = new System.Drawing.Size(122, 40);
            selectFolderBT.TabIndex = 0;
            selectFolderBT.Text = "Select file(s)";
            selectFolderBT.UseVisualStyleBackColor = false;
            selectFolderBT.Click += selectFolderBT_Click;
            // 
            // convertBT
            // 
            convertBT.BackColor = System.Drawing.Color.FromArgb(90, 237, 123);
            convertBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            convertBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            convertBT.Location = new System.Drawing.Point(669, 23);
            convertBT.Name = "convertBT";
            convertBT.Size = new System.Drawing.Size(119, 40);
            convertBT.TabIndex = 1;
            convertBT.Text = "Convert";
            convertBT.UseVisualStyleBackColor = false;
            convertBT.Click += convertBT_Click;
            // 
            // filesListView
            // 
            filesListView.HideSelection = false;
            filesListView.Location = new System.Drawing.Point(12, 169);
            filesListView.Name = "filesListView";
            filesListView.Size = new System.Drawing.Size(776, 269);
            filesListView.TabIndex = 2;
            filesListView.UseCompatibleStateImageBehavior = false;
            filesListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 28);
            label1.TabIndex = 3;
            label1.Text = "Selected file(s)";
            // 
            // clearListBT
            // 
            clearListBT.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            clearListBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clearListBT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            clearListBT.ForeColor = System.Drawing.SystemColors.ControlText;
            clearListBT.Location = new System.Drawing.Point(170, 125);
            clearListBT.Name = "clearListBT";
            clearListBT.Size = new System.Drawing.Size(176, 38);
            clearListBT.TabIndex = 4;
            clearListBT.Text = "Clear files from list";
            clearListBT.UseVisualStyleBackColor = false;
            clearListBT.Click += clearListBT_Click;
            // 
            // convertOptionCB
            // 
            convertOptionCB.FormattingEnabled = true;
            convertOptionCB.Items.AddRange(new object[] { "Convert to MP3", "Convert to WAV" });
            convertOptionCB.Location = new System.Drawing.Point(537, 33);
            convertOptionCB.Name = "convertOptionCB";
            convertOptionCB.Size = new System.Drawing.Size(106, 23);
            convertOptionCB.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(364, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(167, 21);
            label2.TabIndex = 6;
            label2.Text = "Choose convert option";
            // 
            // MediaConverter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(convertOptionCB);
            Controls.Add(clearListBT);
            Controls.Add(label1);
            Controls.Add(filesListView);
            Controls.Add(convertBT);
            Controls.Add(selectFolderBT);
            Name = "MediaConverter";
            Text = "MediaConverter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button selectFolderBT;
        private System.Windows.Forms.Button convertBT;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearListBT;
        private System.Windows.Forms.ComboBox convertOptionCB;
        private System.Windows.Forms.Label label2;
    }
}

