﻿string [] CreateArray(int size, string characterSet, int minSizeRow, int maxSizeRow)
{
    
    string [] newArray = new string[size];
    
    for(int j=0; j<size; j++)
    {
        int rand = new Random().Next(minSizeRow,maxSizeRow+1);
        for (int i = 0; i<rand; i++)
        {
            newArray[j] = newArray[j] + characterSet[new Random().Next(0,characterSet.Length)];
        }
    }


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
            Console.Write($"{array[i]}, ");

    }
    Console.Write("]");
    Console.WriteLine();
        
}

int FindSizeNewArray(string [] array)
{
    int index =0;
    foreach(string el in array)
    {
        if(el.Length <= 3) index++;
    }
    
    return index;
}

string [] CreateNewArray(string [] array, int size)
{
    string [] newArray = new string[size];
    int index = 0;
    foreach(string el in array)
    {
        if(el.Length<=3)
        {
            newArray[index] = el;
            index++;
        } 
    }

    
    return newArray;
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input characterSet: ");
string characterSet = Console.ReadLine();

Console.Write("Input min Size Row array: ");
int minSizeRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max Size Row array: ");
int maxSizeRow = Convert.ToInt32(Console.ReadLine());

string [] array = CreateArray(size, characterSet, minSizeRow,maxSizeRow);

ShowArray(array);

int sizeNewArray = FindSizeNewArray(array);
Console.WriteLine(sizeNewArray);

string [] newArray = CreateNewArray(array, sizeNewArray);

ShowArray(newArray);



