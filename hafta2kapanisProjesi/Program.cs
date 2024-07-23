
// // 1 -
// System.Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

// System.Console.WriteLine("---------------------------");
// // 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
// int tamSayi = 5;
// string metinsel = "burak";
// System.Console.WriteLine("Tam sayi verisi: " + tamSayi);
// System.Console.WriteLine("Metin verisi: " + metinsel);

// System.Console.WriteLine("---------------------------");
// // 3- Rastgele bir sayı üretip , ekrana yazdırınız.

// Random rnd = new Random();
// int randomNumber = rnd.Next(0, 102);
// System.Console.WriteLine("Rastgele Sayi: " + randomNumber);
// //  4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
// System.Console.WriteLine("---------------------------");
// int bolumdenKalan = 0;
// bolumdenKalan = randomNumber % 3;
// System.Console.WriteLine("Rastgele sayinin 3'e bolumunden kalan: " + bolumdenKalan);
// System.Console.WriteLine("---------------------------");

// // 5- Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
// Console.WriteLine("Lutfen yasinizi giriniz: ");
// int yas = Convert.ToInt16(Console.ReadLine());
// if(yas > 18)
// {
//     System.Console.WriteLine(" + ");
// }
// else
// {
//     System.Console.WriteLine(" - ");
// }
// System.Console.WriteLine("---------------------------");
// 6-  Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
// for(int i = 0; i < 10; i++)
// {
//     System.Console.WriteLine("sen vodafone gibi anı yasarken, ben Turkcell gibi seni her yerde cekemem. ");
// }

// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
// using System.Runtime.Intrinsics.Arm;

// System.Console.WriteLine("Birinci degeri girin: ");
// string isim1 = System.Console.ReadLine();

// System.Console.WriteLine("İkinci degeri girin: ");
// string isim2 = Console.ReadLine();
// isim1 = "Gülse Birsel";
// isim2 = "Demet Evgar";

// degerleriDegistir(ref isim1, ref isim2);

// System.Console.WriteLine("Yer degistirdikten sonra: ");
// System.Console.WriteLine("Birinci isim: " + isim1);
// System.Console.WriteLine("İkinci isim: " + isim2);

// static void degerleriDegistir(ref string isim1, ref string isim2)
// {
//     string temp = isim1;
//     isim1 = isim2;
//     isim2 = temp;
// }

// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

// void BenDegerDondurmem()
// {
//     System.Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
// }

// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
// System.Console.WriteLine("Lutfen iki sayi giriniz: ");
// int sayi1 = int.Parse(Console.ReadLine());
// int sayi2 = int.Parse(Console.ReadLine());
// int sum = toplam(sayi1, sayi2);
// System.Console.WriteLine("Girilen sayilarin toplami: " + sum);
// static int toplam(int sayi1, int sayi2)
// { 

//   return sayi1 + sayi2;

// }

// 10- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
// using System.Reflection.Metadata;

// System.Console.WriteLine("Lutfen True yada False degerini girin: ");
// bool userInp = bool.Parse(Console.ReadLine());

// string result = GetStringFromBool(userInp);
// System.Console.WriteLine("Donen string degeri: " + result);

// static string GetStringFromBool(bool value)
// {
//     if(value)
//     {
//         return "Kullanci true degerini girdi";
//     }
//     else
//     {
//         return "Kullanici false degerini girdi";
//     }
// }
// Console.WriteLine("Lutfen ilk kisinin yasini giriniz: ");
// int yas1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Lutfen İkinci kisinin yasini giriniz: ");
// int yas2 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Lutfen Ucuncu kisinin yasini giriniz: ");
// int yas3 = int.Parse(Console.ReadLine());
// EnYasli(yas1, yas2,yas3);

// int EnYasli(int yas1, int yas2, int yas3)
// {
//     if(yas1 > yas2 && yas1 > yas3)
//     {
// System.Console.WriteLine("Yas 1 en buyuktur!");
//     }
//     else if(yas2 > yas1 && yas2 > yas3)
//     {
//         System.Console.WriteLine("Yas2 En buyuktur!");
//     }
//     else if(yas3 > yas1 && yas3 > yas2)
//     {
//         System.Console.WriteLine("Yas 3 en buyuktur!");
//     }
//     else
//     {
//         System.Console.WriteLine("Yanlis veya butun degerleri esit girdiniz lutfen yeni bir deger girdiniz. ");
//     }
//     return 0;
// }
// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
// List<int> numbers = new List<int>();
// string input;
// System.Console.WriteLine("Sayilari girin. Bitirmek icin 'q' tusuna basin. ");
// while(true)
// {
//     input = Console.ReadLine();
//     if (input.ToLower() == "q")
//     {
//         break;
//     }
//     if(int.TryParse(input, out int number))
//     {
//       numbers.Add(number);
//     }
//     else
//     {
//         System.Console.WriteLine("Gecersiz giris.Lutfen bir sayi girin veya 'q' tusuna basarak bitirin.");
//     }
// }
// if(numbers.Count > 0)
// {
//     int largestNumber = SinirsizSayiAl(numbers);
//     System.Console.WriteLine("Girilen en buyuk sayi: "+ largestNumber);
// }
// else
// {
//     System.Console.WriteLine("Hic bir sayi girilmedi.");
// }
// int SinirsizSayiAl(List<int> numbers)
// {
//     int largest = numbers[0];
//     foreach(int number in numbers)
//     {
//         if(number > largest)
//         {
//             largest = number;
//         }
//     }

// return largest;
// }

// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

// Console.WriteLine("Birinci ismi giriniz: ");
// string isim1 = Console.ReadLine();
// Console.WriteLine("İkinci ismi giriniz: ");
// string isim2 = Console.ReadLine();
// YerDegistir(isim2, isim1);

// void YerDegistir(string isim1, string isim2)
// {
//     Console.WriteLine("Birinci İsim: " + isim1);
//     Console.WriteLine("İkinci İsim" + isim2);
// }

// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
// Console.WriteLine("Lutfen bir sayi giriniz: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool result = EvenOrOdd(number);
// System.Console.WriteLine("Sayi : " + result);

// bool EvenOrOdd(int number)
// {
// while(true)
// {
//         return number % 2 == 0;
//         break;
// }
// }
// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
// System.Console.WriteLine("Lutfen Hız bilgisi giriniz: ");
// int hiz = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Lutfen Zaman bilgisini giriniz: ");
// int zaman = Convert.ToInt32(Console.ReadLine());

// int mesafe = GidilenYol(hiz, zaman);
// System.Console.WriteLine("Gidilen yol: " + mesafe);

// int GidilenYol(int hiz, int zaman)
// {
   
//   return hiz * zaman;
// }

// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

// double radius = 12.4;
// double area = YariCapHesapla(radius);
// System.Console.WriteLine("Area: " + area);
// double YariCapHesapla(double radius)
// {

//     return Math.PI * Math.Pow(radius, 2);
// } 

// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

// string cumle = "Zaman Bir GeRi SayIm";

// string buyukHarf = cumle.ToUpper();
// string kucukHarf = cumle.ToLower();

// System.Console.WriteLine("Cumlenin kucuk harfle yazilmis hali:\n" + kucukHarf);
// System.Console.WriteLine("Cumlenin buyuk harfle  yazilmis hali:\n" + buyukHarf);

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

// string metin = " Selamlar";
// System.Console.WriteLine("Bosluklu hali: "+ metin);
// metin = metin.Trim();
// System.Console.WriteLine("Bosluklari silinmis hali:"+ metin);