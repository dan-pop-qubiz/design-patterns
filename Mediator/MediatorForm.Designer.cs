
namespace DesignPatterns.Mediator
{
    partial class MediatorForm
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
            this.textBoxSendAna = new System.Windows.Forms.TextBox();
            this.buttonSendAna = new System.Windows.Forms.Button();
            this.textBoxReceiveAna = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSendAndrei = new System.Windows.Forms.TextBox();
            this.buttonSendAndrei = new System.Windows.Forms.Button();
            this.textBoxReceiveAndrei = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReceiveAna);
            this.groupBox1.Controls.Add(this.buttonSendAna);
            this.groupBox1.Controls.Add(this.textBoxSendAna);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana";
            // 
            // textBoxSendAna
            // 
            this.textBoxSendAna.Location = new System.Drawing.Point(17, 22);
            this.textBoxSendAna.Name = "textBoxSendAna";
            this.textBoxSendAna.Size = new System.Drawing.Size(195, 23);
            this.textBoxSendAna.TabIndex = 0;
            // 
            // buttonSendAna
            // 
            this.buttonSendAna.Location = new System.Drawing.Point(229, 21);
            this.buttonSendAna.Name = "buttonSendAna";
            this.buttonSendAna.Size = new System.Drawing.Size(75, 23);
            this.buttonSendAna.TabIndex = 1;
            this.buttonSendAna.Text = "Send";
            this.buttonSendAna.UseVisualStyleBackColor = true;
            this.buttonSendAna.Click += new System.EventHandler(this.buttonSendAna_Click);
            // 
            // textBoxReceiveAna
            // 
            this.textBoxReceiveAna.Location = new System.Drawing.Point(17, 74);
            this.textBoxReceiveAna.Multiline = true;
            this.textBoxReceiveAna.Name = "textBoxReceiveAna";
            this.textBoxReceiveAna.Size = new System.Drawing.Size(287, 180);
            this.textBoxReceiveAna.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxReceiveAndrei);
            this.groupBox2.Controls.Add(this.buttonSendAndrei);
            this.groupBox2.Controls.Add(this.textBoxSendAndrei);
            this.groupBox2.Location = new System.Drawing.Point(389, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Andrei";
            // 
            // textBoxSendAndrei
            // 
            this.textBoxSendAndrei.Location = new System.Drawing.Point(7, 23);
            this.textBoxSendAndrei.Name = "textBoxSendAndrei";
            this.textBoxSendAndrei.Size = new System.Drawing.Size(240, 23);
            this.textBoxSendAndrei.TabIndex = 0;
            // 
            // buttonSendAndrei
            // 
            this.buttonSendAndrei.Location = new System.Drawing.Point(273, 23);
            this.buttonSendAndrei.Name = "buttonSendAndrei";
            this.buttonSendAndrei.Size = new System.Drawing.Size(83, 23);
            this.buttonSendAndrei.TabIndex = 1;
            this.buttonSendAndrei.Text = "Send";
            this.buttonSendAndrei.UseVisualStyleBackColor = true;
            this.buttonSendAndrei.Click += new System.EventHandler(this.buttonSendAndrei_Click);
            // 
            // textBoxReceiveAndrei
            // 
            this.textBoxReceiveAndrei.Location = new System.Drawing.Point(7, 63);
            this.textBoxReceiveAndrei.Multiline = true;
            this.textBoxReceiveAndrei.Name = "textBoxReceiveAndrei";
            this.textBoxReceiveAndrei.Size = new System.Drawing.Size(349, 180);
            this.textBoxReceiveAndrei.TabIndex = 2;
            // 
            // MediatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MediatorForm";
            this.Text = "MediatorForm";
            this.Load += new System.EventHandler(this.MediatorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxReceiveAna;
        private System.Windows.Forms.Button buttonSendAna;
        private System.Windows.Forms.TextBox textBoxSendAna;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxReceiveAndrei;
        private System.Windows.Forms.Button buttonSendAndrei;
        private System.Windows.Forms.TextBox textBoxSendAndrei;
    }
}