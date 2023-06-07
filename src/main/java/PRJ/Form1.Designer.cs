namespace PRJ
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCate = new System.Windows.Forms.TabPage();
            this.tbCateId = new System.Windows.Forms.TextBox();
            this.btnDeleteCate = new System.Windows.Forms.Button();
            this.btnSaveCate = new System.Windows.Forms.Button();
            this.btnEditCate = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.lbCateName = new System.Windows.Forms.Label();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.tbStu = new System.Windows.Forms.TabPage();
            this.tbStuId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStuCateId = new System.Windows.Forms.ComboBox();
            this.lbStuCateId = new System.Windows.Forms.Label();
            this.btnDeleteStu = new System.Windows.Forms.Button();
            this.btnEditStu = new System.Windows.Forms.Button();
            this.btnSaveStu = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.tbStuClass = new System.Windows.Forms.TextBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.lbStuClass = new System.Windows.Forms.Label();
            this.lbStuName = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tbStu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCate);
            this.tabControl1.Controls.Add(this.tbStu);
            this.tabControl1.Location = new System.Drawing.Point(-1, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCate
            // 
            this.tpCate.Controls.Add(this.tbCateId);
            this.tpCate.Controls.Add(this.btnDeleteCate);
            this.tpCate.Controls.Add(this.btnSaveCate);
            this.tpCate.Controls.Add(this.btnEditCate);
            this.tpCate.Controls.Add(this.btnAddCate);
            this.tpCate.Controls.Add(this.dgvCategory);
            this.tpCate.Controls.Add(this.lbCateName);
            this.tpCate.Controls.Add(this.tbCateName);
            this.tpCate.Location = new System.Drawing.Point(4, 25);
            this.tpCate.Name = "tpCate";
            this.tpCate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCate.Size = new System.Drawing.Size(795, 392);
            this.tpCate.TabIndex = 0;
            this.tpCate.Text = "Danh Mục";
            this.tpCate.UseVisualStyleBackColor = true;
            // 
            // tbCateId
            // 
            this.tbCateId.Location = new System.Drawing.Point(0, 0);
            this.tbCateId.Name = "tbCateId";
            this.tbCateId.Size = new System.Drawing.Size(10, 22);
            this.tbCateId.TabIndex = 9;
            this.tbCateId.Visible = false;
            // 
            // btnDeleteCate
            // 
            this.btnDeleteCate.Enabled = false;
            this.btnDeleteCate.Location = new System.Drawing.Point(579, 75);
            this.btnDeleteCate.Name = "btnDeleteCate";
            this.btnDeleteCate.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCate.TabIndex = 8;
            this.btnDeleteCate.Text = "Xóa";
            this.btnDeleteCate.UseVisualStyleBackColor = true;
            this.btnDeleteCate.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnSaveCate
            // 
            this.btnSaveCate.Enabled = false;
            this.btnSaveCate.Location = new System.Drawing.Point(579, 24);
            this.btnSaveCate.Name = "btnSaveCate";
            this.btnSaveCate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCate.TabIndex = 7;
            this.btnSaveCate.Text = "Lưu";
            this.btnSaveCate.UseVisualStyleBackColor = true;
            this.btnSaveCate.Click += new System.EventHandler(this.btnSaveCate_Click);
            // 
            // btnEditCate
            // 
            this.btnEditCate.Enabled = false;
            this.btnEditCate.Location = new System.Drawing.Point(432, 75);
            this.btnEditCate.Name = "btnEditCate";
            this.btnEditCate.Size = new System.Drawing.Size(75, 23);
            this.btnEditCate.TabIndex = 6;
            this.btnEditCate.Text = "Sửa ";
            this.btnEditCate.UseVisualStyleBackColor = true;
            this.btnEditCate.Click += new System.EventHandler(this.btnEditCate_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(432, 24);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(75, 23);
            this.btnAddCate.TabIndex = 5;
            this.btnAddCate.Text = "Thêm ";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(1, 148);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(787, 272);
            this.dgvCategory.TabIndex = 4;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickCate);
            // 
            // lbCateName
            // 
            this.lbCateName.Enabled = false;
            this.lbCateName.Location = new System.Drawing.Point(20, 60);
            this.lbCateName.Name = "lbCateName";
            this.lbCateName.Size = new System.Drawing.Size(113, 23);
            this.lbCateName.TabIndex = 3;
            this.lbCateName.Text = "Tên đội tuyển :";
            // 
            // tbCateName
            // 
            this.tbCateName.Location = new System.Drawing.Point(162, 60);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(166, 22);
            this.tbCateName.TabIndex = 1;
            // 
            // tbStu
            // 
            this.tbStu.Controls.Add(this.tbStuId);
            this.tbStu.Controls.Add(this.btnSearch);
            this.tbStu.Controls.Add(this.tbSearch);
            this.tbStu.Controls.Add(this.label5);
            this.tbStu.Controls.Add(this.cbStuCateId);
            this.tbStu.Controls.Add(this.lbStuCateId);
            this.tbStu.Controls.Add(this.btnDeleteStu);
            this.tbStu.Controls.Add(this.btnEditStu);
            this.tbStu.Controls.Add(this.btnSaveStu);
            this.tbStu.Controls.Add(this.btnAddStu);
            this.tbStu.Controls.Add(this.tbStuClass);
            this.tbStu.Controls.Add(this.tbStuName);
            this.tbStu.Controls.Add(this.lbStuClass);
            this.tbStu.Controls.Add(this.lbStuName);
            this.tbStu.Controls.Add(this.dgvStudent);
            this.tbStu.Location = new System.Drawing.Point(4, 25);
            this.tbStu.Name = "tbStu";
            this.tbStu.Padding = new System.Windows.Forms.Padding(3);
            this.tbStu.Size = new System.Drawing.Size(795, 392);
            this.tbStu.TabIndex = 1;
            this.tbStu.Text = "Sinh Viên";
            this.tbStu.UseVisualStyleBackColor = true;
            // 
            // tbStuId
            // 
            this.tbStuId.Location = new System.Drawing.Point(1, 0);
            this.tbStuId.Name = "tbStuId";
            this.tbStuId.Size = new System.Drawing.Size(10, 22);
            this.tbStuId.TabIndex = 15;
            this.tbStuId.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(170, 123);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(211, 22);
            this.tbSearch.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(20, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm kiếm sinh viên :";
            // 
            // cbStuCateId
            // 
            this.cbStuCateId.FormattingEnabled = true;
            this.cbStuCateId.Location = new System.Drawing.Point(170, 81);
            this.cbStuCateId.Name = "cbStuCateId";
            this.cbStuCateId.Size = new System.Drawing.Size(121, 24);
            this.cbStuCateId.TabIndex = 11;
            // 
            // lbStuCateId
            // 
            this.lbStuCateId.Enabled = false;
            this.lbStuCateId.Location = new System.Drawing.Point(20, 81);
            this.lbStuCateId.Name = "lbStuCateId";
            this.lbStuCateId.Size = new System.Drawing.Size(100, 23);
            this.lbStuCateId.TabIndex = 10;
            this.lbStuCateId.Text = "Tên đội tuyển : ";
            // 
            // btnDeleteStu
            // 
            this.btnDeleteStu.Enabled = false;
            this.btnDeleteStu.Location = new System.Drawing.Point(554, 78);
            this.btnDeleteStu.Name = "btnDeleteStu";
            this.btnDeleteStu.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStu.TabIndex = 9;
            this.btnDeleteStu.Text = "Xóa";
            this.btnDeleteStu.UseVisualStyleBackColor = true;
            this.btnDeleteStu.Click += new System.EventHandler(this.btnDeleteStu_Click);
            // 
            // btnEditStu
            // 
            this.btnEditStu.Enabled = false;
            this.btnEditStu.Location = new System.Drawing.Point(419, 78);
            this.btnEditStu.Name = "btnEditStu";
            this.btnEditStu.Size = new System.Drawing.Size(75, 23);
            this.btnEditStu.TabIndex = 8;
            this.btnEditStu.Text = "Sửa";
            this.btnEditStu.UseVisualStyleBackColor = true;
            this.btnEditStu.Click += new System.EventHandler(this.btnEditStu_Click);
            // 
            // btnSaveStu
            // 
            this.btnSaveStu.Enabled = false;
            this.btnSaveStu.Location = new System.Drawing.Point(554, 23);
            this.btnSaveStu.Name = "btnSaveStu";
            this.btnSaveStu.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStu.TabIndex = 7;
            this.btnSaveStu.Text = "Lưu";
            this.btnSaveStu.UseVisualStyleBackColor = true;
            this.btnSaveStu.Click += new System.EventHandler(this.btnSaveStu_Click);
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(419, 23);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(75, 23);
            this.btnAddStu.TabIndex = 6;
            this.btnAddStu.Text = "Thêm ";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // tbStuClass
            // 
            this.tbStuClass.Location = new System.Drawing.Point(170, 49);
            this.tbStuClass.Name = "tbStuClass";
            this.tbStuClass.Size = new System.Drawing.Size(100, 22);
            this.tbStuClass.TabIndex = 5;
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(170, 11);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(211, 22);
            this.tbStuName.TabIndex = 4;
            // 
            // lbStuClass
            // 
            this.lbStuClass.Enabled = false;
            this.lbStuClass.Location = new System.Drawing.Point(20, 48);
            this.lbStuClass.Name = "lbStuClass";
            this.lbStuClass.Size = new System.Drawing.Size(100, 23);
            this.lbStuClass.TabIndex = 2;
            this.lbStuClass.Text = "Lớp : ";
            // 
            // lbStuName
            // 
            this.lbStuName.Enabled = false;
            this.lbStuName.Location = new System.Drawing.Point(20, 14);
            this.lbStuName.Name = "lbStuName";
            this.lbStuName.Size = new System.Drawing.Size(108, 23);
            this.lbStuName.TabIndex = 1;
            this.lbStuName.Text = "Tên sinh viên : ";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(1, 163);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(788, 258);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickStu);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(-1, -1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(95, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(90, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCate.ResumeLayout(false);
            this.tpCate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tbStu.ResumeLayout(false);
            this.tbStu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.TextBox tbStuId;

        private System.Windows.Forms.TextBox tbCateId;

        private System.Windows.Forms.Button btnDeleteCate;

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ComboBox cbStuCateId;

        private System.Windows.Forms.Label lbStuCateId;

        private System.Windows.Forms.TextBox tbStuClass;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnSaveStu;
        private System.Windows.Forms.Button btnDeleteStu;
        private System.Windows.Forms.Button btnEditStu;

        private System.Windows.Forms.Label lbStuClass;

        private System.Windows.Forms.DataGridView dgvStudent;

        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button btnEditCate;
        private System.Windows.Forms.Button btnSaveCate;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.TabPage tpCate;

        private System.Windows.Forms.DataGridView dgvCategory;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbStu;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.TextBox tbCateName;
        private System.Windows.Forms.Label lbStuName;
        private System.Windows.Forms.Label lbCateName;

        #endregion
    }
}