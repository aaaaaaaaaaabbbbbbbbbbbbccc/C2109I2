using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number = 10;
string str = "thái";
double money = 10.5;
bool check = true;
//trong C# thường có 2 dạng kiểu chính 
//1 value type(dạng số) không chứa được null, 2 là reference type (chuỗi, đối tượng) cho phép null;

string name = null;

//code cũ 
Nullable<bool> a = null;

//code mới => nullable value type 
int? b = null;
bool? flag = null;
string s = null;
// ?: => ternary operator
Console.WriteLine(name != null ? true : false);
//is not null (!=)
//is (==)
Console.WriteLine(name is not null ? true : false);

// ?=> null conditional operator
// ? dùng sau đít của tên biến hay đối tượng 
// ? tương tự dấu (!=), nếu cái gì đó khác null thì lấy cái vế sau 

int? length = name?.Length;

//if (name!= null)
//{
//  length = name.Length;
//}
//else
//{
//  length = null;
//}

//?? => null coalescing operator 
// ?? tương tự dấu ==, nếu cái gì đó bằng null thì lấy cái vế sau 
int chieudai = name?.Length ?? 10;