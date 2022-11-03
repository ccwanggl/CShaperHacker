namespace WinFormHelloWorld_donet_core
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
            this.text_show_hello = new System.Windows.Forms.TextBox();
            this.btn_say_hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_show_hello
            // 
            this.text_show_hello.Location = new System.Drawing.Point(12, 60);
            this.text_show_hello.Name = "text_show_hello";
            this.text_show_hello.Size = new System.Drawing.Size(776, 23);
            this.text_show_hello.TabIndex = 0;
            // 
            // btn_say_hello
            // 
            this.btn_say_hello.Location = new System.Drawing.Point(12, 110);
            this.btn_say_hello.Name = "btn_say_hello";
            this.btn_say_hello.Size = new System.Drawing.Size(776, 23);
            this.btn_say_hello.TabIndex = 1;
            this.btn_say_hello.Text = "buttonSayHello";
            this.btn_say_hello.UseVisualStyleBackColor = true;
            this.btn_say_hello.Click += new System.EventHandler(this.btn_say_hello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_say_hello);
            this.Controls.Add(this.text_show_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_show_hello;
        private Button btn_say_hello;
    }
}