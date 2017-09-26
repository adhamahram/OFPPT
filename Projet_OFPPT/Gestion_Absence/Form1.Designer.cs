namespace Gestion_Absence
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Title_Lable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Minimise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Close_pictureBox = new System.Windows.Forms.PictureBox();
            this.Humbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.mini_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Tree_Menu_panel = new System.Windows.Forms.Panel();
            this.btn_stat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_modul = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_stagi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_arch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_group = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_filieres = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_abs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Tree_Menu_panel_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).BeginInit();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Tree_Menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Title_Lable
            // 
            this.Title_Lable.AutoSize = true;
            this.logo_animator.SetDecoration(this.Title_Lable, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this.Title_Lable, BunifuAnimatorNS.DecorationType.None);
            this.Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_Lable.Location = new System.Drawing.Point(51, 17);
            this.Title_Lable.Name = "Title_Lable";
            this.Title_Lable.Size = new System.Drawing.Size(145, 20);
            this.Title_Lable.TabIndex = 1;
            this.Title_Lable.Text = "Gestion D\'absence";
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.Header_Panel.Controls.Add(this.Minimise_pictureBox);
            this.Header_Panel.Controls.Add(this.Maximise_pictureBox);
            this.Header_Panel.Controls.Add(this.Close_pictureBox);
            this.Header_Panel.Controls.Add(this.Title_Lable);
            this.Header_Panel.Controls.Add(this.Humbutton);
            this.Tree_Menu_panel_animator.SetDecoration(this.Header_Panel, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Header_Panel, BunifuAnimatorNS.DecorationType.None);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(958, 54);
            this.Header_Panel.TabIndex = 4;
            this.Header_Panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Header_Panel_MouseDoubleClick);
            // 
            // Minimise_pictureBox
            // 
            this.logo_animator.SetDecoration(this.Minimise_pictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this.Minimise_pictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Minimise_pictureBox.Image = global::Gestion_Absence.Properties.Resources.Reduire;
            this.Minimise_pictureBox.Location = new System.Drawing.Point(865, 27);
            this.Minimise_pictureBox.Name = "Minimise_pictureBox";
            this.Minimise_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Minimise_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimise_pictureBox.TabIndex = 4;
            this.Minimise_pictureBox.TabStop = false;
            this.Minimise_pictureBox.Click += new System.EventHandler(this.Minimise_pictureBox_Click);
            // 
            // Maximise_pictureBox
            // 
            this.logo_animator.SetDecoration(this.Maximise_pictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this.Maximise_pictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Maximise_pictureBox.Image = global::Gestion_Absence.Properties.Resources.Agrendire;
            this.Maximise_pictureBox.Location = new System.Drawing.Point(897, 21);
            this.Maximise_pictureBox.Name = "Maximise_pictureBox";
            this.Maximise_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Maximise_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximise_pictureBox.TabIndex = 3;
            this.Maximise_pictureBox.TabStop = false;
            this.Maximise_pictureBox.Click += new System.EventHandler(this.Maximise_pictureBox_Click);
            // 
            // Close_pictureBox
            // 
            this.logo_animator.SetDecoration(this.Close_pictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this.Close_pictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Close_pictureBox.Image = global::Gestion_Absence.Properties.Resources.Close;
            this.Close_pictureBox.Location = new System.Drawing.Point(930, 21);
            this.Close_pictureBox.Name = "Close_pictureBox";
            this.Close_pictureBox.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Close_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Close_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_pictureBox.TabIndex = 2;
            this.Close_pictureBox.TabStop = false;
            this.Close_pictureBox.Click += new System.EventHandler(this.Close_pictureBox_Click);
            // 
            // Humbutton
            // 
            this.Humbutton.BackColor = System.Drawing.Color.Transparent;
            this.Tree_Menu_panel_animator.SetDecoration(this.Humbutton, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Humbutton, BunifuAnimatorNS.DecorationType.None);
            this.Humbutton.Image = global::Gestion_Absence.Properties.Resources.menu;
            this.Humbutton.ImageActive = null;
            this.Humbutton.Location = new System.Drawing.Point(17, 13);
            this.Humbutton.Name = "Humbutton";
            this.Humbutton.Size = new System.Drawing.Size(25, 25);
            this.Humbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Humbutton.TabIndex = 0;
            this.Humbutton.TabStop = false;
            this.Humbutton.Zoom = 10;
            this.Humbutton.Click += new System.EventHandler(this.Humbutton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header_Panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.Logo_Panel.Controls.Add(this.mini_logo);
            this.Logo_Panel.Controls.Add(this.Logo_PictureBox);
            this.Tree_Menu_panel_animator.SetDecoration(this.Logo_Panel, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Logo_Panel, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(257, 212);
            this.Logo_Panel.TabIndex = 0;
            // 
            // mini_logo
            // 
            this.mini_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logo_animator.SetDecoration(this.mini_logo, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this.mini_logo, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini_logo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mini_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(155)))));
            this.mini_logo.Location = new System.Drawing.Point(12, 34);
            this.mini_logo.Name = "mini_logo";
            this.mini_logo.Size = new System.Drawing.Size(24, 132);
            this.mini_logo.TabIndex = 6;
            this.mini_logo.Text = "OFPPT";
            this.mini_logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Logo_PictureBox
            // 
            this.logo_animator.SetDecoration(this.Logo_PictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this.Logo_PictureBox, BunifuAnimatorNS.DecorationType.None);
            this.Logo_PictureBox.Image = global::Gestion_Absence.Properties.Resources.OFPPT;
            this.Logo_PictureBox.Location = new System.Drawing.Point(17, 34);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(227, 123);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Tree_Menu_panel
            // 
            this.Tree_Menu_panel.BackColor = System.Drawing.Color.White;
            this.Tree_Menu_panel.Controls.Add(this.btn_stat);
            this.Tree_Menu_panel.Controls.Add(this.btn_modul);
            this.Tree_Menu_panel.Controls.Add(this.btn_stagi);
            this.Tree_Menu_panel.Controls.Add(this.btn_arch);
            this.Tree_Menu_panel.Controls.Add(this.btn_group);
            this.Tree_Menu_panel.Controls.Add(this.btn_filieres);
            this.Tree_Menu_panel.Controls.Add(this.btn_abs);
            this.Tree_Menu_panel.Controls.Add(this.Logo_Panel);
            this.Tree_Menu_panel_animator.SetDecoration(this.Tree_Menu_panel, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Tree_Menu_panel, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tree_Menu_panel.Location = new System.Drawing.Point(0, 54);
            this.Tree_Menu_panel.Name = "Tree_Menu_panel";
            this.Tree_Menu_panel.Size = new System.Drawing.Size(257, 575);
            this.Tree_Menu_panel.TabIndex = 5;
            // 
            // btn_stat
            // 
            this.btn_stat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.btn_stat.BackColor = System.Drawing.Color.White;
            this.btn_stat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stat.BorderRadius = 0;
            this.btn_stat.ButtonText = "          Statistique";
            this.btn_stat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_stat, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_stat, BunifuAnimatorNS.DecorationType.None);
            this.btn_stat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_stat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_stat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_stat.Iconimage = global::Gestion_Absence.Properties.Resources.statistic;
            this.btn_stat.Iconimage_right = null;
            this.btn_stat.Iconimage_right_Selected = null;
            this.btn_stat.Iconimage_Selected = null;
            this.btn_stat.IconMarginLeft = 12;
            this.btn_stat.IconMarginRight = 0;
            this.btn_stat.IconRightVisible = true;
            this.btn_stat.IconRightZoom = 0D;
            this.btn_stat.IconVisible = true;
            this.btn_stat.IconZoom = 60D;
            this.btn_stat.IsTab = false;
            this.btn_stat.Location = new System.Drawing.Point(0, 212);
            this.btn_stat.Name = "btn_stat";
            this.btn_stat.Normalcolor = System.Drawing.Color.White;
            this.btn_stat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_stat.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_stat.selected = false;
            this.btn_stat.Size = new System.Drawing.Size(258, 48);
            this.btn_stat.TabIndex = 14;
            this.btn_stat.Text = "          Statistique";
            this.btn_stat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stat.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_stat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_modul
            // 
            this.btn_modul.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(155)))));
            this.btn_modul.BackColor = System.Drawing.Color.White;
            this.btn_modul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modul.BorderRadius = 0;
            this.btn_modul.ButtonText = "        Modules";
            this.btn_modul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_modul, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_modul, BunifuAnimatorNS.DecorationType.None);
            this.btn_modul.DisabledColor = System.Drawing.Color.Gray;
            this.btn_modul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_modul.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_modul.Iconimage = global::Gestion_Absence.Properties.Resources.Les_Modules;
            this.btn_modul.Iconimage_right = null;
            this.btn_modul.Iconimage_right_Selected = null;
            this.btn_modul.Iconimage_Selected = null;
            this.btn_modul.IconMarginLeft = 12;
            this.btn_modul.IconMarginRight = 0;
            this.btn_modul.IconRightVisible = true;
            this.btn_modul.IconRightZoom = 0D;
            this.btn_modul.IconVisible = true;
            this.btn_modul.IconZoom = 70D;
            this.btn_modul.IsTab = false;
            this.btn_modul.Location = new System.Drawing.Point(0, 462);
            this.btn_modul.Name = "btn_modul";
            this.btn_modul.Normalcolor = System.Drawing.Color.White;
            this.btn_modul.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_modul.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_modul.selected = false;
            this.btn_modul.Size = new System.Drawing.Size(258, 48);
            this.btn_modul.TabIndex = 11;
            this.btn_modul.Text = "        Modules";
            this.btn_modul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modul.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_modul.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_stagi
            // 
            this.btn_stagi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.btn_stagi.BackColor = System.Drawing.Color.White;
            this.btn_stagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stagi.BorderRadius = 0;
            this.btn_stagi.ButtonText = "          Stagiaires";
            this.btn_stagi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_stagi, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_stagi, BunifuAnimatorNS.DecorationType.None);
            this.btn_stagi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_stagi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_stagi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_stagi.Iconimage = global::Gestion_Absence.Properties.Resources.Student1;
            this.btn_stagi.Iconimage_right = null;
            this.btn_stagi.Iconimage_right_Selected = null;
            this.btn_stagi.Iconimage_Selected = null;
            this.btn_stagi.IconMarginLeft = 12;
            this.btn_stagi.IconMarginRight = 0;
            this.btn_stagi.IconRightVisible = true;
            this.btn_stagi.IconRightZoom = 0D;
            this.btn_stagi.IconVisible = true;
            this.btn_stagi.IconZoom = 60D;
            this.btn_stagi.IsTab = false;
            this.btn_stagi.Location = new System.Drawing.Point(0, 262);
            this.btn_stagi.Name = "btn_stagi";
            this.btn_stagi.Normalcolor = System.Drawing.Color.White;
            this.btn_stagi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_stagi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_stagi.selected = false;
            this.btn_stagi.Size = new System.Drawing.Size(258, 48);
            this.btn_stagi.TabIndex = 13;
            this.btn_stagi.Text = "          Stagiaires";
            this.btn_stagi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stagi.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_stagi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_arch
            // 
            this.btn_arch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.btn_arch.BackColor = System.Drawing.Color.White;
            this.btn_arch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_arch.BorderRadius = 0;
            this.btn_arch.ButtonText = "        Archive";
            this.btn_arch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_arch, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_arch, BunifuAnimatorNS.DecorationType.None);
            this.btn_arch.DisabledColor = System.Drawing.Color.Gray;
            this.btn_arch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_arch.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_arch.Iconimage = global::Gestion_Absence.Properties.Resources.archive;
            this.btn_arch.Iconimage_right = null;
            this.btn_arch.Iconimage_right_Selected = null;
            this.btn_arch.Iconimage_Selected = null;
            this.btn_arch.IconMarginLeft = 12;
            this.btn_arch.IconMarginRight = 0;
            this.btn_arch.IconRightVisible = true;
            this.btn_arch.IconRightZoom = 0D;
            this.btn_arch.IconVisible = true;
            this.btn_arch.IconZoom = 70D;
            this.btn_arch.IsTab = false;
            this.btn_arch.Location = new System.Drawing.Point(0, 512);
            this.btn_arch.Name = "btn_arch";
            this.btn_arch.Normalcolor = System.Drawing.Color.White;
            this.btn_arch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_arch.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_arch.selected = false;
            this.btn_arch.Size = new System.Drawing.Size(258, 48);
            this.btn_arch.TabIndex = 12;
            this.btn_arch.Text = "        Archive";
            this.btn_arch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_arch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_group
            // 
            this.btn_group.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.btn_group.BackColor = System.Drawing.Color.White;
            this.btn_group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_group.BorderRadius = 0;
            this.btn_group.ButtonText = "         Groupes";
            this.btn_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_group, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_group, BunifuAnimatorNS.DecorationType.None);
            this.btn_group.DisabledColor = System.Drawing.Color.Gray;
            this.btn_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_group.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_group.Iconimage = global::Gestion_Absence.Properties.Resources.Les_Groups;
            this.btn_group.Iconimage_right = null;
            this.btn_group.Iconimage_right_Selected = null;
            this.btn_group.Iconimage_Selected = null;
            this.btn_group.IconMarginLeft = 12;
            this.btn_group.IconMarginRight = 0;
            this.btn_group.IconRightVisible = true;
            this.btn_group.IconRightZoom = 0D;
            this.btn_group.IconVisible = true;
            this.btn_group.IconZoom = 70D;
            this.btn_group.IsTab = false;
            this.btn_group.Location = new System.Drawing.Point(0, 412);
            this.btn_group.Name = "btn_group";
            this.btn_group.Normalcolor = System.Drawing.Color.White;
            this.btn_group.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_group.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_group.selected = false;
            this.btn_group.Size = new System.Drawing.Size(258, 48);
            this.btn_group.TabIndex = 10;
            this.btn_group.Text = "         Groupes";
            this.btn_group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_group.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_group.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_filieres
            // 
            this.btn_filieres.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.btn_filieres.BackColor = System.Drawing.Color.White;
            this.btn_filieres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_filieres.BorderRadius = 0;
            this.btn_filieres.ButtonText = "         Filières";
            this.btn_filieres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_filieres, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_filieres, BunifuAnimatorNS.DecorationType.None);
            this.btn_filieres.DisabledColor = System.Drawing.Color.Gray;
            this.btn_filieres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_filieres.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_filieres.Iconimage = global::Gestion_Absence.Properties.Resources.Filiers;
            this.btn_filieres.Iconimage_right = null;
            this.btn_filieres.Iconimage_right_Selected = null;
            this.btn_filieres.Iconimage_Selected = null;
            this.btn_filieres.IconMarginLeft = 12;
            this.btn_filieres.IconMarginRight = 0;
            this.btn_filieres.IconRightVisible = true;
            this.btn_filieres.IconRightZoom = 0D;
            this.btn_filieres.IconVisible = true;
            this.btn_filieres.IconZoom = 70D;
            this.btn_filieres.IsTab = false;
            this.btn_filieres.Location = new System.Drawing.Point(0, 362);
            this.btn_filieres.Name = "btn_filieres";
            this.btn_filieres.Normalcolor = System.Drawing.Color.White;
            this.btn_filieres.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_filieres.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_filieres.selected = false;
            this.btn_filieres.Size = new System.Drawing.Size(258, 48);
            this.btn_filieres.TabIndex = 9;
            this.btn_filieres.Text = "         Filières";
            this.btn_filieres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filieres.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_filieres.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_abs
            // 
            this.btn_abs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.btn_abs.BackColor = System.Drawing.Color.White;
            this.btn_abs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_abs.BorderRadius = 0;
            this.btn_abs.ButtonText = "         Absence";
            this.btn_abs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Menu_panel_animator.SetDecoration(this.btn_abs, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.btn_abs, BunifuAnimatorNS.DecorationType.None);
            this.btn_abs.DisabledColor = System.Drawing.Color.Gray;
            this.btn_abs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_abs.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_abs.Iconimage = global::Gestion_Absence.Properties.Resources.Clock;
            this.btn_abs.Iconimage_right = null;
            this.btn_abs.Iconimage_right_Selected = null;
            this.btn_abs.Iconimage_Selected = null;
            this.btn_abs.IconMarginLeft = 12;
            this.btn_abs.IconMarginRight = 0;
            this.btn_abs.IconRightVisible = true;
            this.btn_abs.IconRightZoom = 0D;
            this.btn_abs.IconVisible = true;
            this.btn_abs.IconZoom = 70D;
            this.btn_abs.IsTab = false;
            this.btn_abs.Location = new System.Drawing.Point(0, 312);
            this.btn_abs.Name = "btn_abs";
            this.btn_abs.Normalcolor = System.Drawing.Color.White;
            this.btn_abs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btn_abs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_abs.selected = false;
            this.btn_abs.Size = new System.Drawing.Size(258, 48);
            this.btn_abs.TabIndex = 8;
            this.btn_abs.Text = "         Absence";
            this.btn_abs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_abs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // logo_animator
            // 
            this.logo_animator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logo_animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logo_animator.DefaultAnimation = animation2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.Tree_Menu_panel_animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(257, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 575);
            this.panel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.Tree_Menu_panel_animator.SetDecoration(this.tabControl1, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.tabControl1, BunifuAnimatorNS.DecorationType.None);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 575);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.Tree_Menu_panel_animator.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.Tree_Menu_panel_animator.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.Tree_Menu_panel_animator.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(693, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.Tree_Menu_panel_animator.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(693, 549);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Tree_Menu_panel_animator
            // 
            this.Tree_Menu_panel_animator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Tree_Menu_panel_animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Tree_Menu_panel_animator.DefaultAnimation = animation1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tree_Menu_panel);
            this.Controls.Add(this.Header_Panel);
            this.logo_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Tree_Menu_panel_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).EndInit();
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Tree_Menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Tree_Menu_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_modul;
        private Bunifu.Framework.UI.BunifuFlatButton btn_stagi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_arch;
        private Bunifu.Framework.UI.BunifuFlatButton btn_group;
        private Bunifu.Framework.UI.BunifuFlatButton btn_filieres;
        private Bunifu.Framework.UI.BunifuFlatButton btn_abs;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.PictureBox Minimise_pictureBox;
        private System.Windows.Forms.PictureBox Maximise_pictureBox;
        private System.Windows.Forms.PictureBox Close_pictureBox;
        private Bunifu.Framework.UI.BunifuCustomLabel Title_Lable;
        private Bunifu.Framework.UI.BunifuImageButton Humbutton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_stat;
        private BunifuAnimatorNS.BunifuTransition Tree_Menu_panel_animator;
        private BunifuAnimatorNS.BunifuTransition logo_animator;
        private Bunifu.Framework.UI.BunifuCustomLabel mini_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

