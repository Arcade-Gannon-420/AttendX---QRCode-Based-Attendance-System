using AttendX___QRCode_Based_Attendance_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.Threading;

namespace AttendX___QRCode_Based_Attendance_System
{
    public partial class Form1 : Form
    {
        public AttendXEntities db = new AttendXEntities();

        VideoCapture _capture = new VideoCapture(0);
        private Mat _image = new Mat();
        Thread thread;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(CaptureCameraCallback));
            thread.Start();
        }

        public void CaptureCameraCallback()
        {
            while (true)
            {
                _capture.Read(_image);
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(() => CameraBox.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_image)));
                }
                else
                {
                    CameraBox.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_image);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
