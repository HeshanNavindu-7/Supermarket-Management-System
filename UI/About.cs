using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AllinOne
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );


        int[] goodspeeds = { 4, 5, 6, 8, 2, 3, 2, 3 };
        int loadingSpeed = 2;
        float initialPercentage = 0;
        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do animation

            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        //animation for rain 1
                        guna2PictureBox14.Location = new Point(guna2PictureBox14.Location.X, guna2PictureBox14.Location.Y + goodspeeds[i]);
                        if (guna2PictureBox14.Location.Y > guna2Panel1.Size.Height + guna2PictureBox14.Size.Height)
                        {
                            guna2PictureBox14.Location = new Point(guna2PictureBox14.Location.X, 0 - guna2PictureBox14.Size.Height);
                        }
                        break;
                    case 1:
                        //animation for rain 2
                        guna2PictureBox7.Location = new Point(guna2PictureBox7.Location.X, guna2PictureBox7.Location.Y + goodspeeds[i]);
                        if (guna2PictureBox7.Location.Y > guna2Panel1.Size.Height + guna2PictureBox7.Size.Height)
                        {
                            guna2PictureBox7.Location = new Point(guna2PictureBox7.Location.X, 0 - guna2PictureBox7.Size.Height);
                        }
                        break;
                    case 2:
                        //animation for rain 3
                        guna2PictureBox3.Location = new Point(guna2PictureBox3.Location.X, guna2PictureBox3.Location.Y + goodspeeds[i]);
                        if (guna2PictureBox3.Location.Y > guna2Panel1.Size.Height + guna2PictureBox3.Size.Height)
                        {
                            guna2PictureBox3.Location = new Point(guna2PictureBox3.Location.X, 0 - guna2PictureBox3.Size.Height);
                        }
                        break;
                    case 3:
                        //animation for rain 4
                        guna2PictureBox12.Location = new Point(guna2PictureBox12.Location.X, guna2PictureBox12.Location.Y + goodspeeds[i]);
                        if (guna2PictureBox12.Location.Y > guna2Panel1.Size.Height + guna2PictureBox12.Size.Height)
                        {
                            guna2PictureBox12.Location = new Point(guna2PictureBox12.Location.X, 0 - guna2PictureBox12.Size.Height);
                        }
                        break;

                    case 4:
                        //animation for rain 4
                        guna2PictureBox13.Location = new Point(guna2PictureBox13.Location.X, guna2PictureBox13.Location.Y + goodspeeds[i]);
                        if (guna2PictureBox13.Location.Y > guna2Panel1.Size.Height + guna2PictureBox12.Size.Height)
                        {
                            guna2PictureBox13.Location = new Point(guna2PictureBox13.Location.X, 0 - guna2PictureBox12.Size.Height);
                        }
                        break;
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }
    }
}