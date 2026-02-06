# Öğrenci Sınav Çalışma Projesi

Bu proje, öğrencilerin seçtikleri dersler üzerinden deneme sınavları çözebileceği,
Windows Forms ve SQL Server kullanılarak geliştirilmiş bir sınav çalışma sistemidir.

Proje; kullanıcı girişi, ders seçimi, sınav türü seçimi (TYT / AYT) ve süreli soru çözme
mantığı üzerine kuruludur.

## Özellikler

- Kullanıcı kayıt (Üye Ol) ve giriş sistemi
- Kullanıcıya özel ders seçimi
- Seçilen derslere göre sınav türü (TYT / AYT) seçimi
- Sınav sırasında süre takibi
- Doğru / yanlış sayacı
- Soruların sırayla gösterilmesi
- Sınav bitiminde sonuç ekranı

## Uygulama Akışı

1. Kullanıcı sisteme giriş yapar
2. Daha önce ders seçmediyse ders seçim ekranına yönlendirilir
3. Seçilen dersler ana sayfada listelenir
4. Ders ve sınav türü seçilir
5. Sorular ekranda sırayla gösterilir
6. Süre, doğru ve yanlış sayıları anlık takip edilir
7. Sınav tamamlandığında sonuç gösterilir

## Kullanılan Teknolojiler

- C# (Windows Forms)
- SQL Server
- ADO.NET
- Timer (süre takibi)

## Veritabanı Yapısı (Özet)

- **Tbl_Kullanicilar**  
  Kullanıcı adı ve şifre bilgileri

- **Tbl_Ogrenciler**  
  Kullanıcıya atanmış dersler

- **Tbl_Sorular**  
  Ders, sınav türü, soru metni, şıklar ve doğru cevap
<img width="716" height="439" alt="Sorular_Ekrani" src="https://github.com/user-attachments/assets/47c66d84-f17f-41f3-84c7-01f31b1733d4" />
<img width="715" height="409" alt="Sinav_Secme_Ekrani" src="https://github.com/user-attachments/assets/bec1a40d-8eca-4c68-b5ee-dd0822d39bc5" />
<img width="544" height="420" alt="Giris_Ekrani" src="https://github.com/user-attachments/assets/4e972c3d-0b61-4f2e-b063-f11a068516c6" />
<img width="657" height="442" alt="Ders_Secme_Ekrani" src="https://github.com/user-attachments/assets/40ea4559-0a34-42d9-a47a-eb974ab2dd5b" />
<img width="465" height="343" alt="Uye_Ol_Ekrani" src="https://github.com/user-attachments/assets/1129ed3f-d5a7-4b4a-b584-0d31ce26d909" />


## Notlar

Bu proje pratik amaçlı geliştirilmiştir.
Kod yapısı özellikle sade tutulmuş, WinForms ve SQL mantığını pekiştirmeye odaklanılmıştır.
