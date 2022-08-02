// Метод создает массив. Атрибут size это размер массива, который задается пользователем. 

string [] CreateArray(int size)
{
    
    return new string[size];
    
}

/* Метод заполняет массив случайным символами. 
Атрибуты:
1) characterSet - набор символов из которых будет состять элемент массива. 
2) minSizeRow - минимальная длина элемента массива. 
3) maxSizeRow - максимальная длина элемента массива. 

*/
void FillArray(string[] array, string characterSet, int minSizeRow, int maxSizeRow)
{
    
    
    int size = array.Length;
    for(int j=0; j<size; j++)
    {
        int rand = new Random().Next(minSizeRow,maxSizeRow+1);
        for (int i = 0; i<rand; i++)
        {
            array[j] = array[j] + characterSet[new Random().Next(0,characterSet.Length)];
        }
    }


}


/* Метод формирует строку, которую можно вывести на печать. 
Атрибуты:
array - массив из которого формируется строка. 

*/
string Print(string[] array)
{
    
    string temp = string.Join(" ", array);
    string result = temp.Replace(" ","\", \"");
    return result;
}

/* Метод находит размер нового массива путем подсчета элементов исходного массива, которые меньше либо равны 3. 
Атрибуты:
array - исходный массив. 

*/

int FindSizeNewArray(string [] inputArray)
{
    int index =0;
    foreach(string el in inputArray)
    {
        if(el.Length <= 3) index++;
    }
    
    return index;
}

/* Метод создает новый массив из элементов исходного значение которых меньше либо равны 3.  
Атрибуты:
1) array - исходный массив. 
2) size - размер нового массива. 

*/

string [] CreateNewArray(string [] inputArray, int size)
{
    string [] newArray = new string[size];
    int index = 0;
    foreach(string el in inputArray)
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

string [] array = CreateArray(size);
FillArray(array, characterSet, minSizeRow,maxSizeRow);

Console.WriteLine();
Console.WriteLine("Created initial array: ");
Console.WriteLine();
Console.WriteLine($"[\"{Print(array)}\"]");
Console.WriteLine();


int sizeNewArray = FindSizeNewArray(array);


string [] newArray = CreateNewArray(array, sizeNewArray);

Console.WriteLine("Created new array: ");
Console.WriteLine();
Console.WriteLine($"[\"{Print(newArray)}\"]");



