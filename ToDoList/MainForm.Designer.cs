namespace ToDoList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.BtnCreateList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOpenList = new System.Windows.Forms.Button();
            this.LbExistingLists = new System.Windows.Forms.ListBox();
            this.BtnDeleteList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbTitle);
            this.groupBox1.Controls.Add(this.BtnCreateList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type a title for your new list";
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(6, 45);
            this.TbTitle.MaxLength = 30;
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(188, 20);
            this.TbTitle.TabIndex = 1;
            // 
            // BtnCreateList
            // 
            this.BtnCreateList.Location = new System.Drawing.Point(6, 71);
            this.BtnCreateList.Name = "BtnCreateList";
            this.BtnCreateList.Size = new System.Drawing.Size(188, 23);
            this.BtnCreateList.TabIndex = 0;
            this.BtnCreateList.Text = "New list";
            this.BtnCreateList.UseVisualStyleBackColor = true;
            this.BtnCreateList.Click += new System.EventHandler(this.BtnCreateList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteList);
            this.groupBox2.Controls.Add(this.BtnOpenList);
            this.groupBox2.Controls.Add(this.LbExistingLists);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open existing list";
            // 
            // BtnOpenList
            // 
            this.BtnOpenList.Location = new System.Drawing.Point(6, 276);
            this.BtnOpenList.Name = "BtnOpenList";
            this.BtnOpenList.Size = new System.Drawing.Size(188, 23);
            this.BtnOpenList.TabIndex = 3;
            this.BtnOpenList.Text = "Open list";
            this.BtnOpenList.UseVisualStyleBackColor = true;
            this.BtnOpenList.Click += new System.EventHandler(this.BtnOpenList_Click);
            // 
            // LbExistingLists
            // 
            this.LbExistingLists.FormattingEnabled = true;
            this.LbExistingLists.Location = new System.Drawing.Point(6, 19);
            this.LbExistingLists.Name = "LbExistingLists";
            this.LbExistingLists.Size = new System.Drawing.Size(188, 251);
            this.LbExistingLists.TabIndex = 2;
            // 
            // BtnDeleteList
            // 
            this.BtnDeleteList.Location = new System.Drawing.Point(6, 305);
            this.BtnDeleteList.Name = "BtnDeleteList";
            this.BtnDeleteList.Size = new System.Drawing.Size(188, 23);
            this.BtnDeleteList.TabIndex = 4;
            this.BtnDeleteList.Text = "Delete list";
            this.BtnDeleteList.UseVisualStyleBackColor = true;
            this.BtnDeleteList.Click += new System.EventHandler(this.BtnDeleteList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Button BtnCreateList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOpenList;
        public System.Windows.Forms.ListBox LbExistingLists;
        private System.Windows.Forms.Button BtnDeleteList;
    }
}

