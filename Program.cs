// Console.Write("Введите слово: ");
// string word = Console.ReadLine().ToLower();
// int c = 0; 

// foreach (char i in word )
// {
//     if (i == 'а')
//     {
//         c ++;
//     }
// }

// Console.WriteLine($"Кол-во А: {c}");

// Console.Write("Имя файла: ");
// string fileName = Console.ReadLine().ToLower();

// if (fileName.EndsWith(".cs")) {
//     Console.WriteLine("Это файл С#");
// } else if (fileName.EndsWith(".png") || fileName.EndsWith(".jpg")) {
//     Console.WriteLine("Это изоброжение");
// } else {
//     Console.WriteLine("неизвестный тип");
// }

// if (fileName.StartsWith("lab")) {
//     Console.WriteLine("Это лабораторная работа");
// }
// if (fileName.Contains("test")) {
//     Console.WriteLine("Тестовый файл");
// }


// string words = Console.ReadLine();

// Console.WriteLine(words.ToUpper());
// Console.WriteLine(words.Replace(" ", "_"));

// if (words.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }

// string date = "2026-09-29";
// string y = date.Substring(0, 4);
// string m = date.Substring(5, 2);
// string d = date.Substring(8, 2);
// Console.WriteLine($"{d}.{m}.{y}");

// string phone = "89161234567";
// string a = phone.Substring(1, 3);
// string b = phone.Substring(4, 3);
// string c = phone.Substring(7, 2);
// string d2 = phone.Substring(9, 2);
// Console.WriteLine($"+7 ({a}) {b}-{c}-{d2}");

// string stroka = Console.ReadLine().ToLower();
// string alfab =  "аеёиоуыэюя";
// Console.WriteLine($"Количество символов: {stroka.Length}");
// Console.WriteLine($"Количество пробелов: {stroka.Count(' ')}");
// int glas_c = 0;
// foreach (char i in stroka) {
//     if (alfab.Contains(i))
//     {
//         glas_c ++;
//     }
// }
// Console.WriteLine($"Количество гласных букв: {glas_c}");

// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// string drow = "";
// for (int i = word.Length - 1; i >= 0; i--)
// {
//     drow += word[i];
// }
// Console.WriteLine(drow);
// if (drow.ToLower() == word.ToLower())
// {
//     Console.WriteLine($"{word} - палиндром");
// } 
// else
// {
//     Console.WriteLine($"{word} - НЕ палиндром");
// }

Console.Write("Введите email: ");
string email = Console.ReadLine();
if (email.Length < 5)
{
    Console.WriteLine("Адрес некорректен: длина меньше 5 символов.");
    return;
}
if (email.Contains(" "))
{
    Console.WriteLine("Адрес некорректен: содержит пробелы.");
    return;
}
if (email.Count('@') != 1)
{
    Console.WriteLine("Адрес некорректен: символ @ должен быть ровно один.");
    return;
}
if (email.StartsWith("@") || email.EndsWith("@"))
{
    Console.WriteLine("Адрес некорректен: не может начинаться или заканчиваться на @.");
    return;
}

string lowerEmail = email.ToLower();
if (!lowerEmail.EndsWith(".ru") && !lowerEmail.EndsWith(".com"))
{
    Console.WriteLine("Адрес некорректен: должен заканчиваться на .ru или .com.");
    return;
}
Console.WriteLine("Адрес корректен: " + lowerEmail);