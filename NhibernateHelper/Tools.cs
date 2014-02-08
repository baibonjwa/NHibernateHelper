using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NhibernateHelper
{
    public static class Tools
    {
        public static String ToFirstLetterLower(String str)
        {
            if (str.Length > 0)
                return str.Substring(0, 1).ToLower() + str.Substring(1, str.Length - 1);
            else
                return "";
        }
        public static DataTable ToDataTable(DataRow[] rows)
        {
            if (rows == null || rows.Length == 0) return null;
            DataTable tmp = rows[0].Table.Clone();  // 复制DataRow的表结构  
            foreach (DataRow row in rows)
                tmp.Rows.Add(row.ItemArray);  // 将DataRow添加到DataTable中  
            return tmp;
        }
    }
}
