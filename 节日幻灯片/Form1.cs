using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace 节日幻灯片
{
    public partial class Form1 : Form
    {
        string[] backfiles;
        string[] frontfiles;
        string[] logofiles;
        int logoindex = 0;
        int i_back = 0;
        int i_front = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;     //设置窗体为无边框样式
            this.WindowState = FormWindowState.Maximized;    //最大化窗体 

            this.Location = new Point(0, 0);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            frontfiles = Directory.GetFiles(Application.StartupPath + "\\frontimgs");
            backfiles = Directory.GetFiles(Application.StartupPath + "\\backimgs");
            logofiles = Directory.GetFiles(Application.StartupPath + "\\logos");

            pan_menu.Location = new Point(Width-pan_menu.Width-10,Height-pan_menu.Height-10);

            pic_logo.Location = new Point(Width/2-pic_logo.Width/2,Height - pic_logo.Height-10);
            pic_logo.Parent = pic_fronts;
            pic_fronts.Parent = pic_back;



        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_slidelogos_Click(object sender, EventArgs e)
        {
            try
            {
                Random rad = new Random();
                logoindex = rad.Next(0, logofiles.Count());
                pic_logo.Image= Image.FromFile(logofiles[logoindex]);                

            }
            catch
            {

            }


            //pic_main.Image = Image.FromFile(files[i]);
        }
        public static Bitmap GetThumbnail(Bitmap bmp, int width, int height)
        {
            Image imgSource = bmp;

            if (width == 0)
            {
                width = height * bmp.Width / bmp.Height;
            }
            if (height == 0)
            {
                height = width * bmp.Height / bmp.Width;
            }


            Bitmap outBmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(outBmp);
            g.Clear(Color.Transparent);
            // 设置画布的描绘质量   
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imgSource, new Rectangle(0, 0, width, height + 1), 0, 0, imgSource.Width, imgSource.Height, GraphicsUnit.Pixel);
            g.Dispose();
            imgSource.Dispose();
            bmp.Dispose();
            outBmp.MakeTransparent(Color.Black);
            return outBmp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Init_Click(sender, e);
        }

        private void tmr_changefront_Tick(object sender, EventArgs e)
        {
            btn_FrontPicture_Click(sender,e);
            //btn_slidelogos_Click(sender, e);
            //pan_menu.Visible = false;
        }

        private void btn_RunFront_Click(object sender, EventArgs e)
        {
            tmr_changefront_Tick(sender, e);
            tmr_changefront.Enabled = !tmr_changefront.Enabled;
            if (tmr_changefront.Enabled == true)
            {
                btn_RunFront.Text = "停止";

            }
            else
            {
                btn_RunFront.Text = "自动";
                pic_fronts.Image = null;
            } 

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_Run_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pic_main_MouseMove(object sender, MouseEventArgs e)
        {
            //pan_menu.Visible = true;
        }

        private void btn_BackColor_Click(object sender, EventArgs e)
        {

            Random rad = new Random();

            if (BackColor==Color.White)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
            btn_slidelogos_Click(sender, e);
        }

        private void pic_main_Click(object sender, EventArgs e)
        {
            pan_menu.Visible = !pan_menu.Visible;
        }
        int b_direction = 1;
        private void btn_BackPicture_Click(object sender, EventArgs e)
        {
            //tmr_changefront.Enabled = false;
            try
            {
                i_back = i_back + b_direction;
                if (i_back > backfiles.Length) i_back = 0;
                if (i_back < 0) i_back = backfiles.Length - 1;
                Bitmap bmp = new Bitmap(Image.FromFile(backfiles[i_back]));
                pic_back.Image = bmp;
                GC.Collect();                

            }
            catch (Exception ee)
            {

            }
        }

        private void btn_FrontPicture_Click(object sender, EventArgs e)
        {
            //tmr_changefront.Enabled = false;
            try
            {
                Random rad = new Random();
                i_front = i_front + b_direction;
                if (i_front > frontfiles.Length) i_front = 0;
                if (i_front < 0) i_front = frontfiles.Length - 1;
                Bitmap bmp = new Bitmap(Image.FromFile(frontfiles[i_front]));
                int pic_Width, pic_Height;
                //横屏
                if (Width > Height)
                {
                    double d_ratio = bmp.Width / bmp.Height;
                    pic_Height = Height;
                    pic_Width = (int)(Width * d_ratio);
                }

                //竖屏
                else
                {
                    double d_ratio = bmp.Height / bmp.Width;
                    pic_Width = Width;
                    pic_Height = (int)(Width * d_ratio);
                }
                pic_fronts.Image = GetThumbnail(bmp, pic_Width, pic_Height);
                GC.Collect();

            }
            catch
            {

            }
        }

        private void tmr_changeback_Tick(object sender, EventArgs e)
        {
            btn_BackPicture_Click(sender, e);
        }

        private void btn_RunBack_Click(object sender, EventArgs e)
        {
            tmr_changeback_Tick(sender, e);
            tmr_changeback.Enabled = !tmr_changeback.Enabled;
            if (tmr_changeback.Enabled == true)
            {
                btn_RunBack.Text = "停止";

            }
            else
            {
                btn_RunBack.Text = "自动";
                pic_back.Image = null;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)

        {

            switch (keyData)

            {

                case Keys.Right:

                    //MessageBox.Show("Right");

                    break;

                case Keys.Left:

                    //MessageBox.Show("Left");

                    break;

                case Keys.Up://方向键不反应

                    //MessageBox.Show("up");
                    b_direction = 1;
                    btn_BackPicture_Click(null,null);
                    break;

                case Keys.Down:
                    b_direction = -1;
                    btn_BackPicture_Click(null, null);
                    //MessageBox.Show("down");

                    break;

                case Keys.Space:

                    //MessageBox.Show("space");

                    break;

                case Keys.Enter:

                   //MessageBox.Show("enter");

                    break;

            }

            return false;//如果要调用KeyDown,这里一定要返回false才行,否则只响应重写方法里的按键.

            //这里调用一下父类方向,相当于调用普通的KeyDown事件.//所以按空格会弹出两个对话框

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void pic_fronts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pan_menu.Visible = !pan_menu.Visible;

            }
            if (e.Button==MouseButtons.Left)
            {
                b_direction = 1;
                btn_BackPicture_Click(sender, e);
            }
        }
    }

}
