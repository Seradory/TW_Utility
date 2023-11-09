namespace KLANLAR_BOT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.process1 = new System.Diagnostics.Process();
            this.button_giris = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_otomatik_yagma = new System.Windows.Forms.Button();
            this.button_kesif_birligi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_maks_yagma_mesafesi = new System.Windows.Forms.TextBox();
            this.button_gizle_goster = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox_dunyalar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Dunya_Sec = new System.Windows.Forms.Button();
            this.listBox_Mevcut_Koyler = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_yagma_ayar_kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_Yagma_A = new System.Windows.Forms.CheckBox();
            this.checkBox_Yagma_B = new System.Windows.Forms.CheckBox();
            this.checkBox_Yagma_C = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_sari_yagma = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_max_sur_seviyesi = new System.Windows.Forms.TextBox();
            this.button_bilgiler = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_yagma_per = new System.Windows.Forms.TextBox();
            this.checkBox_okcu_var_mi = new System.Windows.Forms.CheckBox();
            this.button_kor_saldiri = new System.Windows.Forms.Button();
            this.button_tekil_kor = new System.Windows.Forms.Button();
            this.button_tekil_yagma = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_kor_kilic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_kor_mizrak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // button_giris
            // 
            this.button_giris.Location = new System.Drawing.Point(131, 92);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(75, 23);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "Giriş Yap";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(106, 30);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(106, 56);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(100, 20);
            this.textBox_pw.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // button_otomatik_yagma
            // 
            this.button_otomatik_yagma.Enabled = false;
            this.button_otomatik_yagma.Location = new System.Drawing.Point(615, 339);
            this.button_otomatik_yagma.Name = "button_otomatik_yagma";
            this.button_otomatik_yagma.Size = new System.Drawing.Size(160, 63);
            this.button_otomatik_yagma.TabIndex = 5;
            this.button_otomatik_yagma.Text = "Otomatik Yağma Başlat";
            this.button_otomatik_yagma.UseVisualStyleBackColor = true;
            this.button_otomatik_yagma.Click += new System.EventHandler(this.button_otomatik_yagma_Click);
            // 
            // button_kesif_birligi
            // 
            this.button_kesif_birligi.Enabled = false;
            this.button_kesif_birligi.Location = new System.Drawing.Point(292, 227);
            this.button_kesif_birligi.Name = "button_kesif_birligi";
            this.button_kesif_birligi.Size = new System.Drawing.Size(94, 46);
            this.button_kesif_birligi.TabIndex = 6;
            this.button_kesif_birligi.Text = "Keşif Birliği Gönder";
            this.button_kesif_birligi.UseVisualStyleBackColor = true;
            this.button_kesif_birligi.Click += new System.EventHandler(this.button_kesif_birligi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maksimum Yağma Mesafesi:";
            // 
            // textBox_maks_yagma_mesafesi
            // 
            this.textBox_maks_yagma_mesafesi.Enabled = false;
            this.textBox_maks_yagma_mesafesi.Location = new System.Drawing.Point(539, 53);
            this.textBox_maks_yagma_mesafesi.Name = "textBox_maks_yagma_mesafesi";
            this.textBox_maks_yagma_mesafesi.Size = new System.Drawing.Size(45, 20);
            this.textBox_maks_yagma_mesafesi.TabIndex = 7;
            this.textBox_maks_yagma_mesafesi.Text = "9";
            this.textBox_maks_yagma_mesafesi.TextChanged += new System.EventHandler(this.textBox_maks_yagma_mesafesi_TextChanged);
            // 
            // button_gizle_goster
            // 
            this.button_gizle_goster.Location = new System.Drawing.Point(30, 356);
            this.button_gizle_goster.Name = "button_gizle_goster";
            this.button_gizle_goster.Size = new System.Drawing.Size(90, 46);
            this.button_gizle_goster.TabIndex = 9;
            this.button_gizle_goster.Text = "Siteyi Göster";
            this.button_gizle_goster.UseVisualStyleBackColor = true;
            this.button_gizle_goster.Click += new System.EventHandler(this.button_gizle_goster_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox_dunyalar
            // 
            this.listBox_dunyalar.FormattingEnabled = true;
            this.listBox_dunyalar.Location = new System.Drawing.Point(226, 30);
            this.listBox_dunyalar.Name = "listBox_dunyalar";
            this.listBox_dunyalar.Size = new System.Drawing.Size(60, 134);
            this.listBox_dunyalar.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dünya Seçimi";
            // 
            // button_Dunya_Sec
            // 
            this.button_Dunya_Sec.Enabled = false;
            this.button_Dunya_Sec.Location = new System.Drawing.Point(226, 170);
            this.button_Dunya_Sec.Name = "button_Dunya_Sec";
            this.button_Dunya_Sec.Size = new System.Drawing.Size(60, 51);
            this.button_Dunya_Sec.TabIndex = 14;
            this.button_Dunya_Sec.Text = "Dünya Seç";
            this.button_Dunya_Sec.UseVisualStyleBackColor = true;
            this.button_Dunya_Sec.Click += new System.EventHandler(this.button_Dunya_Sec_Click);
            // 
            // listBox_Mevcut_Koyler
            // 
            this.listBox_Mevcut_Koyler.FormattingEnabled = true;
            this.listBox_Mevcut_Koyler.Location = new System.Drawing.Point(292, 30);
            this.listBox_Mevcut_Koyler.Name = "listBox_Mevcut_Koyler";
            this.listBox_Mevcut_Koyler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Mevcut_Koyler.Size = new System.Drawing.Size(94, 134);
            this.listBox_Mevcut_Koyler.TabIndex = 15;
            this.listBox_Mevcut_Koyler.SelectedIndexChanged += new System.EventHandler(this.listBox_Mevcut_Koyler_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Köy Seçimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seçili Köyün Yağma Ayarları";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_yagma_ayar_kaydet
            // 
            this.button_yagma_ayar_kaydet.Enabled = false;
            this.button_yagma_ayar_kaydet.Location = new System.Drawing.Point(292, 170);
            this.button_yagma_ayar_kaydet.Name = "button_yagma_ayar_kaydet";
            this.button_yagma_ayar_kaydet.Size = new System.Drawing.Size(94, 51);
            this.button_yagma_ayar_kaydet.TabIndex = 18;
            this.button_yagma_ayar_kaydet.Text = "Ayarları Kaydet";
            this.button_yagma_ayar_kaydet.UseVisualStyleBackColor = true;
            this.button_yagma_ayar_kaydet.Click += new System.EventHandler(this.button_yagma_ayar_kaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Yağmada Kullanılacak Birim:";
            // 
            // checkBox_Yagma_A
            // 
            this.checkBox_Yagma_A.AutoSize = true;
            this.checkBox_Yagma_A.Enabled = false;
            this.checkBox_Yagma_A.Location = new System.Drawing.Point(395, 119);
            this.checkBox_Yagma_A.Name = "checkBox_Yagma_A";
            this.checkBox_Yagma_A.Size = new System.Drawing.Size(73, 17);
            this.checkBox_Yagma_A.TabIndex = 20;
            this.checkBox_Yagma_A.Text = "Sadece A";
            this.checkBox_Yagma_A.UseVisualStyleBackColor = true;
            this.checkBox_Yagma_A.CheckedChanged += new System.EventHandler(this.checkBox_Yagma_A_CheckedChanged);
            // 
            // checkBox_Yagma_B
            // 
            this.checkBox_Yagma_B.AutoSize = true;
            this.checkBox_Yagma_B.Checked = true;
            this.checkBox_Yagma_B.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Yagma_B.Enabled = false;
            this.checkBox_Yagma_B.Location = new System.Drawing.Point(395, 142);
            this.checkBox_Yagma_B.Name = "checkBox_Yagma_B";
            this.checkBox_Yagma_B.Size = new System.Drawing.Size(98, 17);
            this.checkBox_Yagma_B.TabIndex = 21;
            this.checkBox_Yagma_B.Text = "A ve B Beraber";
            this.checkBox_Yagma_B.UseVisualStyleBackColor = true;
            // 
            // checkBox_Yagma_C
            // 
            this.checkBox_Yagma_C.AutoSize = true;
            this.checkBox_Yagma_C.Enabled = false;
            this.checkBox_Yagma_C.Location = new System.Drawing.Point(672, 385);
            this.checkBox_Yagma_C.Name = "checkBox_Yagma_C";
            this.checkBox_Yagma_C.Size = new System.Drawing.Size(33, 17);
            this.checkBox_Yagma_C.TabIndex = 22;
            this.checkBox_Yagma_C.Text = "C";
            this.checkBox_Yagma_C.UseVisualStyleBackColor = true;
            this.checkBox_Yagma_C.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sarı Köyleri Yağmala:";
            this.label8.Visible = false;
            // 
            // checkBox_sari_yagma
            // 
            this.checkBox_sari_yagma.AutoSize = true;
            this.checkBox_sari_yagma.Checked = true;
            this.checkBox_sari_yagma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sari_yagma.Enabled = false;
            this.checkBox_sari_yagma.Location = new System.Drawing.Point(502, 80);
            this.checkBox_sari_yagma.Name = "checkBox_sari_yagma";
            this.checkBox_sari_yagma.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sari_yagma.TabIndex = 24;
            this.checkBox_sari_yagma.UseVisualStyleBackColor = true;
            this.checkBox_sari_yagma.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Maksimum Sur Seviyesi:   <=";
            // 
            // textBox_max_sur_seviyesi
            // 
            this.textBox_max_sur_seviyesi.Enabled = false;
            this.textBox_max_sur_seviyesi.Location = new System.Drawing.Point(540, 80);
            this.textBox_max_sur_seviyesi.Name = "textBox_max_sur_seviyesi";
            this.textBox_max_sur_seviyesi.Size = new System.Drawing.Size(45, 20);
            this.textBox_max_sur_seviyesi.TabIndex = 25;
            this.textBox_max_sur_seviyesi.Text = "1";
            this.textBox_max_sur_seviyesi.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_bilgiler
            // 
            this.button_bilgiler.Location = new System.Drawing.Point(672, 42);
            this.button_bilgiler.Name = "button_bilgiler";
            this.button_bilgiler.Size = new System.Drawing.Size(90, 46);
            this.button_bilgiler.TabIndex = 27;
            this.button_bilgiler.Text = "Kurulum Notları";
            this.button_bilgiler.UseVisualStyleBackColor = true;
            this.button_bilgiler.Click += new System.EventHandler(this.button_bilgiler_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Yağma Periyodu(sn):";
            // 
            // textBox_yagma_per
            // 
            this.textBox_yagma_per.Enabled = false;
            this.textBox_yagma_per.Location = new System.Drawing.Point(499, 167);
            this.textBox_yagma_per.Name = "textBox_yagma_per";
            this.textBox_yagma_per.Size = new System.Drawing.Size(45, 20);
            this.textBox_yagma_per.TabIndex = 28;
            this.textBox_yagma_per.Text = "300";
            // 
            // checkBox_okcu_var_mi
            // 
            this.checkBox_okcu_var_mi.AutoSize = true;
            this.checkBox_okcu_var_mi.Enabled = false;
            this.checkBox_okcu_var_mi.Location = new System.Drawing.Point(395, 203);
            this.checkBox_okcu_var_mi.Name = "checkBox_okcu_var_mi";
            this.checkBox_okcu_var_mi.Size = new System.Drawing.Size(130, 17);
            this.checkBox_okcu_var_mi.TabIndex = 30;
            this.checkBox_okcu_var_mi.Text = "Dünyada Okçu Var mı";
            this.checkBox_okcu_var_mi.UseVisualStyleBackColor = true;
            // 
            // button_kor_saldiri
            // 
            this.button_kor_saldiri.Enabled = false;
            this.button_kor_saldiri.Location = new System.Drawing.Point(292, 279);
            this.button_kor_saldiri.Name = "button_kor_saldiri";
            this.button_kor_saldiri.Size = new System.Drawing.Size(94, 46);
            this.button_kor_saldiri.TabIndex = 31;
            this.button_kor_saldiri.Text = "Kör Saldırı Yap";
            this.button_kor_saldiri.UseVisualStyleBackColor = true;
            this.button_kor_saldiri.Click += new System.EventHandler(this.button_kor_saldiri_Click);
            // 
            // button_tekil_kor
            // 
            this.button_tekil_kor.Enabled = false;
            this.button_tekil_kor.Location = new System.Drawing.Point(292, 331);
            this.button_tekil_kor.Name = "button_tekil_kor";
            this.button_tekil_kor.Size = new System.Drawing.Size(94, 46);
            this.button_tekil_kor.TabIndex = 32;
            this.button_tekil_kor.Text = "Tekil Kör Saldırı Yap";
            this.button_tekil_kor.UseVisualStyleBackColor = true;
            this.button_tekil_kor.Click += new System.EventHandler(this.button_tekil_kor_Click);
            // 
            // button_tekil_yagma
            // 
            this.button_tekil_yagma.Enabled = false;
            this.button_tekil_yagma.Location = new System.Drawing.Point(615, 262);
            this.button_tekil_yagma.Name = "button_tekil_yagma";
            this.button_tekil_yagma.Size = new System.Drawing.Size(160, 63);
            this.button_tekil_yagma.TabIndex = 33;
            this.button_tekil_yagma.Text = "Tekil Yağma Başlat";
            this.button_tekil_yagma.UseVisualStyleBackColor = true;
            this.button_tekil_yagma.Click += new System.EventHandler(this.button_tekil_yagma_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Kılıç Sayısı:";
            // 
            // textBox_kor_kilic
            // 
            this.textBox_kor_kilic.Enabled = false;
            this.textBox_kor_kilic.Location = new System.Drawing.Point(465, 308);
            this.textBox_kor_kilic.Name = "textBox_kor_kilic";
            this.textBox_kor_kilic.Size = new System.Drawing.Size(45, 20);
            this.textBox_kor_kilic.TabIndex = 36;
            this.textBox_kor_kilic.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Mizrak Sayısı:";
            // 
            // textBox_kor_mizrak
            // 
            this.textBox_kor_mizrak.Enabled = false;
            this.textBox_kor_mizrak.Location = new System.Drawing.Point(465, 286);
            this.textBox_kor_mizrak.Name = "textBox_kor_mizrak";
            this.textBox_kor_mizrak.Size = new System.Drawing.Size(45, 20);
            this.textBox_kor_mizrak.TabIndex = 34;
            this.textBox_kor_mizrak.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_kor_kilic);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_kor_mizrak);
            this.Controls.Add(this.button_tekil_yagma);
            this.Controls.Add(this.button_tekil_kor);
            this.Controls.Add(this.button_kor_saldiri);
            this.Controls.Add(this.checkBox_okcu_var_mi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_yagma_per);
            this.Controls.Add(this.button_bilgiler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_max_sur_seviyesi);
            this.Controls.Add(this.checkBox_sari_yagma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_yagma_ayar_kaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_Mevcut_Koyler);
            this.Controls.Add(this.button_Dunya_Sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_dunyalar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_gizle_goster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_maks_yagma_mesafesi);
            this.Controls.Add(this.button_kesif_birligi);
            this.Controls.Add(this.button_otomatik_yagma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_Yagma_C);
            this.Controls.Add(this.checkBox_Yagma_B);
            this.Controls.Add(this.checkBox_Yagma_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_kesif_birligi;
        private System.Windows.Forms.Button button_otomatik_yagma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_maks_yagma_mesafesi;
        private System.Windows.Forms.Button button_gizle_goster;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox_dunyalar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Dunya_Sec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Mevcut_Koyler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_yagma_ayar_kaydet;
        private System.Windows.Forms.CheckBox checkBox_Yagma_C;
        private System.Windows.Forms.CheckBox checkBox_Yagma_B;
        private System.Windows.Forms.CheckBox checkBox_Yagma_A;
        private System.Windows.Forms.CheckBox checkBox_sari_yagma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_max_sur_seviyesi;
        private System.Windows.Forms.Button button_bilgiler;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_yagma_per;
        private System.Windows.Forms.CheckBox checkBox_okcu_var_mi;
        private System.Windows.Forms.Button button_kor_saldiri;
        private System.Windows.Forms.Button button_tekil_yagma;
        private System.Windows.Forms.Button button_tekil_kor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_kor_kilic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_kor_mizrak;
    }
}

