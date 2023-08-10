namespace DotNETFrameworkWinForms
{
    partial class MainWindow
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
            this.BtnShowHello = new System.Windows.Forms.Button();
            this.TextBox_ShowHello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnShowHello
            // 
            this.BtnShowHello.Location = new System.Drawing.Point(22, 59);
            this.BtnShowHello.Name = "BtnShowHello";
            this.BtnShowHello.Size = new System.Drawing.Size(754, 38);
            this.BtnShowHello.TabIndex = 0;
            this.BtnShowHello.Text = "Click Me";
            this.BtnShowHello.UseVisualStyleBackColor = true;
            this.BtnShowHello.Click += new System.EventHandler(this.BtnShowHello_Click);
            // 
            // TextBox_ShowHello
            // 
            this.TextBox_ShowHello.Location = new System.Drawing.Point(22, 25);
            this.TextBox_ShowHello.Name = "TextBox_ShowHello";
            this.TextBox_ShowHello.Size = new System.Drawing.Size(754, 28);
            this.TextBox_ShowHello.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_ShowHello);
            this.Controls.Add(this.BtnShowHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowHello;
        private System.Windows.Forms.TextBox TextBox_ShowHello;
    }
}

