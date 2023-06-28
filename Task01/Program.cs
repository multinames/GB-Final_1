// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо 
// равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

// Создание и заполнение массива
string[] arr1 = new string[3];
arr1[0] = "abc1";
arr1[1] = "!%11";
arr1[2] = "ghi2";

// Создание переменной счетчика
// int count_arr = 0;

/* void PrintArray(string[] arr)
// Вывод всех элементов массива
{
    Console.Write("[");
    for(int i=0; i<arr.Length;i++) 
    {
           Console.Write($"\"{arr[i]}\", ");
    }
    Console.Write("]");
}
 */
int CalcSize(string[] arr1, int count_arr)
// Подсчет строк в массиве совпадающих по количеству символов
{
for (int i = 0; i < arr1.Count(); i++)
        if (arr1[i].Length <= 3) {
        count_arr += 1;
        // Console.Write($"{arr1[i].Count()} ");
        }
    // Console.WriteLine("count " + count_arr);
    return count_arr;
}        

// Перемещение нужных строк в новый массив

int count = CalcSize(arr1,0);
// Console.WriteLine(count);

string[] arr2 = new string[count];

void ToNewArray(string[] arr1, string[] arr2, int j) 
// Добавление строк менее трех смиволов в новый массив
{
for (int i = 0; i < arr1.Count(); i++)    
        if (arr1[i].Length <= 3) 
        {
        arr2[j]=arr1[i];
        j+=1;
       // Console.WriteLine("j = "+j);
   //    Console.Write($"{arr2[j-1]} "); 
     //   Console.Write($"{String.Join(" ",arr2)} "); 
        }
        
}

//PrintArray(arr1);

Console.Write($"[{String.Join(", ", arr1)}] ->");

ToNewArray(arr1, arr2, 0);

Console.Write($" [{String.Join(", ", arr2)}]");
