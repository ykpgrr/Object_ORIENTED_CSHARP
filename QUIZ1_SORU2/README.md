Soru 2:

Bu uygulama aracılığı ile kişilere yazılmış cezalar ve ödeme bilgileri üzerinden sıralamalar
yapılacaktır.
İkinci soruda kullancağınız listeyi aşağıdaki fonksiyonu kullanarak elde edebilirsiniz.
İlk boyut cezalara temsil edecektir. Her bir ceza id değerine sahip ilk bilgi ile başlayacaktır. İd
değeri eşsiz bir değer taşımaktadır. Bunu kimlik numarası gibi düşünebilirsiniz. İkinci değer
ödenmiş miktar üçüncü değer ise toplamda alınmış cezadır.
Bir kişi birden fazla ceza almış olabilir. Bu bilgiler göz önüne alınarak ve kullanıcıdan alınan
istek doğrusunda
Sıralama seçeneği 1  Ceza alma sayısı en çok olan kişiden en az olana doğru kimlik
numaralarını ve aldıkları ceza sayılarını ekrana yazınız.
Sıralama seçeneği 2  Toplamda en fazla para cezası alandan en az alan kişiye doğru
sıralayanız ve aldıkları toplam para cezasını ekrana yazınız.
Sıralama seçeneği 3  Anlık olarak bakılınca ödenmeyi bekleyen borç miktarı en fazla olan
kişiden en az olana doğru sıralayanız ve ne kadar borçlarının olduğunu ekrana yazınız.
Sıralama seçeneği 4  numaralı operasyon olarak kişileri kimlik numaralarına göre sıralayınız
ve yanlarına hem aldıkları cezaların toplam tutarını hem ödedikleri toplam tutarı hem kalan
ödemeleri ve kaç adet cezaları olduğunu yazınız.
Adem : 500 370 130 (5 ceza)


 private static int[,] ArrayInitializer()
 {
 return new int[,] {
 { 1, 10, 10 }, { 2, 10, 20 }, { 3, 15, 100 }, { 4, 250, 300 },
 { 1, 50, 150 }, { 6, 47, 60 }, { 7, 50, 150 }, { 3, 0, 175 },
 { 3, 80, 145 }, { 8, 0, 250 }, { 9, 15, 45 }, { 4, 40, 40 },
 { 6, 8, 15 }, { 8, 60, 60 }, { 10, 50, 50 }, { 11 , 451, 452},
 {12, 15, 46 }, {13, 45, 55 }, {13, 50, 95}, {14, 55, 80},
 {10, 20, 50}, {15, 16, 46}, {16, 0, 450}, {17, 10, 100},
 {17, 5, 145 }, {2, 13, 23}, { 8, 95, 235 }, { 9, 70, 70 }
 };
 }
