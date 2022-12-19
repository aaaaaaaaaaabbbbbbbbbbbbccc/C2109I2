
namespace PartialClass
{
    internal partial class Human
    {       
        //1 methor mà chỉ có 1 câu lệnh
        // CSharp sẽ không sử dụng methor 
        // mà sử dụng expression body => biểu thức dưới dạng phương thức
        public void Show() =>
            Console.WriteLine($"{nameof(fullname)}={fullname}");

        public void Check() => Console.WriteLine(10 > 5 ? true:false);
        
    }
}
