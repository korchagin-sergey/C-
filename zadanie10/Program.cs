// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int[] arr = { 11, 25, 30, 55, 40, 65, 75, 80, 91 };
// arr[0] = 12; // присваеваем хначение 

// Console.WriteLine(arr[4]); //вывести элемент массива

// int max = Max(
//     Max(arr[0], arr[1], arr[2]),
//     Max(arr[3], arr[4], arr[5]),
//     Max(arr[6], arr[7], arr[8])
// );
// Console.WriteLine(max);

//Задача2

// int[] array = { 1, 2, 3, 10, 15, 18, 66, 0, 5, 4 };
// int n = array.Length; //определяет длинну массива
// int find = 4;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

//задача3
// void FillArr(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArr(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// int[] arr = new int[10];  //задаем массив поумолчанию в нем 10 элементов
// FillArr(arr);
// PrintArr(arr);

// Задача 4
void FillArr(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArr(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] arr = new int[10];  //задаем массив поумолчанию в нем 10 элементов
FillArr(arr);
PrintArr(arr);
Console.WriteLine();

int pos = IndexOf(arr, 4);
Console.WriteLine(pos);
