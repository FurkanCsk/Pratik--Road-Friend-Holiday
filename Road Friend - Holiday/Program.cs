string input;  // Kullanıcıdan alacağımız lokasyon değişkeni
string planagain; // Tekrar plan yapmak isteyip istenmediğine göre döngüye geri dönecek değişken
string travelinput; // Kullanıcıdan alacağımız ulaşım değişkeni
int person = 0;  // kişi sayısı için kullanacağımız değişken
int travelcost = 0; // ulaşım fiyatları için kullanacağımız değişken
int price = 0; // paket fiyatları için kullanacağımız değişken
bool exit = false;// do-while döngüsünden çıkmak için kullanacağımız bool değişken
bool exit2 = false; // 2.döngüden çıkmak için kullanacağımız bool değişken

do {

    Console.WriteLine("3 adet lokasyon görüntülenmektedir.");
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
    Console.WriteLine("Lütfen çıkmak için çıkış yazınız.");

    input = Console.ReadLine().ToLower();

    if (input == "çıkış")            // Bu alanda çıkış yazıldığı anda programdan çıkış yapılacak
    {
        exit = true;
        continue;
    }
    else if (input != "bodrum" && input != "marmaris" && input != "çeşme")   // Bu alanda istenilen paketler dışında bir yazı yazıldığında paketler ekrana tekrar gelecek.
    {
        Console.WriteLine("Yanlış bir giriş yaptınız. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
        continue;
    }

    Console.WriteLine("Kaç kişilik bir tatil planlamak istiyorsunuz ? ");  // Kişi sayısını aldığımız satır
 
    person = Convert.ToInt32(Console.ReadLine());
    

    switch(input)  // paket seçimlerinin yapıldığı ve fiyatlarının price değişkenine saklandığı switch karar yapısı
    {
        case "bodrum":
            Console.WriteLine("Bodrum'u seçtiniz.");
            Console.WriteLine("Dilerseniz burada Bodrum Antik Tiyatrosu'nu gezebilirsiniz.");
            price = 4000;
            break;

        case "marmaris":
            Console.WriteLine("Marmaris'i seçtiniz.");
            Console.WriteLine("Dilerseniz burada Marmaris Arkeoloji Müzesi'ni gezebilirsiniz.");
            price = 3000;
            break;

        case "çeşme":
            Console.WriteLine("Çeşme'yi seçtiniz.");
            Console.WriteLine("Dilerseniz burada Alaçatı'yı gezebilirsiniz.");
            price = 5000;
            break;
    }
    do  // Ulaşım tercihi için yapılmış ikinci bir döngü
    {
        Console.WriteLine("Tatile hangi ulaşım yoluyla gitmek istersiniz ?");
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
        Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL )");
        Console.WriteLine("Lütfen yukarıdaki seçeneceklerden bir tanesin seçiniz. Girişi sayı olarak yapınız.");
        travelinput =(Console.ReadLine());

        if (travelinput != "1" && travelinput != "2") // İstenilen sayılar dışında bir işlem yapıldığında seçimler tekrar ekrana gelecek.
        {
            Console.WriteLine("Yanlış bir giriş yaptınız. Lütfen sadece ekranda olan sayılar ile işlem yapınız.");
            continue;
        }

        switch(travelinput) // Ulaşım ücretinin kişi sayısına göre hesaplanıp travelcost değişkeninde saklandığı kısım
        {
            case "1":
                travelcost = person * 1500;
                break;
            case "2":
                travelcost = person * 4000;
                break;
        }
        int totaltravelcost = price + travelcost;    // Burada toplam ücret hesaplanıyor ve kullanıcıya bildiriliyor

        Console.WriteLine($"Seçmiş olduğunuz {person} kişilik {input} tatil pakedi seçmiş olduğunuz ulaşım fiyatı dahil {totaltravelcost} TL'dir.");
        Console.WriteLine("Başka bir tatil planlamak istiyorsanız evet yazınız. İstemiyorsanız hayır yazarak programdan çıkabilirsiniz.");
        planagain = Console.ReadLine().ToLower();

        if(planagain == "hayır")  // Tekrar planlama istenip istenilmediği durum kontrol ediliyor ve duruma göre döngü sonlanıyor.
        {
            Console.WriteLine("İyi günler dileriz.");
            exit2 = true;
            exit = true;
        }
        else if(planagain == "evet")
        {
            exit2 = true;
        }

    } while (!exit2);
} while (!exit);
