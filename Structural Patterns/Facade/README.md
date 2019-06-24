# Facade Design Pattern

![DesignPatternNotları](/img/Facade.jpg)

### Notlar : 

- ``` Bir sistemi belirli sayıdaki özel sınıflara bölmek iyi bir nesne yönelimli tasarım pratiğidir. ```
- ``` Fakat, bir sistemin içerisinde çok fazla sayıda sınıfın olması da karmaşıklığı arttırabilir. ```
- ``` Çok fazla alt sisteme sahip olan bu sistemi kullanan istemciler daha fazla nesne ile başa çıkmak zorundadır. ```
- ``` Kullanıcılara yüzlerce yapılandırma seçeneği sunulduğunda kullanıcıların kafası karışır. ```
- ``` Örneğin bir araba üreticisi düşğnelim ve her türlü detayı kullanıcının opsiyonuna bırakmış olsun ```
- ``` Aracın yakıt yanarken kullanacağı hava/gaz oranını ayarlanmasını ya da aracın içerisindeki ateşleme sisteminin nasıl işletilmesi gerektiğini sürücünün tercihine bırakıldığını hayal edelim. ```
- ``` Bu durumda otomobilin her seferinde yeniden ayarlanması gerekir ve bu pratik değildir. ```
- ``` Sürücü olarak istenilen tek şey aracın anahtarını takmak ve aracı çalıştırmaktır. ```
- ``` Sistemin geriye kalanı sürücünün yerine halledilmelidir. ```
- ``` Facade, bu seçenekleri sağlayabilir ve hangi alt sistemin çağrılacağına karar verebilir. ```
- ``` Normalde Facade işin çoğunu alt sistemlere atar , fakat birkaç işi kendisi de yapabilmektedir. ```
- ``` Facade'ın asıl amacı alt sistemlerin saklanması değildir. ```
- ``` Amacı, bir dizi alt sistemi için bir arayüz sağlamaktır.Fakat daha ayrıntılı seşeneklere ihtiyaç duyan istemciler alt sistemlerle etkileşime geçebilmelidir.  ```
- ``` Facade ile birlikte Abstract Factory kullanılabilir.Abstract Factory alt sistemler için arayüz görevi görür. ```
- ``` Facade sınıfları genellikle singleton olarak gerçekleştirilir. ```
- ``` Her alt sistem için bir Facade şeklinde de tasarlanabilir. ```