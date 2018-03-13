using System;

class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;

        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 4.0;
        const double MIN_HEIGHT = 0.25;

        string widthString, heightString;

        Console.Write("Window width [m]:");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        if (width < MIN_WIDTH){
            Console.WriteLine("Width is too small. \n \n");
            Console.WriteLine("Using minimum width of " + MIN_WIDTH + " meters");
            width = MIN_WIDTH;
        }

        if (width > MAX_WIDTH){
            Console.WriteLine("Width is too large. \n \n");
            Console.WriteLine("Using maximum width of " + MAX_WIDTH + " meters");
            width = MAX_WIDTH;
        }

        Console.Write("Window height [m]:");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        if (height < MIN_HEIGHT)
        {
            Console.WriteLine("Height is too small. \n \n");
            Console.WriteLine("Using minimum height of " + MIN_HEIGHT + " meters");
            height = MIN_HEIGHT;
        }

        if (height > MAX_HEIGHT)
        {
            Console.WriteLine("Height is too large. \n \n");
            Console.WriteLine("Using maximum height of " + MAX_HEIGHT + " meters");
            height = MAX_HEIGHT;
        }

        woodLength = 2 * (width + height) * 3.28084;

        glassArea = 2 * (width + height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square meters");
    }
}