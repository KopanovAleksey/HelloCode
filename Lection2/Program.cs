//Поиск максимума из 9 чисел
/*
int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 3;
int b1 = 6;
int c1 = 9;
int a2 = 15;
int b2 = -6;
int c2 = 19;
int a3 = 26;
int b3 = 7;
int c3 = -2;

// int max1 = max(a1, a2, a3);
// int max2 = max(b1, b2, b3);
// int max3 = max(c1, c2, c3);
int maximum = max(max(a1, a2, a3), max(b1, b2, b3), max(c1, c2, c3));
Console.WriteLine(maximum);
*/

//Array C#
/*
int[] array = {1,2,3,4,5,6,7,8,9};
int Max = array[0];
for (int i = 0; i<array.Length; i++)
{
if (array[i]>Max) Max = array[i];
}
Console.WriteLine(Max);
*/
/*
int[] array = {1,5,2,65,5,14,5,465,4,54,65,54,6};
int n = array.Length;
int find = 5;
for (int i = 0; i<n; i++){
    if (array[i]==find){
        Console.WriteLine(i);
        break;
    } 
}
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(collection[position] + " ");
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    int position = -1;
    while(i<count)
    {
        if (collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,44);
Console.WriteLine(pos);