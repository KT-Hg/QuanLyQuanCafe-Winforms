namespace AppQuanLyQuanCafe
{
    partial class frmLogin
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
            this.pnlFullScreen = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.pnlPassWord = new System.Windows.Forms.Panel();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlFullScreen.SuspendLayout();
            this.pnlPassWord.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFullScreen
            // 
            this.pnlFullScreen.Controls.Add(this.lblLogin);
            this.pnlFullScreen.Controls.Add(this.btnExit);
            this.pnlFullScreen.Controls.Add(this.btnLogin);
            this.pnlFullScreen.Controls.Add(this.pnlPassWord);
            this.pnlFullScreen.Controls.Add(this.pnlUserName);
            this.pnlFullScreen.Location = new System.Drawing.Point(25, 10);
            this.pnlFullScreen.Name = "pnlFullScreen";
            this.pnlFullScreen.Size = new System.Drawing.Size(350, 180);
            this.pnlFullScreen.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(150, 10);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(50, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOG IN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUserName
            // 
            this.pnlUserName.Controls.Add(this.txbUserName);
            this.pnlUserName.Controls.Add(this.lblUserName);
            this.pnlUserName.Location = new System.Drawing.Point(25, 40);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(300, 40);
            this.pnlUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(20, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Tên đăng nhập:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(120, 10);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(160, 20);
            this.txbUserName.TabIndex = 4;
            // 
            // pnlPassWord
            // 
            this.pnlPassWord.Controls.Add(this.txbPassWord);
            this.pnlPassWord.Controls.Add(this.lblPassWord);
            this.pnlPassWord.Location = new System.Drawing.Point(25, 90);
            this.pnlPassWord.Name = "pnlPassWord";
            this.pnlPassWord.Size = new System.Drawing.Size(300, 40);
            this.pnlPassWord.TabIndex = 5;
            // 
            // lblPassWord
            // 
            this.lblPassWord.Location = new System.Drawing.Point(20, 10);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(90, 20);
            this.lblPassWord.TabIndex = 6;
            this.lblPassWord.Text = "Mật khẩu:";
            this.lblPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(120, 10);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(160, 20);
            this.txbPassWord.TabIndex = 7;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(165, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.pnlFullScreen);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.pnlFullScreen.ResumeLayout(false);
            this.pnlPassWord.ResumeLayout(false);
            this.pnlPassWord.PerformLayout();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFullScreen;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Panel pnlPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}

