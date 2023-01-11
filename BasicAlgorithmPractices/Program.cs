#region Üçgen Çizdirme
/* Konsolda üçgen çizdirme

int x, y;
for (x = 1; x <= 10; x++) // 1. For
{
    for (y = x; y < 10; y++) // 2. For
    {
        Console.Write(" ");
    }
    for (y = 1; y <= (2 * x - 1); y++) // 3. For
    {
        if (x == 10 || y == 1 || y == (2 * x - 1) || y == x)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
Console.ReadLine();

// 2. for da x 1 iken y 1 oluyor ve 10 a kadar boşluk bırakıyor. Ardında x arttıkça boşluk bırakmalar 1 er 1 er azalıyor.
// 3. for da x 10 olduğu yerde taban kenarı çizdiriyor. 2. for da boşluk bıraktıktan sonra y yi 3 for da 1 iken bir sol kenarı yazıyor. (2 * x - 1) iken ise sağ kenarı çiziyor. y = x iken ise dikmeyi çizdiriyor.
*/
#endregion

#region Kare Çizdirme

/* Konsolda kare çizdirme

int number = 7;
for (int i = 0; i < number; i++) // 1. for
{
    if (i == 0 || i == 6)
    {
        for (int j = 0; j < number; j++) // 2. for
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    if (i >= 1 && i <= 5)
    {
        for (int j = 0; j < number; j++) // 3. for
        {
            if (j == 0 || j == 6)
            {
                Console.Write("* ");
            }
            else if (j >= 1 && j <= 5)
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}

int d = 2;
for (int i = 1; i <= number - 2; i++)
{
    Console.SetCursorPosition(d, i);
    Console.Write("*");
    d += 2;
}

int a = 10;
for (int i = 1; i <= number - 2; i++)
{
    Console.SetCursorPosition(a, i);
    Console.Write("*");
    a -= 2;
}


Console.WriteLine();
Console.ReadLine();

*/

#endregion

#region Dikdörtgen Çizdirme

/*

int number = 7;

for (int i = 0; i < number; i++) // 1. for
{
    if (i == 0 || i == 6)
    {
        for (int j = 0; j < number; j++) // 2. for
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    if (i >= 1 && i <= 5)
    {
        for (int j = 0; j < number; j++) // 3. for
        {
            if (j == 0 || j == 6)
            {
                Console.Write("*");
            }
            else if (j >= 1 && j <= 5)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}

// 1. for a giriyor eğer i 0 veya 6 ise ikinci for a girip j 0 dan number a kadar yan yana * yazdırıyor. diğer durumlarda Console.WriteLine çalışıp bir alt satıra geçiyor. Bu sayede 0 iken üst kenar 6 iken alt kenar çizilmiş oluyor.

// i nin 1 ve 5 aralığında olduğu durumlarda ise 3. for içine girip j 0 veya 6 iken * yazdırıyor, diğer durumlarda ise boşluk bırakıyor.

*/

#endregion

#region Çember Çizdirme

/*

double radius;
double thickness = 0.2;
// ConsoleColor BorderColor = ConsoleColor.Yellow;
//  Console.ForegroundColor = BorderColor;
char symbol = '*';

do
{
    Console.Write("Enter radius:::: ");
    if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
    {
        Console.WriteLine("radius have to be positive number");
    }
}
while (radius <= 0);

Console.WriteLine();
double rIn = radius - thickness, rOut = radius + thickness;

for (double y = radius; y >= -radius; --y)
{
    for (double x = -radius; x < rOut; x += 0.5)
    {
        double value = x * x + y * y;
        if (value >= rIn * rIn && value <= rOut * rOut)
        {
            Console.Write(symbol);
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
for (int i = 1; i < radius * 2 + 2; i++)
{
    //Console.SetCursorPosition(i, Convert.ToInt32( radius)+2);
    Console.SetCursorPosition(Convert.ToInt32(radius * 2), i + 1);
    Console.WriteLine(symbol);
}
Console.ReadKey();

*/

#endregion

#region Asal Sayı
/*
class Program
{
    public static bool asalmi(int sayi)
    {
        bool durum = false;

        int kontrol = 0;

        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0) 
            {
                kontrol = 1;
                break;
            }
        }
        if (kontrol == 1)
        {
            durum = false;
        }
        else
        {
            durum = true;
        }

        return durum;
    }
    static void Main(string[] args)
    {
        int sayac = 0;
        Console.Write("Sayıyı Girin : ");
        int s = Convert.ToInt32(Console.ReadLine());

        if (asalmi(s))
        {
            Console.WriteLine("{0} sayısı Asal", s);
        }
        else
        {
            Console.WriteLine("{0} sayısı asal değil", s);
        }

        Console.WriteLine("===========================");
        Console.WriteLine("Sonraki 5 Asal Sayı");
        Console.WriteLine("===========================");

        while (true)
        {
            s++;
            if (asalmi(s) == true)
            {
                Console.WriteLine("{0} sayısı asal", s);
                sayac++;
                if (sayac == 5)
                {
                    break;
                }
            }
        }
        Console.ReadKey();
    }
}

*/

#endregion

#region Metnin Kaç Harften Oluştuğunu Bul

string cumle;
Console.Write("Cumleyi Girin : ");
cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(' ');
Console.WriteLine(kelimeler.Length);

#endregion