double sayi;

Console.Write("Bir Sayı Giriniz: ");

sayi = Convert.ToDouble(Console.ReadLine());

if (sayi %2 == 0)
{
    Console.WriteLine("Girdiğiniz Sayı Çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz Sayı Tektir");
}