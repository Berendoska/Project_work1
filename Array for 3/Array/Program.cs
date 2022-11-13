using System;
string[] array =  {"hello","2", "may", "1234"}; 
string[] arrayNew  = new string[array.Length];

void ArrayLengthIndexThree(string[] array, string[] arrayNew)
{
int size = 3;
int index = 0;

for (int i = 0; i < array.Length; i++)
{
if(array[i].Length <= size){
  
    arrayNew[index] = array[i];
    index++;  
}
}
}
 void PrintArray(string[] arr)
{
    int count = arr.Length;
    Console.Write("");
     for (int i = 0; i < count; i++)
     {
        System.Console.Write($"{arr[i]} ");
     }
     System.Console.WriteLine("");
}

ArrayLengthIndexThree(array, arrayNew);
PrintArray(arrayNew);
