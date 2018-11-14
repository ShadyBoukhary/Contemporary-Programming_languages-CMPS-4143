/* ******************************************************************
 * Shady Boukhary
 * Dr. Stringfellow
 * Contemporary Programming Languages
 * November 14, 2018
 * Simple app demonstrating drawing graphics
 * ***************************************************************** */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace AnimationApp
{
    public partial class DrawingForm : Form
    {
        bool animationOn;
        public DrawingForm()
        {
            InitializeComponent();
            animationOn = false;
        }

        /// <summary>
        /// Draws on the panel when OnPaint is invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (animationOn)
            {
                
                SolidBrush brush = new SolidBrush(Color.White);
                Pen pen = new Pen(Color.Black, 2);

                // ground
                g.FillRectangle(brush, 0, 600, 1900, 400);

                DrawSky(g);
                DrawTree(g, pen, brush);
                DrawSun(g);
                DrawSnowMen(g, pen);
                DrawString(g, brush);
            } 
            else
            {
                g.Clear(BackColor);
            }
        }

        /// <summary>
        /// Draws the sky with a gradient
        /// </summary>
        /// <param name="g"></param>
        private static void DrawSky(Graphics g)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 600),
                new Point(0, 0),
                Color.FromArgb(176, 196, 222),
                Color.FromArgb(135, 206, 250));

            g.FillRectangle(brush, 0, 0, 1920, 600);
        }

        /// <summary>
        /// Draws a tree using lines and rectangles
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        private void DrawTree(Graphics g, Pen pen, SolidBrush brush)
        {
            
            brush.Color = Color.BurlyWood;
            g.FillRectangle(brush, 350, 320, 100, 460);

            brush = new SolidBrush(Color.LightGray);
            // draw leaves                 
            g.FillClosedCurve(brush, new Point[] { new Point(350, 320),
                new Point(200, 370), new Point(200, 260), new Point(230, 220),
                // arc 2
                new Point(140, 250), new Point(100, 180), new Point(230, 150),
                // arc 3
                new Point(190, 70), new Point(330, 40), new Point(400, 150),
                new Point(400, 40), new Point(550, 40), new Point(550, 150),
                // arc 4
                new Point(600, 150), new Point(600, 270), new Point(550, 270),
                // arc 5
                new Point(590, 300), new Point(600, 340), new Point(530, 350),
                new Point(450, 320), new Point(350, 320)});

            
        }

        /// <summary>
        /// Draws a string
        /// </summary>
        /// <param name="g"></param>
        /// <param name="brush"></param>
        private void DrawString(Graphics g, SolidBrush brush)
        {
            brush.Color = Color.Black;
            g.DrawString("WINTER IS COMING", Font, brush, 900, 100);
        }

        /// <summary>
        /// Draws Snowmen using ellipses
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pen"></param>
        private void DrawSnowMen(Graphics g, Pen pen)
        {
            pen.Color = Color.Brown;
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 600),
                new Point(0, 0),
                Color.FromArgb(242, 242, 242),
                Color.FromArgb(234, 234, 234));

            for (int i = 0; i < 5; i++)
            {
                g.FillEllipse(brush, 800 + (i * 200), 700, 70, 70);
                g.FillEllipse(brush, 810 + (i * 200), 655, 50, 50);
                g.FillEllipse(brush, 820 + (i * 200), 627, 30, 30);
                g.DrawLine(pen, 855 + (i * 200), 675, 880 + (i * 200), 650);
                g.DrawLine(pen, 813 + (i * 200), 675, 787 + (i * 200), 650);
            }
        }

        /// <summary>
        /// Draws gradient sun
        /// </summary>
        /// <param name="g"></param>
        public static void DrawSun(Graphics g)
        {
            Color[] colors = { Color.Orange };
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(1600, 100, 100, 100);

            PathGradientBrush brush = new PathGradientBrush(path)
            {
                CenterPoint = new PointF(675, 100),
                CenterColor = Color.Yellow,
                SurroundColors = colors
            };

            g.FillEllipse(brush, 1600, 100, 100, 100);
        }

        /// <summary>
        /// Animate click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draw_Click(object sender, EventArgs e)
        {
            animationOn = !animationOn;
            // if animation is on, run the background thread
            if (animationOn)
            {
                draw.Text = "Stop Animating";
                if (!animator.IsBusy)
                    animator.RunWorkerAsync();
                
            }
            else
            {
                draw.Text = "Animate";
                animator.CancelAsync();
            }
            // refresh
            panel.Invalidate();
        }

        /// <summary>
        /// Background animator, animates every second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animator_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
            while (!animator.CancellationPending)
            {
                Thread.Sleep(1000);
                animator.ReportProgress(1);
                
            }
            // if cancelled, restore defaults
            animator.ReportProgress(100);
        }

        /// <summary>
        /// Toggle panel drawings and refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animator_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            animationOn = !animationOn;
            panel.Invalidate();
        }

        /// <summary>
        /// Restore defaults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animator_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            animationOn = false;
            draw.Text = "Animate";
        }
    }

     
}
