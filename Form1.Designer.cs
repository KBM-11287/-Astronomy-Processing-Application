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
            this.grpBoxTools = new System.Windows.Forms.GroupBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.rdbSort = new System.Windows.Forms.RadioButton();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.rdBtnEdit = new System.Windows.Forms.RadioButton();
            this.grpBoxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(328, 59);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBxInput.TabIndex = 0;
            // 
            // lblInteractions
            // 
            this.lblInteractions.AutoSize = true;
            this.lblInteractions.Location = new System.Drawing.Point(325, 34);
            this.lblInteractions.Name = "lblInteractions";
            this.lblInteractions.Size = new System.Drawing.Size(105, 13);
            this.lblInteractions.TabIndex = 1;
            this.lblInteractions.Text = "Neutrino Interactions";
            // 
            // grpBoxTools
            // 
            this.grpBoxTools.Controls.Add(this.rdBtnEdit);
            this.grpBoxTools.Controls.Add(this.rdbSort);
            this.grpBoxTools.Controls.Add(this.rdbSearch);
            this.grpBoxTools.Location = new System.Drawing.Point(298, 98);
            this.grpBoxTools.Name = "grpBoxTools";
            this.grpBoxTools.Size = new System.Drawing.Size(155, 110);
            this.grpBoxTools.TabIndex = 2;
            this.grpBoxTools.TabStop = false;
            this.grpBoxTools.Text = "groupBoxTools";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(328, 230);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(100, 23);
            this.BtnRun.TabIndex = 8;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            // 
            // rdbSort
            // 
            this.rdbSort.AutoSize = true;
            this.rdbSort.Location = new System.Drawing.Point(30, 42);
            this.rdbSort.Name = "rdbSort";
            this.rdbSort.Size = new System.Drawing.Size(44, 17);
            this.rdbSort.TabIndex = 1;
            this.rdbSort.TabStop = true;
            this.rdbSort.Text = "Sort";
            this.rdbSort.UseVisualStyleBackColor = true;
            this.rdbSort.CheckedChanged += new System.EventHandler(this.rdbSort_CheckedChanged);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Location = new System.Drawing.Point(30, 19);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(59, 17);
            this.rdbSearch.TabIndex = 0;
            this.rdbSearch.TabStop = true;
            this.rdbSearch.Text = "Search";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(34, 59);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(200, 368);
            this.listBoxOutput.TabIndex = 4;
            // 
            // rdBtnEdit
            // 
            this.rdBtnEdit.AutoSize = true;
            this.rdBtnEdit.Location = new System.Drawing.Point(31, 65);
            this.rdBtnEdit.Name = "rdBtnEdit";
            this.rdBtnEdit.Size = new System.Drawing.Size(43, 17);
            this.rdBtnEdit.TabIndex = 9;
            this.rdBtnEdit.TabStop = true;
            this.rdBtnEdit.Text = "Edit";
            this.rdBtnEdit.UseVisualStyleBackColor = true;
            // 
            // FrmAstroProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.grpBoxTools);
            this.Controls.Add(this.lblInteractions);
            this.Controls.Add(this.txtBxInput);
            this.Name = "FrmAstroProcessing";
            this.Text = "Astronomical Processing";
            this.grpBoxTools.ResumeLayout(false);
            this.grpBoxTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Label lblInteractions;
        private System.Windows.Forms.GroupBox grpBoxTools;
        private System.Windows.Forms.RadioButton rdbSort;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.RadioButton rdBtnEdit;
    }
}

