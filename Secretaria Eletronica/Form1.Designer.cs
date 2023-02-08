
namespace Secretaria_Eletronica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_galeria = new System.Windows.Forms.Button();
            this.sobreContainer = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_contacto = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_somos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.sidebarTimerAnimation = new System.Windows.Forms.Timer(this.components);
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.sobreTimer = new System.Windows.Forms.Timer(this.components);
            this.gunaResizeControl1 = new Guna.UI.WinForms.GunaResizeControl();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sobreContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.sobreContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(245, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(80, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(80, 641);
            this.sidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Transparent;
            this.menuContainer.Controls.Add(this.gunaCirclePictureBox1);
            this.menuContainer.Controls.Add(this.label1);
            this.menuContainer.Controls.Add(this.menuButton);
            this.menuContainer.Location = new System.Drawing.Point(3, 3);
            this.menuContainer.MaximumSize = new System.Drawing.Size(242, 248);
            this.menuContainer.MinimumSize = new System.Drawing.Size(242, 70);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(242, 70);
            this.menuContainer.TabIndex = 5;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Secretaria_Eletronica.Properties.Resources.IMIL_logo;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(42, 68);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(151, 148);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 2;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Secretaria_Eletronica.Properties.Resources.menu_50px1;
            this.menuButton.Location = new System.Drawing.Point(18, 13);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(38, 36);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 49);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(3, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 58);
            this.panel8.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::Secretaria_Eletronica.Properties.Resources.home_30px;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(-17, -11);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(268, 73);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "              Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btn_galeria);
            this.panel3.Location = new System.Drawing.Point(3, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 49);
            this.panel3.TabIndex = 2;
            // 
            // btn_galeria
            // 
            this.btn_galeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.btn_galeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_galeria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_galeria.ForeColor = System.Drawing.Color.White;
            this.btn_galeria.Image = global::Secretaria_Eletronica.Properties.Resources.image_gallery_30px;
            this.btn_galeria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_galeria.Location = new System.Drawing.Point(-17, -11);
            this.btn_galeria.Name = "btn_galeria";
            this.btn_galeria.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_galeria.Size = new System.Drawing.Size(268, 73);
            this.btn_galeria.TabIndex = 2;
            this.btn_galeria.Text = "              Galeria";
            this.btn_galeria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_galeria.UseVisualStyleBackColor = true;
            // 
            // sobreContainer
            // 
            this.sobreContainer.BackColor = System.Drawing.Color.Transparent;
            this.sobreContainer.Controls.Add(this.panel7);
            this.sobreContainer.Controls.Add(this.panel5);
            this.sobreContainer.Controls.Add(this.panel4);
            this.sobreContainer.Location = new System.Drawing.Point(3, 189);
            this.sobreContainer.MaximumSize = new System.Drawing.Size(230, 168);
            this.sobreContainer.MinimumSize = new System.Drawing.Size(230, 58);
            this.sobreContainer.Name = "sobreContainer";
            this.sobreContainer.Size = new System.Drawing.Size(230, 58);
            this.sobreContainer.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.btn_contacto);
            this.panel7.Location = new System.Drawing.Point(-1, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 49);
            this.panel7.TabIndex = 5;
            // 
            // btn_contacto
            // 
            this.btn_contacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(149)))));
            this.btn_contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contacto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contacto.ForeColor = System.Drawing.Color.White;
            this.btn_contacto.Image = global::Secretaria_Eletronica.Properties.Resources.circled_right_20px;
            this.btn_contacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contacto.Location = new System.Drawing.Point(0, -14);
            this.btn_contacto.Name = "btn_contacto";
            this.btn_contacto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_contacto.Size = new System.Drawing.Size(252, 73);
            this.btn_contacto.TabIndex = 2;
            this.btn_contacto.Text = "              Contacte-nos";
            this.btn_contacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contacto.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btn_somos);
            this.panel5.Location = new System.Drawing.Point(-1, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 49);
            this.panel5.TabIndex = 4;
            // 
            // btn_somos
            // 
            this.btn_somos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(149)))));
            this.btn_somos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_somos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_somos.ForeColor = System.Drawing.Color.White;
            this.btn_somos.Image = global::Secretaria_Eletronica.Properties.Resources.circled_right_20px;
            this.btn_somos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_somos.Location = new System.Drawing.Point(0, -19);
            this.btn_somos.Name = "btn_somos";
            this.btn_somos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_somos.Size = new System.Drawing.Size(252, 73);
            this.btn_somos.TabIndex = 2;
            this.btn_somos.Text = "              Quem somos";
            this.btn_somos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_somos.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_sobre);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 49);
            this.panel4.TabIndex = 3;
            // 
            // btn_sobre
            // 
            this.btn_sobre.BackColor = System.Drawing.Color.Transparent;
            this.btn_sobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.btn_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sobre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sobre.ForeColor = System.Drawing.Color.White;
            this.btn_sobre.Image = global::Secretaria_Eletronica.Properties.Resources.info_30px;
            this.btn_sobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sobre.Location = new System.Drawing.Point(-17, -11);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_sobre.Size = new System.Drawing.Size(268, 73);
            this.btn_sobre.TabIndex = 2;
            this.btn_sobre.Text = "              Sobre";
            this.btn_sobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sobre.UseVisualStyleBackColor = false;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // sidebarTimerAnimation
            // 
            this.sidebarTimerAnimation.Interval = 20;
            this.sidebarTimerAnimation.Tick += new System.EventHandler(this.sidebarTimerAnimation_Tick);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 20;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // sobreTimer
            // 
            this.sobreTimer.Interval = 20;
            this.sobreTimer.Tick += new System.EventHandler(this.sobreTimer_Tick);
            // 
            // gunaResizeControl1
            // 
            this.gunaResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaResizeControl1.ForeColor = System.Drawing.Color.Black;
            this.gunaResizeControl1.ForeColorDepth = 255;
            this.gunaResizeControl1.Location = new System.Drawing.Point(1167, 621);
            this.gunaResizeControl1.Name = "gunaResizeControl1";
            this.gunaResizeControl1.Size = new System.Drawing.Size(20, 20);
            this.gunaResizeControl1.TabIndex = 2;
            this.gunaResizeControl1.TargetControl = null;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 20F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1050, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Silver;
            this.gunaControlBox1.Size = new System.Drawing.Size(66, 46);
            this.gunaControlBox1.TabIndex = 3;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 20F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1122, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Silver;
            this.gunaControlBox2.Size = new System.Drawing.Size(66, 46);
            this.gunaControlBox2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(80, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 52);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gunaPictureBox1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(80, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1104, 589);
            this.panel6.TabIndex = 5;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Secretaria_Eletronica.Properties.Resources.emmanuel_ikwuegbu_VC6MGt9ZoBA_unsplash;
            this.gunaPictureBox1.Location = new System.Drawing.Point(656, 82);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(380, 250);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Secretaria_Eletronica.Properties.Resources.emmanuel_ikwuegbu_VC6MGt9ZoBA_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(93, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaResizeControl1);
            this.Controls.Add(this.sidebar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.sobreContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_galeria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_sobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimerAnimation;
        private System.Windows.Forms.Panel sobreContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_contacto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_somos;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Timer sobreTimer;
        private Guna.UI.WinForms.GunaResizeControl gunaResizeControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
    }
}

