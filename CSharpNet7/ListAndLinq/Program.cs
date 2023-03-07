using ListAndLinq;
using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
List<Student> list = new()
{
    new Student(){Id = 1, Name = "vu minh thai", Gender = false, Dob = new DateTime(2003 , 06, 24)}

};

////duyệt qua lits bằng vòng lập foreach
//foreach (var stu in list)
//{
//    Console.WriteLine(stu);
//}

////vòng lặp foreach sex chuyển thành 
//IEnumerator enu = list.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current.ToString());


//duyệt qua list 
list.ForEach(Console.WriteLine);

//linq = language integrated query 
//linq to sql => thay thế cú pháp sql trong c#
//linq to object => console 
//sql => select from where group by having oder by 
//c# => FROM WHERE GROUP BY HAVING ODER BY......SELECT
//linq có 2 dạng 
//Style 1 => query syntax => dựa theo cú pháp của sql, dễ học , dễ dùng 
//Style 1 => method syntax => dựa theo lambda => khó học, khó dùng nhưng cực nhanh 


//hiển thị toàn bộ thông tin của sinh viên trong list, với điều kiện id sinh viên phải lớn hơn 2 

//Style 1 của linq 
//foreach(var stu in list)
//{
//    if (stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

//var t = from stu in list 
//        where stu.Id >2
//       select stu;
//foreach (var i in t)
//{
//    Console.WriteLine(i);
//}

//Style 2 của linq 

var t = list.Where(stu => stu.Id > 2);
foreach (var i in t)
{
    Console.WriteLine(i);
}
Console.ReadKey();
//kết hợp foreach của list 