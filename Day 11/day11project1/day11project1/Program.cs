using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************
Author : G V S S SRI LASYA
Purpose: Write example program for interfaces discussed in the class.
Create IShape interface and include the classes
Cricle, Square, Triangle, Rectangle.
*********************************************************************/



namespace day11project1
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();

    }

    class Circle : IShape
    {

        private int radius;

        /// <summary>
        /// Read user input for radius
        /// </summary>
        /// <return>
        /// void
        /// </return>
        public void ReadRadius()
        {

            Console.Write("\n\n\n\nEnter the radius : ");
            radius = Convert.ToInt32(Console.ReadLine());
        
        }


        /// <summary>
        /// Calculate area of circle
        /// </summary>
        /// <returns>
        /// int
        /// </returns>
        public int CalculateArea()
        {

            return (int)22 * radius * radius / 7;
       
        }


        /// <summary>
        /// Calculate perimeter of circle
        /// </summary>
        /// <returns>
        /// int
        /// </returns>
        public int CalculatePerimeter()
        {

            return (int)2 * 22 * radius / 7;
       
        }

    }

    class Square : IShape
    {
        private int side;

        /// <summary>
        /// Read user input for side of square
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void ReadSide()
        {

            Console.Write("\n\n\n\nEnter the side of square : ");
            side = Convert.ToInt32(Console.ReadLine());
        
        }


        /// <summary>
        /// Calculate perimeter of square
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int CalculatePerimeter()
        {

            return 4 * side;

        }


        /// <summary>
        /// Calculate area of square
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int CalculateArea()
        {

            return side * side;

        }
    }

    class Rectangle : IShape
    {
        private int length, breadth;


        /// <summary>
        /// Read user input for sides of rectangle
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void ReadSides()
        {
            Console.Write("\n\n\n\nEnter length of the rectangle : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of the rectangle : ");
            breadth = Convert.ToInt32(Console.ReadLine());

        }

        /// <summary>
        /// Calculate perimeter of rectangle
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }

        /// <summary>
        /// Calculate area of square
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int CalculateArea()
        {
            return length * breadth;
        }

    }

    class EquilateralTriangle : IShape
    {

        private int side;



        /// <summary>
        /// Read user inut for side of equilaterak triangle
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void ReadSide()
        {
            Console.Write("\n\n\n\nEnter side of the equilateral triangle : ");
            side = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calculate perimeter of equilateral triangle
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int CalculatePerimeter()
        {
            return 3 * side;
        }

        /// <summary>
        /// Calculate area of square
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int CalculateArea()
        {
            return (int)1.732 * side * side / 4;

        }
     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nCalculating areas and perimeters of circle,square,rectangle,equilateral triangle");

            Circle circleObject = new Circle();
            circleObject.ReadRadius();
            Console.Write("Area of circle : " + circleObject.CalculateArea());
            Console.Write("\nPerimeter of circle : " + circleObject.CalculatePerimeter());


            Square squareObject = new Square();
            squareObject.ReadSide();
            Console.Write($"Area of square : " + squareObject.CalculateArea());
            Console.Write($"\nPerimeter of square : " + squareObject.CalculatePerimeter());


            Rectangle rectangleObject = new Rectangle();
            rectangleObject.ReadSides();
            Console.Write($"Area of rectangle : " + rectangleObject.CalculateArea());
            Console.Write($"\nPerimeter of rectangle : " + rectangleObject.CalculatePerimeter());


            EquilateralTriangle triangleObject = new EquilateralTriangle();
            triangleObject.ReadSide();
            Console.Write($"Area of triangle : " + triangleObject.CalculateArea());
            Console.Write($"\nPerimeter of triangle : " + triangleObject.CalculatePerimeter());


            Console.ReadLine();

        }
    }
}
