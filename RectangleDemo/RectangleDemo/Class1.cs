using System;

namespace RectangleDemo
{
    class Rectangle
    {
       public int length;
       public int width;
        //constructor: is called when object is created
        //same name as class
        //no return type
       public Rectangle(int wid, int len)
    {
        length = len;
        width = wid;
    }
        //this method is called when tou need to print an object
       public override string ToString()
{
 	 return string.Format("length: {0}, width: {1}", length, width);
}
    }
    class program
    {
        static void Main(string[] args)
        {
            //declare a variable of type rectangle
            Rectangle bigRectangle;
            //allocate storage
            bigRectangle = new Rectangle(5, 8);
            //set the width to 5
            bigRectangle.width = 5;
            //set the length to 8
            bigRectangle.length = 8;
            Console.WriteLine(bigRectangle);
        }
    }
}
