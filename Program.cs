using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*             
             Hüseyin Hürkan KARAMAN
             1030516163 // 1. Öğretim A Grubu 
             Bilgisayar Mühendisliği // Erciyes Üniversitesi
             Dosya Organizasyon Teknikleri 1. Ödev
             Başlama Tarihi 05.10.2017
             Bitirme Tarihi 08.10.2017    
             Yeniden gözden geçirilme 7.11.2017
             */
            Stopwatch sw = new Stopwatch();//Geçen zamanı hesaplamak için kullandığım sınıf
            Stopwatch sw2 = new Stopwatch(); //Genel stopwatch
            sw.Start();
            sw2.Start();
            Program a = new Program();
            StringBuilder sb = new StringBuilder();//String Builder ile okunan attributeları text dosyasına yazdım.
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            StringBuilder sb5 = new StringBuilder();
            /*sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");*/
            /*sb2.AppendLine("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb2.AppendLine("\n");*/
            /*sb3.AppendLine("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb3.AppendLine("\n");
            sb4.AppendLine("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb4.AppendLine("\n");
            sb5.AppendLine("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb5.AppendLine("\n"); */
            List<student> ogrenciler = new List<student>();//bütün öğrencilerin olduğu liste
            List<student> birinci = new List<student>();//birinci sınıf öğrencilerinin olduğu liste
            List<student> ikinci = new List<student>();//ikinci sınıf öğrencilerinin olduğu liste
            List<student> uc = new List<student>();//üçüncü sınıf öğrencilerinin olduğu liste
            List<student> dort = new List<student>();//dördüncü sınıf öğrencilerinin olduğu liste
            List<String> erkekler = new List<string>() {
                "Acun",
                "Afşar",
                "Ağca",
                "Akın",
                "Alp",
                "Ahmet",
                "Arda",
                "Ata",
                "Ayhan",
                "Berk",
                "Berkan",
                "Berkay",
                "Bora",
                "Can",
                "Caner",
                "Ceyhun",
                "Çetin",
                "Demir",
                "Doğan",
                "Ediz",
                "Efe",
                "Emre",
                "Engin",
                "Erol",
                "Ersan",
                "Ege",
                "Eser",
                "Fatih",
                "Ferit",
                "Fırat",
                "Gökhan",
                "Hakan",
                "Hasan",
                "Hüseyin",
                "İlker",
                "Koray",
                "Kubilay",
                "Levent",
                "Onur"
            };//erkek isimlerinin olduğu liste
            List<String> kizlar = new List<string>() {
                "Alev",
                "Aleyna",
                "Arzu",
                "Aslı",
                "Ayla",
                "Aylin",
                "Ayşe",
                "Bahar",
                "Başak",
                "Beliz",
                "Berna",
                "Betül",
                "Buse",
                "Büşra",
                "Ceylan",
                "Ceyda",
                "Ceren",
                "Çiğdem",
                "Didem",
                "Doğa",
                "Duygu",
                "Elif",
                "Elife",
                "Emel",
                "Emine",
                "Esma",
                "Esra",
                "Ezgi",
                "Fatma",
                "Fatmagül",
                "Feyza",
                "Filiz",
                "Fulya",
                "Funda",
                "Gamze",
                "Gizem",
                "Gül",
                "Gülay",
                "Gülcan",
                "Hasibe",
                "Havva",
                "Hülya"
            };//kız isimlerinin olduğu liste
            List<String> cinsiyet = new List<string>() {
            "erkek","kız"};//cinsiyet bilgisinin olduğu liste buna bağlı olarak isim seçiliyor. Erkek ise Erkekler listesinden, cinsiyet kız ise kızlar listesinden.
            List<String> soyad = new List<string>() {
                "Temel",
                "Koç",
                "Korkmaz",
                "Karaman",
                "Mercan",
                "Şahin",
                "Baysal",
                "Azak",
                "Eren",
                "Gözcü",
                "Çetin",
                "Bulut",
                "Ayvaz",
                "Çelik",
                "Yüce",
                "Acar"
            };//Soyadların bulunduğu liste
            List<int> sinif = new List<int>() {
                1,2,3,4
            };//Sınıfların bulunduğu liste sadece 1,2,3,4 gibi.
            List<int> ogrNo = new List<int>();//ogrNo larını atamak için kullandığım liste. Her bir öğrencinin kendine ait bir ogrNo su bulunuyor. 

            for (int i = 1; i <= 10000; i++)
            {
                ogrNo.Add(i);//İlk olarak ogr_No larını bir listeye attım.
            }

            for (int i = 0; i < 10000; i++)
            {//Her şeyin başı bütün öğrencilerin bilgilerinin doldurulduğu for döngüsü.

                student ogr = new student();//student class'ından nesne tanımladım.

                int ixdex = GetRandomNumber2(0, erkekler.Count);//erkekler listesinden rastgele bir index seçiliyor.
                int index = GetRandomNumber2(0, cinsiyet.Count);//cinsiyet listesinden rastgele bir index seçiliyor.                

                int ixdex2 = GetRandomNumber2(0, kizlar.Count);//kizlar listesinden rastgele bir index seçiliyor.
                ogr.Cinsiyet = cinsiyet[index];//Rastgele index ile cinsiyet seçimi yapılıyor. İlk başta cinsiyet.


                int soyindex = GetRandomNumber2(0, soyad.Count);//Sonra rastgele index ile bir soyadı seçiliyor.
                int ogrNoindex = GetRandomNumber2(0, ogrNo.Count);//Rastgele bir ogrNo su seçiliyor.



                if (ogr.Cinsiyet == "erkek")
                { //isim

                    ogr.Isim = erkekler[ixdex];//Cinsiyet erkekse erkek isimlerinin olduğu listeden rastgele bir isim seçiliyor.

                }
                else
                {

                    ogr.Isim = kizlar[ixdex2];//Cinsiyet kızsa kız isimlerinin olduğu listeden bir isim seçiliyor.
                }
                ogr.Soyad = soyad[soyindex];//Soyad
                ogr.Ogr_no = ogrNo[ogrNoindex];//Ogrenci_No
                ogrNo.RemoveAt(ogrNoindex);// Ogrenci Nosu atandıktan sonra ilk başta yer alan listeden siliniyor ki unique olsun.Bir başka öğrenci aynı No'yu almasın.

                ogr.Gano = Math.Round(GetRandomNumber(1, 4), 3);//Float olsun noktadan sonra 3 rakam gözüksün


                ogrenciler.Add(ogr);// BUTUN OGRENCILER BIR LİSTEYE EKLENİYOR        


            }

            for (int j = 0; j < 10000; j++)
            {

                int sinifindex = GetRandomNumber2(0, sinif.Count);//Random bir sınıf indexi seçiliyor.
                if (sinif[sinifindex] == 1 && birinci.Count < 2500)//Seçilen sınıf 1 ve 1. Sınıfların mevcut 2500'den düşükse o zaman birinci sınıflara ekleme yapıyorum.
                {
                    ogrenciler[j].Sınıf = sinif[sinifindex]; // j hangi değerdeyse o öğrencinin sınıf alanına random bir şekilde atama yapılıyor.
                    birinci.Add(ogrenciler[j]); // Yukarıda sınıfı 1 olarak atanan öğrenci birinci sınıflara ekleniyor.
                    sb2.AppendLine(ogrenciler[j].Ogr_no + ";" + ogrenciler[j].Isim + ";" + ogrenciler[j].Soyad + ";" + ogrenciler[j].Gano + ";" + ogrenciler[j].Bolum_sira + ";" + ogrenciler[j].Sinif_sira + ";" + ogrenciler[j].Cinsiyet + ";" + ogrenciler[j].Sınıf);

                    String butunogrenciler2 = sb2.ToString();//String builder string e çevrilip butunöğrenciler stringine atanıyor.
                    System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\birinci.txt", butunogrenciler2);
                }
                else if (sinif[sinifindex] == 2 && ikinci.Count < 2500) // 2. Sınıf çıkmış ve ikinci sınıflarda yer varsa öğrencinin sınıf alanı 2 oluyor.
                {
                    ogrenciler[j].Sınıf = sinif[sinifindex];
                    ikinci.Add(ogrenciler[j]); //2.Sınıflara öğrenci ekleniyor.
                    sb3.AppendLine(ogrenciler[j].Ogr_no + ";" + ogrenciler[j].Isim + ";" + ogrenciler[j].Soyad + ";" + ogrenciler[j].Gano + ";" + ogrenciler[j].Bolum_sira + ";" + ogrenciler[j].Sinif_sira + ";" + ogrenciler[j].Cinsiyet + ";" + ogrenciler[j].Sınıf);

                    String butunogrenciler3 = sb3.ToString();//String builder string e çevrilip butunöğrenciler stringine atanıyor.
                    System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\ikinci.txt", butunogrenciler3);
                }
                else if (sinif[sinifindex] == 3 && uc.Count < 2500)
                {
                    ogrenciler[j].Sınıf = sinif[sinifindex];
                    uc.Add(ogrenciler[j]);
                    sb4.AppendLine(ogrenciler[j].Ogr_no + ";" + ogrenciler[j].Isim + ";" + ogrenciler[j].Soyad + ";" + ogrenciler[j].Gano + ";" + ogrenciler[j].Bolum_sira + ";" + ogrenciler[j].Sinif_sira + ";" + ogrenciler[j].Cinsiyet + ";" + ogrenciler[j].Sınıf);

                    String butunogrenciler4 = sb4.ToString();//String builder string e çevrilip butunöğrenciler stringine atanıyor.
                    System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\ucuncu.txt", butunogrenciler4);
                }
                else if (sinif[sinifindex] == 4 && dort.Count < 2500)
                {
                    ogrenciler[j].Sınıf = sinif[sinifindex];
                    dort.Add(ogrenciler[j]);
                    sb5.AppendLine(ogrenciler[j].Ogr_no + ";" + ogrenciler[j].Isim + ";" + ogrenciler[j].Soyad + ";" + ogrenciler[j].Gano + ";" + ogrenciler[j].Bolum_sira + ";" + ogrenciler[j].Sinif_sira + ";" + ogrenciler[j].Cinsiyet + ";" + ogrenciler[j].Sınıf);

                    String butunogrenciler5 = sb5.ToString();//String builder string e çevrilip butunöğrenciler stringine atanıyor.
                    System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\dorduncu.txt", butunogrenciler5);
                }
                else
                {//Eğer yukarıda bir sınıf dolmuşsa buraya gelecek bu durumda mevcut 2500'den az olacak sonuçta 10.000 atanması tam olmayacak
                    //bunu önlemek için j index inden düşmemiz gerekiyor ki sonuçta 10.000 öğrencinin hepsi her bir sınıfta 2500 kişi olarak atansın.
                    j--;
                }

            }//Sınıf yerleştirmesi yapılıyor her bir sınıf 2500 kişi olacak şekilde.*/

            //Once bir dosyaya yazalım
            Console.WriteLine("LOAD COMPLETED!");
            Console.WriteLine("All students writing in a text file...");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                sb.AppendLine(ogrenciler[i].Ogr_no + ";" + ogrenciler[i].Isim + ";" + ogrenciler[i].Soyad + ";" + ogrenciler[i].Gano + ";" + ogrenciler[i].Bolum_sira + ";" + ogrenciler[i].Sinif_sira + ";" + ogrenciler[i].Cinsiyet + ";" + ogrenciler[i].Sınıf);
            }//Burada yer alan for döngüsünde ilk istenen operasyon gerçekleştiriliyor. Daha Sınıf sırası ve bölüm sırası hesaplanmadı.Bundan dolayı o bilgiler 0 olarak gözüküyor.

            String butunogrenciler = sb.ToString();//String builder string e çevrilip butunöğrenciler stringine atanıyor.
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\first.txt", butunogrenciler);//first.txt adlı text dosyasına kayıt yapılıyor.
            sw.Stop();//Stopwatch durduruluyor.
            string ExecutionTimeTaken = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("1. Operation Completed!" + " Sure: " + ExecutionTimeTaken);//1. operasyon tamamlandı şeklinde bir bilgi mesajı konsolda yazılıyor ayrıca geçen zamanda dakika,saniye ve ms cinsinden gösteriliyor.
            sw.Reset();//stopwatch resetleniyor ki diğer operasyonlar ne kadar sürede gerçekleştirikdiğini görelim.
            sw.Start();//stopwatch tekrar başlatılıyor.

            //SINIF SIRALAMA
            // a.Sinifsirala(birinci, ogrenciler);//Sınıf sıralaması için her bir sınıf bütün öğrencilerin bulunduğu bir listeyle beraber Sinifsirala metoduna gönderiliyor.
            a.Sinifsirala2("birinci");//GANO ya göre sınıf sıralaması -- V2--
            a.Sinifsirala2("ikinci");
            a.Sinifsirala2("ucuncu");
            a.Sinifsirala2("dorduncu");
            sw.Stop();
            string ExecutionTimeTaken7 = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("Sinif Siralamasi Completed!" + " Sure: " + ExecutionTimeTaken7);
            sw.Start();


            //BOLUM SIRALAMA
            //a.Bolumsirala(ogrenciler, birinci, ikinci, uc, dort);//Bolum sıralaması için bütün öğrencilerin olduğu ogrenciler listesiyle beraber bütün sınıf listeleri de bolum sırala metoduna gönderiliyor.
            a.Bolumsirala2("first");



            sw.Stop();
            string ExecutionTimeTaken2 = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);

            Console.WriteLine("Bolum Siralamasi Operation Completed!" + " Sure: " + ExecutionTimeTaken2); //2. Operasyon tamamlandı ve geçtiği süre ekrana yansıtılıyor.
            //sw.Restart();//stopwatch yeniden başlatılıyor.

            //Bölüm sırasına göre bütün öğrencilerin sıralı listesi
            // a.Bolumegore(ogrenciler);// Bolume gore fonksiyonunda bütün öğrencilerin olduğu ogrenciler listesi metoda gonderiliyor. Burada liste bolum sırasına göre artacak şekilde yeniden düzenlenip bolumegore.txt olarak kaydediliyor.
            /*sw.Stop();//stopwatch durduruluyor.
            string ExecutionTimeTaken3 = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("3. Operation Completed!" + " Sure: " + ExecutionTimeTaken3); //3.operasyon tamamlandı ve ne kadar sürede tamamlandığı konsola yazdırılıyor.*/
            sw.Restart(); // stopwatch tekrar başlatılıyor. 
            //Cinsiyete göre ayrı iki liste
            a.Cinsiyetegore2("first");
            //a.Cinsiyetegore(ogrenciler); // Burada Cinsiyetegore fonksiyonuna bütün öğrencilerin olduğu ogrenciler listesi gönderiliyor bu fonksiyonda erkekleri erkekler adlı bir liste, kızları ise kızlar olarak ayrı bir listeye atıyor.Bunu yaparken lınq sayesinde gelen where,orderby vb. komutlar kullandım. Sıralama da yine GANO ya göre yapılıyor.
            sw.Stop();
            string ExecutionTimeTaken4 = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("4. Operation Completed!" + " Sure: " + ExecutionTimeTaken4);// 4. Operasyon tamamlandı mesajı ve ne kadar sürede tamamlandığı konsola yazdırılıyor.
            sw.Restart(); //stopwatch tekrar başlatılıyor.
            //Öğrenci noya göre sıralı liste
            //a.OgrenciNoyaGore(ogrenciler);// OgrenciNoyaGore fonksiyonuna bütün öğrencilerin bulunduğu ogrenciler listesi gönderiliyor. Bu fonksiyonda liste ogrenci numarasına göre 1 den başlayacak şekilde artarak son öğrenci ye kadar sıralanıyor ve ogrNo_gore.txt olarak kaydediliyor.
            a.OgrenciNoyaGore2("first");
            sw.Stop();//stopwatch durduruluyor.
            sw2.Stop();//Genel stopwatch durduruluyor.
            string ExecutionTimeTaken5 = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            string ExecutionTimeTaken6 = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw2.Elapsed.Minutes, sw2.Elapsed.Seconds, sw2.Elapsed.TotalMilliseconds);
            Console.WriteLine("5. Operation(OgrenciNOyaGore) Completed!" + " Sure: " + ExecutionTimeTaken5);// 5.Operasyon tamamlandı ve ne kadar sürede tamamlandığı konsola yazdırılıyor. Dakika, saniye ve ms cinsinden.
            Console.Write(" Sure: " + ExecutionTimeTaken6 + "\n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            sw.Reset();//stopwatch resetleniyor.
            sw2.Reset();//Genel stopwatch resetleniyor.

        }



        private static readonly Random getrandom = new Random();//çok fazla tekrar oluyor bunun olmaması için private static readonly olarak tanımlandı.
        private static readonly object syncLock = new object();
        public static double GetRandomNumber(double min, double max)//GANO için random function burası böyle oldu yoksa çok fazla tekrar ediyor
        {
            lock (syncLock)
            { // synchronize
                //return getrandom.Next(min, max);
                return getrandom.NextDouble() * (max - min) + min;
            }
        }

        public static int GetRandomNumber2(int min, int max)//veri tekrarı olmaması için böyle yapıldı
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        public void Sinifsirala(List<student> sinif, List<student> hepsi)
        {

            sinif = sinif.OrderByDescending(s => s.Gano).ToList();
            //sinif.Reverse();
            for (int i = 0; i < sinif.Count; i++)
            {
                sinif[i].Sinif_sira = i + 1;
                hepsi.Find(s => s.Ogr_no == sinif[i].Ogr_no).Sinif_sira = i + 1;
            }
            // sinifyaz(sinif);
            /*
             for (int i = 0; i < sinif.Count; i++)
             {
                 sinif.Sort(delegate (student x, student y)
             {
                 return y.Gano.CompareTo(x.Gano);
             });
             }*/
        }
        private void Sinifsirala2(string v)
        {
            //OKUTUP OYLE ATALIM BEN BAŞKA YOL BİLMİYORUM VE INTERNETTE DE ÇOK FAZLA BİLGİ BULAMADIM     
            List<student> sinif = new List<student>();
            List<student> kontrol = new List<student>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + v + ".txt");
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\first.txt");
            StringBuilder sb6 = new StringBuilder();
            StringBuilder sb7 = new StringBuilder();

            


            for (int i = 0; i < lines.Length; i++)
            {
                /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.*/
                string line = lines[i];
                string[] fields = line.Split(';');
                //Console.WriteLine(Convert.ToInt32(fields[0]));
                student s = new student();
                s.Ogr_no = Convert.ToInt32(fields[0]);
                s.Isim = Convert.ToString(fields[1]);
                s.Soyad = Convert.ToString(fields[2]);
                s.Gano = Convert.ToDouble(fields[3]);
                s.Bolum_sira = Convert.ToInt32(fields[4]);
                s.Sinif_sira = Convert.ToInt32(fields[5]);
                s.Sınıf = Convert.ToInt32(fields[7]);
                s.Cinsiyet = Convert.ToString(fields[6]);
                sinif.Add(s);
                /* sinif = sinif.OrderByDescending(x => x.Gano).ToList();
                 sb6.Clear();
                 sb6.AppendLine(sinif[i].Ogr_no + ";" + sinif[i].Isim + ";" + sinif[i].Soyad + ";" + sinif[i].Gano + ";" + sinif[i].Bolum_sira + ";" + i + 1 + ";" + sinif[i].Cinsiyet + ";" + sinif[i].Sınıf);
                 sinif[i].Sinif_sira = i + 1;
                 hepsi.Find(a => a.Ogr_no == sinif[i].Ogr_no).Sinif_sira = i + 1;
                 String hyep = sb6.ToString();
                 System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + v + ".txt", hyep);*/
                /*for (int r = 0; r < sinif.Count; r++)
                    {
                        
                        sb6.AppendLine(sinif[r].Ogr_no + ";" + sinif[r].Isim + ";" + sinif[r].Soyad + ";" + sinif[r].Gano + ";" + sinif[r].Bolum_sira + ";" + r+1 + ";" + sinif[r].Cinsiyet + ";" + sinif[r].Sınıf);
                        sinif[r].Sinif_sira = r + 1;
                        hepsi.Find(a => a.Ogr_no == sinif[r].Ogr_no).Sinif_sira = r + 1;
                        String hyep = sb6.ToString();
                        System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + v + ".txt", hyep);
                    }*/
            }

            for (int i = 0; i < lines2.Length; i++)
            {
                /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.*/
                string line = lines2[i];
                string[] fields = line.Split(';');
                //Console.WriteLine(Convert.ToInt32(fields[0]));
                student s = new student();
               // Console.WriteLine(fields[0]);
                s.Ogr_no = Convert.ToInt32(fields[0]);
                s.Isim = Convert.ToString(fields[1]);
                s.Soyad = Convert.ToString(fields[2]);
                s.Gano = Convert.ToDouble(fields[3]);
                s.Bolum_sira = Convert.ToInt32(fields[4]);
                s.Sinif_sira = Convert.ToInt32(fields[5]);
                s.Sınıf = Convert.ToInt32(fields[7]);
                s.Cinsiyet = Convert.ToString(fields[6]);
                kontrol.Add(s);

            }
            for (int i = 0; i < lines.Length; i++)
            {
                sinif = sinif.OrderByDescending(x => x.Gano).ToList();
                sinif[0].Sinif_sira = i + 1;
               /* if (sinif.Count != 0)
                    kontrol.Find(a => a.Ogr_no == sinif[0].Ogr_no).Sinif_sira = i + 1;*/
                sb6.AppendLine(sinif[0].Ogr_no + ";" + sinif[0].Isim + ";" + sinif[0].Soyad + ";" + sinif[0].Gano + ";" + sinif[0].Bolum_sira + ";" + sinif[0].Sinif_sira + ";" + sinif[0].Cinsiyet + ";" + sinif[0].Sınıf);
                sb7.AppendLine(kontrol[i].Ogr_no + ";" + kontrol[i].Isim + ";" + kontrol[i].Soyad + ";" + kontrol[i].Gano + ";" + kontrol[i].Bolum_sira + ";" + kontrol[i].Sinif_sira + ";" + kontrol[i].Cinsiyet + ";" + kontrol[i].Sınıf);
                
                sinif.RemoveAt(0);
                String hyep = sb6.ToString();
                String hyep2 = sb7.ToString();
                System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + v + ".txt", hyep);
                //System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + "first" + ".txt", hyep2);
            }



            //Console.WriteLine("V2 OK");
            //Console.ReadKey();

            Console.WriteLine(v + ".txt written to disk.");
            //Console.ReadKey();


            //throw new NotImplementedException();
        }

        public void Bolumsirala(List<student> hepsi, List<student> birinci, List<student> iki, List<student> uc, List<student> dort)
        {//BURADA SINIFI ÇIKAR ÖYLE DENE ONDAN DOLAYI BİR SORUN ÇIKIYOR//YAPTIK ÇALIŞTI
            hepsi = hepsi.OrderByDescending(s => s.Gano).ToList();
            for (int i = 0; i < hepsi.Count; i++)
            {
                hepsi[i].Bolum_sira = i + 1;
                if (hepsi[i].Sınıf == 1)
                {
                    birinci.Find(s => s.Ogr_no == hepsi[i].Ogr_no).Bolum_sira = hepsi[i].Bolum_sira;
                }
                else if (hepsi[i].Sınıf == 2)
                {
                    iki.Find(s => s.Ogr_no == hepsi[i].Ogr_no).Bolum_sira = hepsi[i].Bolum_sira;
                }
                else if (hepsi[i].Sınıf == 3)
                {
                    uc.Find(s => s.Ogr_no == hepsi[i].Ogr_no).Bolum_sira = hepsi[i].Bolum_sira;
                }
                else if (hepsi[i].Sınıf == 4)
                {
                    dort.Find(s => s.Ogr_no == hepsi[i].Ogr_no).Bolum_sira = hepsi[i].Bolum_sira;
                }

                //sinif.Find(s => s.Ogr_no == hepsi[i].Ogr_no).Bolum_sira = i;
            }
        }

        public void Bolumsirala2(String ogrenciler)
        {

            List<student> sinif = new List<student>();
            /*List<student> birinci = new List<student>();
            List<student> ikinci = new List<student>();
            List<student> ucuncu = new List<student>();
            List<student> dorduncu = new List<student>();*/

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + ogrenciler + ".txt");
           /* string[] lines1 = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + bir + ".txt");
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + iki + ".txt");
            string[] lines3 = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + uc + ".txt");
            string[] lines4 = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + dort + ".txt");*/
            StringBuilder sb6 = new StringBuilder();
            StringBuilder sb7 = new StringBuilder();
            StringBuilder sb8 = new StringBuilder();
            StringBuilder sb9 = new StringBuilder();
            StringBuilder sb0 = new StringBuilder();


            for (int i = 0; i < lines.Length; i++)
            {
                /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.*/
                string line = lines[i];
                string[] fields = line.Split(';');
                //Console.WriteLine(Convert.ToInt32(fields[0]));
                student s = new student();
                s.Ogr_no = Convert.ToInt32(fields[0]);
                s.Isim = Convert.ToString(fields[1]);
                s.Soyad = Convert.ToString(fields[2]);
                s.Gano = Convert.ToDouble(fields[3]);
                s.Bolum_sira = Convert.ToInt32(fields[4]);
                s.Sinif_sira = Convert.ToInt32(fields[5]);
                s.Sınıf = Convert.ToInt32(fields[7]);
                s.Cinsiyet = Convert.ToString(fields[6]);
                sinif.Add(s);

            }
            for (int i = 0; i < lines.Length; i++)
            {
                sinif = sinif.OrderByDescending(x => x.Gano).ToList();
                sinif[0].Bolum_sira = i + 1;
                sb6.AppendLine(sinif[0].Ogr_no + ";" + sinif[0].Isim + ";" + sinif[0].Soyad + ";" + sinif[0].Gano + ";" + sinif[0].Bolum_sira + ";" + sinif[0].Sinif_sira + ";" + sinif[0].Cinsiyet + ";" + sinif[0].Sınıf);
                // hepsi.Find(a => a.Ogr_no == sinif[0].Ogr_no).Sinif_sira = i + 1;

               /* if (sinif[0].Sınıf == 1)
                {
                    for (int j = 0; j < lines1.Length; j++)
                    {
                        /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.
                        string line = lines1[i];
                        string[] fields = line.Split(';');
                        //Console.WriteLine(Convert.ToInt32(fields[0]));
                        student s = new student();
                        s.Ogr_no = Convert.ToInt32(fields[0]);
                        s.Isim = Convert.ToString(fields[1]);
                        s.Soyad = Convert.ToString(fields[2]);
                        s.Gano = Convert.ToDouble(fields[3]);
                        s.Bolum_sira = Convert.ToInt32(fields[4]);
                        s.Sinif_sira = Convert.ToInt32(fields[5]);
                        s.Sınıf = Convert.ToInt32(fields[7]);
                        s.Cinsiyet = Convert.ToString(fields[6]);
                        birinci.Add(s);

                    }
                    birinci.Find(s => s.Ogr_no == sinif[0].Ogr_no).Bolum_sira = sinif[0].Bolum_sira;
                    for (int z = 0; z < lines1.Length; z++)
                    {

                        sb7.AppendLine(sinif[0].Ogr_no + ";" + sinif[0].Isim + ";" + sinif[0].Soyad + ";" + sinif[0].Gano + ";" + sinif[0].Bolum_sira + ";" + sinif[0].Sinif_sira + ";" + sinif[0].Cinsiyet + ";" + sinif[0].Sınıf);



                        String hyep2 = sb7.ToString();
                        System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + bir + ".txt", hyep2);

                    }

                }
                else if (sinif[0].Sınıf == 2)
                {
                    for (int j = 0; j < lines2.Length; j++)
                    {
                        /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.
                        string line = lines2[i];
                        string[] fields = line.Split(';');
                        //Console.WriteLine(Convert.ToInt32(fields[0]));
                        student s = new student();
                        s.Ogr_no = Convert.ToInt32(fields[0]);
                        s.Isim = Convert.ToString(fields[1]);
                        s.Soyad = Convert.ToString(fields[2]);
                        s.Gano = Convert.ToDouble(fields[3]);
                        s.Bolum_sira = Convert.ToInt32(fields[4]);
                        s.Sinif_sira = Convert.ToInt32(fields[5]);
                        s.Sınıf = Convert.ToInt32(fields[7]);
                        s.Cinsiyet = Convert.ToString(fields[6]);
                        ikinci.Add(s);

                    }
                    ikinci.Find(s => s.Ogr_no == sinif[0].Ogr_no).Bolum_sira = sinif[0].Bolum_sira;
                    for (int z = 0; z < lines2.Length; z++)
                    {

                        sb8.AppendLine(sinif[0].Ogr_no + ";" + sinif[0].Isim + ";" + sinif[0].Soyad + ";" + sinif[0].Gano + ";" + sinif[0].Bolum_sira + ";" + sinif[0].Sinif_sira + ";" + sinif[0].Cinsiyet + ";" + sinif[0].Sınıf);



                        String hyep2 = sb8.ToString();
                        System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + iki + ".txt", hyep2);

                    }
                }
                else if (sinif[0].Sınıf == 3)
                {
                    for (int j = 0; j < lines3.Length; j++)
                    {
                        /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.
                        string line = lines3[i];
                        string[] fields = line.Split(';');
                        //Console.WriteLine(Convert.ToInt32(fields[0]));
                        student s = new student();
                        s.Ogr_no = Convert.ToInt32(fields[0]);
                        s.Isim = Convert.ToString(fields[1]);
                        s.Soyad = Convert.ToString(fields[2]);
                        s.Gano = Convert.ToDouble(fields[3]);
                        s.Bolum_sira = Convert.ToInt32(fields[4]);
                        s.Sinif_sira = Convert.ToInt32(fields[5]);
                        s.Sınıf = Convert.ToInt32(fields[7]);
                        s.Cinsiyet = Convert.ToString(fields[6]);
                        ucuncu.Add(s);

                    }
                    ucuncu.Find(s => s.Ogr_no == sinif[0].Ogr_no).Bolum_sira = sinif[0].Bolum_sira;
                    for (int z = 0; z < lines3.Length; z++)
                    {

                        sb9.AppendLine(sinif[0].Ogr_no + ";" + sinif[0].Isim + ";" + sinif[0].Soyad + ";" + sinif[0].Gano + ";" + sinif[0].Bolum_sira + ";" + sinif[0].Sinif_sira + ";" + sinif[0].Cinsiyet + ";" + sinif[0].Sınıf);



                        String hyep2 = sb9.ToString();
                        System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + uc + ".txt", hyep2);

                    }
                }
                else if (sinif[0].Sınıf == 4)
                {
                    for (int j = 0; j < lines4.Length; j++)
                    {
                        /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.
                        string line = lines4[i];
                        string[] fields = line.Split(';');
                        //Console.WriteLine(Convert.ToInt32(fields[0]));
                        student s = new student();
                        s.Ogr_no = Convert.ToInt32(fields[0]);
                        s.Isim = Convert.ToString(fields[1]);
                        s.Soyad = Convert.ToString(fields[2]);
                        s.Gano = Convert.ToDouble(fields[3]);
                        s.Bolum_sira = Convert.ToInt32(fields[4]);
                        s.Sinif_sira = Convert.ToInt32(fields[5]);
                        s.Sınıf = Convert.ToInt32(fields[7]);
                        s.Cinsiyet = Convert.ToString(fields[6]);
                        dorduncu.Add(s);

                    }
                    dorduncu.Find(s => s.Ogr_no == sinif[0].Ogr_no).Bolum_sira = sinif[0].Bolum_sira;
                    for (int z = 0; z < lines4.Length; z++)
                    {

                        sb0.AppendLine(sinif[0].Ogr_no + ";" + sinif[0].Isim + ";" + sinif[0].Soyad + ";" + sinif[0].Gano + ";" + sinif[0].Bolum_sira + ";" + sinif[0].Sinif_sira + ";" + sinif[0].Cinsiyet + ";" + sinif[0].Sınıf);



                        String hyep2 = sb0.ToString();
                        System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + dort + ".txt", hyep2);

                    }
                }*/
                sinif.RemoveAt(0);
                String hyep = sb6.ToString();
                System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + ogrenciler + ".txt", hyep);
                System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\bolumegore.txt", hyep);
            }





            Console.WriteLine("Bolumegore.txt created, First.txt, birinci.txt, ikinci.txt, ucuncu.txt, dorduncu.txt Updated!");

        }

        public void sinifagore(List<student> sinif)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            sinif = sinif.OrderByDescending(s => s.Sinif_sira).ToList();
            sinif.Reverse();
            if (sinif[0].Sınıf == 1)
            {
                sb.AppendLine("1.SINIF \n");

            }
            else if (sinif[0].Sınıf == 2)
            {
                sb.AppendLine("2.SINIF \n");
            }
            else if (sinif[0].Sınıf == 3)
            {
                sb.AppendLine("3.SINIF \n");
            }
            else if (sinif[0].Sınıf == 4)
            {
                sb.AppendLine("4.SINIF \n");
            }
            sb.AppendLine("Mevcut:" + sinif.Count() + "\n");
            for (int i = 0; i < sinif.Count; i++)
            {
                //Console.WriteLine(sinif[i].Gano);

                sb.AppendLine("\n " + sinif[i].Ogr_no + "          " + sinif[i].Isim + "   " + sinif[i].Soyad + "     " + sinif[i].Gano + "      " + sinif[i].Bolum_sira + "             " + sinif[i].Sinif_sira + "             " + sinif[i].Cinsiyet + "          " + sinif[i].Sınıf + "\n");

            }
            String tumsinif = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + sinif[0].Sınıf + ".txt", tumsinif);//first.txt adlı text dosyasına kayıt yapılıyor.
            Console.WriteLine(sinif[0].Sınıf + "completed!");

        }

        public void Bolumegore(List<student> hepsi)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            hepsi = hepsi.OrderByDescending(s => s.Bolum_sira).ToList();
            hepsi.Reverse();
            for (int i = 0; i < hepsi.Count; i++)
            {
                //Console.WriteLine(sinif[i].Gano);

                sb.AppendLine("\n " + hepsi[i].Ogr_no + "          " + hepsi[i].Isim + "   " + hepsi[i].Soyad + "     " + hepsi[i].Gano + "      " + hepsi[i].Bolum_sira + "             " + hepsi[i].Sinif_sira + "             " + hepsi[i].Cinsiyet + "          " + hepsi[i].Sınıf + "\n");

            }
            String tumsinif = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\bolumegore.txt", tumsinif);//bolumegore.txt adlı text dosyasına kayıt yapılıyor.
            Console.WriteLine("Bolum sırasına gore butun ogrencilerin sirali listesi text dosyasına yazımı tamamlandı");
        }

        public void Cinsiyetegore(List<student> hepsi)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            //hepsi = hepsi.OrderByDescending(s => s.Bolum_sira).ToList();
            var erkekler = hepsi.Where(s => s.Cinsiyet == "erkek").OrderByDescending(s => s.Gano).ToList();
            for (int i = 0; i < erkekler.Count; i++)
            {
                sb.AppendLine("\n " + erkekler[i].Ogr_no + "          " + erkekler[i].Isim + "   " + erkekler[i].Soyad + "     " + erkekler[i].Gano + "      " + erkekler[i].Bolum_sira + "             " + erkekler[i].Sinif_sira + "             " + erkekler[i].Cinsiyet + "          " + erkekler[i].Sınıf + "\n");

            }
            String erkek = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\erkekler.txt", erkek);//erkekler.txt adlı text dosyasına kayıt yapılıyor.
            Console.WriteLine("Erkeklerin GANO'ya gore sirali listesi text dosyasına yazımı tamamlandı");
            sb.Clear();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            var kizlar = hepsi.Where(s => s.Cinsiyet == "kız").OrderByDescending(s => s.Gano).ToList();
            for (int i = 0; i < kizlar.Count; i++)
            {
                sb.AppendLine("\n " + kizlar[i].Ogr_no + "          " + kizlar[i].Isim + "   " + kizlar[i].Soyad + "     " + kizlar[i].Gano + "      " + kizlar[i].Bolum_sira + "             " + kizlar[i].Sinif_sira + "             " + kizlar[i].Cinsiyet + "          " + kizlar[i].Sınıf + "\n");

            }
            String kiz = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\kizlar.txt", kiz);//kizlar.txt adlı text dosyasına kayıt yapılıyor.
            Console.WriteLine("Kizlarin GANO'ya gore sirali listesi text dosyasına yazımı tamamlandı");
        }
        public void Cinsiyetegore2(String v)
        {
            List<student> hepsi = new List<student>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + v + ".txt");
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            sb2.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb2.AppendLine("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.*/
                string line = lines[i];
                string[] fields = line.Split(';');
                //Console.WriteLine(Convert.ToInt32(fields[0]));
                student s = new student();
                s.Ogr_no = Convert.ToInt32(fields[0]);
                s.Isim = Convert.ToString(fields[1]);
                s.Soyad = Convert.ToString(fields[2]);
                s.Gano = Convert.ToDouble(fields[3]);
                s.Bolum_sira = Convert.ToInt32(fields[4]);
                s.Sinif_sira = Convert.ToInt32(fields[5]);
                s.Sınıf = Convert.ToInt32(fields[7]);
                s.Cinsiyet = Convert.ToString(fields[6]);
                hepsi.Add(s);

            }
            for(int i = 0; i < lines.Length; i++) {
                if (hepsi[i].Cinsiyet == "erkek")
                {
                    sb.AppendLine("\n " + hepsi[i].Ogr_no + "          " + hepsi[i].Isim + "   " + hepsi[i].Soyad + "     " + hepsi[i].Gano + "      " + hepsi[i].Bolum_sira + "             " + hepsi[i].Sinif_sira + "             " + hepsi[i].Cinsiyet + "          " + hepsi[i].Sınıf + "\n");
                }
                else {
                    sb2.AppendLine("\n " + hepsi[i].Ogr_no + "          " + hepsi[i].Isim + "   " + hepsi[i].Soyad + "     " + hepsi[i].Gano + "      " + hepsi[i].Bolum_sira + "             " + hepsi[i].Sinif_sira + "             " + hepsi[i].Cinsiyet + "          " + hepsi[i].Sınıf + "\n");
                }
            }

           

            /*var erkekler = hepsi.Where(s => s.Cinsiyet == "erkek").OrderByDescending(s => s.Gano).ToList();
            for (int j = 0; j < erkekler.Count; j++)
            {
                
                sb.AppendLine("\n " + erkekler[j].Ogr_no + "          " + erkekler[j].Isim + "   " + erkekler[j].Soyad + "     " + erkekler[j].Gano + "      " + erkekler[j].Bolum_sira + "             " + erkekler[j].Sinif_sira + "             " + erkekler[j].Cinsiyet + "          " + erkekler[j].Sınıf + "\n");

            }*/
            String erkek = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\erkekler.txt", erkek);//erkekler.txt adlı text dosyasına kayıt yapılıyor.

            /*sb.Clear();
            var kizlar = hepsi.Where(s => s.Cinsiyet == "erkek").OrderByDescending(s => s.Gano).ToList();
            for (int j = 0; j < kizlar.Count; j++)
            {
                sb.AppendLine("\n " + kizlar[j].Ogr_no + "          " + kizlar[j].Isim + "   " + kizlar[j].Soyad + "     " + kizlar[j].Gano + "      " + kizlar[j].Bolum_sira + "             " + kizlar[j].Sinif_sira + "             " + kizlar[j].Cinsiyet + "          " + kizlar[j].Sınıf + "\n");

            }*/
            String kiz = sb2.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\kizlar.txt", kiz);//erkekler.txt adlı text dosyasına kayıt yapılıyor.

            Console.WriteLine("Erkeklerin GANO'ya gore sirali listesi text dosyasına yazımı tamamlandi");
            Console.WriteLine("Kizlarin GANO'ya gore sirali listesi text dosyasına yazımı tamamlandi");
        }

        public void OgrenciNoyaGore(List<student> hepsi)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            hepsi = hepsi.OrderByDescending(s => s.Ogr_no).ToList();
            hepsi.Reverse();
            for (int i = 0; i < hepsi.Count; i++)
            {
                sb.AppendLine("\n " + hepsi[i].Ogr_no + "          " + hepsi[i].Isim + "   " + hepsi[i].Soyad + "     " + hepsi[i].Gano + "      " + hepsi[i].Bolum_sira + "             " + hepsi[i].Sinif_sira + "             " + hepsi[i].Cinsiyet + "          " + hepsi[i].Sınıf + "\n");
            }
            String tumsinif = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\ogrNo_gore.txt", tumsinif);//ogrNo_gore.txt adlı text dosyasına kayıt yapılıyor.
            Console.WriteLine("Ogrenci NO_ya gore butun ogrencilerin sirali listesi text dosyasına yazımı tamamlandı");
        }
        public void OgrenciNoyaGore2(String v)
        {
            List<student> hepsi = new List<student>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\" + v + ".txt");
            StringBuilder sb = new StringBuilder();
            sb.Append("Ogrenci No || İsim || Soyad || GANO || Bölüm sıra || Sınıf Sıra || Cinsiyet || Sınıf \n");
            sb.AppendLine("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                /* TODO: dosya okunup listeye çevrilir ve geçen sürümde olduğu gibi yapılır. Ama sonuç olarak istenen olmaz çünkü liste yapısında ram de sıralamış olurum.*/
                string line = lines[i];
                string[] fields = line.Split(';');
                //Console.WriteLine(Convert.ToInt32(fields[0]));
                student s = new student();
                s.Ogr_no = Convert.ToInt32(fields[0]);
                s.Isim = Convert.ToString(fields[1]);
                s.Soyad = Convert.ToString(fields[2]);
                s.Gano = Convert.ToDouble(fields[3]);
                s.Bolum_sira = Convert.ToInt32(fields[4]);
                s.Sinif_sira = Convert.ToInt32(fields[5]);
                s.Sınıf = Convert.ToInt32(fields[7]);
                s.Cinsiyet = Convert.ToString(fields[6]);
                hepsi.Add(s);

            }
            for (int i = 0; i < lines.Length; i++)
            {
                hepsi = hepsi.OrderBy(x => x.Ogr_no).ToList();
                sb.AppendLine(hepsi[0].Ogr_no + ";" + hepsi[0].Isim + ";" + hepsi[0].Soyad + ";" + hepsi[0].Gano + ";" + hepsi[0].Bolum_sira + ";" + hepsi[0].Sinif_sira + ";" + hepsi[0].Cinsiyet + ";" + hepsi[0].Sınıf);
                hepsi.RemoveAt(0);
                String hyep = sb.ToString();
                System.IO.File.WriteAllText(@"C:\Users\hhk19\Documents\Visual Studio 2017\Projects\ConsoleApp1\ConsoleApp1\v2\ogrNo_gore.txt", hyep);
            }
        }
    }
}
