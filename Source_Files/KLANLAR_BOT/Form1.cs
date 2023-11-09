using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Web.WebView2.WinForms;
using System.Collections;
using System.Threading;


namespace KLANLAR_BOT
{
    
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool isTimerActive = false;
        private bool isTaskRunning = false;

        private System.Windows.Forms.Timer timer_kor = new System.Windows.Forms.Timer();
        private bool isTimerActive_kor = false;
        private bool isTaskRunning_kor = false;



        List<string> saldirilacak_koyler=new List<string>();

        List<string> koy_listesi = new List<string>();
        List<int> selected_indexes;
        Dictionary<int, string> koy_yagma_ayarlari=new Dictionary<int, string>();
        //List<string> script_list=File.ReadAllLines("C:\\Users\\alise\\Desktop\\Yazılım\\Klanlar_Bot\\KLANLAR_BOT\\KLANLAR_BOT\\scripts.txt").ToList();
        static FileStream kullanici_bilgileri_dosyasi;
        static string kullanici_adi;
        static string kullanici_sifre;
        static bool kullanici_bilgileri_kayitli = false;
        static bool selected = false;
        static WebView2 webView2;
        static int yagma_periyodu = 300;
        static web web_c;
        static bool okcu_varmi=false;
        static bool counter=false;
        public Form1()
        {
            InitializeComponent();

            web_c = new web();
            webView2 = web_c.webView21;
            web_c.Hide();
            if (!(File.Exists(Directory.GetCurrentDirectory() + @"/data.txt")))
            {
                kullanici_bilgileri_dosyasi = File.Create((Directory.GetCurrentDirectory() + @"/data.txt"));
                kullanici_bilgileri_dosyasi.Close();
            }
            else
            {

                if ((File.ReadAllText((Directory.GetCurrentDirectory() + @"/data.txt")).Length > 0))
                {
                    kullanici_bilgileri_kayitli = true;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_maks_yagma_mesafesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_gizle_goster_Click(object sender, EventArgs e)
        {
            if (web_c.Visible) {
                web_c.Hide() ;
            }
            else
            {
                web_c.Show();
            }
        }

        private async void button_giris_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != string.Empty && textBox_pw.Text != string.Empty)
            {
                kullanici_adi = textBox_id.Text;
                kullanici_sifre = textBox_pw.Text;
                if (checkBox1.Checked)
                {
                    File.WriteAllLines("data.txt", [kullanici_adi, kullanici_sifre]);
                }


                await web_c.giris_yap(kullanici_adi, kullanici_sifre);
                string sonuc=await web_c.mevcut_dunya_getir();
                sonuc = sonuc.Remove(sonuc.Length-1, 1);
                sonuc = sonuc.Remove(0, 1);
                List<string> list = sonuc.Split(new char[] { ',' }).ToList(); 
                listBox_dunyalar.DataSource=list;
                button_Dunya_Sec.Enabled = true;



            }

            else
            {
                MessageBox.Show("Kullanıcı Adı Şifre Giriniz", "HATA");
                //this.Close();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //kullanici_bilgileri_dosyasi = File.Open("data.txt", FileMode.Open, FileAccess.ReadWrite);
            if (kullanici_bilgileri_kayitli && checkBox1.Checked)
            {
                List<string> kullanici_data_list = File.ReadLines("data.txt").ToList();
                kullanici_adi = kullanici_data_list[0];
                kullanici_sifre = kullanici_data_list[1];
                textBox_id.Text = kullanici_adi;
                textBox_pw.Text = kullanici_sifre;

            }

            else
            {
            }
        }

        private async void button_Dunya_Sec_Click(object sender, EventArgs e)
        {
            await web_c.script_uygula(web_c.dunya_sec, listBox_dunyalar.SelectedIndex.ToString());

            Boolean res = await web_c.giris_kontrol();
            if (res) {
                button_Dunya_Sec.BackColor = Color.Green;
                button_Dunya_Sec.Text = "Giriş Başarılı!";


                string koyler=(string)await web_c.script_uygula(web_c.koyleri_getir);
                koyler=koyler.Remove(koyler.Length - 1, 1);
                koyler = koyler.Remove(0, 1);
                listBox_Mevcut_Koyler.Enabled = true;
                koy_listesi= koyler.Split(new char[] { ',' }).ToList();
                listBox_Mevcut_Koyler.DataSource = koy_listesi;
                button_yagma_ayar_kaydet.Enabled = true;
                textBox_maks_yagma_mesafesi.Enabled = true;
                checkBox_sari_yagma.Enabled = true;
                checkBox_Yagma_A.Enabled    = true;
                checkBox_Yagma_B.Enabled = true;    
                checkBox_Yagma_C.Enabled = true;    
                button_kesif_birligi.Enabled = true;
                textBox_max_sur_seviyesi.Enabled = true;
                textBox_yagma_per.Enabled = true;
                checkBox_okcu_var_mi.Enabled = true;
                textBox_kor_kilic.Enabled = true;   
                textBox_kor_mizrak.Enabled = true;    

                

            }
            else {
                button_Dunya_Sec.BackColor = Color.Red;
                button_Dunya_Sec.Text = "GİRİŞ BAŞARISIZ!";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_yagma_ayar_kaydet_Click(object sender, EventArgs e)
        {
            okcu_varmi = checkBox_okcu_var_mi.Checked;
            yagma_periyodu = int.Parse(textBox_yagma_per.Text);
            timer.Interval = yagma_periyodu*1000; // 30 saniye
            timer.Tick += Timer_Tick;

            timer_kor.Interval = yagma_periyodu * 1000; // 30 saniye
            timer_kor.Tick += Timer_Tick_kor_saldiri;

            selected = true;
            int yagma_ABC= 2;
            selected_indexes =listBox_Mevcut_Koyler.SelectedIndices.Cast<int>().ToList();

            if(checkBox_Yagma_A.Checked && !checkBox_Yagma_B.Checked && !checkBox_Yagma_C.Checked)
            {
                yagma_ABC = 0;
            }
            else if (!checkBox_Yagma_A.Checked && checkBox_Yagma_B.Checked && !checkBox_Yagma_C.Checked)
            {

                yagma_ABC = 1;
            }
            else if (!checkBox_Yagma_A.Checked && !checkBox_Yagma_B.Checked && checkBox_Yagma_C.Checked)
            {
                yagma_ABC = 2;

            }
            else
            {
                MessageBox.Show("Birden Fazla Yağma A B C kutusu seçili. Sadece 1ini seçin");
                checkBox_Yagma_A.Checked = false;
                checkBox_Yagma_B.Checked = false;
                checkBox_Yagma_C.Checked = false;
                return;
            }

            foreach (int item in selected_indexes)
            {
                if (koy_yagma_ayarlari.ContainsKey(item*10+0))
                {
                    // Anahtar zaten varsa, değeri güncelle
                    koy_yagma_ayarlari[item * 10 + 0]= textBox_maks_yagma_mesafesi.Text;
                }
                else
                {
                    // Anahtar yoksa, yeni bir anahtar/değer çifti ekle
                    koy_yagma_ayarlari.Add(item * 10 + 0, textBox_maks_yagma_mesafesi.Text);
                }

                if (koy_yagma_ayarlari.ContainsKey(item * 10 + 1))
                {
                    // Anahtar zaten varsa, değeri güncelle
                    koy_yagma_ayarlari[item * 10 + 1] = checkBox_sari_yagma.Checked.ToString();
                }
                else
                {
                    // Anahtar yoksa, yeni bir anahtar/değer çifti ekle
                    koy_yagma_ayarlari.Add(item * 10 + 1, checkBox_sari_yagma.Checked.ToString());
                }
                if (koy_yagma_ayarlari.ContainsKey(item * 10 + 2))
                {
                    // Anahtar zaten varsa, değeri güncelle
                    koy_yagma_ayarlari[item * 10 + 2] = yagma_ABC.ToString();
                }
                else
                {
                    // Anahtar yoksa, yeni bir anahtar/değer çifti ekle
                    koy_yagma_ayarlari.Add(item * 10 + 2, yagma_ABC.ToString());
                }

                if (koy_yagma_ayarlari.ContainsKey(item * 10 + 3))
                {
                    // Anahtar zaten varsa, değeri güncelle
                    koy_yagma_ayarlari[item * 10 + 3] = textBox_max_sur_seviyesi.Text;
                }
                else
                {
                    // Anahtar yoksa, yeni bir anahtar/değer çifti ekle
                    koy_yagma_ayarlari.Add(item * 10 + 3, textBox_max_sur_seviyesi.Text);
                }



                if (koy_yagma_ayarlari.ContainsKey(item * 10 + 4))
                {
                    // Anahtar zaten varsa, değeri güncelle
                    koy_yagma_ayarlari[item * 10 + 4] = textBox_kor_mizrak.Text;
                }
                else
                {
                    // Anahtar yoksa, yeni bir anahtar/değer çifti ekle
                    koy_yagma_ayarlari.Add(item * 10 + 4, textBox_kor_mizrak.Text);
                }


                if (koy_yagma_ayarlari.ContainsKey(item * 10 + 5))
                {
                    // Anahtar zaten varsa, değeri güncelle
                    koy_yagma_ayarlari[item * 10 + 5] = textBox_kor_kilic.Text;
                }
                else
                {
                    // Anahtar yoksa, yeni bir anahtar/değer çifti ekle
                    koy_yagma_ayarlari.Add(item * 10 + 5, textBox_kor_kilic.Text);
                }






            }
         
                
            button_otomatik_yagma.Enabled = true;
            button_kor_saldiri.Enabled = true;
            button_tekil_kor.Enabled = true;
            button_tekil_yagma.Enabled = true;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void button_kesif_birligi_Click(object sender, EventArgs e)
        {
            selected_indexes = listBox_Mevcut_Koyler.SelectedIndices.Cast<int>().ToList();
            for (int i = 0; i < koy_yagma_ayarlari.Keys.Count/4; i++)
            {
                int islem_yapilan_koy_indeks = (int)(Math.Floor((Double)(koy_yagma_ayarlari.Keys.ToList<int>()[4*i]) / 10));
                if (selected_indexes.Contains(islem_yapilan_koy_indeks)) {
                    await web_c.ilgili_koyu_sec_f(islem_yapilan_koy_indeks);

                    var dict= await web_c.barbar_liste_dondur_f();

                    await web_c.ilgili_koyu_sec_f(islem_yapilan_koy_indeks);

                    await web_c.script_uygula(web_c.ictima_meydanı);

                    await web_c.casus_gonder_f(dict, int.Parse(koy_yagma_ayarlari[10* islem_yapilan_koy_indeks]));

                }

            }
        }

        private void listBox_Mevcut_Koyler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selected && koy_yagma_ayarlari.Keys.Contains(listBox_Mevcut_Koyler.SelectedIndex * 10)) {
                textBox_maks_yagma_mesafesi.Text = koy_yagma_ayarlari[listBox_Mevcut_Koyler.SelectedIndex * 10].ToString();
                textBox_max_sur_seviyesi.Text = koy_yagma_ayarlari[(listBox_Mevcut_Koyler.SelectedIndex * 10) + 3].ToString();
            }

        }

        private void button_otomatik_yagma_Click(object sender, EventArgs e)
        {
            if (!isTimerActive)
            {
                timer.Start(); // Zamanlayıcıyı başlat
                button_otomatik_yagma.Text = "Otomatik Yağma Durdur";
                isTimerActive = true;
            }
            else
            {
                timer.Stop(); // Zamanlayıcıyı durdur
                button_otomatik_yagma.Text = "Otomatik Yağma Başlat";
                isTimerActive = false;
            }


        }

        private void checkBox_Yagma_A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_bilgiler_Click(object sender, EventArgs e)
        {
            string kurulum = "Merhaba, Aşağıdaki notları uygulayın.\r\nYağma asistanında A ya Hafif Atlı Casus ve B ye Mızrak Kılıç Casus birim koyup kaydedin\r\nYağma asistanında Tüm Kayıpları Gösterme şeklinde ayarlayın\r\nYağma asistanında Şuanda Saldırılan köylerin raporlarını dahil et seçin.\r\nYağma asistanında sadece Bu köyden giden saldırıları gösteri seçin.\r\nSohbet Penceresini ve Bildirimklerini sağ alttan kapatın.\n\rKör Yağma butonu en yakindaki köylere 3 mizrak 2 kılıç gönderir.Oyunun başında ahıra rushlamak için etkili olabilir.";
            MessageBox.Show(kurulum);
        }



        private async Task yagma_yap_func()
        {


                selected_indexes = listBox_Mevcut_Koyler.SelectedIndices.Cast<int>().ToList();
                for (int i = 0; i < koy_yagma_ayarlari.Keys.Count / 4; i++)
                {
                    int islem_yapilan_koy_indeks = (int)(Math.Floor((Double)(koy_yagma_ayarlari.Keys.ToList<int>()[4 * i]) / 10));
                    if (selected_indexes.Contains(islem_yapilan_koy_indeks))
                    {
                        await web_c.ilgili_koyu_sec_f(islem_yapilan_koy_indeks);



                        await web_c.ilgili_koyu_sec_f(islem_yapilan_koy_indeks);

                        await web_c.script_uygula(web_c.yagma_asistanina_git);

                        await web_c.yagma_yap_sayfada(int.Parse(koy_yagma_ayarlari[(10 * islem_yapilan_koy_indeks) + 3]), int.Parse(koy_yagma_ayarlari[10 * islem_yapilan_koy_indeks]), int.Parse(koy_yagma_ayarlari[(10 * islem_yapilan_koy_indeks) + 2]), okcu_varmi);

                    }

                }

        }


        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (!isTaskRunning)
            {
                isTaskRunning = true;
                await yagma_yap_func();
                isTaskRunning = false;
            }
        }
        private async void Timer_Tick_kor_saldiri(object sender, EventArgs e)
        {
            if (!isTaskRunning_kor)
            {
                isTaskRunning_kor = true;
                await kor_soldiri_yap_func();
                isTaskRunning_kor = false;
            }
        }

        private void button_kor_saldiri_Click(object sender, EventArgs e)
        {
            if (!isTimerActive_kor)
            {
                timer_kor.Start(); // Zamanlayıcıyı başlat
                button_kor_saldiri.Text = "Kör Yağma Durdur";
                isTimerActive_kor = true;
            }
            else
            {
                timer_kor.Stop(); // Zamanlayıcıyı durdur
                button_kor_saldiri.Text = "Kör Yağma Başlat";
                isTimerActive_kor = false;
            }
        }

        private async Task kor_soldiri_yap_func()
        {


                selected_indexes = listBox_Mevcut_Koyler.SelectedIndices.Cast<int>().ToList();
                for (int i = 0; i < koy_yagma_ayarlari.Keys.Count / 4; i++)
                {
                    int islem_yapilan_koy_indeks = (int)(Math.Floor((Double)(koy_yagma_ayarlari.Keys.ToList<int>()[4 * i]) / 10));
                    if (selected_indexes.Contains(islem_yapilan_koy_indeks))
                    {
                        await web_c.ilgili_koyu_sec_f(islem_yapilan_koy_indeks);

                        var dict = await web_c.barbar_liste_dondur_f();

                        await web_c.ilgili_koyu_sec_f(islem_yapilan_koy_indeks);

                        await web_c.script_uygula(web_c.ictima_meydanı);

                        await web_c.kilic_mizrak_gonder_f(dict, int.Parse(koy_yagma_ayarlari[10 * islem_yapilan_koy_indeks]), int.Parse(koy_yagma_ayarlari[(10 * islem_yapilan_koy_indeks) + 4]), int.Parse(koy_yagma_ayarlari[(10 * islem_yapilan_koy_indeks) + 5]));

                    }

                }

        }

        private async void button_tekil_kor_Click(object sender, EventArgs e)
        {
            await kor_soldiri_yap_func();
        }

        private async void button_tekil_yagma_Click(object sender, EventArgs e)
        {
            await yagma_yap_func();
        }
    }
}
