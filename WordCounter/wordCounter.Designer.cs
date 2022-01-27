namespace WordCounter
{
    partial class wordCounter
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.rbtnWords = new System.Windows.Forms.RadioButton();
            this.rbtnCount = new System.Windows.Forms.RadioButton();
            this.rbtnAscending = new System.Windows.Forms.RadioButton();
            this.rbtnDescending = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(196, 427);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Open";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            this.btnBrowse.MouseHover += new System.EventHandler(this.BtnBrowse_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.BtnSave_MouseHover);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Count});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 349);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 190;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 90;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAs.Location = new System.Drawing.Point(85, 427);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(66, 28);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save As..";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            this.btnSaveAs.MouseHover += new System.EventHandler(this.BtnSaveAs_MouseHover);
            // 
            // rbtnWords
            // 
            this.rbtnWords.AutoSize = true;
            this.rbtnWords.Location = new System.Drawing.Point(6, 0);
            this.rbtnWords.Name = "rbtnWords";
            this.rbtnWords.Size = new System.Drawing.Size(56, 17);
            this.rbtnWords.TabIndex = 5;
            this.rbtnWords.TabStop = true;
            this.rbtnWords.Text = "Words";
            this.rbtnWords.UseVisualStyleBackColor = true;
            this.rbtnWords.Click += new System.EventHandler(this.RbtnWords_Click);
            // 
            // rbtnCount
            // 
            this.rbtnCount.AutoCheck = false;
            this.rbtnCount.AutoSize = true;
            this.rbtnCount.Location = new System.Drawing.Point(6, 21);
            this.rbtnCount.Name = "rbtnCount";
            this.rbtnCount.Size = new System.Drawing.Size(53, 17);
            this.rbtnCount.TabIndex = 6;
            this.rbtnCount.TabStop = true;
            this.rbtnCount.Text = "Count";
            this.rbtnCount.UseVisualStyleBackColor = true;
            this.rbtnCount.Click += new System.EventHandler(this.RbtnCount_Click);
            // 
            // rbtnAscending
            // 
            this.rbtnAscending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnAscending.AutoSize = true;
            this.rbtnAscending.Location = new System.Drawing.Point(6, 0);
            this.rbtnAscending.Name = "rbtnAscending";
            this.rbtnAscending.Size = new System.Drawing.Size(75, 17);
            this.rbtnAscending.TabIndex = 7;
            this.rbtnAscending.TabStop = true;
            this.rbtnAscending.Text = "Ascending";
            this.rbtnAscending.UseVisualStyleBackColor = true;
            this.rbtnAscending.Click += new System.EventHandler(this.RbtnAscending_Click);
            // 
            // rbtnDescending
            // 
            this.rbtnDescending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnDescending.AutoCheck = false;
            this.rbtnDescending.AutoSize = true;
            this.rbtnDescending.Location = new System.Drawing.Point(6, 23);
            this.rbtnDescending.Name = "rbtnDescending";
            this.rbtnDescending.Size = new System.Drawing.Size(82, 17);
            this.rbtnDescending.TabIndex = 8;
            this.rbtnDescending.TabStop = true;
            this.rbtnDescending.Text = "Descending";
            this.rbtnDescending.UseVisualStyleBackColor = true;
            this.rbtnDescending.Click += new System.EventHandler(this.RbtnDescending_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.Location = new System.Drawing.Point(221, 26);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 40);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(23, 7);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(43, 13);
            this.lblSortBy.TabIndex = 10;
            this.lblSortBy.Text = "Sort by:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnWords);
            this.groupBox1.Controls.Add(this.rbtnCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(67, 44);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAscending);
            this.groupBox2.Controls.Add(this.rbtnDescending);
            this.groupBox2.Location = new System.Drawing.Point(85, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 44);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // wordCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Name = "wordCounter";
            this.Text = "Word Counter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.RadioButton rbtnWords;
        private System.Windows.Forms.RadioButton rbtnCount;
        private System.Windows.Forms.RadioButton rbtnAscending;
        private System.Windows.Forms.RadioButton rbtnDescending;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

