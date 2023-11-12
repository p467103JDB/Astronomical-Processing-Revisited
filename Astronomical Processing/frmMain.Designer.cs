namespace Astronomical_Processing
{
    partial class frmMain
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
            btnEdit = new Button();
            btnSearch = new Button();
            btnSort = new Button();
            listBox = new ListBox();
            textBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(94, 442);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 33);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(211, 442);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 33);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(328, 442);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(111, 33);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(94, 97);
            listBox.Name = "listBox";
            listBox.Size = new Size(345, 229);
            listBox.TabIndex = 3;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(94, 365);
            textBox.Name = "textBox";
            textBox.Size = new Size(345, 31);
            textBox.TabIndex = 4;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 548);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 594);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(listBox);
            Controls.Add(btnSort);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Name = "frmMain";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnSearch;
        private Button btnSort;
        private Label label1;
        public ListBox listBox;
        public TextBox textBox;
    }
}