using AttendX___QRCode_Based_Attendance_System.Model;
using AttendX___QRCode_Based_Attendance_System.Common.Helper;
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

        private VideoCapture _capture;
        private Mat _image = new Mat();
        private bool _isRunning = true;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await InitializeCameraAsync();
            if (_capture != null && _capture.IsOpened())
            {
                await StartCameraFeedAsync();
            }
        }

        private async Task InitializeCameraAsync()
        {
            while (_capture == null || !_capture.IsOpened())
            {
                try
                {
                    _capture = new VideoCapture(0); // 0 for default camera
                    if (_capture.IsOpened())
                    {
                        //MessageBox.Show("Camera successfully started!");
                        AutoClosingMessageBox.Show("Camera successfully started!", "", 3000);
                        break;
                    }
                    else
                    {
                        _capture.Release();
                        _capture.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    // Optionally log the exception
                }
                AutoClosingMessageBox.Show("Unable to access the camera. Retrying in 3 seconds...", "", 3000);
                
            }
        }

        private async Task StartCameraFeedAsync()
        {
            await Task.Run(() =>
            {
                while (_isRunning)
                {
                    _capture.Read(_image);
                    if (_image.Empty())
                        continue;

                    if (CameraBox.InvokeRequired)
                    {
                        CameraBox.Invoke(new MethodInvoker(() =>
                        {
                            CameraBox.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_image);
                        }));
                    }
                    else
                    {
                        CameraBox.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_image);
                    }
                }
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isRunning = false;

            if (_capture != null)
            {
                _capture.Release();
                _capture.Dispose();
            }

            if (_image != null)
            {
                _image.Dispose();
            }
        }
    }
}
