namespace PMW3Practice
{
    partial class FileSelectionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFile1 = new System.Windows.Forms.ComboBox();
            this.cmbFile2 = new System.Windows.Forms.ComboBox();
            this.cmbFile3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.40845F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFile2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFile3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 78);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "File 3:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File 2:";
            // 
            // cmbFile1
            // 
            this.cmbFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFile1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFile1.FormattingEnabled = true;
            this.cmbFile1.Location = new System.Drawing.Point(70, 3);
            this.cmbFile1.Name = "cmbFile1";
            this.cmbFile1.Size = new System.Drawing.Size(211, 21);
            this.cmbFile1.TabIndex = 0;
            this.cmbFile1.SelectedIndexChanged += new System.EventHandler(this.cmbFile1_SelectedIndexChanged);
            // 
            // cmbFile2
            // 
            this.cmbFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFile2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFile2.FormattingEnabled = true;
            this.cmbFile2.Location = new System.Drawing.Point(70, 29);
            this.cmbFile2.Name = "cmbFile2";
            this.cmbFile2.Size = new System.Drawing.Size(211, 21);
            this.cmbFile2.TabIndex = 1;
            this.cmbFile2.SelectedIndexChanged += new System.EventHandler(this.cmbFile2_SelectedIndexChanged);
            // 
            // cmbFile3
            // 
            this.cmbFile3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFile3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFile3.FormattingEnabled = true;
            this.cmbFile3.Location = new System.Drawing.Point(70, 55);
            this.cmbFile3.Name = "cmbFile3";
            this.cmbFile3.Size = new System.Drawing.Size(211, 21);
            this.cmbFile3.TabIndex = 2;
            this.cmbFile3.SelectedIndexChanged += new System.EventHandler(this.cmbFile3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File 1:";
            // 
            // FileSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 78);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FileSelectionForm";
            this.Text = "PMW3 Practice Files";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFile1;
        private System.Windows.Forms.ComboBox cmbFile2;
        private System.Windows.Forms.ComboBox cmbFile3;
        private System.Windows.Forms.Label label1;
    }
}

