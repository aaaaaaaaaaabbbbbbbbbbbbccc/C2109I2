using OopPolymorphismOverloading;

//object initializer
//BasicMath basic1 = new();
//BasicMath basic2 = new(){NumberOne = 5};
//BasicMath basic3 = new() { NumberTwo= 6 };
//BasicMath basic4 = new(){ NumberOne = 5,NumberTwo = 6};

BasicMath basic1 = new();
basic1.Sum();//=>0
basic1.Sum(5, 6);//=>11
basic1.Sum(num1: 5);

//named argumemt
basic1.Sum(num2: 5);
basic1.Sum(num2: 5, num1: 9);
