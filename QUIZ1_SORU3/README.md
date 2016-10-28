Soru 3:

Bu soru için permütasyon bilgilerinizi hatırlamanız gerekmektedir.
Sorunun anlaşılması için bir örnek üzerinden soru anlatılacaktır. Sorunun çözümü sırasında kod
akışı kısmını inceleyiniz.
Örnek :
Sayısal loto için 1-49 arasında 6 adet sayı seçilebilmektedir. Bu da demek oluyor ki (
49
6
) farklı
seçilim yapılabilmektedir. Fakat loto oynayacak kişi 2 adet şanslı sayı belirler ve bunları her
loto oynadığı zaman kullanırsa oluşabilecek farklı seçilim sayısı (
47
4
) şeklinde olacaktır. Veya
eğer 3 şanssız sayı belirler ve bunlarla hiç oynamazsa seçilim sayısı (
46
6
) şeklinde
belirlenebilmektedir.
Kod akışı:
 Kullanıcıdan maximum ve minimum değerler alınacaktır (Maximum değerin minimum
değerden büyük olduğunu kontrol ediniz)
 Kaç adet sayı seçileceğini kullanıcıdan alınız ( 51 - 70 arasında sayılar seçilecekse
20den daha az sayı seçilecektir ki şans faktörü oluşsun)
 Bir önceki adım tamamlandıktan sonra kaç farklı seçilim yapılabileceği ekrana
yazılacaktır. (51-70 arasında seçilim yapılacak ve 2 sayı seçilecekse 380 farklı seçilim
yapılabilir)
 Daha sonra kaç defa oynamak istediğini kullanıcıya soracağız. (Bir önceki durum göz
önüne alındığı zaman 380 defadan fazla oynayamaz)
 Kaç defa oynamak istediğini de öğrendikten sonra bir fonksiyon aracılığı ile kaç tane
şanslı sayı girebileceği hesaplayıp ekrana bu bilgiyi gösteriniz.
 Kullanıcıya şanlı numarası varsa girmesini yoksa enter tuşuna basarak devam etmesini
söyleyiniz
o Eğer sayı girerse bu sayı saklanacak ve ekrana kaç tane daha şanslı numara
girebileceği söylenecek ve bu işlem yenilenecek
o Eğer kullanıcı enter tuşuna basarsa bir sonraki adıma geçebilirsiniz
 Şanssız numara girme hakkı varsa, kullanıcıya şanssız numarası varsa girmesini yoksa
enter tuşuna basarak devam etmesini söyleyiniz
o Kullanıcı şanssız numarasını girerse bu sayı saklanacak ve kaç tane daha şanssız
numara girebileceği ekrana basılacak
o Kullanıcı şanssız numara girmezse bir sonraki adıma geçebilirsiniz
 Son adım olarak oluşturulan kuponlar ekrana yazılacak
