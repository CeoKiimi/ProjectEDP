using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEDP
{
    public static class CurrentUser
    {
        public static int CustomerID { get; set; }
        public static string CustomerName { get; set; }

        public static int AdminID { get; set; }
        public static string AdminName { get; set; }
        public static bool IsAdmin { get; set; }

        public static void Logout()
        {
            CustomerID = 0;
            CustomerName = null;

            AdminID = 0;
            AdminName = null;
            IsAdmin = false;
        }
    }
}