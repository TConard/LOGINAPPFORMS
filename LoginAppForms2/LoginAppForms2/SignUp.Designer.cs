using System.Drawing;
using System.Windows.Forms;

namespace LoginAppForms2
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNewUsername = new TextBox();
            label2 = new Label();
            txtNewPasswords = new TextBox();
            label3 = new Label();
            txtConfirmPasswords = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(81, 40, 136);
            label1.Location = new Point(117, 119);
            label1.Name = "label1";
            label1.Size = new Size(124, 29);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtNewUsername
            // 
            txtNewUsername.BorderStyle = BorderStyle.None;
            txtNewUsername.Location = new Point(117, 151);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(570, 16);
            txtNewUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(81, 40, 136);
            label2.Location = new Point(117, 283);
            label2.Name = "label2";
            label2.Size = new Size(120, 29);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtNewPasswords
            // 
            txtNewPasswords.BorderStyle = BorderStyle.None;
            txtNewPasswords.Location = new Point(117, 315);
            txtNewPasswords.Name = "txtNewPasswords";
            txtNewPasswords.Size = new Size(570, 16);
            txtNewPasswords.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(81, 40, 136);
            label3.Location = new Point(117, 448);
            label3.Name = "label3";
            label3.Size = new Size(210, 29);
            label3.TabIndex = 0;
            label3.Text = "Confirm Password";
            // 
            // txtConfirmPasswords
            // 
            txtConfirmPasswords.BorderStyle = BorderStyle.None;
            txtConfirmPasswords.Location = new Point(117, 480);
            txtConfirmPasswords.Name = "txtConfirmPasswords";
            txtConfirmPasswords.Size = new Size(570, 16);
            txtConfirmPasswords.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 40, 136);
            button1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(117, 578);
            button1.Name = "button1";
            button1.Size = new Size(570, 49);
            button1.TabIndex = 2;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(81, 40, 136);
            label4.Location = new Point(310, 642);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 3;
            label4.Text = "Already has an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(81, 40, 136);
            label5.Location = new Point(333, 679);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 3;
            label5.Text = "Click here to log in";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 1098);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtConfirmPasswords);
            Controls.Add(txtNewPasswords);
            Controls.Add(txtNewUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNewUsername;
        private Label label2;
        private TextBox txtNewPasswords;
        private Label label3;
        private TextBox txtConfirmPasswords;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}