namespace 节日幻灯片
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Init = new System.Windows.Forms.Button();
            this.pan_menu = new System.Windows.Forms.Panel();
            this.btn_RunBack = new System.Windows.Forms.Button();
            this.btn_FrontPicture = new System.Windows.Forms.Button();
            this.btn_BackPicture = new System.Windows.Forms.Button();
            this.btn_BackColor = new System.Windows.Forms.Button();
            this.btn_RunFront = new System.Windows.Forms.Button();
            this.tmr_changefront = new System.Windows.Forms.Timer(this.components);
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_slidelogos = new System.Windows.Forms.Button();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.pic_fronts = new System.Windows.Forms.PictureBox();
            this.tmr_changeback = new System.Windows.Forms.Timer(this.components);
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fronts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(250, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(47, 23);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Init
            // 
            this.btn_Init.BackColor = System.Drawing.Color.Black;
            this.btn_Init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Init.ForeColor = System.Drawing.Color.White;
            this.btn_Init.Location = new System.Drawing.Point(15, 67);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(84, 29);
            this.btn_Init.TabIndex = 1;
            this.btn_Init.Text = "初始化";
            this.btn_Init.UseVisualStyleBackColor = false;
            this.btn_Init.Visible = false;
            this.btn_Init.Click += new System.EventHandler(this.btn_Init_Click);
            // 
            // pan_menu
            // 
            this.pan_menu.BackColor = System.Drawing.Color.Black;
            this.pan_menu.Controls.Add(this.btn_RunBack);
            this.pan_menu.Controls.Add(this.btn_FrontPicture);
            this.pan_menu.Controls.Add(this.btn_BackPicture);
            this.pan_menu.Controls.Add(this.btn_BackColor);
            this.pan_menu.Controls.Add(this.btn_RunFront);
            this.pan_menu.Controls.Add(this.btn_Exit);
            this.pan_menu.Location = new System.Drawing.Point(12, 8);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(307, 38);
            this.pan_menu.TabIndex = 2;
            // 
            // btn_RunBack
            // 
            this.btn_RunBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_RunBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RunBack.ForeColor = System.Drawing.Color.White;
            this.btn_RunBack.Location = new System.Drawing.Point(150, 7);
            this.btn_RunBack.Name = "btn_RunBack";
            this.btn_RunBack.Size = new System.Drawing.Size(45, 23);
            this.btn_RunBack.TabIndex = 8;
            this.btn_RunBack.Text = "动态";
            this.btn_RunBack.UseVisualStyleBackColor = false;
            this.btn_RunBack.Click += new System.EventHandler(this.btn_RunBack_Click);
            // 
            // btn_FrontPicture
            // 
            this.btn_FrontPicture.BackColor = System.Drawing.Color.Transparent;
            this.btn_FrontPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FrontPicture.ForeColor = System.Drawing.Color.White;
            this.btn_FrontPicture.Location = new System.Drawing.Point(9, 7);
            this.btn_FrontPicture.Name = "btn_FrontPicture";
            this.btn_FrontPicture.Size = new System.Drawing.Size(45, 23);
            this.btn_FrontPicture.TabIndex = 7;
            this.btn_FrontPicture.Text = "前景";
            this.btn_FrontPicture.UseVisualStyleBackColor = false;
            this.btn_FrontPicture.Click += new System.EventHandler(this.btn_FrontPicture_Click);
            // 
            // btn_BackPicture
            // 
            this.btn_BackPicture.BackColor = System.Drawing.Color.Transparent;
            this.btn_BackPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackPicture.ForeColor = System.Drawing.Color.White;
            this.btn_BackPicture.Location = new System.Drawing.Point(104, 7);
            this.btn_BackPicture.Name = "btn_BackPicture";
            this.btn_BackPicture.Size = new System.Drawing.Size(45, 23);
            this.btn_BackPicture.TabIndex = 6;
            this.btn_BackPicture.Text = "背景";
            this.btn_BackPicture.UseVisualStyleBackColor = false;
            this.btn_BackPicture.Click += new System.EventHandler(this.btn_BackPicture_Click);
            // 
            // btn_BackColor
            // 
            this.btn_BackColor.BackColor = System.Drawing.Color.Transparent;
            this.btn_BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackColor.ForeColor = System.Drawing.Color.White;
            this.btn_BackColor.Location = new System.Drawing.Point(199, 7);
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Size = new System.Drawing.Size(47, 23);
            this.btn_BackColor.TabIndex = 5;
            this.btn_BackColor.Text = "Logo";
            this.btn_BackColor.UseVisualStyleBackColor = false;
            this.btn_BackColor.Click += new System.EventHandler(this.btn_BackColor_Click);
            // 
            // btn_RunFront
            // 
            this.btn_RunFront.BackColor = System.Drawing.Color.Transparent;
            this.btn_RunFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RunFront.ForeColor = System.Drawing.Color.White;
            this.btn_RunFront.Location = new System.Drawing.Point(55, 7);
            this.btn_RunFront.Name = "btn_RunFront";
            this.btn_RunFront.Size = new System.Drawing.Size(45, 23);
            this.btn_RunFront.TabIndex = 4;
            this.btn_RunFront.Text = "动态";
            this.btn_RunFront.UseVisualStyleBackColor = false;
            this.btn_RunFront.Click += new System.EventHandler(this.btn_RunFront_Click);
            this.btn_RunFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseMove);
            // 
            // tmr_changefront
            // 
            this.tmr_changefront.Interval = 3000;
            this.tmr_changefront.Tick += new System.EventHandler(this.tmr_changefront_Tick);
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo.Location = new System.Drawing.Point(381, 498);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(262, 53);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 4;
            this.pic_logo.TabStop = false;
            // 
            // btn_slidelogos
            // 
            this.btn_slidelogos.BackColor = System.Drawing.Color.Black;
            this.btn_slidelogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_slidelogos.ForeColor = System.Drawing.Color.White;
            this.btn_slidelogos.Location = new System.Drawing.Point(211, 67);
            this.btn_slidelogos.Name = "btn_slidelogos";
            this.btn_slidelogos.Size = new System.Drawing.Size(84, 29);
            this.btn_slidelogos.TabIndex = 5;
            this.btn_slidelogos.Text = "Logo Show";
            this.btn_slidelogos.UseVisualStyleBackColor = false;
            this.btn_slidelogos.Visible = false;
            this.btn_slidelogos.Click += new System.EventHandler(this.btn_slidelogos_Click);
            // 
            // pic_back
            // 
            this.pic_back.BackColor = System.Drawing.Color.Transparent;
            this.pic_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_back.Location = new System.Drawing.Point(0, 0);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(1037, 582);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 7;
            this.pic_back.TabStop = false;
            // 
            // pic_fronts
            // 
            this.pic_fronts.BackColor = System.Drawing.Color.Transparent;
            this.pic_fronts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_fronts.Location = new System.Drawing.Point(0, 0);
            this.pic_fronts.Name = "pic_fronts";
            this.pic_fronts.Size = new System.Drawing.Size(1037, 582);
            this.pic_fronts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_fronts.TabIndex = 3;
            this.pic_fronts.TabStop = false;
            this.pic_fronts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_fronts_MouseDown);
            this.pic_fronts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_main_MouseMove);
            // 
            // tmr_changeback
            // 
            this.tmr_changeback.Interval = 3000;
            this.tmr_changeback.Tick += new System.EventHandler(this.tmr_changeback_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1037, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btn_slidelogos);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_Init);
            this.Controls.Add(this.pan_menu);
            this.Controls.Add(this.pic_fronts);
            this.Controls.Add(this.pic_back);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pan_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fronts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Init;
        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Timer tmr_changefront;
        private System.Windows.Forms.Button btn_RunFront;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_slidelogos;
        private System.Windows.Forms.Button btn_BackColor;
        private System.Windows.Forms.Button btn_BackPicture;
        private System.Windows.Forms.Button btn_FrontPicture;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.PictureBox pic_fronts;
        private System.Windows.Forms.Button btn_RunBack;
        private System.Windows.Forms.Timer tmr_changeback;
    }
}

