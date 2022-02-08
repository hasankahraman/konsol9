// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1den başlayıp girilen sayıya kadar olan (sayı dahil) sayıların ortalamasını ekrana yazdırma
Console.WriteLine("Lütfen bir sayı giriniz: ");

int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac ++;
}

Console.WriteLine(toplam/sayi);
Console.ReadLine();


//a'dan z'ye kadar olan tüm harfleri ekrana yazdırma

char karakter = 'a';

while (karakter <= 'z')
{
    Console.Write(karakter + " ");
    karakter ++;
}
Console.ReadLine();


string[] arabalar = {"bmw", "ford", "nissan", "toyota"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
Console.ReadLine();