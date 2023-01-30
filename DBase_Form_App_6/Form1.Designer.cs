namespace DBase_Form_App_6
{
    partial class frmDBase
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
            this.btnDBaseConnect = new System.Windows.Forms.Button();
            this.rtbSQL = new System.Windows.Forms.RichTextBox();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.btnSQL = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbSQLExamples = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDBaseConnect
            // 
            this.btnDBaseConnect.Location = new System.Drawing.Point(12, 12);
            this.btnDBaseConnect.Name = "btnDBaseConnect";
            this.btnDBaseConnect.Size = new System.Drawing.Size(103, 23);
            this.btnDBaseConnect.TabIndex = 0;
            this.btnDBaseConnect.Text = "DBase Connect";
            this.btnDBaseConnect.UseVisualStyleBackColor = true;
            this.btnDBaseConnect.Click += new System.EventHandler(this.btnDBaseConnect_Click);
            // 
            // rtbSQL
            // 
            this.rtbSQL.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbSQL.Location = new System.Drawing.Point(12, 41);
            this.rtbSQL.Name = "rtbSQL";
            this.rtbSQL.Size = new System.Drawing.Size(776, 120);
            this.rtbSQL.TabIndex = 1;
            this.rtbSQL.Text = "SELECT * FROM tblPerson;";
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSet.Location = new System.Drawing.Point(12, 194);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowTemplate.Height = 25;
            this.dgvDataSet.Size = new System.Drawing.Size(776, 244);
            this.dgvDataSet.TabIndex = 2;
            this.dgvDataSet.DoubleClick += new System.EventHandler(this.dgvDataSet_DoubleClick);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(164, 12);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(75, 23);
            this.btnSQL.TabIndex = 3;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Peru;
            this.lblTitle.Location = new System.Drawing.Point(12, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 15);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "SQL Examples";
            // 
            // rtbSQLExamples
            // 
            this.rtbSQLExamples.BackColor = System.Drawing.Color.PapayaWhip;
            this.rtbSQLExamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSQLExamples.Location = new System.Drawing.Point(12, 30);
            this.rtbSQLExamples.Name = "rtbSQLExamples";
            this.rtbSQLExamples.Size = new System.Drawing.Size(280, 397);
            this.rtbSQLExamples.TabIndex = 5;
            this.rtbSQLExamples.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtbSQLExamples);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(795, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 438);
            this.panel1.TabIndex = 6;
            // 
            // frmDBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.dgvDataSet);
            this.Controls.Add(this.rtbSQL);
            this.Controls.Add(this.btnDBaseConnect);
            this.Name = "frmDBase";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.frmDBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDBaseConnect;
        private RichTextBox rtbSQL;
        private DataGridView dgvDataSet;
        private Button btnSQL;
        private Label lblTitle;
        private RichTextBox rtbSQLExamples;
        private Panel panel1;
    }
}