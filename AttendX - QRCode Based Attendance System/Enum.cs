using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendX___QRCode_Based_Attendance_System
{
    internal class Enum
    {
    }
    public static class UserStatus
    {
        public const string Active = "A";
        public const string Inactive = "I";
        public static string Display(this string value)
        {
            return value == "A" ? "Active"
                  : value == "I" ? "Inactive"
                  : string.Empty;
        }
    }
    public static class EnrollmentStatus
    {
        public const string Enrolled = "E";
        public const string Pending = "P";
        public const string NotEnrolled = "N";
        public static string Display(this string value)
        {
            return value == "E" ? "Enrolled"
                  : value == "P" ? "Pending"
                  : value == "N" ? "NotEnrolled"
                  : string.Empty;
        }
    }
}
