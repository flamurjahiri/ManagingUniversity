namespace ProjektiOrari.Views
{
    partial class StudentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.butoniX = new System.Windows.Forms.Button();
            this.feedbackButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.chatButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.AllowDrop = true;
            this.bunifuDropdown1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownHeight = 126;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.DropDownWidth = 200;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.Purple;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.IntegralHeight = false;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.bunifuDropdown1.Items.AddRange(new object[] {
            "Nderro te dhenat",
            "Logout"});
            this.bunifuDropdown1.Location = new System.Drawing.Point(0, 44);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(40, 32);
            this.bunifuDropdown1.TabIndex = 31;
            this.bunifuDropdown1.Text = null;
            this.bunifuDropdown1.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 581);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // userInfo
            // 
            this.userInfo.AutoEllipsis = false;
            this.userInfo.AutoSize = false;
            this.userInfo.AutoSizeHeightOnly = true;
            this.userInfo.CursorType = null;
            this.userInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfo.ForeColor = System.Drawing.Color.DimGray;
            this.userInfo.Location = new System.Drawing.Point(41, 46);
            this.userInfo.Name = "userInfo";
            this.userInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userInfo.Size = new System.Drawing.Size(149, 30);
            this.userInfo.TabIndex = 23;
            this.userInfo.Text = "Emri Mbiemri";
            this.userInfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.userInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.userInfo.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Shiko Orarin";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(13, 140);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.bunifuButton1.onHoverState.BorderRadius = 3;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 3;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 3;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(155, 41);
            this.bunifuButton1.TabIndex = 24;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMax.BackgroundImage")));
            this.buttonMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMax.Location = new System.Drawing.Point(795, 4);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(28, 28);
            this.buttonMax.TabIndex = 26;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.BackColor = System.Drawing.Color.Transparent;
            this.buttonMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMin.BackgroundImage")));
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMin.Location = new System.Drawing.Point(761, 4);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(28, 28);
            this.buttonMin.TabIndex = 25;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // butoniX
            // 
            this.butoniX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butoniX.BackColor = System.Drawing.Color.Transparent;
            this.butoniX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butoniX.BackgroundImage")));
            this.butoniX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butoniX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butoniX.Location = new System.Drawing.Point(829, 4);
            this.butoniX.Name = "butoniX";
            this.butoniX.Size = new System.Drawing.Size(28, 28);
            this.butoniX.TabIndex = 27;
            this.butoniX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butoniX.UseVisualStyleBackColor = false;
            this.butoniX.Click += new System.EventHandler(this.butoniX_Click);
            // 
            // feedbackButton
            // 
            this.feedbackButton.AllowToggling = false;
            this.feedbackButton.AnimationSpeed = 200;
            this.feedbackButton.AutoGenerateColors = false;
            this.feedbackButton.BackColor = System.Drawing.Color.Transparent;
            this.feedbackButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.feedbackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("feedbackButton.BackgroundImage")));
            this.feedbackButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.feedbackButton.ButtonText = "Feedback";
            this.feedbackButton.ButtonTextMarginLeft = 0;
            this.feedbackButton.ColorContrastOnClick = 45;
            this.feedbackButton.ColorContrastOnHover = 45;
            this.feedbackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.feedbackButton.CustomizableEdges = borderEdges2;
            this.feedbackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.feedbackButton.DisabledBorderColor = System.Drawing.Color.Empty;
            this.feedbackButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.feedbackButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.feedbackButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.feedbackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.feedbackButton.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackButton.IconMarginLeft = 11;
            this.feedbackButton.IconPadding = 10;
            this.feedbackButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.feedbackButton.IdleBorderRadius = 3;
            this.feedbackButton.IdleBorderThickness = 1;
            this.feedbackButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.feedbackButton.IdleIconLeftImage = null;
            this.feedbackButton.IdleIconRightImage = null;
            this.feedbackButton.IndicateFocus = false;
            this.feedbackButton.Location = new System.Drawing.Point(13, 265);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.feedbackButton.onHoverState.BorderRadius = 3;
            this.feedbackButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.feedbackButton.onHoverState.BorderThickness = 1;
            this.feedbackButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.feedbackButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.onHoverState.IconLeftImage = null;
            this.feedbackButton.onHoverState.IconRightImage = null;
            this.feedbackButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.feedbackButton.OnIdleState.BorderRadius = 3;
            this.feedbackButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.feedbackButton.OnIdleState.BorderThickness = 1;
            this.feedbackButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.feedbackButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.OnIdleState.IconLeftImage = null;
            this.feedbackButton.OnIdleState.IconRightImage = null;
            this.feedbackButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.feedbackButton.OnPressedState.BorderRadius = 3;
            this.feedbackButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.feedbackButton.OnPressedState.BorderThickness = 1;
            this.feedbackButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.feedbackButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.OnPressedState.IconLeftImage = null;
            this.feedbackButton.OnPressedState.IconRightImage = null;
            this.feedbackButton.Size = new System.Drawing.Size(155, 41);
            this.feedbackButton.TabIndex = 28;
            this.feedbackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.feedbackButton.TextMarginLeft = 0;
            this.feedbackButton.UseDefaultRadiusAndThickness = true;
            this.feedbackButton.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "Nderrimi i orarit";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges3;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton3.IdleBorderRadius = 3;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(13, 201);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.bunifuButton3.onHoverState.BorderRadius = 3;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton3.OnIdleState.BorderRadius = 3;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = null;
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.BorderRadius = 3;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(155, 41);
            this.bunifuButton3.TabIndex = 29;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // chatButton
            // 
            this.chatButton.AllowToggling = false;
            this.chatButton.AnimationSpeed = 200;
            this.chatButton.AutoGenerateColors = false;
            this.chatButton.BackColor = System.Drawing.Color.Transparent;
            this.chatButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.chatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chatButton.BackgroundImage")));
            this.chatButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chatButton.ButtonText = "Chat";
            this.chatButton.ButtonTextMarginLeft = 0;
            this.chatButton.ColorContrastOnClick = 45;
            this.chatButton.ColorContrastOnHover = 45;
            this.chatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.chatButton.CustomizableEdges = borderEdges4;
            this.chatButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.chatButton.DisabledBorderColor = System.Drawing.Color.Empty;
            this.chatButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chatButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.chatButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.chatButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chatButton.ForeColor = System.Drawing.Color.White;
            this.chatButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.chatButton.IconMarginLeft = 11;
            this.chatButton.IconPadding = 10;
            this.chatButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.chatButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.chatButton.IdleBorderRadius = 3;
            this.chatButton.IdleBorderThickness = 1;
            this.chatButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.chatButton.IdleIconLeftImage = null;
            this.chatButton.IdleIconRightImage = null;
            this.chatButton.IndicateFocus = false;
            this.chatButton.Location = new System.Drawing.Point(13, 324);
            this.chatButton.Name = "chatButton";
            this.chatButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.chatButton.onHoverState.BorderRadius = 3;
            this.chatButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chatButton.onHoverState.BorderThickness = 1;
            this.chatButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(182)))));
            this.chatButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.chatButton.onHoverState.IconLeftImage = null;
            this.chatButton.onHoverState.IconRightImage = null;
            this.chatButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.chatButton.OnIdleState.BorderRadius = 3;
            this.chatButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chatButton.OnIdleState.BorderThickness = 1;
            this.chatButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.chatButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.chatButton.OnIdleState.IconLeftImage = null;
            this.chatButton.OnIdleState.IconRightImage = null;
            this.chatButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.chatButton.OnPressedState.BorderRadius = 3;
            this.chatButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chatButton.OnPressedState.BorderThickness = 1;
            this.chatButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.chatButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.chatButton.OnPressedState.IconLeftImage = null;
            this.chatButton.OnPressedState.IconRightImage = null;
            this.chatButton.Size = new System.Drawing.Size(155, 41);
            this.chatButton.TabIndex = 30;
            this.chatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chatButton.TextMarginLeft = 0;
            this.chatButton.UseDefaultRadiusAndThickness = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(199, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 523);
            this.panel1.TabIndex = 32;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.butoniX);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPanel";
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel userInfo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button butoniX;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton feedbackButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton chatButton;
        private System.Windows.Forms.Panel panel1;
    }
}