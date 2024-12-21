using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }
    static void Task1()
    {
        Console.Write("Введіть символ для квадрата: ");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("Введіть розмір сторони квадрата: ");
        int size = int.Parse(Console.ReadLine());
        DrawSquare(symbol, size);
    }
    static void DrawSquare(char symbol, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
    static void Task2()
    {
        Console.Write("Введіть число для перевірки на паліндром: ");
        int number = int.Parse(Console.ReadLine());
        bool isPalindrome = CheckPalindrome(number);
        Console.WriteLine($"Число {number} {(isPalindrome ? "є" : "не є")} паліндромом.");
    }
    static bool CheckPalindrome(int number)
    {
        string str = number.ToString();
        string reversed = new string(str.Reverse().ToArray());
        return str == reversed;
    }
    static void Task3()
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        int[] result = FilterArray(originalArray, filterArray);

        Console.WriteLine("Оригінальний масив: " + string.Join(" ", originalArray));
        Console.WriteLine("Масив для фільтрації: " + string.Join(" ", filterArray));
        Console.WriteLine("Відфільтрований масив: " + string.Join(" ", result));
    }
    static int[] FilterArray(int[] original, int[] filter)
    {
        return original.Where(x => !filter.Contains(x)).ToArray();
    }
    static void Task4()
    {
        Website site = new Website();
        site.InputData();
        site.DisplayData();
    }
    static void Task5()
    {
        Journal journal = new Journal();
        journal.InputData();
        journal.DisplayData();
    }
    static void Task6()
    {
        Store store = new Store();
        store.InputData();
        store.DisplayData();
    }
}
class Website
{
    private string name;
    private string path;
    private string description;
    private string ipAddress;
    public void InputData()
    {
        Console.Write("Введіть назву сайту: ");
        name = Console.ReadLine();
        Console.Write("Введіть шлях до сайту: ");
        path = Console.ReadLine();
        Console.Write("Введіть опис сайту: ");
        description = Console.ReadLine();
        Console.Write("Введіть IP-адресу сайту: ");
        ipAddress = Console.ReadLine();
    }
    public void DisplayData()
    {
        Console.WriteLine($"Назва сайту: {name}");
        Console.WriteLine($"Шлях до сайту: {path}");
        Console.WriteLine($"Опис сайту: {description}");
        Console.WriteLine($"IP-адреса сайту: {ipAddress}");
    }
}
class Journal
{
    private string name;
    private int yearFounded;
    private string description;
    private string phone;
    private string email;
    public void InputData()
    {
        Console.Write("Введіть назву журналу: ");
        name = Console.ReadLine();
        Console.Write("Введіть рік заснування: ");
        yearFounded = int.Parse(Console.ReadLine());
        Console.Write("Введіть опис журналу: ");
        description = Console.ReadLine();
        Console.Write("Введіть контактний телефон: ");
        phone = Console.ReadLine();
        Console.Write("Введіть email: ");
        email = Console.ReadLine();
    }
    public void DisplayData()
    {
        Console.WriteLine($"Назва журналу: {name}");
        Console.WriteLine($"Рік заснування: {yearFounded}");
        Console.WriteLine($"Опис журналу: {description}");
        Console.WriteLine($"Контактний телефон: {phone}");
        Console.WriteLine($"Email: {email}");
    }
}
class Store
{
    private string name;
    private string address;
    private string profileDescription;
    private string phone;
    private string email;
    public void InputData()
    {
        Console.Write("Введіть назву магазину: ");
        name = Console.ReadLine();
        Console.Write("Введіть адресу магазину: ");
        address = Console.ReadLine();
        Console.Write("Введіть опис профілю магазину: ");
        profileDescription = Console.ReadLine();
        Console.Write("Введіть контактний телефон: ");
        phone = Console.ReadLine();
        Console.Write("Введіть email: ");
        email = Console.ReadLine();
    }
    public void DisplayData()
    {
        Console.WriteLine($"Назва магазину: {name}");
        Console.WriteLine($"Адреса магазину: {address}");
        Console.WriteLine($"Опис профілю: {profileDescription}");
        Console.WriteLine($"Контактний телефон: {phone}");
        Console.WriteLine($"Email: {email}");
    }
}
