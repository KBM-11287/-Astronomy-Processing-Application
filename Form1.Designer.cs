namespace Neutrino_Astronomy_Processing
{
    partial class FrmAstroProcessing
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
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.lblInteractions = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(34, 62);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(248, 20);
            this.txtBxInput.TabIndex = 0;
            // 
            // lblInteractions
            // 
            this.lblInteractions.AutoSize = true;
            this.lblInteractions.Location = new System.Drawing.Point(31, 46);
            this.lblInteractions.Name = "lblInteractions";
            this.lblInteractions.Size = new System.Drawing.Size(105, 13);
            this.lblInteractions.TabIndex = 1;
            this.lblInteractions.Text = "Neutrino Interactions";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(34, 111);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(248, 173);
            this.listBoxOutput.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(328, 185);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(102, 23);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(328, 111);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(102, 23);
            this.BtnSort.TabIndex = 10;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(180, 318);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 23);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(328, 261);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(34, 320);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIndex.TabIndex = 14;
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(34, 381);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewValue.TabIndex = 15;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(34, 301);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(33, 13);
            this.lblIndex.TabIndex = 16;
            this.lblIndex.Text = "Index";
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Location = new System.Drawing.Point(34, 362);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(59, 13);
            this.lblNewValue.TabIndex = 17;
            this.lblNewValue.Text = "New Value";
            // 
            // FrmAstroProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.lblInteractions);
            this.Controls.Add(this.txtBxInput);
            this.Name = "FrmAstroProcessing";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Label lblInteractions;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblNewValue;
    }
}

