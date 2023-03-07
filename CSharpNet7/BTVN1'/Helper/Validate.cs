using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_.Helper
{
    internal class Validate<T>
    {

        public static T Input(string message)
        {
            var typecode = Type.GetTypeCode(typeof(T));
            Object obj = new();
            bool flag;
            Console.WriteLine(message);
            do
            {
                flag = true;

                try
                {
                    var str = Console.ReadLine();
                    // tu bat loi, ,khong can phai dung may
                    if (string.IsNullOrEmpty(str))
                    {
                        throw new Exception("Error, null or empty");
                    }
                    switch (typecode)
                    {
                        case TypeCode.String:
                            obj = str;
                            break;

                        case TypeCode.Int32:
                            obj = int.Parse(str);
                            if ((int)obj < 0)
                            {
                                throw new Exception("Value must be greater than or equal 0");
                            }
                            break;
                        case TypeCode.Boolean:
                            obj = Convert.ToBoolean(str);
                            if (str == "true") obj = true; 
                            else 
                            { 
                                obj = false; throw new Exception("Value must be true or false (default = flase)"); 
                            }
                            break;
                        case TypeCode.DateTime:                            
                            var date = DateTime.TryParseExact(str, new[] { "d/M/yyyy", "d-M-yyyy" }, new CultureInfo("vi-VN"), DateTimeStyles.None, out var t) ? t : throw new Exception("Error, Ngu nhu cho ngay thang sai roi kia thang ngu(d/M/yyyy)");
                            obj = date.Add(DateTime.Now.TimeOfDay);
                            break;
                        default: obj = null; break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.GetType()}:{e.Message}, Enter again");
                    flag = false;
                }
            } while (!flag);
            return (T)obj;
        }
        internal static object Input()
        {
            throw new NotImplementedException();
        }
    }
}
