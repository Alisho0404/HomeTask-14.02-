int Max(int val1, int val2)
{
    if (val1>val2 )
    {
        return val1;
    } 
    else return val2;
}  
int val1=int.Parse(Console.ReadLine()); 
int val2=int.Parse(Console.ReadLine());
System.Console.WriteLine(Max(val1,val2));