 int Divisors(int a) 
        {
            int divisors = 1;
            while (divisors<=a)
            {
                if (a%divisors == 0)
                {
                    Console.Write(divisors+" ");
                }
                divisors++;
            }
            return a;
        } 
         int a=int.Parse(Console.ReadLine());
         Divisors (a);
