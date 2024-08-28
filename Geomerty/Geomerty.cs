namespace Geomerty
{
    public class Geomerty
    {

    }
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double perimeter();
        public override abstract string ToString();
        //Тема: Створення бібліотек класів
        //Завдання 3: Створення бібліотеки класів для управління геометричними фігурами
        //Опис завдання:

        //Створіть бібліотеку класів(Class Library), яка включає класи для роботи з різними геометричними фігурами: Circle, Rectangle, Triangle.
        //Кожен клас повинен мати:
        //Властивості для зберігання розмірів(радіус для кола, сторони для прямокутника та трикутника).
        //Методи для обчислення площі(Area) та периметра(Perimeter).
        //Метод ToString(), який повертає інформацію про фігуру та її розміри.
        //Завдання для тестування:
        //Створіть консольну програму, яка підключає цю бібліотеку класів.
        //Створіть об'єкти кожного типу геометричної фігури, обчисліть їхню площу та периметр, і виведіть ці дані на екран.
    }

    //Створіть бібліотеку класів(Class Library), яка включає класи для роботи з різними геометричними фігурами: Circle, Rectangle, Triangle.






    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double pi { get; } = 3.14159265359;

        public Circle(double radius) { Radius = radius; }

        public override double Area() { return pi * Radius * Radius; }

        public override double perimeter() { return 2 * pi * Radius; }

        public override string ToString() { return $"circle with radius = {Radius}"; }
    }

    public class Rectangle : Shape
    {
        public int XSide { get; set; }
        public int YSide { get; set; }

        public override double Area()
        {
            return XSide * YSide;
        }

        public override double perimeter()
        {
            return (XSide + YSide) * 2;
        }
        public override string ToString()
        {
            return $"Rectangle with Width {XSide}  and Hight {YSide} , Area =  {Area()} ,  perimeter = {perimeter()}";
        }

    }



    public class Triangle : Shape
    {

        public double leftSide { get; set; }
        public double rightSide { get; set; }
        public double bottomSide { get; set; }

        public Triangle(double LeftSide, double RightSide, double BottomSide)
        {
            leftSide = LeftSide;
            rightSide = RightSide;
            bottomSide = BottomSide;
        }


        public override double Area()
        {
            // Вычисление полупериметра
            double s = leftSide + rightSide + bottomSide;

            return Math.Sqrt(s * (s - leftSide) * (s - rightSide) * (s - bottomSide));
        }
        public override double perimeter()
        {
            return leftSide + rightSide + bottomSide;
        }
        public override string ToString()
        {
            return $"Triangle with left side : {leftSide}  right side : {rightSide} and bottom Side : {bottomSide} , Area =  {Area()} ,  perimeter = {perimeter()}";
        }
    }
}
