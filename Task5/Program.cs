  void Swap(ref int a, ref int b)
        {
            int c = a;
            a=b;
            b=c;
            Console.WriteLine("X = "+a);
            Console.WriteLine("Y = "+b);

        } 
            System.Console.Write("X = ");
            int x = int.Parse(Console.ReadLine()); 
            System.Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());

Swap(ref x, ref y);