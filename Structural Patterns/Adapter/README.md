# Adapter Design Pattern

![DesignPatternNotları](/img/Adapter.jpg)

### Notlar :

- ``` Sizin geliştirdiğiniz bir uygulama için yabancı bir arkadaşınızla işbirliği yapmaya karar verdiğinizi varsayalım  ```

- ``` Arkadaşınız benzer bir projede çalışmakta ve size ticari uygulamanın bir bileşeni olan «adres sistemini» sağlayabilmektedir ```

- ```Fakat siz bu dosyaları aldığınızda, projenizde kullandığınız arayüzler ile dosyadaki arayüzlerin eşleşmediğini fark ettiniz. ```

- ``` Daha da kötü bir senaryo ise kod (değişkenler, fonksiyonlar, yorumlar) İngilizce değil, arkadaşınızın ana dilinde yazılmış.  ```

- ``` Böyle bir durumda kendinizi iki kötü çözümle karşı karşıya bulursunuz: ```

- ``` 1 - İlk seçeneğiniz: bileşenin yeniden yazılması ve böylece gereken tüm ara yüzleri implemente edilmesidir.  ```

- ```2 - uygulamanızı yeniden yazmak ve arkadaşınızın sağladığı bileşene uygun bir şekilde tasarlamaktır.   ```

- ``` Burada ihtiyacınız olan şey ise bir tercümandır.  ```

- ``` İşte bu da tam olarak Adapter tasarım kalıbının yaptığıdır.  ```

- ``` Bir güç adaptörüne benzer şekilde davranarak, bir tipi bir diğer – uyumsuz – tipe dönüştürür.  ```

- ``` Adapter tasarım kalıbı, temelde birbiriyle uyumsuz ancak aynı işi yapması öngörülen iki interface'in haberleştirilmesi için kullanılır ```

- ``` FrameWork : Adapter’i kullanan yapı. ```
- ``` Adapter : Framework’un kullanacağı metotları tanımlayan arayüz.```
- ``` Adaptee : Adapte edilecek tipin metotlarını tanımlayan arayüz. Bu arayüz, çalışma zamanında dinamik olarak belirli Adaptee’nin yüklenmesine izin verir. ```

