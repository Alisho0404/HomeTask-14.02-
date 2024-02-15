 int MinNumber(int a, int b, int c, int d)
        {
            if (a < b && a < c && a < d) { return  a; } 
            if (b<a && b < c && b < d) { return  b; }
            if (c < a && c < b && c < d) { return a; }
            else
                return d;

             
        }
int a=int.Parse(Console.ReadLine()); 
int b=int.Parse(Console.ReadLine()); 
int c=int.Parse(Console.ReadLine()); 
int d=int.Parse(Console.ReadLine());
        Console.WriteLine(MinNumber(a, b, c, d));