namespace AttendX___QRCode_Based_Attendance_System
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
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeInBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TimeOutBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullnameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CourseandYearBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubjectBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ScheduleBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraBox
            // 
            this.CameraBox.ErrorImage = null;
            this.CameraBox.InitialImage = null;
            this.CameraBox.Location = new System.Drawing.Point(923, 371);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(218, 170);
            this.CameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CameraBox.TabIndex = 1;
            this.CameraBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 176);
            this.label1.TabIndex = 0;
            this.label1.Text = "AttendX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1226, 726);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TimeInBox
            // 
            this.TimeInBox.AutoRoundedCorners = true;
            this.TimeInBox.BorderRadius = 26;
            this.TimeInBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeInBox.DefaultText = "";
            this.TimeInBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeInBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeInBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeInBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeInBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeInBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TimeInBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeInBox.Location = new System.Drawing.Point(924, 90);
            this.TimeInBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeInBox.Name = "TimeInBox";
            this.TimeInBox.PasswordChar = '\0';
            this.TimeInBox.PlaceholderText = "Time In";
            this.TimeInBox.SelectedText = "";
            this.TimeInBox.Size = new System.Drawing.Size(217, 55);
            this.TimeInBox.TabIndex = 8;
            // 
            // TimeOutBox
            // 
            this.TimeOutBox.AutoRoundedCorners = true;
            this.TimeOutBox.BorderRadius = 26;
            this.TimeOutBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeOutBox.DefaultText = "";
            this.TimeOutBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeOutBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeOutBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeOutBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeOutBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOutBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TimeOutBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOutBox.Location = new System.Drawing.Point(924, 165);
            this.TimeOutBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeOutBox.Name = "TimeOutBox";
            this.TimeOutBox.PasswordChar = '\0';
            this.TimeOutBox.PlaceholderText = "Time Out";
            this.TimeOutBox.SelectedText = "";
            this.TimeOutBox.Size = new System.Drawing.Size(217, 55);
            this.TimeOutBox.TabIndex = 9;
            // 
            // fullnameBox
            // 
            this.fullnameBox.AutoRoundedCorners = true;
            this.fullnameBox.BorderRadius = 28;
            this.fullnameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnameBox.DefaultText = "";
            this.fullnameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullnameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullnameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullnameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullnameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullnameBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fullnameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullnameBox.Location = new System.Drawing.Point(4, 90);
            this.fullnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.PasswordChar = '\0';
            this.fullnameBox.PlaceholderText = "Fullname";
            this.fullnameBox.SelectedText = "";
            this.fullnameBox.Size = new System.Drawing.Size(518, 58);
            this.fullnameBox.TabIndex = 4;
            // 
            // CourseandYearBox
            // 
            this.CourseandYearBox.AutoRoundedCorners = true;
            this.CourseandYearBox.BorderRadius = 29;
            this.CourseandYearBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseandYearBox.DefaultText = "";
            this.CourseandYearBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseandYearBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseandYearBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseandYearBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseandYearBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseandYearBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CourseandYearBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseandYearBox.Location = new System.Drawing.Point(4, 165);
            this.CourseandYearBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseandYearBox.Name = "CourseandYearBox";
            this.CourseandYearBox.PasswordChar = '\0';
            this.CourseandYearBox.PlaceholderText = "Course and Year";
            this.CourseandYearBox.SelectedText = "";
            this.CourseandYearBox.Size = new System.Drawing.Size(518, 60);
            this.CourseandYearBox.TabIndex = 5;
            // 
            // SubjectBox
            // 
            this.SubjectBox.AutoRoundedCorners = true;
            this.SubjectBox.BorderRadius = 26;
            this.SubjectBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjectBox.DefaultText = "";
            this.SubjectBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SubjectBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SubjectBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SubjectBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SubjectBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubjectBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.SubjectBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubjectBox.Location = new System.Drawing.Point(4, 238);
            this.SubjectBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.PasswordChar = '\0';
            this.SubjectBox.PlaceholderText = "Subject";
            this.SubjectBox.SelectedText = "";
            this.SubjectBox.Size = new System.Drawing.Size(518, 55);
            this.SubjectBox.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.34934F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.65066F));
            this.tableLayoutPanel2.Controls.Add(this.TimeOutBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ScheduleBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.SubjectBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CourseandYearBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CameraBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.fullnameBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TimeInBox, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(78, 179);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1145, 544);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // ScheduleBox
            // 
            this.ScheduleBox.AutoRoundedCorners = true;
            this.ScheduleBox.BorderRadius = 26;
            this.ScheduleBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScheduleBox.DefaultText = "";
            this.ScheduleBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ScheduleBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ScheduleBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScheduleBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScheduleBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScheduleBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ScheduleBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScheduleBox.Location = new System.Drawing.Point(4, 306);
            this.ScheduleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleBox.Name = "ScheduleBox";
            this.ScheduleBox.PasswordChar = '\0';
            this.ScheduleBox.PlaceholderText = "Schedule";
            this.ScheduleBox.SelectedText = "";
            this.ScheduleBox.Size = new System.Drawing.Size(518, 55);
            this.ScheduleBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.PictureBox CameraBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TimeOutBox;
        private Guna.UI2.WinForms.Guna2TextBox TimeInBox;
        private Guna.UI2.WinForms.Guna2TextBox CourseandYearBox;
        private Guna.UI2.WinForms.Guna2TextBox SubjectBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox fullnameBox;
        private Guna.UI2.WinForms.Guna2TextBox ScheduleBox;
    }
}

