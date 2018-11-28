using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipe_Farm
{
    class SQL
    {
        public static String SelectAll = "SELECT * FROM Orders";
        public static String Insert = "INSERT INTO Orders (CustomerID, OrderInformation, TotalPrice, StorageRequired) VALUES (@Cust_ID_Txt, @Order_Info_Txt, @Total_Cost_Txt, Item_Count_Txt)";
    }
}
