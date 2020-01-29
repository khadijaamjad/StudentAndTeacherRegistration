namespace VP_XMLassignment
{
    partial class UpdateTea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTea));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbNewValue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.ddOptions = new Bunifu.Framework.UI.BunifuDropdown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbStaffId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(65, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 196;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 195;
            this.pictureBox2.TabStop = false;
            // 
            // tbNewValue
            // 
            this.tbNewValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNewValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewValue.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.tbNewValue.HintForeColor = System.Drawing.Color.DarkGray;
            this.tbNewValue.HintText = "New Value";
            this.tbNewValue.isPassword = false;
            this.tbNewValue.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.tbNewValue.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.tbNewValue.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.tbNewValue.LineThickness = 4;
            this.tbNewValue.Location = new System.Drawing.Point(124, 287);
            this.tbNewValue.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(222, 30);
            this.tbNewValue.TabIndex = 194;
            this.tbNewValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(67, 145);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(39, 34);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox12.TabIndex = 193;
            this.pictureBox12.TabStop = false;
            // 
            // ddOptions
            // 
            this.ddOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.ddOptions.BorderRadius = 0;
            this.ddOptions.DisabledColor = System.Drawing.Color.Gray;
            this.ddOptions.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ddOptions.Items = new string[] {
        "What do you want to update?",
        "FirstName",
        "LastName",
        "PhoneNo",
        "Email",
        "Department",
        "Username",
        "Password"};
            this.ddOptions.Location = new System.Drawing.Point(124, 217);
            this.ddOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddOptions.Name = "ddOptions";
            this.ddOptions.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.ddOptions.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.ddOptions.selectedIndex = -1;
            this.ddOptions.Size = new System.Drawing.Size(222, 31);
            this.ddOptions.TabIndex = 191;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 190;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(412, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 188;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(69, 24);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(324, 39);
            this.bunifuCustomLabel3.TabIndex = 187;
            this.bunifuCustomLabel3.Text = "Update Teacher Record";
            // 
            // tbStaffId
            // 
            this.tbStaffId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbStaffId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStaffId.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.tbStaffId.HintForeColor = System.Drawing.Color.DarkGray;
            this.tbStaffId.HintText = "Staff ID";
            this.tbStaffId.isPassword = false;
            this.tbStaffId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.tbStaffId.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.tbStaffId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.tbStaffId.LineThickness = 4;
            this.tbStaffId.Location = new System.Drawing.Point(124, 149);
            this.tbStaffId.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbStaffId.Name = "tbStaffId";
            this.tbStaffId.Size = new System.Drawing.Size(222, 30);
            this.tbStaffId.TabIndex = 197;
            this.tbStaffId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Update Teacher";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(114, 394);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(204, 41);
            this.bunifuFlatButton1.TabIndex = 198;
            this.bunifuFlatButton1.Text = "Update Teacher";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // UpdateTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 471);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.tbStaffId);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.ddOptions);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateTea";
            this.Text = "UpdateTea";
            this.Load += new System.EventHandler(this.UpdateTea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewValue;
        private System.Windows.Forms.PictureBox pictureBox12;
        private Bunifu.Framework.UI.BunifuDropdown ddOptions;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbStaffId;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}