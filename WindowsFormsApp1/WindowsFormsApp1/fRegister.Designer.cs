namespace WindowsFormsApp1
{
    partial class fRegister
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.insDisplayName = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.insUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.insPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.insRe_enter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.insDisplayName);
            this.panel2.Controls.Add(this.txtDisplay);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 82);
            this.panel2.TabIndex = 2;
            // 
            // insDisplayName
            // 
            this.insDisplayName.Location = new System.Drawing.Point(206, 43);
            this.insDisplayName.Name = "insDisplayName";
            this.insDisplayName.Size = new System.Drawing.Size(332, 22);
            this.insDisplayName.TabIndex = 5;
            // 
            // txtDisplay
            // 
            this.txtDisplay.AutoSize = true;
            this.txtDisplay.Font = new System.Drawing.Font("UTM Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(18, 30);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(181, 40);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "Display Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.insUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 82);
            this.panel1.TabIndex = 3;
            // 
            // insUserName
            // 
            this.insUserName.Location = new System.Drawing.Point(206, 43);
            this.insUserName.Name = "insUserName";
            this.insUserName.Size = new System.Drawing.Size(332, 22);
            this.insUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.insPassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 82);
            this.panel3.TabIndex = 2;
            // 
            // insPassword
            // 
            this.insPassword.Location = new System.Drawing.Point(206, 43);
            this.insPassword.Name = "insPassword";
            this.insPassword.Size = new System.Drawing.Size(332, 22);
            this.insPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.insRe_enter);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 82);
            this.panel4.TabIndex = 2;
            // 
            // insRe_enter
            // 
            this.insRe_enter.Location = new System.Drawing.Point(206, 43);
            this.insRe_enter.Name = "insRe_enter";
            this.insRe_enter.Size = new System.Drawing.Size(332, 22);
            this.insRe_enter.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Re-enter: ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(366, 394);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(84, 28);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRegister";
            this.Load += new System.EventHandler(this.fRegister_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox insDisplayName;
        private System.Windows.Forms.Label txtDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox insUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox insPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox insRe_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
    }
}