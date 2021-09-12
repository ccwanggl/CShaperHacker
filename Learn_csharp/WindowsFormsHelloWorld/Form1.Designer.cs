namespace WindowsFormsHelloWorld
{
    partial class Form1
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
            this.textBoxShowMsg = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowMsg
            // 
            this.textBoxShowMsg.Location = new System.Drawing.Point(98, 65);
            this.textBoxShowMsg.Name = "textBoxShowMsg";
            this.textBoxShowMsg.Size = new System.Drawing.Size(666, 25);
            this.textBoxShowMsg.TabIndex = 0;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(98, 124);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(666, 23);
            this.btnSayHello.TabIndex = 1;
            this.btnSayHello.Text = "Click Me";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.textBoxShowMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowMsg;
        private System.Windows.Forms.Button btnSayHello;
    }
}

