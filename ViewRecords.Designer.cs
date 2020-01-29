namespace VP_XMLassignment
{
    partial class ViewRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddType = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgRecords = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(632, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 173;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(215, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(194, 39);
            this.bunifuCustomLabel3.TabIndex = 170;
            this.bunifuCustomLabel3.Text = "View Records";
            // 
            // ddType
            // 
            this.ddType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.ddType.BorderRadius = 0;
            this.ddType.DisabledColor = System.Drawing.Color.Gray;
            this.ddType.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ddType.Items = new string[] {
        "",
        "Teachers",
        "Students"};
            this.ddType.Location = new System.Drawing.Point(361, 93);
            this.ddType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddType.Name = "ddType";
            this.ddType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.ddType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.ddType.selectedIndex = 0;
            this.ddType.Size = new System.Drawing.Size(262, 31);
            this.ddType.TabIndex = 174;
            this.ddType.onItemSelected += new System.EventHandler(this.ddType_onItemSelected);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(28, 105);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(326, 19);
            this.bunifuCustomLabel1.TabIndex = 175;
            this.bunifuCustomLabel1.Text = "Select the user type you want to view data for:";
            // 
            // dgRecords
            // 
            this.dgRecords.AllowUserToAddRows = false;
            this.dgRecords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRecords.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecords.DoubleBuffered = true;
            this.dgRecords.EnableHeadersVisualStyles = false;
            this.dgRecords.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgRecords.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgRecords.Location = new System.Drawing.Point(41, 162);
            this.dgRecords.Name = "dgRecords";
            this.dgRecords.ReadOnly = true;
            this.dgRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgRecords.Size = new System.Drawing.Size(582, 277);
            this.dgRecords.TabIndex = 176;
            // 
            // ViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 486);
            this.Controls.Add(this.dgRecords);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ddType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewRecords";
            this.Text = "ViewRecords";
            this.Load += new System.EventHandler(this.ViewRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown ddType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgRecords;
    }
}