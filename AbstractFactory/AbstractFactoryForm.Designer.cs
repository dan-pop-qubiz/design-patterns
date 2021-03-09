
namespace DesignPatterns.AbstractFactory
{
    partial class AbstractFactoryForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numberOfWheels = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numberOfPassengers = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hasCargoNo = new System.Windows.Forms.RadioButton();
            this.hasCargoYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hasEngineNo = new System.Windows.Forms.RadioButton();
            this.hasEngineYes = new System.Windows.Forms.RadioButton();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(48, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numberOfWheels);
            this.groupBox5.Location = new System.Drawing.Point(41, 373);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 64);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Number of Wheels";
            // 
            // numberOfWheels
            // 
            this.numberOfWheels.Location = new System.Drawing.Point(25, 23);
            this.numberOfWheels.Name = "numberOfWheels";
            this.numberOfWheels.Size = new System.Drawing.Size(221, 23);
            this.numberOfWheels.TabIndex = 0;
            this.numberOfWheels.Text = "4";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numberOfPassengers);
            this.groupBox4.Location = new System.Drawing.Point(41, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(299, 62);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number of passengers";
            // 
            // numberOfPassengers
            // 
            this.numberOfPassengers.Location = new System.Drawing.Point(25, 23);
            this.numberOfPassengers.Name = "numberOfPassengers";
            this.numberOfPassengers.Size = new System.Drawing.Size(221, 23);
            this.numberOfPassengers.TabIndex = 0;
            this.numberOfPassengers.Text = "5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hasCargoNo);
            this.groupBox3.Controls.Add(this.hasCargoYes);
            this.groupBox3.Location = new System.Drawing.Point(41, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Has Cargo";
            // 
            // hasCargoNo
            // 
            this.hasCargoNo.AutoSize = true;
            this.hasCargoNo.Checked = true;
            this.hasCargoNo.Location = new System.Drawing.Point(25, 49);
            this.hasCargoNo.Name = "hasCargoNo";
            this.hasCargoNo.Size = new System.Drawing.Size(41, 19);
            this.hasCargoNo.TabIndex = 1;
            this.hasCargoNo.TabStop = true;
            this.hasCargoNo.Text = "No";
            this.hasCargoNo.UseVisualStyleBackColor = true;
            // 
            // hasCargoYes
            // 
            this.hasCargoYes.AutoSize = true;
            this.hasCargoYes.Location = new System.Drawing.Point(25, 23);
            this.hasCargoYes.Name = "hasCargoYes";
            this.hasCargoYes.Size = new System.Drawing.Size(42, 19);
            this.hasCargoYes.TabIndex = 0;
            this.hasCargoYes.TabStop = true;
            this.hasCargoYes.Text = "Yes";
            this.hasCargoYes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hasEngineNo);
            this.groupBox2.Controls.Add(this.hasEngineYes);
            this.groupBox2.Location = new System.Drawing.Point(41, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Has Engine";
            // 
            // hasEngineNo
            // 
            this.hasEngineNo.AutoSize = true;
            this.hasEngineNo.Location = new System.Drawing.Point(25, 49);
            this.hasEngineNo.Name = "hasEngineNo";
            this.hasEngineNo.Size = new System.Drawing.Size(41, 19);
            this.hasEngineNo.TabIndex = 1;
            this.hasEngineNo.TabStop = true;
            this.hasEngineNo.Text = "No";
            this.hasEngineNo.UseVisualStyleBackColor = true;
            // 
            // hasEngineYes
            // 
            this.hasEngineYes.AutoSize = true;
            this.hasEngineYes.Checked = true;
            this.hasEngineYes.Location = new System.Drawing.Point(25, 23);
            this.hasEngineYes.Name = "hasEngineYes";
            this.hasEngineYes.Size = new System.Drawing.Size(42, 19);
            this.hasEngineYes.TabIndex = 0;
            this.hasEngineYes.TabStop = true;
            this.hasEngineYes.Text = "Yes";
            this.hasEngineYes.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(426, 488);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // AbstractFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBox1);
            this.Name = "AbstractFactoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AbstractFactoryForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AbstractFactoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton hasEngineNo;
        private System.Windows.Forms.RadioButton hasEngineYes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton hasCargoYes;
        private System.Windows.Forms.RadioButton hasCargoNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox numberOfWheels;
        private System.Windows.Forms.TextBox numberOfPassengers;
        private System.Windows.Forms.Button buttonConfirm;
    }
}