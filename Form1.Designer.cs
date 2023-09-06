namespace Autorizacion
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_login = new System.Windows.Forms.TextBox();
            this.mascktb_pass = new System.Windows.Forms.MaskedTextBox();
            this.l_login = new System.Windows.Forms.Label();
            this.l_pass = new System.Windows.Forms.Label();
            this.b_addUser = new System.Windows.Forms.Button();
            this.l_users = new System.Windows.Forms.Label();
            this.b_testregistr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(73, 53);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(130, 20);
            this.tb_login.TabIndex = 0;
            // 
            // mascktb_pass
            // 
            this.mascktb_pass.Location = new System.Drawing.Point(73, 127);
            this.mascktb_pass.Name = "mascktb_pass";
            this.mascktb_pass.PasswordChar = '*';
            this.mascktb_pass.Size = new System.Drawing.Size(130, 20);
            this.mascktb_pass.TabIndex = 1;
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Location = new System.Drawing.Point(73, 34);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(33, 13);
            this.l_login.TabIndex = 2;
            this.l_login.Text = "Login";
            // 
            // l_pass
            // 
            this.l_pass.AutoSize = true;
            this.l_pass.Location = new System.Drawing.Point(73, 108);
            this.l_pass.Name = "l_pass";
            this.l_pass.Size = new System.Drawing.Size(53, 13);
            this.l_pass.TabIndex = 3;
            this.l_pass.Text = "Password";
            // 
            // b_addUser
            // 
            this.b_addUser.Location = new System.Drawing.Point(73, 185);
            this.b_addUser.Name = "b_addUser";
            this.b_addUser.Size = new System.Drawing.Size(65, 23);
            this.b_addUser.TabIndex = 4;
            this.b_addUser.Text = "Добавить";
            this.b_addUser.UseVisualStyleBackColor = true;
            this.b_addUser.Click += new System.EventHandler(this.b_addUser_Click);
            // 
            // l_users
            // 
            this.l_users.AutoSize = true;
            this.l_users.Location = new System.Drawing.Point(265, 34);
            this.l_users.Name = "l_users";
            this.l_users.Size = new System.Drawing.Size(80, 13);
            this.l_users.TabIndex = 5;
            this.l_users.Text = "Пользователи";
            // 
            // b_testregistr
            // 
            this.b_testregistr.Location = new System.Drawing.Point(138, 185);
            this.b_testregistr.Name = "b_testregistr";
            this.b_testregistr.Size = new System.Drawing.Size(65, 23);
            this.b_testregistr.TabIndex = 4;
            this.b_testregistr.Text = "Проверить";
            this.b_testregistr.UseVisualStyleBackColor = true;
            this.b_testregistr.Click += new System.EventHandler(this.b_testrregistr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 251);
            this.Controls.Add(this.l_users);
            this.Controls.Add(this.b_testregistr);
            this.Controls.Add(this.b_addUser);
            this.Controls.Add(this.l_pass);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.mascktb_pass);
            this.Controls.Add(this.tb_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.MaskedTextBox mascktb_pass;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Label l_pass;
        private System.Windows.Forms.Button b_addUser;
        private System.Windows.Forms.Label l_users;
        private System.Windows.Forms.Button b_testregistr;
    }
}

