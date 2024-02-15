 int[] IncrementArrayElement(int[] array, ref int n)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((array[i] += n)+","); 
            }
            Console.Write("]");
            return array;
        }  
        int n=int.Parse(Console.ReadLine());
         int[] array = new int[] {  1, 2, 3 };
         IncrementArrayElement(array, ref n);   