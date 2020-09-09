using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplacetask.TestData
{
    class ReadData
    {
        public static String Email;
        public static String Password;
        public static String Description;
        public static String FileExtention;
        public static String Content;
        public static String FileExtention2;
        public static String Content2;
        public static String Comment1;
        public static String Comment2;
      


        public static void setData(String datafilepath)
        {
            
            List<String> data = ExcelRead.ReadExcel(datafilepath, Constants.Sheet);
            Email = data[0];
            Password = data[1];
            Description = data[2];
            FileExtention = data[3];
            Content = data[4];
            FileExtention2 = data[5];
            Content2 = data[6];
            Comment1 = data[7];
            Comment2 = data[8];
           


        }

    }
}
