
namespace DesignPatterns.Observer
{
    partial class ObserverForm
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
            this.stopSteauaDinamo = new System.Windows.Forms.Button();
            this.startSteauaDinamo = new System.Windows.Forms.Button();
            this.updateSteauaDinamo = new System.Windows.Forms.Button();
            this.textBoxSteauaDinamo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stopInterMilan = new System.Windows.Forms.Button();
            this.startInterMilan = new System.Windows.Forms.Button();
            this.updateInterMilan = new System.Windows.Forms.Button();
            this.textBoxInterMilan = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxProTV = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxTVR = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopSteauaDinamo);
            this.groupBox1.Controls.Add(this.startSteauaDinamo);
            this.groupBox1.Controls.Add(this.updateSteauaDinamo);
            this.groupBox1.Controls.Add(this.textBoxSteauaDinamo);
            this.groupBox1.Location = new System.Drawing.Point(51, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Steaua-Dinamo";
            // 
            // stopSteauaDinamo
            // 
            this.stopSteauaDinamo.Location = new System.Drawing.Point(262, 147);
            this.stopSteauaDinamo.Name = "stopSteauaDinamo";
            this.stopSteauaDinamo.Size = new System.Drawing.Size(115, 23);
            this.stopSteauaDinamo.TabIndex = 3;
            this.stopSteauaDinamo.Text = "Stop";
            this.stopSteauaDinamo.UseVisualStyleBackColor = true;
            this.stopSteauaDinamo.Click += new System.EventHandler(this.stopSteauaDinamo_Click);
            // 
            // startSteauaDinamo
            // 
            this.startSteauaDinamo.Location = new System.Drawing.Point(262, 98);
            this.startSteauaDinamo.Name = "startSteauaDinamo";
            this.startSteauaDinamo.Size = new System.Drawing.Size(115, 23);
            this.startSteauaDinamo.TabIndex = 2;
            this.startSteauaDinamo.Text = "Start";
            this.startSteauaDinamo.UseVisualStyleBackColor = true;
            this.startSteauaDinamo.Click += new System.EventHandler(this.startSteauaDinamo_Click);
            // 
            // updateSteauaDinamo
            // 
            this.updateSteauaDinamo.Location = new System.Drawing.Point(262, 48);
            this.updateSteauaDinamo.Name = "updateSteauaDinamo";
            this.updateSteauaDinamo.Size = new System.Drawing.Size(115, 23);
            this.updateSteauaDinamo.TabIndex = 1;
            this.updateSteauaDinamo.Text = "Update";
            this.updateSteauaDinamo.UseVisualStyleBackColor = true;
            this.updateSteauaDinamo.Click += new System.EventHandler(this.updateSteauaDinamo_Click);
            // 
            // textBoxSteauaDinamo
            // 
            this.textBoxSteauaDinamo.Location = new System.Drawing.Point(18, 49);
            this.textBoxSteauaDinamo.Name = "textBoxSteauaDinamo";
            this.textBoxSteauaDinamo.Size = new System.Drawing.Size(218, 23);
            this.textBoxSteauaDinamo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stopInterMilan);
            this.groupBox2.Controls.Add(this.startInterMilan);
            this.groupBox2.Controls.Add(this.updateInterMilan);
            this.groupBox2.Controls.Add(this.textBoxInterMilan);
            this.groupBox2.Location = new System.Drawing.Point(507, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inter-Milan";
            // 
            // stopInterMilan
            // 
            this.stopInterMilan.Location = new System.Drawing.Point(300, 147);
            this.stopInterMilan.Name = "stopInterMilan";
            this.stopInterMilan.Size = new System.Drawing.Size(107, 23);
            this.stopInterMilan.TabIndex = 3;
            this.stopInterMilan.Text = "Stop";
            this.stopInterMilan.UseVisualStyleBackColor = true;
            this.stopInterMilan.Click += new System.EventHandler(this.stopInterMilan_Click);
            // 
            // startInterMilan
            // 
            this.startInterMilan.Location = new System.Drawing.Point(300, 98);
            this.startInterMilan.Name = "startInterMilan";
            this.startInterMilan.Size = new System.Drawing.Size(107, 23);
            this.startInterMilan.TabIndex = 2;
            this.startInterMilan.Text = "Start";
            this.startInterMilan.UseVisualStyleBackColor = true;
            this.startInterMilan.Click += new System.EventHandler(this.startInterMilan_Click);
            // 
            // updateInterMilan
            // 
            this.updateInterMilan.Location = new System.Drawing.Point(300, 48);
            this.updateInterMilan.Name = "updateInterMilan";
            this.updateInterMilan.Size = new System.Drawing.Size(107, 23);
            this.updateInterMilan.TabIndex = 1;
            this.updateInterMilan.Text = "Update";
            this.updateInterMilan.UseVisualStyleBackColor = true;
            this.updateInterMilan.Click += new System.EventHandler(this.updateInterMilan_Click);
            // 
            // textBoxInterMilan
            // 
            this.textBoxInterMilan.Location = new System.Drawing.Point(42, 48);
            this.textBoxInterMilan.Name = "textBoxInterMilan";
            this.textBoxInterMilan.Size = new System.Drawing.Size(236, 23);
            this.textBoxInterMilan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxProTV);
            this.groupBox3.Location = new System.Drawing.Point(51, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ProTV";
            // 
            // textBoxProTV
            // 
            this.textBoxProTV.Location = new System.Drawing.Point(18, 38);
            this.textBoxProTV.Multiline = true;
            this.textBoxProTV.Name = "textBoxProTV";
            this.textBoxProTV.Size = new System.Drawing.Size(359, 160);
            this.textBoxProTV.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxTVR);
            this.groupBox4.Location = new System.Drawing.Point(507, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 235);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TVR";
            // 
            // textBoxTVR
            // 
            this.textBoxTVR.Location = new System.Drawing.Point(19, 38);
            this.textBoxTVR.Multiline = true;
            this.textBoxTVR.Name = "textBoxTVR";
            this.textBoxTVR.Size = new System.Drawing.Size(388, 160);
            this.textBoxTVR.TabIndex = 0;
            // 
            // ObserverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 641);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ObserverForm";
            this.Text = "ObserverForm";
            this.Load += new System.EventHandler(this.ObserverForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startSteauaDinamo;
        private System.Windows.Forms.Button updateSteauaDinamo;
        private System.Windows.Forms.TextBox textBoxSteauaDinamo;
        private System.Windows.Forms.Button stopSteauaDinamo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stopInterMilan;
        private System.Windows.Forms.Button startInterMilan;
        private System.Windows.Forms.Button updateInterMilan;
        private System.Windows.Forms.TextBox textBoxInterMilan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxProTV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxTVR;
    }
}