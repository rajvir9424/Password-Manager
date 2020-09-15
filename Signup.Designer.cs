namespace PasswordManager
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsign = new FlatButton.JFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pastxt = new JMaterialTextbox.JMaterialTextbox();
            this.usertxt = new JMaterialTextbox.JMaterialTextbox();
            this.emailtxt = new JMaterialTextbox.JMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(244, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(180, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Already have an account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(431, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.Maroon;
            this.btnsign.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnsign.ButtonText = "Sign Up";
            this.btnsign.CausesValidation = false;
            this.btnsign.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnsign.ErrorImageLeft")));
            this.btnsign.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnsign.ErrorImageRight")));
            this.btnsign.FocusBackground = System.Drawing.Color.Empty;
            this.btnsign.FocusFontColor = System.Drawing.Color.Empty;
            this.btnsign.ForeColors = System.Drawing.Color.White;
            this.btnsign.HoverBackground = System.Drawing.Color.Transparent;
            this.btnsign.HoverFontColor = System.Drawing.Color.White;
            this.btnsign.ImageLeft = null;
            this.btnsign.ImageRight = null;
            this.btnsign.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnsign.Location = new System.Drawing.Point(199, 327);
            this.btnsign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsign.Name = "btnsign";
            this.btnsign.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnsign.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnsign.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnsign.Size = new System.Drawing.Size(148, 43);
            this.btnsign.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnsign.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnsign.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(73, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "       SignUp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pastxt
            // 
            this.pastxt.BackColor = System.Drawing.Color.Transparent;
            this.pastxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pastxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pastxt.ForeColors = System.Drawing.Color.Maroon;
            this.pastxt.HintText = "Password";
            this.pastxt.IsPassword = false;
            this.pastxt.LineBackColor = System.Drawing.Color.Maroon;
            this.pastxt.LineThickness = 3;
            this.pastxt.Location = new System.Drawing.Point(168, 191);
            this.pastxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pastxt.MaxLength = 32767;
            this.pastxt.Name = "pastxt";
            this.pastxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.pastxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.pastxt.ReadOnly = false;
            this.pastxt.Size = new System.Drawing.Size(219, 35);
            this.pastxt.TabIndex = 13;
            this.pastxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pastxt.TextName = "Password";
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.Transparent;
            this.usertxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usertxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usertxt.ForeColors = System.Drawing.Color.Maroon;
            this.usertxt.HintText = "User Name";
            this.usertxt.IsPassword = false;
            this.usertxt.LineBackColor = System.Drawing.Color.Maroon;
            this.usertxt.LineThickness = 3;
            this.usertxt.Location = new System.Drawing.Point(168, 123);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usertxt.MaxLength = 32767;
            this.usertxt.Name = "usertxt";
            this.usertxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.usertxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.usertxt.ReadOnly = false;
            this.usertxt.Size = new System.Drawing.Size(219, 35);
            this.usertxt.TabIndex = 12;
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usertxt.TextName = "User Name";
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.Transparent;
            this.emailtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailtxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailtxt.ForeColors = System.Drawing.Color.Maroon;
            this.emailtxt.HintText = "Email";
            this.emailtxt.IsPassword = false;
            this.emailtxt.LineBackColor = System.Drawing.Color.Maroon;
            this.emailtxt.LineThickness = 3;
            this.emailtxt.Location = new System.Drawing.Point(168, 261);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailtxt.MaxLength = 32767;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.emailtxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.emailtxt.ReadOnly = false;
            this.emailtxt.Size = new System.Drawing.Size(219, 35);
            this.emailtxt.TabIndex = 19;
            this.emailtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailtxt.TextName = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 89);
            this.panel1.TabIndex = 20;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.pastxt);
            this.Controls.Add(this.usertxt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatButton.JFlatButton btnsign;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox pastxt;
        private JMaterialTextbox.JMaterialTextbox usertxt;
        private JMaterialTextbox.JMaterialTextbox emailtxt;
        private System.Windows.Forms.Panel panel1;
    }
}