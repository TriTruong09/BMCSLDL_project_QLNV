﻿namespace Quan_ly_NV
{
    partial class frm_crud
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_changepw = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pbl_role = new System.Windows.Forms.Label();
            this.btn_createrole = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rb_lock = new System.Windows.Forms.RadioButton();
            this.rb_unlock = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(107, 28);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Tên đăng nhập";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 34);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 142);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 32);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(107, 113);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(52, 13);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // btn_create
            // 
            this.btn_create.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Location = new System.Drawing.Point(121, 200);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(169, 32);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Tạo tài khoản";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_changepw
            // 
            this.btn_changepw.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_changepw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_changepw.FlatAppearance.BorderSize = 0;
            this.btn_changepw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepw.Location = new System.Drawing.Point(121, 257);
            this.btn_changepw.Name = "btn_changepw";
            this.btn_changepw.Size = new System.Drawing.Size(169, 32);
            this.btn_changepw.TabIndex = 5;
            this.btn_changepw.Text = "Đổi mật khẩu";
            this.btn_changepw.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 346);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 32);
            this.textBox3.TabIndex = 7;
            // 
            // pbl_role
            // 
            this.pbl_role.AutoSize = true;
            this.pbl_role.Location = new System.Drawing.Point(107, 317);
            this.pbl_role.Name = "pbl_role";
            this.pbl_role.Size = new System.Drawing.Size(37, 13);
            this.pbl_role.TabIndex = 6;
            this.pbl_role.Text = "Vai trò";
            // 
            // btn_createrole
            // 
            this.btn_createrole.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_createrole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_createrole.FlatAppearance.BorderSize = 0;
            this.btn_createrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createrole.Location = new System.Drawing.Point(121, 420);
            this.btn_createrole.Name = "btn_createrole";
            this.btn_createrole.Size = new System.Drawing.Size(169, 32);
            this.btn_createrole.TabIndex = 8;
            this.btn_createrole.Text = "Tạo vai trò";
            this.btn_createrole.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btn_remove
            // 
            this.btn_remove.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Location = new System.Drawing.Point(443, 164);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(169, 32);
            this.btn_remove.TabIndex = 10;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Location = new System.Drawing.Point(443, 352);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(169, 32);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Gửi";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(431, 240);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // rb_lock
            // 
            this.rb_lock.AutoSize = true;
            this.rb_lock.Location = new System.Drawing.Point(454, 308);
            this.rb_lock.Name = "rb_lock";
            this.rb_lock.Size = new System.Drawing.Size(50, 17);
            this.rb_lock.TabIndex = 13;
            this.rb_lock.TabStop = true;
            this.rb_lock.Text = "Khóa";
            this.rb_lock.UseVisualStyleBackColor = true;
            // 
            // rb_unlock
            // 
            this.rb_unlock.AutoSize = true;
            this.rb_unlock.Location = new System.Drawing.Point(556, 308);
            this.rb_unlock.Name = "rb_unlock";
            this.rb_unlock.Size = new System.Drawing.Size(67, 17);
            this.rb_unlock.TabIndex = 14;
            this.rb_unlock.TabStop = true;
            this.rb_unlock.Text = "Mở khóa";
            this.rb_unlock.UseVisualStyleBackColor = true;
            // 
            // frm_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 537);
            this.Controls.Add(this.rb_unlock);
            this.Controls.Add(this.rb_lock);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_createrole);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pbl_role);
            this.Controls.Add(this.btn_changepw);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_username);
            this.Name = "frm_crud";
            this.Text = "frm_crud";
            this.Load += new System.EventHandler(this.frm_crud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_changepw;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label pbl_role;
        private System.Windows.Forms.Button btn_createrole;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rb_lock;
        private System.Windows.Forms.RadioButton rb_unlock;
    }
}