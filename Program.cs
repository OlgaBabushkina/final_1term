Console.WriteLine("Введите слова через запятую без пробелов");
string? userInput = Console.ReadLine();
char divider = ',';
int count = 1;
int quantity = 0;
int minSymbolNumber = 3;
int l = 0;

for (int i = 0; i < userInput.Length; i++)//цикл определяет количество слов введенных пользователем и размер массива
{
    if (userInput[i] == divider)
    {
        count++;
    }
}
string[] words = new string[count];//инициализация массива из введенных пользователем слов

for (int i = 0; i < userInput.Length; i++)//цикл заполняет массив словами, которые ввел пользователь
{
    if (userInput[i] != divider)
    {
        words[quantity] += userInput[i];
    }
    else
    {
        quantity++;
    }
}

string[] shortWords = new string[quantity];// инициализация массива для слов (<=3 символов) из ввода пользователя

for (int i = 0; i < words.Length; i++)// поиск слов, которые <=3 символов и запись их в итоговый массив с одновременным выводом
{
    if (words[i].Length <= minSymbolNumber)
    {
        shortWords[l] = words[i];
        Console.Write(shortWords[l] + " ");
        l++;
    }
}