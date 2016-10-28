Soru 1:
İlk soru için aşağıda bulunan kodu kopyalayıp kullanarak program için gerekli olan iki boyutlu
diziyi oluşturunuz.
İki boyutlu dizi de bulunan bilgiler hata kodları olarak düşünülebilir. İlki hatanın majör değeri
ikincisi minör değeri olarak düşünülmelidir. İlk soru için sizden istenen sadece kullanıcıdan bu
bilgiyi ne şekilde sıralanmasının istendiğidir. Ve bu sıralama isteğine göre değerler sıralanıp
ekrana basılacaktır.
Sıralama seçeneği 1  En kritik hatadan en az kritik hataya göre sıralanma
Sıralama seçeneği 2  En az kritik hatadan en kritik hataya
Sıralama seçeneği 3  En sık rastlanan hatadan en nadir rastlanan hataya
Sıralama seçeneği 4  En nadir rastlanan hatadan en çok karşılaşılan hataya
 
 
 private static int[,] ArrayInitializer()
 {
 return new int[,] {
 { 5, 6 }, { 1, 2 }, { 1, 3 }, { 2, 2 }, {11, 7 }, { 5, 3 }, { 4, 11},
 {15, 8 }, {14, 2 }, { 3, 9 }, { 7, 4 }, { 6, 8 }, { 8, 6 }, { 9, 5 },
 {11, 3 }, {15, 5 }, {13, 15}, {18, 14}, { 5, 19}, {15, 16}, {15, 11},
 {13, 12}, {14, 5 }, { 1, 13}, { 8, 5 }, { 9, 7 }
 };
 }
