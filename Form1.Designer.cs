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
            this.BtnClear = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
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
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(330, 320);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 23);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(34, 111);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(248, 316);
            this.listBoxOutput.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(328, 111);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(102, 23);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(328, 162);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(102, 23);
            this.BtnSort.TabIndex = 10;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(328, 214);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 23);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(328, 264);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(328, 404);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(102, 23);
            this.BtnQuit.TabIndex = 13;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // FrmAstroProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.BtnClear);
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
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnQuit;
    }
}

