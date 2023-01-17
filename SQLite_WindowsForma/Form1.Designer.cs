
namespace SQLite_WindowsForma
{
    partial class Form1
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
            this.dgvTabella = new System.Windows.Forms.DataGridView();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.DB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileQuery = new System.Windows.Forms.TextBox();
            this.btnFileQuery = new System.Windows.Forms.Button();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabella)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabella
            // 
            this.dgvTabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabella.Location = new System.Drawing.Point(12, 151);
            this.dgvTabella.Name = "dgvTabella";
            this.dgvTabella.RowHeadersWidth = 51;
            this.dgvTabella.RowTemplate.Height = 29;
            this.dgvTabella.Size = new System.Drawing.Size(1282, 287);
            this.dgvTabella.TabIndex = 0;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(82, 48);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(410, 27);
            this.txtDB.TabIndex = 1;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(82, 99);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(410, 27);
            this.txtQuery.TabIndex = 2;
            // 
            // DB
            // 
            this.DB.AutoSize = true;
            this.DB.Location = new System.Drawing.Point(26, 51);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(29, 20);
            this.DB.TabIndex = 3;
            this.DB.Text = "DB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Query";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(498, 46);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(94, 29);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(498, 99);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(94, 29);
            this.btnEsegui.TabIndex = 6;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleziona query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "File con query";
            // 
            // txtFileQuery
            // 
            this.txtFileQuery.Location = new System.Drawing.Point(767, 50);
            this.txtFileQuery.Name = "txtFileQuery";
            this.txtFileQuery.Size = new System.Drawing.Size(410, 27);
            this.txtFileQuery.TabIndex = 9;
            // 
            // btnFileQuery
            // 
            this.btnFileQuery.Location = new System.Drawing.Point(1183, 50);
            this.btnFileQuery.Name = "btnFileQuery";
            this.btnFileQuery.Size = new System.Drawing.Size(94, 29);
            this.btnFileQuery.TabIndex = 10;
            this.btnFileQuery.Text = "...";
            this.btnFileQuery.UseVisualStyleBackColor = true;
            this.btnFileQuery.Click += new System.EventHandler(this.btnFileQuery_Click);
            // 
            // cmbQuery
            // 
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Location = new System.Drawing.Point(767, 91);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(510, 28);
            this.cmbQuery.TabIndex = 11;
            this.cmbQuery.SelectedIndexChanged += new System.EventHandler(this.cmbQuery_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.cmbQuery);
            this.Controls.Add(this.btnFileQuery);
            this.Controls.Add(this.txtFileQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DB);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.dgvTabella);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabella;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label DB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileQuery;
        private System.Windows.Forms.Button btnFileQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
    }
}

