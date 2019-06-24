# Abstract Factory Pattern
![DesignPatternNotları](/img/AbstractFactory.jpg)
### Notlar

- ``` Bir personel bilgi sistemi uygulamasında adres ve telefon bilgilerini yönetmeyi planladığımızı varsayalım. ```

- ``` İlk aklımıza gelen Adres ve telefon verilerini tutacak sınıfları yaratmak olacaktır. ```
- ``` Sınıflar girilen bilgileri ve pnların biçimlerini ilgili alanlarda tutar. ```
- ``` Örneğin Kuzey Amerikadaki tüm telefon numaraları 10 haneden oluşacak şekilde ve adres bilgileride belli koşullara dayanarak oluşturulmuştur.  ```
- ``` Sınıflarıoluşturduktan kısa bir süre sonra ,adres ve telefon numara bilgileri için olan koşulların başka bir ülke için (Hollanda ,İngiltere vs) düzenlenmesi gerektiğini fark ederiz. ```
- ``` Yani kişisel ağ genişledikçe farklı ülkelerin bilgilerini yönetmemiz gerekecektir. ```
- ``` Sınıfımızın kurallarına eklenen her yenş kod bloğu sınıfı koda boğacak ve sınıfın yönetimini zorlaştıracaktır. ```
- ``` Uygulamamız ve sınıflarımız yeni ülkelerin koşulları eklendikçe kırılganlaşacaktır. ```
- ``` Abstract factory kalıbı ile bunu çözebiliriz. ```