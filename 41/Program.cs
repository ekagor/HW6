// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

PrintInfo();
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
PrintResult();

int NumberOfNumbersGreaterThanZero(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] > 0){
            count++;
        }
    }
    return count;
}
 
void PrintInfo(){
    Console.WriteLine("Программа показывает количество чисел больше 0");
    Console.Write("Введите числа через пробел: ");
} 

void PrintResult(){
    Console.WriteLine($"Чисел больше 0: {NumberOfNumbersGreaterThanZero(arr)}");
}