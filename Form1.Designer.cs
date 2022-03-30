namespace Prac_SAC_Task_3
{
    partial class Form1
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
            this.dgvTask3Shop = new System.Windows.Forms.DataGridView();
            this.comSubject = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask3Shop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTask3Shop
            // 
            this.dgvTask3Shop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask3Shop.Location = new System.Drawing.Point(26, 201);
            this.dgvTask3Shop.Name = "dgvTask3Shop";
            this.dgvTask3Shop.RowHeadersWidth = 51;
            this.dgvTask3Shop.RowTemplate.Height = 24;
            this.dgvTask3Shop.Size = new System.Drawing.Size(1120, 237);
            this.dgvTask3Shop.TabIndex = 0;
            this.dgvTask3Shop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comSubject
            // 
            this.comSubject.FormattingEnabled = true;
            this.comSubject.Items.AddRange(new object[] {
            "Rating",
            "Subject",
            "Textbook"});
            this.comSubject.Location = new System.Drawing.Point(522, 75);
            this.comSubject.Name = "comSubject";
            this.comSubject.Size = new System.Drawing.Size(121, 24);
            this.comSubject.TabIndex = 1;
            this.comSubject.SelectedIndexChanged += new System.EventHandler(this.cmboSubject_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(995, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(410, 80);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 16);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter by:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(914, 80);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(26, 70);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(96, 29);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comSubject);
            this.Controls.Add(this.dgvTask3Shop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask3Shop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTask3Shop;
        private System.Windows.Forms.ComboBox comSubject;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

