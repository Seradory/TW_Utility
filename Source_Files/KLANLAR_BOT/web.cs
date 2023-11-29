using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace KLANLAR_BOT
{



    public partial class web : Form
    {

        public string sayfa_yuklendi_mi = "document.readyState;";
        public string reload = "location.reload();";
        private string giris_basarili_mi = "var result=false;var el=document.getElementsByTagName('h2');for(var i=0;i<el.length;i++){  if(el[i].textContent.toLowerCase().includes(\"hoş geldin\")){result=true;break;}}result;";
        /// <summary>
        // private string giris_yap_s = "var el=document.querySelector(\"[id='remember-me'][name='remember-me']\");if(el.checked){el.click();}var el=document.querySelector(\"[id='user'][type='text']\");el.value=\"{0}\";var el=document.querySelector(\"[id='password'][name='password']\");el.value=\"{1}*\";var el=document.getElementsByClassName(\"btn-login\");el[0].click();\r\n";
        private string giris_yap_s = @"var el=document.querySelector(""[id='remember-me'][name='remember-me']"");if(el.checked){{el.click();}}var el=document.querySelector(""[id='user'][type='text']"");el.value=""{0}"";var el=document.querySelector(""[id='password'][name='password']"");el.value=""{1}"";var el=document.getElementsByClassName(""btn-login"");el[0].click();";
        /// </summary>
        private string mevcut_dunyalar = "var el=document.getElementsByClassName(\"world-select\");\r\nvar result=\"\";\r\nfor(var i=0;i<el.length;i++){\r\n    result+=el[i].text + \",\";\r\n}\r\nresult;";
        public string dunya_sec = "el[{0}].click();";
        public string koyleri_getir = "var el=document.getElementById(\"production_table\");\r\nvar result=\"\";\r\nif(el!=null){\r\n    var el2=el.querySelectorAll(\"[class='quickedit-label'][data-text]\");\r\n    for(var i=0;i<el2.length;i++){\r\n        result+=el2[i].innerText+\",\";\r\n    }\r\n}\r\nelse{\r\n    var el=document.getElementsByClassName(\"nowrap tooltip-delayed\");\r\n    result=el[0].text;\r\n}\r\nresult;";
        private string daily_bonus_kapa_s = "var el5=document.getElementsByClassName(\"popup_box show\");\r\nvar el6=el5[0].getElementsByTagName(\"a\");\r\nel6[0].click();";
        private string genel_bakisa_git = "var el=document.querySelector(\"[href*='/game.php?village=']\");\r\nel.click();";
        private string ilgili_koyu_sec = @"var el=document.getElementById(""production_table"");if(el!=null){{var el2=el.querySelectorAll(""[class='quickedit-label'][data-text]"");el2[{0}].click();}}";
        public string haritaya_git= @"var el=document.querySelector(""[href*='map']"");el.click();";
        private string barbar_yazdir = @"var el=document.querySelector(""[type='radio'][name='target_type'][value='village_name']"");el.click();var inputElement = document.querySelector('.target-input-field');inputElement.value = ""Barbar Köy"";var event = new Event('input', {'bubbles': true,'cancelable': true});inputElement.dispatchEvent(event);";
        private string barbar_genislet = @"var el=document.getElementsByClassName(""village-item village-more"");el[0].click();";
        private string barbar_liste_dondur = @"var villageItems = document.querySelectorAll('.village-item');
var allInfo = [];  // Bilgileri saklamak için bir dizi

villageItems.forEach(function(villageItem, index) {
    // Eğer bu eleman son eleman değilse işleme devam et
    if (index !== villageItems.length - 1) {
        var villageName = villageItem.querySelector('.village-name').textContent;
        var villageInfo = villageItem.querySelector('.village-info').textContent;
        var villageDistance = villageItem.querySelector('.village-distance').textContent;

        // Her bir village-item için bilgileri diziye ekleyin
        allInfo.push(villageName, villageInfo, villageDistance);
    }
});
allInfo.join("","");";

        public string ictima_meydanı = @"var el=document.querySelector(""[href*='place']"");el.click();";
        private string casus_gonder = @"var el=document.querySelector(""[type='text'][class='target-input-field target-input-autocomplete ui-autocomplete-input']"");el.value=""{0}"";var el=document.querySelector(""[id='unit_input_spy'][name='spy']"");el.value=""1"";var el=document.querySelector(""[id='target_attack'][type='submit']"");el.click();";
        private string kilic_mizrak_gonder = @"var el=document.querySelector(""[type='text'][class='target-input-field target-input-autocomplete ui-autocomplete-input']"");el.value=""{0}"";var el=document.querySelector(""[id='unit_input_spy'][name='spy']"");el.value=""0"";var el=document.querySelector(""[id='unit_input_spear'][name='spear']"");el.value=""{1}"";var el=document.querySelector(""[id='unit_input_sword'][name='sword']"");el.value=""{2}"";var el=document.querySelector(""[id='target_attack'][type='submit']"");el.click();";

        private string casus_gonder_onay = @"var el=document.getElementById(""troop_confirm_submit"");el.click();";
        private string send_troop_check = @"var el=document.querySelector(""[class='place-confirm-new-attack']"");el;";
        
        
        public string yagma_asistanina_git = "var el=document.getElementById(\"manager_icon_farm\");el.click();";
        private string mevcut_asker_sayilari = "var result=\"\";\r\nvar el=document.querySelectorAll(\"[class*='unit-item unit-item']\");\r\nfor (let index = 0; index < el.length; index++) {\r\n    result=result+el[index].textContent+\",\";\r\n}\r\nresult;";
        private string a_birimleri = "var result=\"\";\r\nvar el=document.querySelectorAll(\"[name*='spear'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='sword'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='axe'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='spy'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='light'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='heavy'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nresult;";
        private string b_birimleri = "var result=\"\";\r\nvar el=document.querySelectorAll(\"[name*='spear'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='sword'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='axe'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='spy'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='light'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='heavy'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nresult;";


      
        //private string a_birimleri = "var result=\"\";\r\nvar el=document.querySelectorAll(\"[name*='spear'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='sword'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='axe'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='spy'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='light'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='heavy'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='knight'][type='text']\");\r\nresult=result+el[0].value+\",\";\r\nresult;";
        //private string b_birimleri = "var result=\"\";\r\nvar el=document.querySelectorAll(\"[name*='spear'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='sword'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='axe'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='spy'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='light'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='heavy'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nvar el=document.querySelectorAll(\"[name*='knight'][type='text']\");\r\nresult=result+el[1].value+\",\";\r\nresult;";



        private string yagma_mesafeler = @"var result="""";
var el=document.querySelectorAll(""[id*='village_'][class*='report_']"");
for (let index = 0; index < el.length; index++) {
    var temp_vil=el[index];
    result=result+temp_vil.querySelector(""td:nth-child(8)"").textContent+"","";
}
result;";
        private string yagma_surlar = @"var result="""";
var el=document.querySelectorAll(""[id*='village_'][class*='report_']"");
for (let index = 0; index < el.length; index++) {
    var temp_vil=el[index];
    result=result+temp_vil.querySelector(""td:nth-child(7)"").textContent+"","";
}
result;";
        private string yagma_element_idleri = @"var result="""";
var el=document.querySelectorAll(""[id*='village_'][class*='report_']"");
for (let index = 0; index < el.length; index++) {
    var temp_vil=el[index];
    result=result+temp_vil.getAttribute(""id"")+"","";
}
result;";
        private string a_buttons = "var el=document.querySelectorAll(\"[class*='farm_icon farm_icon_a']\");el=Array.from(el);el=el.slice(1);";
        private string b_buttons = "var el=document.querySelectorAll(\"[class*='farm_icon farm_icon_b']\");el=Array.from(el);el=el.slice(1);";
        private string c_buttons = "var el=document.querySelectorAll(\"[class*='farm_icon farm_icon_c']\");el;";

        private string a_ya_tikla = "var el=document.querySelectorAll(\"[class*='farm_icon farm_icon_a']\");el=Array.from(el);el=el.slice(1);el[{0}].click();";
        private string b_ye_tikla = "var el=document.querySelectorAll(\"[class*='farm_icon farm_icon_b']\");el=Array.from(el);el=el.slice(1);el[{0}].click();";



        private string sonraki_sayfa = "var el=document.querySelectorAll(\"[class='paged-nav-item'][href*='Farm_page=']\");el[{0}].click();";
        private string onceki_sayfa = "var el=document.querySelectorAll(\"[class='paged-nav-item'][href*='Farm_page=']\");el[0].click();";
        private string sayfadaki_yagma_sayisi_s = "var el=document.getElementById(\"farm_pagesize\");el.value;";
        private string sayfa_sayisi_s = "var el=document.querySelectorAll(\"[class='paged-nav-item'][href*='Farm_page=']\");el.length;";
        private string mevcut_sayfa_s = "document.getElementsByTagName(\"strong\")[0].innerText.charAt(1);";




        #region

        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private object _;

        public web()
        {
            InitializeComponent();
            this.webView = this.webView21;
            
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }



        public async Task giris_yap(string id, string pw)
        {

            await script_uygula(giris_yap_s,id,pw);
            var result=await script_uygula(giris_basarili_mi);
            if (result.ToString() == "false") {
                Thread.Sleep(5000);
                await giris_yap(id,pw);
            }
            
            
        }

        private async Task sayfa_hazir_waitAsync()
        {
            string txt = string.Empty;
            int timeout = 0;
            while (true)
            {
                txt = await webView.ExecuteScriptAsync(sayfa_yuklendi_mi);

                if (txt == "\"complete\"") { break; }
                else
                {
                    timeout++;
                    if (timeout > 900000000)
                    {
                        await webView.ExecuteScriptAsync(reload);
                        timeout = 0;
                    }
                }
            }
        }




        public async Task<object> script_uygula(string sc)
        {
            await sayfa_hazir_waitAsync();
            var result = await webView.ExecuteScriptAsync(sc);
            await sayfa_hazir_waitAsync();
            return result;
        }
        public async Task<object> script_uygula(string sc, string arg1)
        {
            await sayfa_hazir_waitAsync();
            string hzr = string.Format(sc, arg1);
            var result = await webView.ExecuteScriptAsync(hzr);
            await sayfa_hazir_waitAsync();
            return result;
        }
        public async Task<object> script_uygula(string sc, string arg1, string arg2)
        {
            await sayfa_hazir_waitAsync();
            string hzr = string.Format(sc, arg1, arg2);
            var result = await webView.ExecuteScriptAsync(hzr);
            await sayfa_hazir_waitAsync();
            return result;

        }
        public async Task<object> script_uygula(string sc, string arg1, string arg2, string arg3)
        {
            await sayfa_hazir_waitAsync();
            string hzr = string.Format(sc, arg1, arg2, arg3);
            var result = await webView.ExecuteScriptAsync(hzr);
            await sayfa_hazir_waitAsync();
            return result;
        }


        public async Task<string> mevcut_dunya_getir()
        {

            var result = (string)await script_uygula(mevcut_dunyalar);


            return result;

        }

        public async Task<Boolean> giris_kontrol()
        { 
            int timeout = 0;
            
            var result = (string)await script_uygula("var el=document.getElementById(\"menu_row\");el;");
            while (result == "null")
            {
                result = (string)await script_uygula("var el=document.getElementById(\"menu_row\");el;");
                timeout++;
                if (timeout > 900000000) { 
                return false;
                
                }
            }

            return true;

        }

        public async Task daily_bonus_kapa(Func<string,Task<string>>f,string arg )
        {
            var result =await script_uygula(daily_bonus_kapa_s);
            await f(arg);//null check yapılabilir.
        
        }

        public async Task ilgili_koyu_sec_f(int i)
        {
            await script_uygula(genel_bakisa_git);
            await script_uygula(ilgili_koyu_sec, i.ToString());

        }




        public async Task<Dictionary<int,List<string>>> barbar_liste_dondur_f()
        {
            var barbar_dict=new Dictionary<int,List<string>>();
            var barbar_bilgi=new List<string>();

            await script_uygula(haritaya_git);
            await script_uygula(barbar_yazdir);

            for (int i = 0; i < 10; i++)
            {
                await script_uygula(barbar_genislet);
                Thread.Sleep(2000);
            }


            string return_res= (string)await script_uygula(barbar_liste_dondur);
            return_res = return_res.Remove(return_res.Length - 1, 1);
            return_res = return_res.Remove(0, 1);
            var bilgi=return_res.Split(',');


            for (int i = 3; i < bilgi.Length; i=i+3)
            {
                string x_y_koordinat= bilgi[i - 3].Substring(13, 7);
                //string y = x.Substring(4, 3);
              //  x =x.Substring(0, 3);
                barbar_bilgi.Add(x_y_koordinat);
                //barbar_bilgi.Add(y);

                string alan = bilgi[i-1].Split(new char[] {' '})[1];
                barbar_bilgi.Add((string)alan);


            }
            int index = 0;
            for (int i = 0; i < barbar_bilgi.Count-2; i=i+2)
            {
                barbar_dict[index] = (List<string>)[barbar_bilgi[i], barbar_bilgi[i + 1]];
                index++;
            }

            return barbar_dict;
        }

        public async Task casus_gonder_f(Dictionary<int, List<string>> barbar_dict,int mesafe)
        {
            for (int i = 0; i < barbar_dict.Keys.Count; i++)
            {
                var temp_koy = barbar_dict[i];
                if (int.Parse(temp_koy[1])<=mesafe) {

                    await script_uygula(casus_gonder, temp_koy[0]);

                    var result = (string)await script_uygula(send_troop_check);
                    while (result == "null")
                    {
                        result = (string)await script_uygula("var el=document.getElementById(\"menu_row\");el;");
                      

                    }

                    await script_uygula(casus_gonder_onay);
                }


            }
        }


        public async Task kilic_mizrak_gonder_f(Dictionary<int, List<string>> barbar_dict, int mesafe,int mizrak,int kilic)
        {
            for (int i = 0; i < barbar_dict.Keys.Count; i++)
            {
                var temp_koy = barbar_dict[i];
                if (int.Parse(temp_koy[1]) <= mesafe)
                {

                    await script_uygula(kilic_mizrak_gonder, temp_koy[0],mizrak.ToString(),kilic.ToString());

                    var result = (string)await script_uygula(send_troop_check);
                    while (result == "null")
                    {
                        result = (string)await script_uygula("var el=document.getElementById(\"menu_row\");el;");


                    }

                    await script_uygula(casus_gonder_onay);
                }


            }
        }
        #endregion
        public async Task yagma_yap_sayfada(int sur_seviyesi,int mesafe,int yagma_birim, bool okcu_varmi)
        {   
          
            int spear, sword, axe, spy, light, heavy, knight = 0;
            int spear_a, sword_a, axe_a, spy_a, light_a, heavy_a, knight_a = 0;

            List<string> mevcut_asker = new List<string>();
            List<string> yagma_askerleri= new List<string>();
            List<string> yagma_koy_idleri = new List<string>();
            List<string> yagma_mesafeler_l = new List<string>();
            List<string> yagma_surlar_l = new List<string>();
            List<string[]> yagma_koy_bilgileri = new List<string[]>();
            int sayfadaki_yagma_sayisi = 0;
            int sayfa_sayisi = 0;
            int mevcut_sayfa = 0;


            string temp_koy_id = ((string)await script_uygula(yagma_element_idleri));
            //temp_koy_id = temp_koy_id.Remove(temp_koy_id.Length - 2, 2);
            //temp_koy_id = temp_koy_id.Remove(0, 1);
            //yagma_koy_idleri=temp_koy_id.Split(new char[] { ',' }).ToList();
            yagma_koy_idleri = tirnak_sil(temp_koy_id);

            string temp_koy_mesafe = ((string)await script_uygula(yagma_mesafeler));
            //temp_koy_mesafe = temp_koy_mesafe.Remove(temp_koy_mesafe.Length - 2, 2);
            //temp_koy_mesafe = temp_koy_mesafe.Remove(0, 1);
            //yagma_mesafeler_l = temp_koy_mesafe.Split(new char[] { ',' }).ToList();
            yagma_mesafeler_l = tirnak_sil(temp_koy_mesafe);


            string temp_koy_sur = ((string)await script_uygula(yagma_surlar));
            
            //temp_koy_sur = temp_koy_sur.Remove(temp_koy_sur.Length - 2, 2);
            //temp_koy_sur = temp_koy_sur.Remove(0, 1);
            //yagma_surlar_l = temp_koy_sur.Split(new char[] { ',' }).ToList();
            yagma_surlar_l = tirnak_sil(temp_koy_sur);
           
            while (yagma_surlar_l.Contains("?") )
            {
                yagma_surlar_l[yagma_surlar_l.IndexOf("?")] = "99";
            }
            

            sayfadaki_yagma_sayisi = int.Parse(tirnak_sil_virgulsuz((string)await script_uygula(sayfadaki_yagma_sayisi_s)));

            for (int i = 0; i < yagma_koy_idleri.Count; i++)
            {
                bool a_birim_yeterli = false;
                var list_mevcut_askerler = tirnak_sil((string)await script_uygula(mevcut_asker_sayilari));
                var list_a_asker_sayiları = tirnak_sil((string)await script_uygula(a_birimleri));
                var list_b_asker_sayiları = tirnak_sil((string)await script_uygula(b_birimleri));

                if (okcu_varmi)
                {
                    list_mevcut_askerler[3] = list_mevcut_askerler[4];
                    list_mevcut_askerler[4] = list_mevcut_askerler[5];
                }

                if (int.Parse(yagma_surlar_l[i]) > sur_seviyesi)
                {
                    continue;
                }
                if (Double.Parse(yagma_mesafeler_l[i], CultureInfo.InvariantCulture) > mesafe)
                {
                    continue;
                }

                if (!asker_var_mi(list_mevcut_askerler, list_a_asker_sayiları,1))//a da hafif atlı casus b de mizrak kılıc 0 sa sadece a 1se sadece b
                {
                    if (yagma_birim==0)
                    {
                        break;
                    }
                    else
                    {
                        a_birim_yeterli=false;
                    }
                    
                }
                else
                {
                    a_birim_yeterli=true;

                    //burda a dan asker gönder
                    await script_uygula(a_ya_tikla, i.ToString());
                    Thread.Sleep(500);
                }

                if ((!a_birim_yeterli)&& yagma_birim == 1) //ada yeteri kadar asker yok ve mizrak gönderme açık
                {
                    // mizrak kontrolü yap ve b denbirim gönder
                    if(asker_var_mi(list_mevcut_askerler, list_b_asker_sayiları, 0))
                    {
                        //asker gönder
                        await script_uygula(b_ye_tikla, i.ToString());
                        Thread.Sleep(500);
                    }
                    else
                    {
                        break; //b de de asker yok bitir.
                    }
                }
                else
                {
                    if(!a_birim_yeterli)
                    {
                        break;// hem a da asker yok hem de
                    }
                     //abirim yeterli
                }
               
            }

            sayfa_sayisi = int.Parse((string)await script_uygula(sayfa_sayisi_s)) + 2;
            mevcut_sayfa = int.Parse(tirnak_sil_virgulsuz((string)await script_uygula(mevcut_sayfa_s)));
            if (sayfa_sayisi != 0 && mevcut_sayfa!=0)
            {
                sayfa_sayisi = sayfa_sayisi / 2;
                if (mevcut_sayfa != sayfa_sayisi)
                {
                    await script_uygula(sonraki_sayfa, (mevcut_sayfa - 1).ToString());
                    await yagma_yap_sayfada(sur_seviyesi, mesafe, yagma_birim, okcu_varmi); //
                }

            }



        }



        private List<string> tirnak_sil(string s)
        {
            try
            {

                if (s != "null")
                {
                    if (!s.Contains("\"\""))
                    {
                        // s içinde iki çift tırnak karakteri yok.
                    
                    s = s.Remove(s.Length - 2, 2);
                    s = s.Remove(0, 1);
                    return s.Split(new char[] { ',' }).ToList();
                    }
                    else
                    {
                        List<string> return_list = new List<string>();

                        return return_list;
                    }
                }
                else {
                    List<string>  return_list = new List<string>();
                   
                    return return_list; 
                }
            }
            catch (Exception)
            {


                return null;
            }

        }
        private string tirnak_sil_virgulsuz(string s)
        {
            if (s != "null") { 
            s = s.Remove(s.Length - 1, 1);
            s = s.Remove(0, 1);
            return s;
            }
            else { return "0"; }
        }

        private bool asker_var_mi(List<string> mevcut, List<string> a_birim,int mizrak_atli)
        {
            bool result=false;
                for (int i = 0; i < mevcut.Count - 1; i++)
                {
                    if (mizrak_atli == 0)   //hafif atlı casus a birimi
                    {
                        if (!(i == 0 || i == 1 || i == 3)) { continue; }
                    }
                    else if (mizrak_atli == 1) //sadece mizrak casus kılıç b birimi
                    {
                        if (!(i == 3 || i == 4)) { continue; }
                    }

                    int temp_mevcut = int.Parse(mevcut[i]);
                    int temp_a_birim = int.Parse(a_birim[i]);

                    if (temp_mevcut - temp_a_birim <= 0)
                    {
                        result = false;
                        return result;
                    }
                    else
                    {
                        result = true;
                    }
                }
                return result;
            }

        
    
    
    }
}
