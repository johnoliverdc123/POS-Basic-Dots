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
    }

    public enum LogType
    {
        LOGBOOK,
        USER,
        POSITION,
        CATEGORY,
        PRODUCT,
        ORDERS,
        EXPENSES
    }

    public enum PaymentStatus
    {
        PAID,
        CREDIT
    }
}
