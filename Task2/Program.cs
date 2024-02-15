  int Add(int a, int b)
 {
     return a + b;
 }
  int Subtract(int a, int b)
 {
     return a - b;
 }
  int Multiply(int a, int b)
 {
     return a * b;
 }
 int Division(int a, int b)
 {
     return a / b;
 }
  
 
     int a = int.Parse(Console.ReadLine());
     int b = int.Parse(Console.ReadLine());
     Console.WriteLine("Add: " + Add(a, b));
     Console.WriteLine("Subtract: " + Subtract(a, b));
     Console.WriteLine("Multiply: " + Multiply(a, b));
     Console.WriteLine("Division: " + Division(a, b));
 