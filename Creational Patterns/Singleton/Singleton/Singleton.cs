using System;


namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static Guid _id;
        private static object _lockObject = new object(); //Multithread uygulamalar için bir object tipinde nesne olusturulur

        public Guid id
        {
            get { return Singleton._id; }
        }

        /*
           Constructor metodu private yapılarak  
           Singleton s1 = new Singleton() şeklinde instance alınması engellenmiş olur.
        */
        private Singleton(Guid id)
        {
            _id = id;
        }

        public static Singleton GetInstance()
        {
            if (_instance == null) // Daha önce bir instance oluşturulup oluşturulmadığının kontrolü yapılır.
            {
                lock (_lockObject)  //içeride çalışacak olan bloğu senkronize hale getir(Thread safe)
                {
                    if (_instance == null)
                        _instance = new Singleton(Guid.NewGuid());//Olusturulmadıysa Yeni bir instance olusuturulur.
                }
            }       
            return _instance; //Önceden bulunuyorsa o instance geri döndürülür.

        }
    }
}
