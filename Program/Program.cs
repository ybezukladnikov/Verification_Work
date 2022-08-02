string [] CreateArray()
{
    Console.Write("Input size array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string [] newArray = new string[size];
    
    
    
    
    return newArray;
}

void ShowArray(string [] array)
{
    Console.WriteLine("Created array: ");
    Console.Write("[");
    for(int i =0; i<array.Length; i++)
    {
        if(i == array.Length-1)
        {
            Console.Write(array[i]);
        }
        else
            Console.Write(array[i] + ", ");

    }
    Console.Write("]");
        
}

string [] newArray = CreateArray();

ShowArray(newArray);
