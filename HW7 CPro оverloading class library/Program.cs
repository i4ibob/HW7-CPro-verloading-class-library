using HW7_CPro_оverloading_class_library;
using System.Numerics;
using Geomerty;
using Geomerty.Geomerty;


class Program
{
    static void Main(string[] args)
    {



        while (true) {
            Console.Clear();
            Console.Write($"1# Complex Numbers" +
            $"\n2#Geometry objects" +
            $"\nEnter number:");
        var query = Convert.ToInt32(Console.ReadLine());
            switch (query)
            {



                case 1:
                    Console.Clear();
                    Console.WriteLine("Create first complex num");

                    Console.Write("Enter real part of  num:");
                    double Real = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter  imaginary part of  num:");
                    double imaginary = Convert.ToDouble(Console.ReadLine());
                    ComplexNumber c1 = new ComplexNumber(Real, imaginary);

                    Console.WriteLine("Create second  complex num");
                    Console.Write("Enter  real part of  num:");
                    Real = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter  imaginary part of  num:");
                    imaginary = Convert.ToDouble(Console.ReadLine());
                    ComplexNumber c2 = new ComplexNumber(Real, imaginary);

                    ComplexNumber sum = c1 + c2;
                    ComplexNumber difference = c1 - c2;
                    ComplexNumber product = c1 * c2;
                    ComplexNumber quotient = c1 / c2;

                    Console.WriteLine($"Первое комплексное число: {c1}");
                    Console.WriteLine($"Второе комплексное число: {c2}");
                    Console.WriteLine($"Сумма: {sum}");
                    Console.WriteLine($"Разность: {difference}");
                    Console.WriteLine($"Произведение: {product}");
                    Console.WriteLine($"Частное: {quotient}");

                    Console.WriteLine("\npress any kay to continue..");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Create Circle ");
                    Console.Write("Enter  radius:");
                    var Radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(Radius);
                    Console.WriteLine(circle.ToString());
                    Console.WriteLine($"Area: {circle.Area()}");
                    Console.WriteLine($"Perimeter: {circle.Perimeter()}");

                    Console.WriteLine("\nCreate rectangle ");
                    Console.Write("Enter size of x side :");
                    var xside = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter size of y side :");
                    var yside = Convert.ToDouble(Console.ReadLine());
                    if (xside == 0 || yside == 0) { break; }
                    
                    Rectangle rectangle = new Rectangle(xside, yside);
                    Console.WriteLine(rectangle.ToString());
                    Console.WriteLine($"Area: {rectangle.Area()}");
                    Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");
                     

                    Console.WriteLine("\nCreate rectangle ");
                    Console.Write("Enter size of left side :");
                    var leftside = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter size of right side :");
                    var rightside = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter size of bottom side :");
                    var bottomside = Convert.ToDouble(Console.ReadLine());
                    if (xside == 0 || yside == 0) { break; }
                    Triangle triangle = new Triangle(leftside, rightside, bottomside);
                    Console.WriteLine(triangle.ToString());
                    Console.WriteLine($"Area: {triangle.Area()}");
                    Console.WriteLine($"Perimeter: {triangle.Perimeter()}");

                    Console.WriteLine("\npress any kay to continue..");
                    Console.ReadKey();
                    break;
            }
        }
    }
}