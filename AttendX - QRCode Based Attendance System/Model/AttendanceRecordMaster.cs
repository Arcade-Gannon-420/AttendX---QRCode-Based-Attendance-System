//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendX___QRCode_Based_Attendance_System.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceRecordMaster
    {
        public int AttendanceID { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> EnrollmentID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> TimeIn { get; set; }
        public Nullable<System.TimeSpan> TimeOut { get; set; }
    }
}
