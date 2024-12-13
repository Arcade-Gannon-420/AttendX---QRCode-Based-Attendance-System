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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendX___QRCode_Based_Attendance_System
{
    public partial class Form1 : Form
    {
        public AttendXEntities db = new AttendXEntities();
        private VideoCapture _capture;
        private Mat _image = new Mat();
        private bool _isRunning = true;

        private GarbageCollector _garbageCollector;

        public Form1()
        {
            InitializeComponent();
            _garbageCollector = new GarbageCollector(UpdateMemoryStatus, UpdateMemoryAfterGcStatus);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Start monitoring memory usage asynchronously
            _ = _garbageCollector.MonitorMemoryAsync(); // Fire and forget

            await InitializeCameraAsync();
            if (_capture != null && _capture.IsOpened())
            {
                await StartCameraFeedAsync();
            }

        }
        private void UpdateMemoryStatus(string status)
        {
            //if (textBox1.InvokeRequired)
            //{
            //    textBox1.Invoke(new MethodInvoker(() => textBox1.Text = status));
            //}
            //else
            //{
            //    textBox1.Text = status;
            //}
        }
        private void UpdateMemoryAfterGcStatus(string status)
        {
            //if (textBox2.InvokeRequired)
            //{
            //    textBox2.Invoke(new MethodInvoker(() => textBox2.Text = status));
            //}
            //else
            //{
            //    textBox2.Text = status;
            //}
        }

        private async Task InitializeCameraAsync()
        {
            while (_capture == null || !_capture.IsOpened())
            {
                try
                {                   
                    await Task.Run(() =>
                    {
                        _capture = new VideoCapture(0); // Attempt to initialize the camera
                    });

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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
