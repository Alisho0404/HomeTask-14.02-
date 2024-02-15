  int MaxDigit(int a)
{
    int maxDigit = int.MinValue;
    while (a>0)
    {
        if (a % 10 > maxDigit)
        {
            maxDigit = a % 10;
        }
        a /= 10;
    }
    
    
    return maxDigit;
}
 int MinDigit(int a)
{ 
    int minDigit = int.MaxValue;
    while (a>0)
    {
        if (a%10<minDigit)
        {
            minDigit = a % 10;
        } 
        a /= 10;
    } 
    return minDigit;
}
 
 

    int a = int.Parse(Console.ReadLine());
    Console.Write(MinDigit(a)+" + "); 
    Console.Write(MaxDigit(a)+" = ");

    Console.WriteLine(MaxDigit(a)+MinDigit(a));
