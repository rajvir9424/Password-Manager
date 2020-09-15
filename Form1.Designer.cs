namespace PasswordManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new FlatButton.JFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(128, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "Passvault";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Maroon;
            this.btnlogin.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.CausesValidation = false;
            this.btnlogin.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnlogin.ErrorImageLeft")));
            this.btnlogin.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnlogin.ErrorImageRight")));
            this.btnlogin.FocusBackground = System.Drawing.Color.Empty;
            this.btnlogin.FocusFontColor = System.Drawing.Color.Empty;
            this.btnlogin.ForeColors = System.Drawing.Color.Azure;
            this.btnlogin.HoverBackground = System.Drawing.Color.Maroon;
            this.btnlogin.HoverFontColor = System.Drawing.Color.White;
            this.btnlogin.ImageLeft = null;
            this.btnlogin.ImageRight = null;
            this.btnlogin.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnlogin.Location = new System.Drawing.Point(191, 471);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnlogin.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnlogin.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnlogin.Size = new System.Drawing.Size(148, 43);
            this.btnlogin.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnlogin.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(187, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Don\'t have an account ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(232, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sign Up";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 83);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(150, 406);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.Maroon;
            this.jMaterialTextbox1.HintText = "Username";
            this.jMaterialTextbox1.IsPassword = false;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.Color.Maroon;
            this.jMaterialTextbox1.LineThickness = 3;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(117, 266);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(323, 49);
            this.jMaterialTextbox1.TabIndex = 17;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "Username";
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.Maroon;
            this.jMaterialTextbox2.HintText = "Password";
            this.jMaterialTextbox2.IsPassword = true;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.Color.Maroon;
            this.jMaterialTextbox2.LineThickness = 3;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(116, 339);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(324, 41);
            this.jMaterialTextbox2.TabIndex = 18;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 623);
            this.Controls.Add(this.jMaterialTextbox2);
            this.Controls.Add(this.jMaterialTextbox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FlatButton.JFlatButton btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
    }
}

