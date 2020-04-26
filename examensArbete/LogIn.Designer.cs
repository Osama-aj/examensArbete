namespace examensArbete
{
    partial class LogIn
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
            this.btnSignUpInLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.tbEmailLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUpInLogin
            // 
            this.btnSignUpInLogin.Location = new System.Drawing.Point(102, 225);
            this.btnSignUpInLogin.Name = "btnSignUpInLogin";
            this.btnSignUpInLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpInLogin.TabIndex = 11;
            this.btnSignUpInLogin.Text = "Bli Medlem";
            this.btnSignUpInLogin.UseVisualStyleBackColor = true;
            this.btnSignUpInLogin.Click += new System.EventHandler(this.btnSignUpInLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(113, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Logga in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(120, 85);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordLogin.TabIndex = 9;
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.Location = new System.Drawing.Point(120, 54);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(100, 20);
            this.tbEmailLogin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lösenord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-postadress";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 357);
            this.Controls.Add(this.btnSignUpInLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbEmailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Logga in";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.FormClosing +=
    new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUpInLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.TextBox tbEmailLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

