/*
2
3
4

1.3
1
6

2
-3
4
*/

namespace ClassBoxData
{
    public class StartUp
    {
		public static void Main()
		{
			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
			try
			{
				Box box = new Box(length, width, height);

				Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
				Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
				Console.WriteLine($"Volume - {box.Volume():f2}");
            }
			catch (ArgumentException ex)
			{

                Console.WriteLine(ex.Message);
			}
		}
    }
}