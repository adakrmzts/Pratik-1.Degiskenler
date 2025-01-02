
//Öncelikle değişkenlerimi belirledim.

string TcKmlikNo, Isim, SoyIsim;
int Yas;
double BirinciUrun, IkinciUrun, ToplamHarcama, PatikaPuan, TelNo;

Console.WriteLine("TC Kimlik Numaranızı Giriniz.");
TcKmlikNo = Console.ReadLine();

Console.WriteLine("Adınızı Giriniz.");
Isim = Console.ReadLine();

Console.WriteLine("Soyadını Giriniz.");
SoyIsim = Console.ReadLine();

 //Telefon numarası uzun bir değer olduğu için ve örnekte başında sıfır olmadığı için int64 ile değişken atadım.

Console.WriteLine("Telefon Numarası Giriniz.");
TelNo = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Kaç Yaşındasınız?");
Yas = Convert.ToInt32(Console.ReadLine());

//Ürün fiyatları küsüratlı olabileceği için double tercih ettim.

Console.WriteLine("İlk aldığınız ürün fiyatı: ");
BirinciUrun  = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci aldığınız ürün fiyatı: ");
IkinciUrun    = Convert.ToDouble(Console.ReadLine());

ToplamHarcama = BirinciUrun +  IkinciUrun;
PatikaPuan = ToplamHarcama * 0.1;

Console.WriteLine(TcKmlikNo + "  TC Kimlik Numaralı   " + Isim + " " + SoyIsim + "  İsimli Kişi İçin Kayıt Oluşturulmuştur.");
Console.WriteLine(TelNo + "  Numaraya bildirim mesajı gönderilmiştir.");
Console.WriteLine(ToplamHarcama + "  toplam harcama karşılığı kazanılan 10% patika puan miktarı ->   " + PatikaPuan + " TL'dir.  ");


