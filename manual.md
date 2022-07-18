# C# Введение

## Основные команды

через console мы обращаемся к системному терминалу

1. dotnet new console - создание нового проекта

2. Console.WriteLine("Hello, World!") - вывод в консоль терминала в новой строке

3. dotnet run - выполнить код в терминале "Запустить проект"

4. Write(); - Вывод в одну строчку

5. WriteLine() - В конце перейти на новую строку

6.ReadLine() - Считать строчку из терминала

7. ToLower() - перевести в нижний регистер

8. Clear() - Отчистка консоли


## Типы данных

1. int - целый тип данных
2. double - вешественный тип данных
3. string - тип данных строка
4. bool - булевые значения

## Случайности 
new Random().Next(min, max)
даст случайное целое число от min до max-1
[min,max-1] или [min, max)


## циклы

1. while
2. for

## Массивы

определение массива

ТИПДАННЫХ[]ИМЯ = {зНАЧЕНИЕ 1, ЗНАЧЕНИЕ2, ......}
int[] arr = {9, 29, 30, 45, 55}
int[] arr = new int[5];
int[] arr = new int[]{0, 0, 0, 0, 0}
int[]arr = new int[5]{1, 0, 2, 0, 5}

## Методы

void - метод не возращает
имена методов всегда с большой буквы
переменные с маленькой


//Вид 1

void Metod1()
{
    Console.WriteLine("Автор .....");
}
Metod1();

//Вид 2

не чего не возращают но могут принемать разные аггументы

void Metod2(string msg)
{
    ConsoleWriteLine(msg);
}
Metod2("text")

void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod21("text", 4); //сколько раз мы хотим увидеть вывод

// Вид3
чтото возращают но не чего не принемают

int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);

// Вид 4
методы что то принемают и чтото возращают

string Metod4(int count, string c)
{
    int i = 0;
    string result = String.Empty; //Пустая страка
    while(i < count)
    {
        result = result + c;
        i++
    }
    reyurn result;
}
string res = Metod4(10, "text");
Console.WriteLine(res);


string Metod41(int count, string c)
{
    string result = String.Empty; //Пустая страка
    for(int i = 0; i < count; i++)
    {
        result = result + c;
        
    }
    reyurn result;
}
string res = Metod41(10, "text");
Console.WriteLine(res);

