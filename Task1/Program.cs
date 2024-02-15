    int EvenCount(int n)
 {
     int evenCount = 0;
     while (n > 0)
     {
         if (n % 2 == 0)
         {
             evenCount++;
         }
         n /= 10;
     } 
     return evenCount;
 }

   int OddCount(int n)
 {
     int oddCount = 0;
     while (n > 0)
     {
         if (n % 2 != 0)
         {
             oddCount++;
         }
         n /= 10;
     }
     return oddCount;
 }
   int Digit(int n)
 {
     int digit = 0;
     while (n > 0)
     {
         digit++;
         n /= 10;
     }
     return digit;
 }
   int Sum(int n)
 {
     int sum = 0;
     while (n > 0)
     {
         sum += n % 10;
         n /= 10;
     }
     return sum;
 }
  
 
     int n = int.Parse(Console.ReadLine());
     Console.WriteLine("Even: "+ EvenCount(n)); 
     Console.WriteLine("Odd: "+ OddCount(n)); 
     Console.WriteLine("Digit: "+ Digit(n)); 
     Console.WriteLine("Sum: "+ Sum(n)); 
     
 
