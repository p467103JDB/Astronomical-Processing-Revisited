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
            components=new System.ComponentModel.Container();
            btnEdit=new Button();
            btnBinarySearch=new Button();
            btnSort=new Button();
            listBox=new ListBox();
            textBox=new TextBox();
            btnLinearSearch=new Button();
            textBoxCalc=new TextBox();
            btnRange=new Button();
            btnMedian=new Button();
            btnMode=new Button();
            btnMean=new Button();
            toolTipMean=new ToolTip(components);
            toolTipMedian=new ToolTip(components);
            toolTipMode=new ToolTip(components);
            toolTipRange=new ToolTip(components);
            toolTipEdit=new ToolTip(components);
            toolTipSort=new ToolTip(components);
            toolTipBSearch=new ToolTip(components);
            toolTipLSearch=new ToolTip(components);
            toolTipInputTextBox=new ToolTip(components);
            toolTipResultTextBox=new ToolTip(components);
            toolTipListBox=new ToolTip(components);
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location=new Point(139, 575);
            btnEdit.Name="btnEdit";
            btnEdit.Size=new Size(86, 33);
            btnEdit.TabIndex=0;
            btnEdit.Text="Edit";
            toolTipEdit.SetToolTip(btnEdit, "Edit selected item from the lis");
            btnEdit.UseVisualStyleBackColor=true;
            btnEdit.Click+=btnEdit_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location=new Point(327, 575);
            btnBinarySearch.Name="btnBinarySearch";
            btnBinarySearch.Size=new Size(129, 33);
            btnBinarySearch.TabIndex=1;
            btnBinarySearch.Text="Binary Search";
            toolTipBSearch.SetToolTip(btnBinarySearch, "Perform a binary search from the user input");
            btnBinarySearch.UseVisualStyleBackColor=true;
            btnBinarySearch.Click+=btnBinarySearch_Click;
            // 
            // btnSort
            // 
            btnSort.Location=new Point(231, 575);
            btnSort.Name="btnSort";
            btnSort.Size=new Size(90, 33);
            btnSort.TabIndex=2;
            btnSort.Text="Sort";
            toolTipSort.SetToolTip(btnSort, "Sort the data in the list");
            btnSort.UseVisualStyleBackColor=true;
            btnSort.Click+=btnSort_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled=true;
            listBox.ItemHeight=25;
            listBox.Location=new Point(139, 87);
            listBox.Name="listBox";
            listBox.Size=new Size(452, 329);
            listBox.TabIndex=3;
            toolTipListBox.SetToolTip(listBox, "Displays list of randomly generated data");
            listBox.SelectedIndexChanged+=listBox_SelectedIndexChanged;
            // 
            // textBox
            // 
            textBox.Location=new Point(139, 514);
            textBox.Name="textBox";
            textBox.Size=new Size(452, 31);
            textBox.TabIndex=4;
            toolTipInputTextBox.SetToolTip(textBox, "Take user's inputs");
            textBox.TextChanged+=textBox_TextChanged;
            // 
            // btnLinearSearch
            // 
            btnLinearSearch.Location=new Point(462, 575);
            btnLinearSearch.Name="btnLinearSearch";
            btnLinearSearch.Size=new Size(129, 33);
            btnLinearSearch.TabIndex=6;
            btnLinearSearch.Text="Linear Search";
            toolTipLSearch.SetToolTip(btnLinearSearch, "Perform a linear search on a selected item from the listbox ");
            btnLinearSearch.UseVisualStyleBackColor=true;
            btnLinearSearch.Click+=BtnLinearSearch_Click;
            // 
            // textBoxCalc
            // 
            textBoxCalc.Location=new Point(139, 703);
            textBoxCalc.Name="textBoxCalc";
            textBoxCalc.Size=new Size(452, 31);
            textBoxCalc.TabIndex=7;
            toolTipResultTextBox.SetToolTip(textBoxCalc, "Display result");
            // 
            // btnRange
            // 
            btnRange.Location=new Point(447, 761);
            btnRange.Name="btnRange";
            btnRange.Size=new Size(96, 33);
            btnRange.TabIndex=11;
            btnRange.Text="Range";
            toolTipRange.SetToolTip(btnRange, "Calculate Range");
            btnRange.UseVisualStyleBackColor=true;
            btnRange.Click+=btnRange_Click;
            // 
            // btnMedian
            // 
            btnMedian.Location=new Point(257, 761);
            btnMedian.Name="btnMedian";
            btnMedian.Size=new Size(90, 33);
            btnMedian.TabIndex=10;
            btnMedian.Text="Median";
            toolTipMedian.SetToolTip(btnMedian, "Calculate Median");
            btnMedian.UseVisualStyleBackColor=true;
            btnMedian.Click+=btnMedian_Click;
            // 
            // btnMode
            // 
            btnMode.Location=new Point(353, 761);
            btnMode.Name="btnMode";
            btnMode.Size=new Size(88, 33);
            btnMode.TabIndex=9;
            btnMode.Text="Mode";
            toolTipMode.SetToolTip(btnMode, "Calculate Mode");
            btnMode.UseVisualStyleBackColor=true;
            btnMode.Click+=btnMode_Click;
            // 
            // btnMean
            // 
            btnMean.Location=new Point(165, 761);
            btnMean.Name="btnMean";
            btnMean.Size=new Size(86, 33);
            btnMean.TabIndex=8;
            btnMean.Text="Mean";
            toolTipMean.SetToolTip(btnMean, "Calculate Mean");
            btnMean.UseVisualStyleBackColor=true;
            btnMean.Click+=btnMean_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(708, 882);
            Controls.Add(btnRange);
            Controls.Add(btnMedian);
            Controls.Add(btnMode);
            Controls.Add(btnMean);
            Controls.Add(textBoxCalc);
            Controls.Add(btnLinearSearch);
            Controls.Add(textBox);
            Controls.Add(listBox);
            Controls.Add(btnSort);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnEdit);
            Name="frmMain";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnBinarySearch;
        private Button btnSort;
        public ListBox listBox;
        public TextBox textBox;
        private Button btnLinearSearch;
        public TextBox textBoxCalc;
        private Button btnRange;
        private Button btnMedian;
        private Button btnMode;
        private Button btnMean;
        private ToolTip toolTipMean;
        private ToolTip toolTipMedian;
        private ToolTip toolTipMode;
        private ToolTip toolTipRange;
        private ToolTip toolTipEdit;
        private ToolTip toolTipSort;
        private ToolTip toolTipBSearch;
        private ToolTip toolTipLSearch;
        private ToolTip toolTipInputTextBox;
        private ToolTip toolTipResultTextBox;
        private ToolTip toolTipListBox;
    }
}