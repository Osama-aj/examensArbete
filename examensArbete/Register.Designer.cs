namespace examensArbete
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPasswordLogIn = new System.Windows.Forms.TextBox();
            this.tbEmailLogIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginInRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Bli Medlem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbPasswordLogIn
            // 
            this.tbPasswordLogIn.Location = new System.Drawing.Point(137, 96);
            this.tbPasswordLogIn.Name = "tbPasswordLogIn";
            this.tbPasswordLogIn.PasswordChar = '*';
            this.tbPasswordLogIn.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordLogIn.TabIndex = 18;
            // 
            // tbEmailLogIn
            // 
            this.tbEmailLogIn.Location = new System.Drawing.Point(137, 65);
            this.tbEmailLogIn.Name = "tbEmailLogIn";
            this.tbEmailLogIn.Size = new System.Drawing.Size(100, 20);
            this.tbEmailLogIn.TabIndex = 17;
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
            this.FormClosing +=
    new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 357);
            this.Controls.Add(this.btnLoginInRegister);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbPasswordLogIn);
            this.Controls.Add(this.tbEmailLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Bli Medlem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPasswordLogIn;
        private System.Windows.Forms.TextBox tbEmailLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginInRegister;
    }
}