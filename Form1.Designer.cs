
namespace DesignPatterns
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAbstractFactory = new System.Windows.Forms.Button();
            this.buttonSingleton = new System.Windows.Forms.Button();
            this.buttonProxi = new System.Windows.Forms.Button();
            this.buttonMediator = new System.Windows.Forms.Button();
            this.buttonObserver = new System.Windows.Forms.Button();
            this.buttonChainOfResponsibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbstractFactory
            // 
            this.buttonAbstractFactory.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAbstractFactory.Location = new System.Drawing.Point(32, 34);
            this.buttonAbstractFactory.Name = "buttonAbstractFactory";
            this.buttonAbstractFactory.Size = new System.Drawing.Size(148, 23);
            this.buttonAbstractFactory.TabIndex = 0;
            this.buttonAbstractFactory.Text = "Abstract Factory";
            this.buttonAbstractFactory.UseVisualStyleBackColor = true;
            this.buttonAbstractFactory.Click += new System.EventHandler(this.buttonAbstractFactory_Click);
            // 
            // buttonSingleton
            // 
            this.buttonSingleton.Location = new System.Drawing.Point(32, 75);
            this.buttonSingleton.Name = "buttonSingleton";
            this.buttonSingleton.Size = new System.Drawing.Size(148, 23);
            this.buttonSingleton.TabIndex = 1;
            this.buttonSingleton.Text = "Singleton";
            this.buttonSingleton.UseVisualStyleBackColor = true;
            this.buttonSingleton.Click += new System.EventHandler(this.buttonSingleton_Click);
            // 
            // buttonProxi
            // 
            this.buttonProxi.Location = new System.Drawing.Point(32, 121);
            this.buttonProxi.Name = "buttonProxi";
            this.buttonProxi.Size = new System.Drawing.Size(148, 23);
            this.buttonProxi.TabIndex = 2;
            this.buttonProxi.Text = "Proxy";
            this.buttonProxi.UseVisualStyleBackColor = true;
            this.buttonProxi.Click += new System.EventHandler(this.buttonProxi_Click);
            // 
            // buttonMediator
            // 
            this.buttonMediator.Location = new System.Drawing.Point(32, 171);
            this.buttonMediator.Name = "buttonMediator";
            this.buttonMediator.Size = new System.Drawing.Size(148, 23);
            this.buttonMediator.TabIndex = 3;
            this.buttonMediator.Text = "Mediator";
            this.buttonMediator.UseVisualStyleBackColor = true;
            this.buttonMediator.Click += new System.EventHandler(this.buttonMediator_Click);
            // 
            // buttonObserver
            // 
            this.buttonObserver.Location = new System.Drawing.Point(32, 219);
            this.buttonObserver.Name = "buttonObserver";
            this.buttonObserver.Size = new System.Drawing.Size(148, 23);
            this.buttonObserver.TabIndex = 4;
            this.buttonObserver.Text = "Observer";
            this.buttonObserver.UseVisualStyleBackColor = true;
            this.buttonObserver.Click += new System.EventHandler(this.buttonObserver_Click);
            // 
            // buttonChainOfResponsibility
            // 
            this.buttonChainOfResponsibility.Location = new System.Drawing.Point(32, 269);
            this.buttonChainOfResponsibility.Name = "buttonChainOfResponsibility";
            this.buttonChainOfResponsibility.Size = new System.Drawing.Size(188, 23);
            this.buttonChainOfResponsibility.TabIndex = 5;
            this.buttonChainOfResponsibility.Text = "Chain of Responsibility";
            this.buttonChainOfResponsibility.UseVisualStyleBackColor = true;
            this.buttonChainOfResponsibility.Click += new System.EventHandler(this.buttonChainOfResponsibility_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 805);
            this.Controls.Add(this.buttonChainOfResponsibility);
            this.Controls.Add(this.buttonObserver);
            this.Controls.Add(this.buttonMediator);
            this.Controls.Add(this.buttonProxi);
            this.Controls.Add(this.buttonSingleton);
            this.Controls.Add(this.buttonAbstractFactory);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbstractFactory;
        private System.Windows.Forms.Button buttonSingleton;
        private System.Windows.Forms.Button buttonProxi;
        private System.Windows.Forms.Button buttonMediator;
        private System.Windows.Forms.Button buttonObserver;
        private System.Windows.Forms.Button buttonChainOfResponsibility;
    }
}

