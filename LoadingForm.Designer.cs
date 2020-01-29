namespace VP_XMLassignment
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTeacher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRecords = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditStu = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(166, 27);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(149, 39);
            this.bunifuCustomLabel3.TabIndex = 108;
            this.bunifuCustomLabel3.Text = "Welcome!";
            // 
            // btnStu
            // 
            this.btnStu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnStu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStu.BorderRadius = 0;
            this.btnStu.ButtonText = "Register Student";
            this.btnStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStu.DisabledColor = System.Drawing.Color.Gray;
            this.btnStu.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStu.Iconimage")));
            this.btnStu.Iconimage_right = null;
            this.btnStu.Iconimage_right_Selected = null;
            this.btnStu.Iconimage_Selected = null;
            this.btnStu.IconMarginLeft = 0;
            this.btnStu.IconMarginRight = 0;
            this.btnStu.IconRightVisible = true;
            this.btnStu.IconRightZoom = 0D;
            this.btnStu.IconVisible = true;
            this.btnStu.IconZoom = 90D;
            this.btnStu.IsTab = false;
            this.btnStu.Location = new System.Drawing.Point(27, 201);
            this.btnStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStu.Name = "btnStu";
            this.btnStu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnStu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.btnStu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStu.selected = false;
            this.btnStu.Size = new System.Drawing.Size(204, 41);
            this.btnStu.TabIndex = 167;
            this.btnStu.Text = "Register Student";
            this.btnStu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStu.Textcolor = System.Drawing.Color.White;
            this.btnStu.TextFont = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacher.BorderRadius = 0;
            this.btnTeacher.ButtonText = "Register Teacher";
            this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacher.DisabledColor = System.Drawing.Color.Gray;
            this.btnTeacher.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTeacher.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Iconimage")));
            this.btnTeacher.Iconimage_right = null;
            this.btnTeacher.Iconimage_right_Selected = null;
            this.btnTeacher.Iconimage_Selected = null;
            this.btnTeacher.IconMarginLeft = 0;
            this.btnTeacher.IconMarginRight = 0;
            this.btnTeacher.IconRightVisible = true;
            this.btnTeacher.IconRightZoom = 0D;
            this.btnTeacher.IconVisible = true;
            this.btnTeacher.IconZoom = 90D;
            this.btnTeacher.IsTab = false;
            this.btnTeacher.Location = new System.Drawing.Point(27, 252);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnTeacher.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.btnTeacher.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTeacher.selected = false;
            this.btnTeacher.Size = new System.Drawing.Size(204, 41);
            this.btnTeacher.TabIndex = 168;
            this.btnTeacher.Text = "Register Teacher";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Textcolor = System.Drawing.Color.White;
            this.btnTeacher.TextFont = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(434, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 169;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecords.BorderRadius = 0;
            this.btnRecords.ButtonText = "View Records";
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecords.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecords.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRecords.Iconimage")));
            this.btnRecords.Iconimage_right = null;
            this.btnRecords.Iconimage_right_Selected = null;
            this.btnRecords.Iconimage_Selected = null;
            this.btnRecords.IconMarginLeft = 0;
            this.btnRecords.IconMarginRight = 0;
            this.btnRecords.IconRightVisible = true;
            this.btnRecords.IconRightZoom = 0D;
            this.btnRecords.IconVisible = true;
            this.btnRecords.IconZoom = 90D;
            this.btnRecords.IsTab = false;
            this.btnRecords.Location = new System.Drawing.Point(144, 303);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnRecords.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.btnRecords.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRecords.selected = false;
            this.btnRecords.Size = new System.Drawing.Size(204, 41);
            this.btnRecords.TabIndex = 170;
            this.btnRecords.Text = "View Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Textcolor = System.Drawing.Color.White;
            this.btnRecords.TextFont = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(243, 252);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(204, 41);
            this.bunifuFlatButton1.TabIndex = 172;
            this.bunifuFlatButton1.Text = "Update Teacher";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnEditStu
            // 
            this.btnEditStu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnEditStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnEditStu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditStu.BorderRadius = 0;
            this.btnEditStu.ButtonText = "Update Student";
            this.btnEditStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStu.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditStu.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditStu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditStu.Iconimage")));
            this.btnEditStu.Iconimage_right = null;
            this.btnEditStu.Iconimage_right_Selected = null;
            this.btnEditStu.Iconimage_Selected = null;
            this.btnEditStu.IconMarginLeft = 0;
            this.btnEditStu.IconMarginRight = 0;
            this.btnEditStu.IconRightVisible = true;
            this.btnEditStu.IconRightZoom = 0D;
            this.btnEditStu.IconVisible = true;
            this.btnEditStu.IconZoom = 90D;
            this.btnEditStu.IsTab = false;
            this.btnEditStu.Location = new System.Drawing.Point(243, 201);
            this.btnEditStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEditStu.Name = "btnEditStu";
            this.btnEditStu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnEditStu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.btnEditStu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditStu.selected = false;
            this.btnEditStu.Size = new System.Drawing.Size(204, 41);
            this.btnEditStu.TabIndex = 171;
            this.btnEditStu.Text = "Update Student";
            this.btnEditStu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStu.Textcolor = System.Drawing.Color.White;
            this.btnEditStu.TextFont = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStu.Click += new System.EventHandler(this.btnEditStu_Click);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 403);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnEditStu);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStu);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnTeacher;
        private Bunifu.Framework.UI.BunifuFlatButton btnStu;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecords;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditStu;
    }
}