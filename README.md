# graduation-project
![ss1](https://user-images.githubusercontent.com/95189466/191696717-904dba61-7c15-4a1a-81aa-cc43f8a31497.PNG)

projede 4 controller bulunmaktadır;
Category Controller sınıfında get post ve put metodu ile kategori getirme ekleme ve güncelleme işlemlerini yapabiliyoruz. Gerçekleştirilen işlemler databasede de saklanmaktadır.
![image](https://user-images.githubusercontent.com/95189466/191698382-9fcbd11c-0ab5-4b6e-aab9-b503a9784637.png)

Product Controller sınıfında get ve post metodları ile ürünleri getirme ve ekleme işlemlerini yapabiliyoruz.Gerçekleştirilen işlemler databasede de saklanmaktadır. Category id ile de category ide ait ürünler gelmektedir.


Token Controller sınıfında ise email ve password istenerek token üretmesi gerekiyor fakat bunu başarılı bir şekilde uygulayamadım 400 hatası aldım günlerdir uğraştım falan 400 hatasını çözemedim hatta çözebilmek adına tek tek hocanın projesini de inceledim ama işin içinden çıkamadım. Bu sebeple token üretilemiyor.

![ss4](https://user-images.githubusercontent.com/95189466/191698850-fa4b2890-b704-46c2-aab8-3dcff0a6a6cb.PNG)


 User Controller sınıfında ise 2 adet post metodu kullanılmıştır. Biri giriş yapmak diğeri kaydolmak için token hatası nedeniyle başarılı şekilde giriş yapılamıyor fakat sign up olurken sorun yok istenilen bilgiler girildiğinde aynı şekilde database sınıfına şifrelenmiş olarak gelmektedir. Bu Controllerda md5 formatı ile şifreleme de bulunmaktadır ve başarılı bir şekilde çalışmaktadır.
 
 ![ss5](https://user-images.githubusercontent.com/95189466/191699181-83ad7899-2996-4eaa-8e11-ca1c430cddc1.PNG)

![ss6](https://user-images.githubusercontent.com/95189466/191699324-212a2479-faa4-4e2f-b93e-5bef1db4a7db.PNG)

İstenilen validasyonlarda validators üzerinde yer almaktadır. 
