﻿namespace examensArbete
{
    partial class Register
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
            this.tbRepeatPasswordSignUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.tbPasswordSignUp = new System.Windows.Forms.TextBox();
            this.tbEmailSignup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginInRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRepeatPasswordSignUp
            // 
            this.tbRepeatPasswordSignUp.Location = new System.Drawing.Point(137, 134);
            this.tbRepeatPasswordSignUp.Name = "tbRepeatPasswordSignUp";
            this.tbRepeatPasswordSignUp.PasswordChar = '*';
            this.tbRepeatPasswordSignUp.Size = new System.Drawing.Size(100, 20);
            this.tbRepeatPasswordSignUp.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Repetera Lösenord";
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(106, 188);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 19;
            this.btnSignup.Text = "Bli Medlem";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // tbPasswordSignUp
            // 
            this.tbPasswordSignUp.Location = new System.Drawing.Point(137, 96);
            this.tbPasswordSignUp.Name = "tbPasswordSignUp";
            this.tbPasswordSignUp.PasswordChar = '*';
            this.tbPasswordSignUp.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordSignUp.TabIndex = 18;
            // 
            // tbEmailSignup
            // 
            this.tbEmailSignup.Location = new System.Drawing.Point(137, 65);
            this.tbEmailSignup.Name = "tbEmailSignup";
            this.tbEmailSignup.Size = new System.Drawing.Size(100, 20);
            this.tbEmailSignup.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lösenord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "E-postadress";
            // 
            // btnLoginInRegister
            // 
            this.btnLoginInRegister.Location = new System.Drawing.Point(106, 234);
            this.btnLoginInRegister.Name = "btnLoginInRegister";
            this.btnLoginInRegister.Size = new System.Drawing.Size(75, 23);
            this.btnLoginInRegister.TabIndex = 22;
            this.btnLoginInRegister.Text = "Logga in";
            this.btnLoginInRegister.UseVisualStyleBackColor = true;
            this.btnLoginInRegister.Click += new System.EventHandler(this.btnLoginInRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 357);
            this.Controls.Add(this.btnLoginInRegister);
            this.Controls.Add(this.tbRepeatPasswordSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.tbPasswordSignUp);
            this.Controls.Add(this.tbEmailSignup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Bli Medlem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRepeatPasswordSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox tbPasswordSignUp;
        private System.Windows.Forms.TextBox tbEmailSignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginInRegister;
    }
}