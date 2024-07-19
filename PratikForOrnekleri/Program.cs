
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i+" Kendime inanıyorum. ben bu yazılımı işini hallederim!");
}

// 1 ile 20 arasındaki sayıları ekrana yazdırdık.
for(int i=1; i<21; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");
for (int i = 0;i<21; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//50 ile 150 arasındaki sayilari topladık.

int sayi = 0;
for (int i = 50; i <= 150; i++)
{
    sayi = sayi + i;
    Console.WriteLine("toplamları: " + sayi);
}

//tek çift sayilar yazdirildi.
for(int i = 1; i<=120; i++)
{
    if(i % 2 == 0)
        Console.WriteLine("Çift sayilar: " + i);
    if(i % 2 == 1)
        Console.WriteLine("tek sayilar: " + i);
}