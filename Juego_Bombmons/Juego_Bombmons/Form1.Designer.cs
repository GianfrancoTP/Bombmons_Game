namespace Juego_Bombmons
{
    partial class GameWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MenuLBL = new System.Windows.Forms.Label();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Records = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.GamePanel1 = new System.Windows.Forms.Panel();
            this.GamePanel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewGame = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.OpenAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NewGameElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.GamePanel1.SuspendLayout();
            this.GamePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.TopPanel.Controls.Add(this.MenuLBL);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Controls.Add(this.MenuButton);
            this.OpenAnimation.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1052, 57);
            this.TopPanel.TabIndex = 0;
            // 
            // MenuLBL
            // 
            this.MenuLBL.AutoSize = true;
            this.CloseAnimation.SetDecoration(this.MenuLBL, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MenuLBL, BunifuAnimatorNS.DecorationType.None);
            this.MenuLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLBL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuLBL.Location = new System.Drawing.Point(73, 18);
            this.MenuLBL.Name = "MenuLBL";
            this.MenuLBL.Size = new System.Drawing.Size(59, 24);
            this.MenuLBL.TabIndex = 3;
            this.MenuLBL.Text = "Menu";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.OpenAnimation.SetDecoration(this.Close, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.Close, BunifuAnimatorNS.DecorationType.None);
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageActive = null;
            this.Close.Location = new System.Drawing.Point(1010, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.Close.Zoom = 10;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.OpenAnimation.SetDecoration(this.Minimize, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.Minimize, BunifuAnimatorNS.DecorationType.None);
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageActive = null;
            this.Minimize.Location = new System.Drawing.Point(974, 13);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Zoom = 10;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenAnimation.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImageActive = null;
            this.MenuButton.Location = new System.Drawing.Point(27, 12);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(30, 30);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Zoom = 10;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuPanel.Controls.Add(this.MenuBar);
            this.OpenAnimation.SetDecoration(this.MenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 57);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(300, 825);
            this.MenuPanel.TabIndex = 1;
            // 
            // MenuBar
            // 
            this.MenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuBar.BackgroundImage")));
            this.MenuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBar.Controls.Add(this.Settings);
            this.MenuBar.Controls.Add(this.Records);
            this.OpenAnimation.SetDecoration(this.MenuBar, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MenuBar, BunifuAnimatorNS.DecorationType.None);
            this.MenuBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuBar.Location = new System.Drawing.Point(15, 22);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Quality = 10;
            this.MenuBar.Size = new System.Drawing.Size(279, 791);
            this.MenuBar.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Activecolor = System.Drawing.Color.Transparent;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.BorderRadius = 0;
            this.Settings.ButtonText = "      Settings";
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAnimation.SetDecoration(this.Settings, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.Settings, BunifuAnimatorNS.DecorationType.None);
            this.Settings.DisabledColor = System.Drawing.Color.Gray;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.Settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("Settings.Iconimage")));
            this.Settings.Iconimage_right = null;
            this.Settings.Iconimage_right_Selected = null;
            this.Settings.Iconimage_Selected = null;
            this.Settings.IconMarginLeft = 0;
            this.Settings.IconMarginRight = 0;
            this.Settings.IconRightVisible = true;
            this.Settings.IconRightZoom = 0D;
            this.Settings.IconVisible = true;
            this.Settings.IconZoom = 50D;
            this.Settings.IsTab = false;
            this.Settings.Location = new System.Drawing.Point(6, 119);
            this.Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Settings.Name = "Settings";
            this.Settings.Normalcolor = System.Drawing.Color.Transparent;
            this.Settings.OnHovercolor = System.Drawing.Color.Transparent;
            this.Settings.OnHoverTextColor = System.Drawing.Color.White;
            this.Settings.selected = false;
            this.Settings.Size = new System.Drawing.Size(238, 59);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "      Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Textcolor = System.Drawing.Color.LightGray;
            this.Settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Records
            // 
            this.Records.Activecolor = System.Drawing.Color.Transparent;
            this.Records.BackColor = System.Drawing.Color.Transparent;
            this.Records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Records.BorderRadius = 0;
            this.Records.ButtonText = "      Records";
            this.Records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAnimation.SetDecoration(this.Records, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.Records, BunifuAnimatorNS.DecorationType.None);
            this.Records.DisabledColor = System.Drawing.Color.Gray;
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.Iconcolor = System.Drawing.Color.Transparent;
            this.Records.Iconimage = ((System.Drawing.Image)(resources.GetObject("Records.Iconimage")));
            this.Records.Iconimage_right = null;
            this.Records.Iconimage_right_Selected = null;
            this.Records.Iconimage_Selected = null;
            this.Records.IconMarginLeft = 0;
            this.Records.IconMarginRight = 0;
            this.Records.IconRightVisible = true;
            this.Records.IconRightZoom = 0D;
            this.Records.IconVisible = true;
            this.Records.IconZoom = 50D;
            this.Records.IsTab = false;
            this.Records.Location = new System.Drawing.Point(6, 42);
            this.Records.Margin = new System.Windows.Forms.Padding(4);
            this.Records.Name = "Records";
            this.Records.Normalcolor = System.Drawing.Color.Transparent;
            this.Records.OnHovercolor = System.Drawing.Color.Transparent;
            this.Records.OnHoverTextColor = System.Drawing.Color.White;
            this.Records.selected = false;
            this.Records.Size = new System.Drawing.Size(238, 59);
            this.Records.TabIndex = 0;
            this.Records.Text = "      Records";
            this.Records.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Records.Textcolor = System.Drawing.Color.LightGray;
            this.Records.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.CloseAnimation.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(43, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "label3";
            // 
            // GamePanel1
            // 
            this.GamePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.GamePanel1.Controls.Add(this.GamePanel2);
            this.OpenAnimation.SetDecoration(this.GamePanel1, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.GamePanel1, BunifuAnimatorNS.DecorationType.None);
            this.GamePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel1.Location = new System.Drawing.Point(300, 57);
            this.GamePanel1.Name = "GamePanel1";
            this.GamePanel1.Size = new System.Drawing.Size(752, 825);
            this.GamePanel1.TabIndex = 2;
            // 
            // GamePanel2
            // 
            this.GamePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.GamePanel2.Controls.Add(this.panel1);
            this.GamePanel2.Controls.Add(this.tableLayoutPanel1);
            this.GamePanel2.Controls.Add(this.NewGame);
            this.GamePanel2.Controls.Add(this.label2);
            this.GamePanel2.Controls.Add(this.label1);
            this.OpenAnimation.SetDecoration(this.GamePanel2, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.GamePanel2, BunifuAnimatorNS.DecorationType.None);
            this.GamePanel2.Location = new System.Drawing.Point(10, 22);
            this.GamePanel2.Name = "GamePanel2";
            this.GamePanel2.Size = new System.Drawing.Size(730, 791);
            this.GamePanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.OpenAnimation.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 595);
            this.tableLayoutPanel1.TabIndex = 69;
            // 
            // NewGame
            // 
            this.NewGame.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewGame.BorderRadius = 0;
            this.NewGame.ButtonText = "     New Game";
            this.NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAnimation.SetDecoration(this.NewGame, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.NewGame, BunifuAnimatorNS.DecorationType.None);
            this.NewGame.DisabledColor = System.Drawing.Color.Gray;
            this.NewGame.Iconcolor = System.Drawing.Color.Transparent;
            this.NewGame.Iconimage = null;
            this.NewGame.Iconimage_right = null;
            this.NewGame.Iconimage_right_Selected = null;
            this.NewGame.Iconimage_Selected = null;
            this.NewGame.IconMarginLeft = 0;
            this.NewGame.IconMarginRight = 0;
            this.NewGame.IconRightVisible = true;
            this.NewGame.IconRightZoom = 0D;
            this.NewGame.IconVisible = true;
            this.NewGame.IconZoom = 90D;
            this.NewGame.IsTab = false;
            this.NewGame.Location = new System.Drawing.Point(544, 42);
            this.NewGame.Name = "NewGame";
            this.NewGame.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NewGame.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NewGame.OnHoverTextColor = System.Drawing.Color.White;
            this.NewGame.selected = false;
            this.NewGame.Size = new System.Drawing.Size(104, 48);
            this.NewGame.TabIndex = 68;
            this.NewGame.Text = "     New Game";
            this.NewGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewGame.Textcolor = System.Drawing.Color.White;
            this.NewGame.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.CloseAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 39);
            this.label2.TabIndex = 67;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.CloseAnimation.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 66;
            this.label1.Text = "label1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.MenuBar;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 8;
            this.bunifuElipse2.TargetControl = this;
            // 
            // CloseAnimation
            // 
            this.CloseAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.CloseAnimation.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.CloseAnimation.DefaultAnimation = animation4;
            // 
            // OpenAnimation
            // 
            this.OpenAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.OpenAnimation.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.OpenAnimation.DefaultAnimation = animation3;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.GamePanel2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // NewGameElipse
            // 
            this.NewGameElipse.ElipseRadius = 5;
            this.NewGameElipse.TargetControl = this.NewGame;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.OpenAnimation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 784);
            this.panel1.TabIndex = 70;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 882);
            this.Controls.Add(this.GamePanel1);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TopPanel);
            this.OpenAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.GamePanel1.ResumeLayout(false);
            this.GamePanel2.ResumeLayout(false);
            this.GamePanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel GamePanel1;
        private Bunifu.Framework.UI.BunifuImageButton Close;
        private Bunifu.Framework.UI.BunifuImageButton Minimize;
        private Bunifu.Framework.UI.BunifuImageButton MenuButton;
        private System.Windows.Forms.Label MenuLBL;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuBar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton Settings;
        private Bunifu.Framework.UI.BunifuFlatButton Records;
        private BunifuAnimatorNS.BunifuTransition CloseAnimation;
        private BunifuAnimatorNS.BunifuTransition OpenAnimation;
        private System.Windows.Forms.Panel GamePanel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton NewGame;
        private Bunifu.Framework.UI.BunifuElipse NewGameElipse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

