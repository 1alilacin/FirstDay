using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        //hepsinin referansını tuttuğu için bunu kullanmalıyız
        //aynı zamanda ben bunu loglamak istersem
        //aynı anda birden fazla loglama işlemi kullanırken Listden yardım alırız diğer türlü tek olacağı zaman kredimanager gibi kullanılabilir
        {
           
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //program.csden hangi kredi gönderilirse o hesaplanır
            //hangi loglayıcı seçilmiş ise onu logla
        }

        //muster diyelim ki bana en uygun kredi hangisi onu öğrenmek istiyorum dediğinde seçilen krediler arasında hesaplama işlemi yapar
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //bana bir liste ver ama bunun türü IKrediManager olsun
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //listedeki her bir kredinin hesabını yap
            }
        }
    }
}
