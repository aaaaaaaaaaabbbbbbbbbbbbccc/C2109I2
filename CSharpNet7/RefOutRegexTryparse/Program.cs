using RefOutRegexTryparse;

//int a = 10;
//int b = 5;
//RefOut.Changevar(ref a, ref b);
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

RefOut.ChangeVar(out int a, out int b);
Console.WriteLine("main: ");
Console.WriteLine($"{nameof(a)}={a}, {nameof(b)}={b}");

//pure oop => oop nguyên thủy, thuần oop =>C# cũ
RegexTryparse parse = new RegexTryparse();

//dùng từ var 
var par = new RegexTryparse();

//target-type c# new
RegexTryparse p = new();
//p.CheckNumberByRegex();
p.TryCatchBug();


//ref thì cần tạo giá trị bên ngoài để làm biến cục bộ có sẵn không cần tạo thêm biến 
// out thì cần phải tạo thêm biến ở bên trong code bên phần RefOut 