Console.WriteLine("Введите натуральное число c");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число x");
double x = double.Parse(Console.ReadLine());
double rezultat = 1;
if (c <= 0)
{
    Console.WriteLine("Число n неудовлетворяет требованиям, введите другое");
}
else
{
    for(double k = 1; k<c; k ++)
    {
        rezultat = ((k + 1)/(k + 2)) * Math.Pow(x, k);
    }
}
Console.WriteLine(Math.Round(rezultat, 2));

Console.WriteLine("Введите число а, удовлетворяющее условию: 1 < a < 1.5");
double a = double.Parse(Console.ReadLine());
double i = 2;
double rezultatDwa = 1.5;
if (( a > 1)&(a < 1.5))
{
    while(rezultatDwa >= a)
    {
        Console.WriteLine(i);
        i = i +1;
        rezultatDwa = 1 + 1/i;
    }
}

Console.WriteLine("Введите первое натурально число");
int natfirst = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе натурально число");
int natsecond = int.Parse(Console.ReadLine());
while (natfirst != natsecond)
{
    if (natfirst > natsecond)
    {
        natfirst = natfirst - natsecond;
    }
    else
    {
        natsecond = natsecond - natfirst;
    }
}
Console.WriteLine("Наибольший общий делитель равен " + natfirst);

Console.WriteLine("Введите количество работников");
int kolvorab = int.Parse(Console.ReadLine());
double[,] zpinmoth1 = new double[kolvorab, 2]; 
double[,] zpinmoth2 = new double[kolvorab, 2];
double[,] zpinmoth3 = new double[kolvorab, 2];
int j = 0;
Random rand = new Random();
while (j<kolvorab)
{
    double k = j;
    zpinmoth1[j,0] = rand.Next(1,1000);
    zpinmoth1[j,1] = k + 1;
    zpinmoth2[j,0] = rand.Next(1,1000);
    zpinmoth2[j,1] = k + 1;
    zpinmoth3[j,0] = rand.Next(1,1000);
    zpinmoth3[j,1] = k + 1;
    double maxzprab = 0;
    if(zpinmoth1[j,0]> maxzprab)
    {
        maxzprab = zpinmoth1[j,0];
        if(zpinmoth2[j,0]>maxzprab)
        {
            maxzprab = zpinmoth2[j,0];
            if(zpinmoth3[j,0]>maxzprab)
            {
                maxzprab = zpinmoth3[j,0];
            }
        }
        else
        {
            if(zpinmoth3[j,0]>maxzprab)
            {
                maxzprab = zpinmoth3[j,0];
            }
        }
    }
    Console.WriteLine("Максимальная зарпалата сотрудника номер " + (j+1) + " за три месяца составила " + maxzprab);
    j ++;
}
static double[,] MaxMontZp(double[,] array, int kolvorab)
{
    double[,] maxmonth = new double[1,2];
    for(int i = 0; i<kolvorab; i++)
    {
        if(array[i,0]>maxmonth[0,0])
        {
            maxmonth[0,0] = array[i,0];
            maxmonth[0,1] = array[i,1];
        }

    }
    return maxmonth;
}
Console.WriteLine("Самая высока зарплата в первом месяце составила " + MaxMontZp(zpinmoth1, kolvorab)[0,0] + " у работника номер " + MaxMontZp(zpinmoth1, kolvorab)[0,1]);
Console.WriteLine("Самая высока зарплата во втором месяце составила " + MaxMontZp(zpinmoth2, kolvorab)[0,0] + " у работника номер " + MaxMontZp(zpinmoth2, kolvorab)[0,1]);
Console.WriteLine("Самая высока зарплата в третьем месяце составила " + MaxMontZp(zpinmoth3, kolvorab)[0,0] + " у работника номер " + MaxMontZp(zpinmoth3, kolvorab)[0,1]);