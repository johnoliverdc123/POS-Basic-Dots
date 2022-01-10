using System;
using System.Collections.Generic;

namespace POSWinforms.Models
{
    public class DatabaseHelper
    {
        public static frmLogin frmLogin;
        public static POSDBDataContext db = new POSDBDataContext();
        public static User user = new User();
        public static tblItem item = null;
        public static List<OrderDetail> cartList = new List<OrderDetail>();

        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }

    public enum LogType
    {
        LOGBOOK,
        USER,
        POSITION,
        CATEGORY,
        PRODUCT,
        ORDERS,
        EXPENSES,
        EXPENSE_TYPE
    }

    public enum PaymentStatus
    {
        PAID,
        CREDIT
    }
}
