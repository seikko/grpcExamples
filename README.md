 RPC: uzak sunucudaki metotları sanki kendi ortamının birer parçasıymış gibi çağırabilen sistemdir.
 gRPC : CPU, memory ve bandwidth kullanımının önemli ve kritik olduğu uygulamalarda JSON yerine binary formatta çalıştığı için tercih edilebilecek bir teknolojidir.
 gRPC Avantajları 
Http/1’e nazaran Http/2’yi kullanmaktadır. Böylece Http/2 stream desteği verebilmektedir.
TCP socket haberleşmesi sağlayabilmektedir.
Http/2 sayesinde binary serialization kullanmaktadır. Böylece text-based mesajlaşmaya nazaran oldukça hızlıdır.
Yapılan optimizasyonlar neticesinde Http/1 kullanan Restfull servislere nazaran 2.5 kat daha hızlı olduğu tespit edilmiştir. Http/1 ile Http/2 arasındaki hız farkını daha net görebilmek için http2demo.io adresindeki demoyu inceleyebilirsiniz.
Aynı bağlantı üzerinden birden fazla paralel request desteği sağlanmaktadır. Http/1’de ise bir request’e nazaran bir response söz konusudur.
Client ile server arasında çift yönlü iletişim vardır.
Moderndir.
Yukarıdaki özelliklerle birlikte birçok niteliğinden dolayı yüksek performanslıdır.
Default olarak Protocol Buffers kullanarak dilden bağımsız olacak şekilde birçok uygulama tarafından kullanılabilmektedir.
