namespace DemoWindowForm
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lbFullname = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbRePassword = new System.Windows.Forms.Label();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.lbAddess = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(574, 460);
            this.dgvUser.TabIndex = 0;
            // 
            // lbFullname
            // 
            this.lbFullname.Enabled = false;
            this.lbFullname.Location = new System.Drawing.Point(580, 0);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(100, 23);
            this.lbFullname.TabIndex = 1;
            this.lbFullname.Text = "Fulname";
            // 
            // tbFullname
            // 
            this.tbFullname.Enabled = false;
            this.tbFullname.Location = new System.Drawing.Point(580, 26);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(208, 22);
            this.tbFullname.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.Enabled = false;
            this.lbUsername.Location = new System.Drawing.Point(580, 51);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(100, 23);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(580, 77);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(208, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.Enabled = false;
            this.lbPassword.Location = new System.Drawing.Point(580, 102);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 23);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(580, 128);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(208, 22);
            this.tbPassword.TabIndex = 6;
            // 
            // lbRePassword
            // 
            this.lbRePassword.Enabled = false;
            this.lbRePassword.Location = new System.Drawing.Point(580, 153);
            this.lbRePassword.Name = "lbRePassword";
            this.lbRePassword.Size = new System.Drawing.Size(100, 23);
            this.lbRePassword.TabIndex = 7;
            this.lbRePassword.Text = "RePassword";
            // 
            // tbRePassword
            // 
            this.tbRePassword.Enabled = false;
            this.tbRePassword.Location = new System.Drawing.Point(580, 179);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.Size = new System.Drawing.Size(208, 22);
            this.tbRePassword.TabIndex = 8;
            // 
            // lbAddess
            // 
            this.lbAddess.Enabled = false;
            this.lbAddess.Location = new System.Drawing.Point(580, 204);
            this.lbAddess.Name = "lbAddess";
            this.lbAddess.Size = new System.Drawing.Size(100, 23);
            this.lbAddess.TabIndex = 9;
            this.lbAddess.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(580, 230);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(208, 22);
            this.tbAddress.TabIndex = 10;
            // 
            // lbPhone
            // 
            this.lbPhone.Enabled = false;
            this.lbPhone.Location = new System.Drawing.Point(580, 255);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(100, 23);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Enabled = false;
            this.tbPhone.Location = new System.Drawing.Point(580, 281);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(208, 22);
            this.tbPhone.TabIndex = 12;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(580, 309);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 13;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(713, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(580, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(713, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddess);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.lbRePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.dgvUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbRePassword;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Label lbAddess;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.TextBox tbFullname;

        private System.Windows.Forms.DataGridView dgvUser;

        #endregion
    }
}