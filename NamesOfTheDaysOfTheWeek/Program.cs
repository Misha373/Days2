Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Названи днів тижня:");
Console.WriteLine($"1-Понеділок \n 2-Вівторок \n 3-Cереда \n 4-Четвер \n 5-П'ятниця \n 6-Субота \n 7-Неділя");
Console.WriteLine("Вибери день тижня:");
int DateName = Convert.ToInt32(Console.ReadLine());
switch (DateName)
{
    case 1:
        Console.WriteLine("Сьогодні - Понеділок");
        break;
     case 2:
        Console.WriteLine("Сьогодні - Вівторок");
        break;
    case 3:
        Console.WriteLine("Сьогодні - Середа");
        break;
    case 4:
        Console.WriteLine("Сьогодні - Четвер");
        break;
    case 5:
        Console.WriteLine("Сьогодні - П'ятниця");
        break;
    case 6:
        Console.WriteLine("Сьогодні - Субота");
        break;
    case 7:
        Console.WriteLine("Сьогодні - Неділя");
        break;
}
Console.ReadKey();
