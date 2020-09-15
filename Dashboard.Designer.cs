namespace PasswordManager
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Labeltxt = new JMaterialTextbox.JMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acnametxt = new JMaterialTextbox.JMaterialTextbox();
            this.acpasstxt = new JMaterialTextbox.JMaterialTextbox();
            this.urltxt = new JMaterialTextbox.JMaterialTextbox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnupdate = new FlatButton.JFlatButton();
            this.btndelete = new FlatButton.JFlatButton();
            this.btnadd = new FlatButton.JFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndisplay = new FlatButton.JFlatButton();
            this.searchtxt = new JMaterialTextbox.JMaterialTextbox();
            this.btnsearch = new FlatButton.JFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Labeltxt
            // 
            this.Labeltxt.BackColor = System.Drawing.Color.Transparent;
            this.Labeltxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Labeltxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Labeltxt.ForeColors = System.Drawing.Color.Maroon;
            this.Labeltxt.HintText = "Label";
            this.Labeltxt.IsPassword = false;
            this.Labeltxt.LineBackColor = System.Drawing.Color.Maroon;
            this.Labeltxt.LineThickness = 3;
            this.Labeltxt.Location = new System.Drawing.Point(228, 238);
            this.Labeltxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Labeltxt.MaxLength = 32767;
            this.Labeltxt.Name = "Labeltxt";
            this.Labeltxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.Labeltxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.Labeltxt.ReadOnly = false;
            this.Labeltxt.Size = new System.Drawing.Size(157, 38);
            this.Labeltxt.TabIndex = 0;
            this.Labeltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Labeltxt.TextName = "Label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 84);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(946, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // acnametxt
            // 
            this.acnametxt.BackColor = System.Drawing.Color.Transparent;
            this.acnametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.acnametxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.acnametxt.ForeColors = System.Drawing.Color.Maroon;
            this.acnametxt.HintText = "Username";
            this.acnametxt.IsPassword = false;
            this.acnametxt.LineBackColor = System.Drawing.Color.Maroon;
            this.acnametxt.LineThickness = 3;
            this.acnametxt.Location = new System.Drawing.Point(445, 243);
            this.acnametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acnametxt.MaxLength = 32767;
            this.acnametxt.Name = "acnametxt";
            this.acnametxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.acnametxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.acnametxt.ReadOnly = false;
            this.acnametxt.Size = new System.Drawing.Size(165, 33);
            this.acnametxt.TabIndex = 2;
            this.acnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.acnametxt.TextName = "Username";
            // 
            // acpasstxt
            // 
            this.acpasstxt.BackColor = System.Drawing.Color.Transparent;
            this.acpasstxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.acpasstxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.acpasstxt.ForeColors = System.Drawing.Color.Maroon;
            this.acpasstxt.HintText = "Password";
            this.acpasstxt.IsPassword = true;
            this.acpasstxt.LineBackColor = System.Drawing.Color.Maroon;
            this.acpasstxt.LineThickness = 3;
            this.acpasstxt.Location = new System.Drawing.Point(648, 247);
            this.acpasstxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.acpasstxt.MaxLength = 32767;
            this.acpasstxt.Name = "acpasstxt";
            this.acpasstxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.acpasstxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.acpasstxt.ReadOnly = false;
            this.acpasstxt.Size = new System.Drawing.Size(200, 29);
            this.acpasstxt.TabIndex = 3;
            this.acpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.acpasstxt.TextName = "Password";
            // 
            // urltxt
            // 
            this.urltxt.BackColor = System.Drawing.Color.Transparent;
            this.urltxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.urltxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.urltxt.ForeColors = System.Drawing.Color.Maroon;
            this.urltxt.HintText = "Website Url";
            this.urltxt.IsPassword = false;
            this.urltxt.LineBackColor = System.Drawing.Color.Maroon;
            this.urltxt.LineThickness = 3;
            this.urltxt.Location = new System.Drawing.Point(228, 305);
            this.urltxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.urltxt.MaxLength = 32767;
            this.urltxt.Name = "urltxt";
            this.urltxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.urltxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.urltxt.ReadOnly = false;
            this.urltxt.Size = new System.Drawing.Size(150, 33);
            this.urltxt.TabIndex = 4;
            this.urltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.urltxt.TextName = "Website Url";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(665, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(321, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(319, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btndisplay);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(-3, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 510);
            this.panel2.TabIndex = 8;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Maroon;
            this.btnupdate.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnupdate.ButtonText = "Update";
            this.btnupdate.CausesValidation = false;
            this.btnupdate.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnupdate.ErrorImageLeft")));
            this.btnupdate.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnupdate.ErrorImageRight")));
            this.btnupdate.FocusBackground = System.Drawing.Color.Empty;
            this.btnupdate.FocusFontColor = System.Drawing.Color.Empty;
            this.btnupdate.ForeColors = System.Drawing.Color.White;
            this.btnupdate.HoverBackground = System.Drawing.Color.Gold;
            this.btnupdate.HoverFontColor = System.Drawing.Color.Maroon;
            this.btnupdate.ImageLeft = null;
            this.btnupdate.ImageRight = null;
            this.btnupdate.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnupdate.Location = new System.Drawing.Point(16, 224);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnupdate.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnupdate.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnupdate.Size = new System.Drawing.Size(142, 50);
            this.btnupdate.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnupdate.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.BackgroundColor = System.Drawing.Color.Maroon;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.CausesValidation = false;
            this.btndelete.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btndelete.ErrorImageLeft")));
            this.btndelete.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btndelete.ErrorImageRight")));
            this.btndelete.FocusBackground = System.Drawing.Color.Empty;
            this.btndelete.FocusFontColor = System.Drawing.Color.Empty;
            this.btndelete.ForeColors = System.Drawing.Color.White;
            this.btndelete.HoverBackground = System.Drawing.Color.Gold;
            this.btndelete.HoverFontColor = System.Drawing.Color.Maroon;
            this.btndelete.ImageLeft = null;
            this.btndelete.ImageRight = null;
            this.btndelete.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btndelete.Location = new System.Drawing.Point(17, 145);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btndelete.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btndelete.RightPictureColor = System.Drawing.Color.Transparent;
            this.btndelete.Size = new System.Drawing.Size(142, 50);
            this.btndelete.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btndelete.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btndelete.TabIndex = 10;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Maroon;
            this.btnadd.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnadd.ButtonText = "Add";
            this.btnadd.CausesValidation = false;
            this.btnadd.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnadd.ErrorImageLeft")));
            this.btnadd.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnadd.ErrorImageRight")));
            this.btnadd.FocusBackground = System.Drawing.Color.Empty;
            this.btnadd.FocusFontColor = System.Drawing.Color.Empty;
            this.btnadd.ForeColors = System.Drawing.Color.White;
            this.btnadd.HoverBackground = System.Drawing.Color.Gold;
            this.btnadd.HoverFontColor = System.Drawing.Color.Maroon;
            this.btnadd.ImageLeft = null;
            this.btnadd.ImageRight = null;
            this.btnadd.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnadd.Location = new System.Drawing.Point(16, 74);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnadd.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnadd.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnadd.Size = new System.Drawing.Size(143, 50);
            this.btnadd.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnadd.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnadd.TabIndex = 9;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 169);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.Maroon;
            this.btndisplay.BackgroundColor = System.Drawing.Color.Maroon;
            this.btndisplay.ButtonText = "Display";
            this.btndisplay.CausesValidation = false;
            this.btndisplay.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btndisplay.ErrorImageLeft")));
            this.btndisplay.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btndisplay.ErrorImageRight")));
            this.btndisplay.FocusBackground = System.Drawing.Color.Empty;
            this.btndisplay.FocusFontColor = System.Drawing.Color.Empty;
            this.btndisplay.ForeColors = System.Drawing.Color.White;
            this.btndisplay.HoverBackground = System.Drawing.Color.Gold;
            this.btndisplay.HoverFontColor = System.Drawing.Color.Maroon;
            this.btndisplay.ImageLeft = null;
            this.btndisplay.ImageRight = null;
            this.btndisplay.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btndisplay.Location = new System.Drawing.Point(17, 302);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btndisplay.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btndisplay.RightPictureColor = System.Drawing.Color.Transparent;
            this.btndisplay.Size = new System.Drawing.Size(142, 50);
            this.btndisplay.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btndisplay.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btndisplay.TabIndex = 12;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.Transparent;
            this.searchtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchtxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchtxt.ForeColors = System.Drawing.Color.Maroon;
            this.searchtxt.HintText = "Search";
            this.searchtxt.IsPassword = false;
            this.searchtxt.LineBackColor = System.Drawing.Color.Maroon;
            this.searchtxt.LineThickness = 3;
            this.searchtxt.Location = new System.Drawing.Point(228, 373);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchtxt.MaxLength = 32767;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.OnFocusedColor = System.Drawing.Color.Maroon;
            this.searchtxt.OnFocusedTextColor = System.Drawing.Color.Maroon;
            this.searchtxt.ReadOnly = false;
            this.searchtxt.Size = new System.Drawing.Size(150, 33);
            this.searchtxt.TabIndex = 10;
            this.searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtxt.TextName = "Search";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Maroon;
            this.btnsearch.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnsearch.ButtonText = "Search";
            this.btnsearch.CausesValidation = false;
            this.btnsearch.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnsearch.ErrorImageLeft")));
            this.btnsearch.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnsearch.ErrorImageRight")));
            this.btnsearch.FocusBackground = System.Drawing.Color.Empty;
            this.btnsearch.FocusFontColor = System.Drawing.Color.Empty;
            this.btnsearch.ForeColors = System.Drawing.Color.White;
            this.btnsearch.HoverBackground = System.Drawing.Color.Gold;
            this.btnsearch.HoverFontColor = System.Drawing.Color.Maroon;
            this.btnsearch.ImageLeft = null;
            this.btnsearch.ImageRight = null;
            this.btnsearch.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnsearch.Location = new System.Drawing.Point(417, 372);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnsearch.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnsearch.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnsearch.Size = new System.Drawing.Size(142, 41);
            this.btnsearch.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnsearch.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 594);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.urltxt);
            this.Controls.Add(this.acpasstxt);
            this.Controls.Add(this.acnametxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Labeltxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMaterialTextbox.JMaterialTextbox Labeltxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JMaterialTextbox.JMaterialTextbox acnametxt;
        private JMaterialTextbox.JMaterialTextbox acpasstxt;
        private JMaterialTextbox.JMaterialTextbox urltxt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private FlatButton.JFlatButton btnadd;
        private FlatButton.JFlatButton btndelete;
        private FlatButton.JFlatButton btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FlatButton.JFlatButton btndisplay;
        private JMaterialTextbox.JMaterialTextbox searchtxt;
        private FlatButton.JFlatButton btnsearch;
    }
}