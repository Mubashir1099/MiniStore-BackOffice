namespace App.WinForms
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
            this.lblUsername_ = new System.Windows.Forms.Label();
            this.btnRrefresh_ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsername_
            // 
            this.lblUsername_.AutoSize = true;
            this.lblUsername_.Location = new System.Drawing.Point(163, 162);
            this.lblUsername_.Name = "lblUsername_";
            this.lblUsername_.Size = new System.Drawing.Size(98, 20);
            this.lblUsername_.TabIndex = 0;
            this.lblUsername_.Text = "lblUsername";
            this.lblUsername_.Click += new System.EventHandler(this.lblUsername);
            // 
            // btnRrefresh_
            // 
            this.btnRrefresh_.Location = new System.Drawing.Point(365, 116);
            this.btnRrefresh_.Name = "btnRrefresh_";
            this.btnRrefresh_.Size = new System.Drawing.Size(102, 33);
            this.btnRrefresh_.TabIndex = 1;
            this.btnRrefresh_.Text = "btnRefresh";
            this.btnRrefresh_.UseVisualStyleBackColor = true;
            this.btnRrefresh_.Click += new System.EventHandler(this.btnRefresh);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRrefresh_);
            this.Controls.Add(this.lblUsername_);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername_;
        private System.Windows.Forms.Button btnRrefresh_;
        private System.Windows.Forms.TextBox textBox1;
    }
}
//Auto Generated code
