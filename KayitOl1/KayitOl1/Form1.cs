using System;                               //sistemi kullanmak icin gereken kutuphane
using System.Collections.Generic;           //sistemin genel koleksiyonlarini kullanma icin gereken kutuphane
using System.ComponentModel;                //sistem bilesenlerini kullanma icin gereken kutuphane
using System.Data;                          //sistem verisi kullanilir
using System.Drawing;                       //sistemi cizer
using System.Linq;                          //veri sorgulamak icin kullanilir
using System.Text;                          //metin icin kullanilir
using System.Threading.Tasks;               //is parcacigi gorevlerini aktif hale getiren kutuphane
using System.Windows.Forms;                 //windows form kullanma icin gereken kutuphane

namespace KayitOl1                          //kayitOl isimli isim uzayi
{
    public partial class Form1 : Form        //genele acik Form1 icerisindeki Form kismi sinifi
    {
        public Form1()                       //genele acik Form1 metodu
        {
            InitializeComponent();          //Form1 nesnesine ait olan uye elemanlarla ilgili ilk islemler yapilir.
        }

        bool dokuzKarakter;                 //kontrol islemi icin karakter sayisi tanimlanir           
        bool birBuyuk;                      //buyuk harf kontrolu icin anahtar tanimlama
        bool birKucuk;                      //kucuk harf kontrolu icin anahtar tanimlama
        bool birRakam;                      //rakam kontrolu icin anahtar tanimlama
        bool birSembol;                     //sembol kontrolu icin anahtar tanimlama

