namespace UserDemo
{
    partial class MainForm
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
            this.btnOpenUserRegistFrm = new System.Windows.Forms.Button();
            this.btnOpenLoginFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenUserRegistFrm
            // 
            this.btnOpenUserRegistFrm.Location = new System.Drawing.Point(51, 40);
            this.btnOpenUserRegistFrm.Name = "btnOpenUserRegistFrm";
            this.btnOpenUserRegistFrm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenUserRegistFrm.TabIndex = 0;
            this.btnOpenUserRegistFrm.Text = "用户注册";
            this.btnOpenUserRegistFrm.UseVisualStyleBackColor = true;
            this.btnOpenUserRegistFrm.Click += new System.EventHandler(this.btnOpenUserRegistFrm_Click);
            // 
            // btnOpenLoginFrm
            // 
            this.btnOpenLoginFrm.Location = new System.Drawing.Point(51, 101);
            this.btnOpenLoginFrm.Name = "btnOpenLoginFrm";
            this.btnOpenLoginFrm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLoginFrm.TabIndex = 1;
            this.btnOpenLoginFrm.Text = "用户登录";
            this.btnOpenLoginFrm.UseVisualStyleBackColor = true;
            this.btnOpenLoginFrm.Click += new System.EventHandler(this.btnOpenLoginFrm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenLoginFrm);
            this.Controls.Add(this.btnOpenUserRegistFrm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenUserRegistFrm;
        private System.Windows.Forms.Button btnOpenLoginFrm;
    }
}