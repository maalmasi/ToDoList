namespace ToDoList
{
    partial class ToDoListForm
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
            this.ClbItems = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ClbItems
            // 
            this.ClbItems.CheckOnClick = true;
            this.ClbItems.FormattingEnabled = true;
            this.ClbItems.Location = new System.Drawing.Point(12, 12);
            this.ClbItems.Name = "ClbItems";
            this.ClbItems.Size = new System.Drawing.Size(298, 19);
            this.ClbItems.TabIndex = 0;
            this.ClbItems.Click += new System.EventHandler(this.ClbItems_Click);
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 27);
            this.Controls.Add(this.ClbItems);
            this.Name = "ToDoListForm";
            this.Text = "ToDoListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbItems;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}