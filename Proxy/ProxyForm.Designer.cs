
namespace DesignPatterns.Proxy
{
    partial class ProxyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewEmployeesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.employeeNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "dan";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(87, 84);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(259, 23);
            this.passwordTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(87, 42);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(259, 23);
            this.usernameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // viewEmployeesBtn
            // 
            this.viewEmployeesBtn.Location = new System.Drawing.Point(26, 178);
            this.viewEmployeesBtn.Name = "viewEmployeesBtn";
            this.viewEmployeesBtn.Size = new System.Drawing.Size(158, 23);
            this.viewEmployeesBtn.TabIndex = 1;
            this.viewEmployeesBtn.Text = "View Employees";
            this.viewEmployeesBtn.UseVisualStyleBackColor = true;
            this.viewEmployeesBtn.Click += new System.EventHandler(this.viewEmployeesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddEmployeeButton);
            this.groupBox2.Controls.Add(this.employeeNameTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Employee";
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(271, 81);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // employeeNameTextbox
            // 
            this.employeeNameTextbox.Location = new System.Drawing.Point(77, 36);
            this.employeeNameTextbox.Name = "employeeNameTextbox";
            this.employeeNameTextbox.Size = new System.Drawing.Size(269, 23);
            this.employeeNameTextbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 15;
            this.employeesListBox.Location = new System.Drawing.Point(230, 178);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(408, 94);
            this.employeesListBox.TabIndex = 3;
            // 
            // ProxyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewEmployeesBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProxyForm";
            this.Text = "ProxyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewEmployeesBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.TextBox employeeNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox employeesListBox;
    }
}