        private void textBox1_TextChanged(object sender, EventArgs e)   //textbox1 i baslatan ozel fonksiyon
        {
            
           
        }
        private void Form1_Load(object sender, EventArgs e)               //form1 yuklemesini baslatan fonksiyon
        {
            
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)          //kayitol butonuna tiklaninca gerceklesek olaylar
        {
            dokuzKarakter = false;      //karakter sayisi yanlis olarak tanimlandi
            birBuyuk = false;      //buyuk harf yanlis olarak tanimlandi
            birKucuk = false;      //kucuk harf yanlis olarak tanimlandi
            birRakam = false;      //rakam yanlis olarak tanimlandi
            birSembol = false;      //sembol yanlis olarak tanimlandi

            int genelSayac = 0;          //genel sayac 0'a esitlendi
            int karakterSayaci = 0;          //karakter sayaci 0'a esitlendi
            int buyukHarfSayaci = 0;          //buyuk harf sayisi 0'a esitlendi
            int buyukHarfPuani = 0;          //buyuk harf puani 0'a esitlendi
            int kucukHarfSayaci = 0;          //kucuk harf sayisi 0'a esitlendi
            int kucukHarfPuani = 0;          //kucuk harf puani 0'a esitlendi
            int rakamSayaci = 0;          //rakam sayisi 0'a esitlendi
            int rakamPuani = 0;          //rakam puani 0'a esitlendi
            int sembolSayaci = 0;          //sembol sayisi 0'a esitlendi
            int sembolPuani = 0;          //sembol puani 0'a esitlendi

            lstBox_mesaj.Items.Clear();                     //mesaj listboxundaki veriler temizlendi

            if (txt_sifre.Text.ToCharArray().Count()>0)         //sifrenin bos olmadigi kontrol edilir
            {
                char[] karakterler = txt_sifre.Text.ToCharArray();  //karakterler degiskeni sifrenin sayisina esitlenir
                karakterSayisi();       //karakter sayisi fonksiyonu cagrilir
                void karakterSayisi()       //karakter sayisi fonksiyonu olusturulur
                {
                    if(karakterler.Length>=9)       //karakter uzunlugu 9'a esit ve buyukse buraya girer
                    {
                        dokuzKarakter = true;       //dokuz karakter anahtari dogruya cevrilir
                        lbl_minKarakter.ForeColor = Color.Green;        //minimum karakter label'i yesil renk olur
                        karakterSayaci = 10;            //karakter sayaci 10 olur
                    }
                    else                                        //(if saglanmazsa) karakter sayisi 9dan kucukse buraya girer
                    {
                        dokuzKarakter = false;                    //dokuz karakter anahtari yanlisa cevrilir
                        lbl_minKarakter.ForeColor = Color.Red;    //minimum karakter label'i kirmizi renk olur
                        karakterSayaci = 0;                         //karakter sayaci 0 olur
                        lstBox_mesaj.Items.Add("Parola en az 9 karakterden oluşmalıdır.");         //mesaj kutusuna saglanmasi gereken kosul yazdirilir
                    }
                    buyukKontrol();                     //buyuk harf kontrol fonksiyonu cagrilir
                }

                
                void buyukKontrol()                     //buyuk harf kontrol fonksiyonu olusturulur
                {
                    foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                    {
                        if (char.IsUpper(karakter))         //buyuk harf karakter sayisi kadar dongu doner
                        {
                            birBuyuk = true;                //buyuk harf anahtarini true yapar
                            buyukHarfSayaci += 1;           //buyuk harf sayacini 1 arttirir
                        }
                        if(buyukHarfSayaci==1)              //buyuk harf sayisi 1 ise buraya girer
                        {
                            buyukHarfPuani = 10;            //buyuk harf puanini 10a esitler
                        }
                        else if(buyukHarfSayaci>1)          //buyuk harf sayaci 1den buyukse buraya girer
                        {
                            buyukHarfPuani = 20;            //buyuk harf puani 20 olur
                        }
                        else                                //diger kosullar saglanmazsa buraya girer
                        {
                            buyukHarfPuani = 0;             //buyuk harf puanini 0 yapar
                        } 
                    }
                    if (birBuyuk == true)                   //buyuk harf anahtari dogru ise buraya girer
                    {
                        lbl_buyukHarf.ForeColor = Color.Green;          //buyuk harf kosulu yazisini yesil renk yapar
                    }
                    else                                                //diger kosul saglanmazsa
                    {
                        lbl_buyukHarf.ForeColor = Color.Red;            //buyuk harf kosulu yazisini kirmizi renk yapar
                        lstBox_mesaj.Items.Add("Parolanız büyük harf içermelidir.");    //mesaj listboxina gerekli uyari mesaji yazdirilir
                    }
                    kucukKontrol();                                         //kucuk harf kontrol fonksiyonu cagrilir
                }

                
                void kucukKontrol()                     //kucuk harf kontrol fonksiyonu olusturulur
                {
                    foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                    {
                        if (char.IsLower(karakter))          //kucuk harf karakter sayisi kadar dongu doner    
                        {
                            birKucuk = true;               //kucuk harf anahtarini true yapar
                            kucukHarfSayaci += 1;           //kucuk harf sayacini 1 arttirir
                        }
                        if(kucukHarfSayaci==1)              //kucuk harf sayisi 1 ise buraya girer
                        {
                            kucukHarfPuani = 10;           //kucuk harf puanini 10a esitler
                        }
                        else if(kucukHarfSayaci>1)          //kucuk harf sayaci 1den buyukse buraya girer
                        {
                            kucukHarfPuani = 20;            //kucuk harf puani 20 olur
                        }
                        else                               //diger kosullar saglanmazsa buraya girer
                        {
                            kucukHarfPuani = 0;            //kucuk harf puanini 0 yapar
                        }
                    }
                    if (birKucuk == true)                  //kucuk harf anahtari dogru ise buraya girer
                    {
                        lbl_kucukHarf.ForeColor = Color.Green;         //kucuk harf kosulu yazisini yesil renk yapar
                    }
                    else                                               //diger kosul saglanmazsa
                    {
                        lbl_kucukHarf.ForeColor = Color.Red;            //kucuk harf kosulu yazisini kirmizi renk yapar
                        lstBox_mesaj.Items.Add("Parolanız küçük harf içermelidir.");   //mesaj listboxina gerekli uyari mesaji yazdirilir
                    }
                    rakamKontrol();                                        //rakam kontrol fonksiyonu cagrilir
                }

               
                void rakamKontrol()                     //rakam kontrol fonksiyonu olusturulur
                {
                    foreach(char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                    {
                        if(char.IsNumber(karakter))          //rakam karakteri sayisi kadar dongu doner  
                        {
                            birRakam = true;             //rakam anahtarini true yapar
                            rakamSayaci += 1;          //rakam sayacini 1 arttirir
                        }
                        if (rakamSayaci == 1)              //rakam sayisi 1 ise buraya girer
                        {
                            rakamPuani = 10;           //rakam puanini 10a esitler
                        }
                        else if(rakamSayaci>1)         //rakam sayaci 1den buyukse buraya girer
                        {
                            rakamPuani = 20;            //rakam puani 20 olur
                        }
                        else                               //diger kosullar saglanmazsa buraya girer
                        {
                            rakamPuani = 0;           //rakam puanini 0 yapar
                        }
                    }
                    if(birRakam==true)                 //rakam anahtari dogru ise buraya girer
                    {
                        lbl_rakam.ForeColor = Color.Green;         //rakam kosulu yazisini yesil renk yapar
                    }
                    else                                              //diger kosul saglanmazsa
                    {
                        lbl_rakam.ForeColor = Color.Red;            //rakam kosulu yazisini kirmizi renk yapar
                        lstBox_mesaj.Items.Add("Parolanız rakam içermelidir.");     //mesaj listboxina gerekli uyari mesaji yazdirilir
                    }
                    sembolKontrol();                                       //sembol kontrol fonksiyonu cagrilir
                }

                
                void sembolKontrol()                      //sembol kontrol fonksiyonu olusturulur       
                {
                    foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                    {
                        if (char.IsSymbol(karakter))          //sembol karakter sayisi kadar dongu doner
                        {
                            birSembol = true;             //sembol anahtarini true yapar
                            sembolSayaci += 1;          //sembol harf sayacini 1 arttirir
                        }
                        if(sembolSayaci==1)              //sembol sayisi 1 ise buraya girer
                        {
                            sembolPuani = 10;           //sembol harf puanini 10a esitler
                        }
                        else if(sembolSayaci>1)        //sembol sayaci 1den buyukse buraya girer
                        { 
                            sembolPuani += 10;           //sembol puani 20 olur
                        }
                        else                               //diger kosullar saglanmazsa buraya girer
                        {
                            sembolPuani = 0;          //sembol puanini 0 yapar
                        }
                    }
                    if (birSembol == true)                 //sembol anahtari dogru ise buraya girer
                    {
                        lbl_sembol.ForeColor = Color.Green;        //sembol kosulu yazisini yesil renk yapar
                    }
                    else                                              //diger kosul saglanmazsa
                    {
                        lbl_sembol.ForeColor = Color.Red;           //sembol kosulu yazisini kirmizi renk yapar
                        lstBox_mesaj.Items.Add("Parolanız sembol içermelidir.");    //mesaj listboxina gerekli uyari mesaji yazdirilir
                    }
                }

            }

            genelSayac = karakterSayaci + buyukHarfPuani + kucukHarfPuani + rakamPuani + sembolPuani;       
            //genel sayac puanini diger tum puanlarin toplamina esitler
            lstBox_puan.Items.Clear();      //puan listbox verilerini temizler
            lstBox_puan.Items.Add("Genel Puan: " + genelSayac);     //puan listbox'ina genel puan yazdirilir

            lstBox_genelPuan.Items.Clear();     //genel puan listboxi temizlenir

            if(dokuzKarakter==true && birBuyuk==true && birKucuk == true && birRakam == true && birSembol == true)  //tum kosullar dogru saglaniyorsa donguye girer
            { 
                if (genelSayac>=90)     //genel sayac 90a esit ve buyukse
                {
                    lstBox_genelPuan.Items.Add("Şifreniz güçlüdür.");       //puan listboxina sifreniz gucludur yazdirilir
                }
                else if(genelSayac>=70 && genelSayac<90)    //genel puan 79-90 arasi ise
                {
                    lstBox_genelPuan.Items.Add("Şifreniz uygundur.");     //puan listboxina sifreniz uygundur yazdirilir
                }
                else                                                    //diger kosullar saglanmaz ise buraya girer
                {
                    lstBox_genelPuan.Items.Add("Şifrenizin puanı 70'ten küçük olduğu için kayıt olamazsınız.");     //genel puan listbox uyesine uyari mesaji yazdirilir
                    MessageBox.Show("Şifrenizin puanı 70'ten küçük olduğu için kayıt olamazsınız.");        //ekrana uyari niteliginde mesaj kutusu gonderilir
                }
                lstBox_mesaj.Items.Add("Tüm koşulları sağladınız.");        //listboxa yazi yazdirilir
                
                foreach (var item in this.Controls)     //foreach dongusuyle diziler icindeki degerler kullanilir
                {
                      if (item.GetType() == typeof(ListBox))        //listbox uyesi
                      {
                         ((ListBox)item).BackColor = Color.Green;   //listbox arka plan rengini yesil yapar
                      }
                 }
                        
            }
            else                                                                 //kosullar saglanmazsa buraya girer
            {
                foreach (var item in this.Controls)                     //foreach dongusuyle diziler icindeki degerler kullanilir
                {
                    if (item.GetType() == typeof(ListBox))              //listbox uyesi
                    {
                        ((ListBox)item).BackColor = Color.Red;          //listbox arka plan rengini kirmizi yapar
                    }
                }
                MessageBox.Show("Şifreniz uygun değildir.");            //ekrana uyari niteliginde sifreniz uygun degildir mesaj kutusu yazdirilir
                lstBox_genelPuan.Items.Add("Şifreniz uygun değildir.");     //genel puan listboxina uyari yazisi yazdirilir         
            }
        }

        private void lstBox_puan_SelectedIndexChanged(object sender, EventArgs e)   //secilen dizinin degisimi olan ozel fonksiyonu
        {

        }
    }
}
