namespace ToDoList
{
    partial class CreateNewListForm
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
            this.LTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbAddItem = new System.Windows.Forms.TextBox();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.LbItems = new System.Windows.Forms.ListBox();
            this.BtnCreateList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(12, 9);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(36, 15);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Title: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddItem);
            this.groupBox1.Controls.Add(this.TbAddItem);
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add items to list";
            // 
            // TbAddItem
            // 
            this.TbAddItem.Location = new System.Drawing.Point(6, 19);
            this.TbAddItem.MaxLength = 40;
            this.TbAddItem.Name = "TbAddItem";
            this.TbAddItem.Size = new System.Drawing.Size(255, 20);
            this.TbAddItem.TabIndex = 0;
            TbAddItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TbEnterKey);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Location = new System.Drawing.Point(6, 45);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(255, 23);
            this.BtnAddItem.TabIndex = 1;
            this.BtnAddItem.Text = "Add item";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // LbItems
            // 
            this.LbItems.FormattingEnabled = true;
            this.LbItems.Location = new System.Drawing.Point(15, 109);
            this.LbItems.Name = "LbItems";
            this.LbItems.Size = new System.Drawing.Size(267, 251);
            this.LbItems.TabIndex = 2;
            // 
            // BtnCreateList
            // 
            this.BtnCreateList.Location = new System.Drawing.Point(15, 366);
            this.BtnCreateList.Name = "BtnCreateList";
            this.BtnCreateList.Size = new System.Drawing.Size(267, 23);
            this.BtnCreateList.TabIndex = 3;
            this.BtnCreateList.Text = "Create list";
            this.BtnCreateList.UseVisualStyleBackColor = true;
            this.BtnCreateList.Click += new System.EventHandler(this.BtnCreateList_Click);
            // 
            // CreateNewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 400);
            this.Controls.Add(this.BtnCreateList);
            this.Controls.Add(this.LbItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LTitle);
            this.Name = "CreateNewListForm";
            this.Text = "CreateNewListForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.TextBox TbAddItem;
        private System.Windows.Forms.ListBox LbItems;
        private System.Windows.Forms.Button BtnCreateList;
    }
}