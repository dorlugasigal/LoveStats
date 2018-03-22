namespace LoveStats
{
    partial class frmMain
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pictureBoxSmallLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnChat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPartner = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStats = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewStats = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelUC = new System.Windows.Forms.Panel();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelButtons.Controls.Add(this.pictureBoxSmallLogo);
            this.panelButtons.Controls.Add(this.pictureBoxLogo);
            this.panelButtons.Controls.Add(this.btnChat);
            this.panelButtons.Controls.Add(this.btnPartner);
            this.panelButtons.Controls.Add(this.btnStats);
            this.panelButtons.Controls.Add(this.btnNewStats);
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Controls.Add(this.btnMenu);
            this.PanelTransition.SetDecoration(this.panelButtons, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelButtons, BunifuAnimatorNS.DecorationType.None);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 55);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(361, 590);
            this.panelButtons.TabIndex = 0;
            // 
            // pictureBoxSmallLogo
            // 
            this.LogoTransition.SetDecoration(this.pictureBoxSmallLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBoxSmallLogo, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxSmallLogo.Image = global::LoveStats.Properties.Resources.LogoSmall;
            this.pictureBoxSmallLogo.Location = new System.Drawing.Point(9, 72);
            this.pictureBoxSmallLogo.Name = "pictureBoxSmallLogo";
            this.pictureBoxSmallLogo.Size = new System.Drawing.Size(50, 65);
            this.pictureBoxSmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSmallLogo.TabIndex = 8;
            this.pictureBoxSmallLogo.TabStop = false;
            this.pictureBoxSmallLogo.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.LogoTransition.SetDecoration(this.pictureBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxLogo.Image = global::LoveStats.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(59, 55);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(235, 76);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnChat
            // 
            this.btnChat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChat.BorderRadius = 0;
            this.btnChat.ButtonText = "               Chat";
            this.btnChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnChat, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnChat, BunifuAnimatorNS.DecorationType.None);
            this.btnChat.DisabledColor = System.Drawing.Color.Gray;
            this.btnChat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChat.Iconimage = global::LoveStats.Properties.Resources.icons8_Chat_32px;
            this.btnChat.Iconimage_right = null;
            this.btnChat.Iconimage_right_Selected = null;
            this.btnChat.Iconimage_Selected = null;
            this.btnChat.IconMarginLeft = 0;
            this.btnChat.IconMarginRight = 0;
            this.btnChat.IconRightVisible = true;
            this.btnChat.IconRightZoom = 0D;
            this.btnChat.IconVisible = true;
            this.btnChat.IconZoom = 50D;
            this.btnChat.IsTab = true;
            this.btnChat.Location = new System.Drawing.Point(0, 423);
            this.btnChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChat.Name = "btnChat";
            this.btnChat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnChat.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnChat.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnChat.selected = false;
            this.btnChat.Size = new System.Drawing.Size(361, 59);
            this.btnChat.TabIndex = 6;
            this.btnChat.Text = "               Chat";
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.Textcolor = System.Drawing.Color.Silver;
            this.btnChat.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPartner
            // 
            this.btnPartner.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPartner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPartner.BorderRadius = 0;
            this.btnPartner.ButtonText = "               Partner";
            this.btnPartner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnPartner, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnPartner, BunifuAnimatorNS.DecorationType.None);
            this.btnPartner.DisabledColor = System.Drawing.Color.Gray;
            this.btnPartner.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPartner.Iconimage = global::LoveStats.Properties.Resources.icons8_Romance_32px;
            this.btnPartner.Iconimage_right = null;
            this.btnPartner.Iconimage_right_Selected = null;
            this.btnPartner.Iconimage_Selected = null;
            this.btnPartner.IconMarginLeft = 0;
            this.btnPartner.IconMarginRight = 0;
            this.btnPartner.IconRightVisible = true;
            this.btnPartner.IconRightZoom = 0D;
            this.btnPartner.IconVisible = true;
            this.btnPartner.IconZoom = 50D;
            this.btnPartner.IsTab = true;
            this.btnPartner.Location = new System.Drawing.Point(0, 358);
            this.btnPartner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPartner.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnPartner.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnPartner.selected = false;
            this.btnPartner.Size = new System.Drawing.Size(361, 59);
            this.btnPartner.TabIndex = 5;
            this.btnPartner.Text = "               Partner";
            this.btnPartner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartner.Textcolor = System.Drawing.Color.Silver;
            this.btnPartner.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStats
            // 
            this.btnStats.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStats.BorderRadius = 0;
            this.btnStats.ButtonText = "               Stats";
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnStats, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnStats, BunifuAnimatorNS.DecorationType.None);
            this.btnStats.DisabledColor = System.Drawing.Color.Gray;
            this.btnStats.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStats.Iconimage = global::LoveStats.Properties.Resources.icons8_Bar_Chart_32px_1;
            this.btnStats.Iconimage_right = null;
            this.btnStats.Iconimage_right_Selected = null;
            this.btnStats.Iconimage_Selected = null;
            this.btnStats.IconMarginLeft = 0;
            this.btnStats.IconMarginRight = 0;
            this.btnStats.IconRightVisible = true;
            this.btnStats.IconRightZoom = 0D;
            this.btnStats.IconVisible = true;
            this.btnStats.IconZoom = 50D;
            this.btnStats.IsTab = true;
            this.btnStats.Location = new System.Drawing.Point(0, 293);
            this.btnStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStats.Name = "btnStats";
            this.btnStats.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnStats.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnStats.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnStats.selected = false;
            this.btnStats.Size = new System.Drawing.Size(361, 59);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "               Stats";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Textcolor = System.Drawing.Color.Silver;
            this.btnStats.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNewStats
            // 
            this.btnNewStats.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNewStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNewStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewStats.BorderRadius = 0;
            this.btnNewStats.ButtonText = "               New Stats";
            this.btnNewStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnNewStats, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnNewStats, BunifuAnimatorNS.DecorationType.None);
            this.btnNewStats.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewStats.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewStats.Iconimage = global::LoveStats.Properties.Resources.icons8_Create_32px;
            this.btnNewStats.Iconimage_right = null;
            this.btnNewStats.Iconimage_right_Selected = null;
            this.btnNewStats.Iconimage_Selected = null;
            this.btnNewStats.IconMarginLeft = 0;
            this.btnNewStats.IconMarginRight = 0;
            this.btnNewStats.IconRightVisible = true;
            this.btnNewStats.IconRightZoom = 0D;
            this.btnNewStats.IconVisible = true;
            this.btnNewStats.IconZoom = 50D;
            this.btnNewStats.IsTab = true;
            this.btnNewStats.Location = new System.Drawing.Point(0, 228);
            this.btnNewStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewStats.Name = "btnNewStats";
            this.btnNewStats.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNewStats.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnNewStats.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnNewStats.selected = false;
            this.btnNewStats.Size = new System.Drawing.Size(361, 59);
            this.btnNewStats.TabIndex = 3;
            this.btnNewStats.Text = "               New Stats";
            this.btnNewStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewStats.Textcolor = System.Drawing.Color.Silver;
            this.btnNewStats.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStats.Click += new System.EventHandler(this.btnNewStats_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "               Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::LoveStats.Properties.Resources.icons8_Home_32px_1;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 50D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 163);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(361, 59);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "               Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.Silver;
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::LoveStats.Properties.Resources.icons8_Menu_32px;
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(315, 11);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(34, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.pictureBoxIcon);
            this.panelTop.Controls.Add(this.lblTitle);
            this.PanelTransition.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1091, 55);
            this.panelTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PanelTransition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = global::LoveStats.Properties.Resources.icons8_Delete_32px;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1046, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxIcon
            // 
            this.LogoTransition.SetDecoration(this.pictureBoxIcon, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBoxIcon, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxIcon.Image = global::LoveStats.Properties.Resources.icons8_Heart_32px;
            this.pictureBoxIcon.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(36, 32);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.LogoTransition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(55, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Love Statistics Manager";
            // 
            // panelUC
            // 
            this.PanelTransition.SetDecoration(this.panelUC, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelUC, BunifuAnimatorNS.DecorationType.None);
            this.panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUC.Location = new System.Drawing.Point(361, 55);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(730, 590);
            this.panelUC.TabIndex = 1;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panelTop;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBoxIcon;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(30);
            animation6.RotateCoeff = 0.5F;
            animation6.RotateLimit = 0.2F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation6;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.PanelTransition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 1F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1091, 645);
            this.Controls.Add(this.panelUC);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelUC;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnChat;
        private Bunifu.Framework.UI.BunifuFlatButton btnPartner;
        private Bunifu.Framework.UI.BunifuFlatButton btnStats;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewStats;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxSmallLogo;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
    }
}

