// C# program to illustrate the 
// Multicasting of Delegates
using System;

class rectangle
{

    // declaring delegate
    public delegate void rectDelegate(double height,
                                      double width);

    // "area" method
    public void area(double height, double width)
    {
        Console.WriteLine("Area is: {0}", (width * height));
    }

    // "perimeter" method
    public void perimeter(double height, double width)
    {
        Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
    }


    // Main Method
    public static void Main(String[] args)
    {

        // creating object of class 
        // "rectangle", named as "rect"
        rectangle rect = new rectangle();

        // these two lines are normal calling
        // of that two methods
        // rect.area(6.3, 4.2);
        // rect.perimeter(6.3, 4.2);

        // creating delegate object, name as "rectdele"
        // and pass the method as parameter by 
        // class object "rect"
        rectDelegate rectdele = new rectDelegate(rect.area);

        // also can be written as 
        // rectDelegate rectdele = rect.area;

        // call 2nd method "perimeter"
        // Multicasting
        rectdele += rect.perimeter;

        // pass the values in two method 
        // by using "Invoke" method
        rectdele.Invoke(6.3, 4.2);
        Console.WriteLine();

        // call the methods with 
        // different values
        rectdele.Invoke(16.3, 10.3);
    }
}
