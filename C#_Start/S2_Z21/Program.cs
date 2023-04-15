int ax = 4;
int ay = 4;
int bx = 2;
int by = 4;

double GetDist(int ax, int ay, int bx, int by)
{
    return Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
}

Console.WriteLine( GetDist(ax, ay, bx, by) );

// double ax = double.Parse(Console.ReadLine());
// double ay = 4;
// double bx = 2;
// double by = 4;



// double GetDist(int ax, int ay, int bx, int by)
// {
//     return Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
// }

// Console.WriteLine( GetDist(ax, ay, bx, by) );

// double[] a = new double[2];
// double[] b = new double[2];

// double[] GetCoordFromConsole()
// {

// }