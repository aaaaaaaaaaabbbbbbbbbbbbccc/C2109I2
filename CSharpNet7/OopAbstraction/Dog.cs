
namespace OopAbstraction
{
    internal class Dog : Animal
        //thực thi lại các phương thức abstract của animal
        //buộc phải dùng từ khóa override vào 
    {
        public override void ShowInfo() 
        {
            Console.WriteLine( "234");
        }
    }
}
