// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
void GenerateAndPrintNewArray(string[] array,int maxSymbol){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= maxSymbol) count ++;
    
    }
    if (count == 0){
        Console.WriteLine("[]");
        return;
    }
    string[] arrayFinal = new string[count];
    int tempI = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= maxSymbol){
            arrayFinal[tempI] = array[i];
            tempI ++;
        }
    }
    Console.WriteLine($"Итоговый масиив состоящий из строк не длиннее {maxSymbol} символов: [{String.Join(", ", arrayFinal)}]");

}

string[] array = {"asc", "dgsh", "av", "ssss"};
Console.WriteLine($"Исходный масиив строк: [{String.Join(", ", array)}]");
int maxSymbolInString = 3;
GenerateAndPrintNewArray(array, maxSymbolInString);