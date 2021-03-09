
namespace DesignPatterns.ChainOfResponsibility
{
    partial class ChainOfResponsibilityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.buttonHandle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Period (in months)";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(183, 53);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(238, 23);
            this.textBoxAmount.TabIndex = 2;
            this.textBoxAmount.Text = "500";
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(183, 85);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(238, 23);
            this.textBoxPeriod.TabIndex = 3;
            this.textBoxPeriod.Text = "6";
            // 
            // buttonHandle
            // 
            this.buttonHandle.Location = new System.Drawing.Point(324, 142);
            this.buttonHandle.Name = "buttonHandle";
            this.buttonHandle.Size = new System.Drawing.Size(97, 23);
            this.buttonHandle.TabIndex = 4;
            this.buttonHandle.Text = "Process request";
            this.buttonHandle.UseVisualStyleBackColor = true;
            this.buttonHandle.Click += new System.EventHandler(this.buttonHandle_Click);
            // 
            // ChainOfResponsibilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHandle);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChainOfResponsibilityForm";
            this.Text = "ChainOfResponsibilityForm";
            this.Load += new System.EventHandler(this.ChainOfResponsibilityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Button buttonHandle;
    }
}