// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо 
// равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

Console.Clear();

// Создание и заполнение исходного массива
string[] arr1 = new string[4];
arr1[0] = "abc1-";
arr1[1] = "2";
arr1[2] = "!ghi2";
arr1[3] = ":-)";

int CalcSize(string[] arr1, int count_arr)
// Метод подсчета строк в массиве, длина которых меньше, либо равна 3 символам
{
for (int i = 0; i < arr1.Count(); i++)
        if (arr1[i].Length <= 3) {
        count_arr += 1;
        }
    return count_arr;
}        

void ToNewArray(string[] arr1, string[] arr2, int count_arr) 
// Метод добавления строк, длина которых меньше, либо равна 3 символам, в новый массив
{
for (int i = 0; i < arr1.Count(); i++)    
        if (arr1[i].Length <= 3) 
        {
        arr2[count_arr]=arr1[i];
        count_arr+=1;
        }
        
}

// Создание нового массива необходимого размера с использованием метода CalcSize
string[] arr2 = new string[CalcSize(arr1,0)];

// Перемещение строк, длина которых меньше, либо равна 3 символам, из массива arr1 в массив arr2
ToNewArray(arr1, arr2, 0);

//Вывод исходного и нового массивов
Console.Write($"[{String.Join(", ", arr1)}] ->");
Console.Write($" [{String.Join(", ", arr2)}]");
