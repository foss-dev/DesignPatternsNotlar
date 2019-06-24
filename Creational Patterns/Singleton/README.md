# Singleton Tasarım Kalıbı 
![DesignPatternNotları](/img/Singleton.jpg)
### Notlar

- ``` Singleton tasarım kalıbı Creational ,yani Nesnenin olusturulmasıyla ilgili bir tasarım kalıbıdır. ```

- ``` Uygulamamızda global bir nesneye ihtiyaç duyulabilir ```
- ``` Bu nesne heryerden erisilebilir olmalı, fakat sadece bir kez yaratılmalıdır.Uygulamamızın tüm parçalarının bu nesneyi kullanmasının mümkün olmasını fakat tümünün aynı instance'ı kullanmasını isteyebilirsiniz ```
- ``` Bunu başarmanın tek yolu Ana Uygulamada global bir nesne yaratılması ve sonrasında bu nesnenin referansını ihtiyaç olması durumunda geçirilmesidir. ```
- ``` Global değerlerin yaratılması için bir diğer yol ise static değişkenler kullanmaktır ```
-``` getInstance() metodu önceden yaratılmadıysa yeni tek bir instance yaratır ve singleton'un referansını bu nesneyi çağıran fonksiyona döndürür. ```