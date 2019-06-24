# Proxy Design Pattern

![DesignPatternNotları](/img/Proxy.jpg)

### Notlar :

- ``` Bir proxy (ya da stub) diğer nesnenin temsilcisidir. ```
- ``` Gerçek nesneyi sunmak amacıyla proxy'nin uygun hale getirilmesi için proxy gerçek nesnenin implemente ettiği arayüzü implemente etmek zorundadır. ```
- ``` Ek olarak , proxy gerçek nesne için bir referans sağlar. ```
- ``` Proxy, gerekli olduğunda gerçek nesne üzerindeki metotları çağırabilmek için gerçek nesnenin referansına ihtiyaç duyar. ```
- ``` Proxy tasarım kalıbında istemci sürekli olarak proxy ile etkileşim halindedir, fakat gerektiğinde proxy gerçek nesnenin çalıştırılmasını sağlayabilir. ```
- ``` Proxy gerçek nesne ile aynı arayüzü implemente eder (virtual proxy), fakat gerçek nesnenin yapmadığı uzaktan iletişim (remote proxy) ya da güvenlik(protection proxy) gibi görevleri de yapabilir. ```
- ``` Proxy gerçek nesne yerine kullanılan bir dublordür. ```
- ``` Kısaca tehlikeli sahneler sırasında proxy devereye girer ve uçaktan atlar veya ateş içinden geçer. ```
- ``` Proxy tasarım kalıbı özellikler yaratılması maliyetli ve birçok işlem yapan bir nesneyi taklit eden bir tasarım kalıbıdır. ```