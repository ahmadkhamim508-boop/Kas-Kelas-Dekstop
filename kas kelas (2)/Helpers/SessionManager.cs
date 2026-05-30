using kas_kelas__2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_kelas__2_.Helpers
{
    public static class SessionManager
    {
        public static string Role { get; private set; }
        public static UsersModel CurrentUser { get; private set; }
        public static StudentsModel CurrentStudent { get; private set; }

        public static void SetAdmin(UsersModel user)
        {
            Role = "admin";
            CurrentUser = user;
            CurrentStudent = null;
        }

        public static void SetStudent(StudentsModel student)
        {
            Role = "student";
            CurrentStudent = student;
            CurrentUser = null;
        }

        public static void Clear()
        {
            Role = null;
            CurrentUser = null;
            CurrentStudent = null;
        }

        public static bool IsAdmin() => string.Equals(Role, "admin");
        public static bool IsStudent() => string.Equals(Role, "student");
    }
}
