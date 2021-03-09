
namespace DesignPatterns.Singleton
{
    partial class SingletonForm
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
            this.numberOfDocumentsTextbox = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.singletonFlowResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of documents";
            // 
            // numberOfDocumentsTextbox
            // 
            this.numberOfDocumentsTextbox.Location = new System.Drawing.Point(172, 31);
            this.numberOfDocumentsTextbox.Name = "numberOfDocumentsTextbox";
            this.numberOfDocumentsTextbox.Size = new System.Drawing.Size(111, 23);
            this.numberOfDocumentsTextbox.TabIndex = 1;
            this.numberOfDocumentsTextbox.Text = "5";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(38, 74);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 2;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // singletonFlowResult
            // 
            this.singletonFlowResult.Location = new System.Drawing.Point(38, 133);
            this.singletonFlowResult.Multiline = true;
            this.singletonFlowResult.Name = "singletonFlowResult";
            this.singletonFlowResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.singletonFlowResult.Size = new System.Drawing.Size(672, 226);
            this.singletonFlowResult.TabIndex = 3;
            // 
            // SingletonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.singletonFlowResult);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.numberOfDocumentsTextbox);
            this.Controls.Add(this.label1);
            this.Name = "SingletonForm";
            this.Text = "SingletonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfDocumentsTextbox;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox singletonFlowResult;
    }
}