// Вид 1        Ничего не принимает и ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// Method1();      //Вызываем метод

//-------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------


// Вид 2        Что то принимает и ничего не возвращает
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Метод 2 тест");
//-------------------------------------------------------------------------------------------------------------------------------

// void Method21(string msg, int count)    //Если аргументов несколько, делаем именованые аргументы
// {
//     int i = 0;
//     while(i < count){
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Метод 2 тест", 4);
// Method21(count: 4, msg:"Метод 21 тест");   //При вызове метода именованые аргументы модно менять местами
//-------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------

// Вид 3        Ниего не принимает и что то возвращает
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//-------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------


// Вид 4        Что то принимает и что то возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count){
//         result += text;
//         i++;
//     }
//     return result;
// }
//-------------------------------------------------------------------------------------------------------------------------------

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++){
//         result += text;
//     }
//     return result;
// }

// string res = Method4(10, "Hello ");
// Console.WriteLine(res);
//-------------------------------------------------------------------------------------------------------------------------------

// for (int i = 1; i <= 10; i++){
//     for (int j = 1; j <= 10; j++){
//         Console.WriteLine($"{i} X {j} = {i * j} ");
//     }
//     Console.WriteLine();
// }

//-------------------------------------------------------------------------------------------------------------------------------

// Работа с текстом.
// Дан текст. В тексте нужно все пробелы заменить черточками.
// Маленькие буквы к заменить большими К.
// А большие С заменить маленькими с.

string text = "- Я думаю, - сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нащего милого Винценгероде, "
            + "вы бы взяли приступом согласия прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
//     {
//         string result = String.Empty;
//         int lenght = text.Length;
//         for ( int i = 0; i < lenght; i ++){
//             if (text[i] == oldValue){
//                 result += newValue;
//             }
//             else result += text[i];
//         }
//         return result;
//     }
//     string newText = Replace(text, ' ', '|');
//     Console.WriteLine(newText);

//     Console.WriteLine();

//     newText = Replace(newText, 'к', 'К');
//     Console.WriteLine(newText);

//     Console.WriteLine();

//     newText = Replace(newText, 'с', 'С');
//     Console.WriteLine(newText);
    
//  Сортировка массива

//-------------------------------------------------------------------------------------------------------------------------------

int[] num = {8, 6, 3, 2, 1, 4, 5, 7};
void PrintArray(int[] array)
{
    int len = num.Length;
    for (int i = 0; i < len; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Selection(int[] array)
{
    for (int i = 0; i < array.Length; i ++){
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPosition]){
                minPosition = j;
            }
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(num);
Selection(num);
PrintArray(num);