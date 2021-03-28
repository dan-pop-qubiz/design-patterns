
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
            this.singletonFlowResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfUsers = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxDocuments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // singletonFlowResult
            // 
            this.singletonFlowResult.Location = new System.Drawing.Point(12, 156);
            this.singletonFlowResult.Multiline = true;
            this.singletonFlowResult.Name = "singletonFlowResult";
            this.singletonFlowResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.singletonFlowResult.Size = new System.Drawing.Size(672, 403);
            this.singletonFlowResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of users";
            // 
            // textBoxNumberOfUsers
            // 
            this.textBoxNumberOfUsers.Location = new System.Drawing.Point(246, 28);
            this.textBoxNumberOfUsers.Name = "textBoxNumberOfUsers";
            this.textBoxNumberOfUsers.Size = new System.Drawing.Size(102, 23);
            this.textBoxNumberOfUsers.TabIndex = 5;
            this.textBoxNumberOfUsers.Text = "5";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(38, 116);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max number of documents per user";
            // 
            // textBoxMaxDocuments
            // 
            this.textBoxMaxDocuments.Location = new System.Drawing.Point(246, 70);
            this.textBoxMaxDocuments.Name = "textBoxMaxDocuments";
            this.textBoxMaxDocuments.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxDocuments.TabIndex = 8;
            this.textBoxMaxDocuments.Text = "10";
            // 
            // SingletonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.textBoxMaxDocuments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxNumberOfUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.singletonFlowResult);
            this.Name = "SingletonForm";
            this.Text = "SingletonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox singletonFlowResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberOfUsers;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxDocuments;
    }
}