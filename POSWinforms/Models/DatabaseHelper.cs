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

        public static List<string> sizeTypes = new List<string>
        {
            "TARPAULIN",
            "STICKER",
            "PANTS",
            "SHIRT",
            "MUGS",
            "NONE"
        };

        public static List<PriceSize> shirtSizes = new List<PriceSize>
        {
            new PriceSize { Size = "XS", Price = 90 },
            new PriceSize { Size = "S", Price = 110 },
            new PriceSize { Size = "M", Price = 130 },
            new PriceSize { Size = "L", Price = 150 },
            new PriceSize { Size = "XL", Price = 170 },
            new PriceSize { Size = "2XL", Price = 190 },
            new PriceSize { Size = "3XL", Price = 210 },
        };

        public static List<PriceSize> pantSizes = new List<PriceSize>
        {
            new PriceSize { Size = "24", Price = 90 },
            new PriceSize { Size = "25", Price = 100 },
            new PriceSize { Size = "26", Price = 110 },
            new PriceSize { Size = "27", Price = 120 },
            new PriceSize { Size = "28", Price = 130 },
            new PriceSize { Size = "29", Price = 140 },
            new PriceSize { Size = "30", Price = 150 },
            new PriceSize { Size = "31", Price = 160 },
            new PriceSize { Size = "32", Price = 170 },
            new PriceSize { Size = "33", Price = 180 },
            new PriceSize { Size = "34", Price = 190 },
            new PriceSize { Size = "35", Price = 200 },
            new PriceSize { Size = "36", Price = 210 },
            new PriceSize { Size = "37", Price = 220 },
            new PriceSize { Size = "38", Price = 230 },
            new PriceSize { Size = "39", Price = 240 },
            new PriceSize { Size = "40", Price = 250 },
        };

        public static List<PriceSize> mugTypes = new List<PriceSize>
        {
            new PriceSize { Size = "Regular", Price = 150 },
            new PriceSize { Size = "Magic", Price = 250 },
            new PriceSize { Size = "Clear", Price = 250 },
            new PriceSize { Size = "Frosted", Price = 250 },
            new PriceSize { Size = "Colored", Price = 250 },
        };
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
