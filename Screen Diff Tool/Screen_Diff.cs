using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Diff_Tool 
{
    public partial class Screen_Diff : Form
    {
        public Screen_Diff()
        {
            InitializeComponent();
            diffLabel.Visible = false;
            runningThread = new Thread(new ThreadStart(this.runloop));
            runningThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (runMainThread)
            {
                runMainThread = false;
                isDifferent = false;
                startDiffButton.Text = "Start";
                diffLabel.Visible = false;
                pictureBox1.Image = null;
                imageCaptured = false;
            }
            else
            {
                runMainThread = true;
                startDiffButton.Text = "Stop";
                diffLabel.Visible = false;
                imageCaptured = false;
            }
            oldImage = currentImage;

        }

        private void runloop()
        {
            while (true)
            {
                if (runMainThread)
                {
                    if (isDifferent == true)
                    {
                        runMainThread = false;
                    }
                    if (runMainThread)
                    {
                        CaptureScreen();
                        Thread.Sleep(5000);
                    }        
                }
            }
        }


        Bitmap currentImage;
        Bitmap oldImage;
        bool imageCaptured = false;
        bool isDifferent = false;
        bool runMainThread = false;
        Thread beepThread;
        Thread runningThread;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();

            //pictureBox1.

            Rectangle r = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);


            currentImage = new Bitmap(pictureBox1.Width, pictureBox1.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(currentImage);


            //memoryGraphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            this.BeginInvoke((MethodInvoker)delegate ()
            {
                this.Hide();
            
            Thread.Sleep(400);
                memoryGraphics.CopyFromScreen(pictureBox1.RectangleToScreen(pictureBox1.DisplayRectangle).Location, new Point(0, 0), pictureBox1.Size);
                this.Show();

                if (screenshotMode_Checkbox.Checked)
                {
                    currentImage.Save("Screen_Capture.bmp");
                }
                else
                {
                    if (imageCaptured)
                    {
                        pictureBox1.Image.Dispose();
                        memoryGraphics.Dispose();
                        for (int i = 0; i < oldImage.Height; i++)
                        {
                            for (int j = 0; j < oldImage.Width; j++)
                            {
                                if (oldImage.GetPixel(j, i) != currentImage.GetPixel(j, i))
                                {

                                    beepThread = new Thread(new ThreadStart(this.beep));
                                    beepThread.Start();
                                    pictureBox1.Image = currentImage;
                                    isDifferent = true;
                                    return;

                                }
                            }
                        }
                    }
                }
                
                imageCaptured = true;
                pictureBox1.Image = currentImage;
                oldImage = new Bitmap(currentImage);
            });
        }

        public void beep()
        {
            System.IO.Stream str = Properties.Resources.Police_Siren;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
            player.Play();
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                diffLabel.Visible = true;
            });
            while (isDifferent)
            {
                Thread.Sleep(5000);
                player.Play();
            }
        }

        private void Screen_Diff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(beepThread != null)
            {
                beepThread.Abort();
            }
            runningThread.Abort();


        }
    }
}
