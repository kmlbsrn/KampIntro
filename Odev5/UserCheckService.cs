using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class UserCheckService : IGameCustomerDal
    {
        public void Delete()
        {
            Console.WriteLine("silme işlemi tamamlandi");
        }



        public void Register()
        {
            Console.WriteLine("kayıt olma işlemi tamamlandı");
        }
        public void IdContol(GameCustomer gameCustomer)
        {
            Console.WriteLine("Id kontolü sağlandı, Hoşgeldin : "+gameCustomer.FirstName);
        }
        public void Update()
        {
            Console.WriteLine("Kullanıcı kayıt bilgileri güncellendi");
        }
    }
}
