namespace WindowsFormsApp2
{
    partial class Form2
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
            this.第二个窗体 = new System.Windows.Forms.ListBox();
            this.打开窗体一 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 第二个窗体
            // 
            this.第二个窗体.FormattingEnabled = true;
            this.第二个窗体.ItemHeight = 12;
            this.第二个窗体.Location = new System.Drawing.Point(244, 92);
            this.第二个窗体.Name = "第二个窗体";
            this.第二个窗体.Size = new System.Drawing.Size(263, 208);
            this.第二个窗体.TabIndex = 0;
            // 
            // 打开窗体一
            // 
            this.打开窗体一.Location = new System.Drawing.Point(30, 164);
            this.打开窗体一.Name = "打开窗体一";
            this.打开窗体一.Size = new System.Drawing.Size(133, 102);
            this.打开窗体一.TabIndex = 1;
            this.打开窗体一.Text = "打开窗体一";
            this.打开窗体一.UseVisualStyleBackColor = true;
            this.打开窗体一.Click += new System.EventHandler(this.打开窗体一_Click);
            this.打开窗体一.MouseHover += new System.EventHandler(this.打开窗体一_MouseHover);
            this.打开窗体一.Move += new System.EventHandler(this.打开窗体一_Move);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._65616682461717286;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.打开窗体一);
            this.Controls.Add(this.第二个窗体);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox 第二个窗体;
        private System.Windows.Forms.Button 打开窗体一;
        private System.Windows.Forms.Button button1;
    }
}