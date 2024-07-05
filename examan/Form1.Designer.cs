namespace examan
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_connect = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.Txt_login = new System.Windows.Forms.TextBox();
            this.Txt_pwd = new System.Windows.Forms.TextBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(214, 222);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(158, 46);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(60, 75);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(68, 33);
            this.login.TabIndex = 1;
            this.login.Text = "login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(60, 148);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(154, 33);
            this.pwd.TabIndex = 2;
            this.pwd.Text = "mot de passe";
            this.pwd.Click += new System.EventHandler(this.pwd_Click);
            // 
            // Txt_login
            // 
            this.Txt_login.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_login.Location = new System.Drawing.Point(258, 75);
            this.Txt_login.Name = "Txt_login";
            this.Txt_login.Size = new System.Drawing.Size(157, 37);
            this.Txt_login.TabIndex = 3;
            this.Txt_login.TextChanged += new System.EventHandler(this.Txt_login_TextChanged);
            // 
            // Txt_pwd
            // 
            this.Txt_pwd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pwd.Location = new System.Drawing.Point(258, 144);
            this.Txt_pwd.Name = "Txt_pwd";
            this.Txt_pwd.Size = new System.Drawing.Size(157, 37);
            this.Txt_pwd.TabIndex = 4;
            this.Txt_pwd.TextChanged += new System.EventHandler(this.Txt_pwd_TextChanged);
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F);
            this.bt_exit.Location = new System.Drawing.Point(417, 295);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(107, 42);
            this.bt_exit.TabIndex = 5;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 359);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.Txt_pwd);
            this.Controls.Add(this.Txt_login);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.login);
            this.Controls.Add(this.bt_connect);
            this.Name = "frmLogin";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox Txt_login;
        private System.Windows.Forms.TextBox Txt_pwd;
        private System.Windows.Forms.Button bt_exit;
    }
}

