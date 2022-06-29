namespace WinFormHelloWorld_donet_framework
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
            this.textBox_show_hello = new System.Windows.Forms.TextBox();
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_show_hello
            // 
            this.textBox_show_hello.Location = new System.Drawing.Point(12, 12);
            this.textBox_show_hello.Name = "textBox_show_hello";
            this.textBox_show_hello.Size = new System.Drawing.Size(776, 21);
            this.textBox_show_hello.TabIndex = 0;
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(12, 39);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(776, 23);
            this.buttonSayHello.TabIndex = 1;
            this.buttonSayHello.Text = "buttonSayHello";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSayHello);
            this.Controls.Add(this.textBox_show_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_show_hello;
        private System.Windows.Forms.Button buttonSayHello;
    }
}

