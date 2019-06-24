# Factory Tasarım Kalıbı 
![DesignPatternNotları](/img/Factory.jpg)
### Notlar :
- ``` Günlük hayatta bazı varlıklar veya nesnelerin yaratılışları basittir.Ve bu tür nesneleri kendimiz bile yaratabiliriz.Örneğin basit bir zil veya pusulayı evde kendi kendimize yapabiliriz. ```

- ``` Oysa bazı varlıklar veya nesneler ise oldukça karmaşık süreçlerden geçilerek oluşturulmaktadır. ```

- ``` Nesne Yönelimli Programlama açısından da böyle bir durum söz konusudur. ```
- ``` Bazı nesneler doğrudan kullanıcısı tarafından yaratılabilmektedir.Bunun anlamı ,sınıfın constructor fonksiyonunu new opertaörü kullanarak nesnenin yaratılmasıdır. ```

- ``` Ancak bazı nesnelerin(Product) , kullanıcı(Client) olarak erişebileceğimiz başlangıç fonksiyonları bulunmamaktadır. ```

  ![DesignPatternNotları](/img/client-factory-product.png)

- ``` Client olan nesne, Factory nesnesini kullanarak ihtiyacı olan Product nesnesini elde eder.   ```

- ``` İstenen tipte yeni nesne olusturma sürecinin  Factory sınıfına aktarılması ile nesne oluşturma süreci Client'tan soyutlanmış olur. ```

- ``` Bu sayede Client; Uygulama içerisinde tamamen kendi rolüne odaklanmış olur, çünkü yeni nesnenin nasıl oluşturulacağına dair detaylardan soyutlanmış olur, bunları bilmek zorunda değildir. ```
### Factory Pattern Genel Olarak : 
- ``` İstenen tipte nesne oluşturma sürecini ,Client'ın bu konuda detaylı bilgi sahibi olmadan gerçekleştirilmesini sağlar. ```
- ``` Yeni oluşturulan nesneye bir interface ile referans edilerek ulaşılmasını sağlar. ```

### Factory Method: 

- **Product** : ``` Factory tarafından yaratılan nesnelerin arayüzüdür. ```
- **ConcreteProduct** : ``` Product arayüzünü implemente eden sınıftır.Bu sınıfın nesneleri ConcreteCreator tarafından yaratılır. ```
- **Creator** : ``` Factory metodunu/metodlarını tanımlayan arayüzdür. ```
- **ConcreteCreator** : ``` Creator sınıfını genişleten ve FactoryMethod için bir implementasyon sağlayan sınıf ```

### Özetle : 

``` Factory tasarım kalıbında, istemciyi normal şekilde nesne oluşturma mantığına maruz bırakmadan nesne oluşturulması sağlanır ve yeni yaratılan nesneye ortak bir arayüz kullanılarak erişilebilir.  ```