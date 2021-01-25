using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GameCustomerManager
    {
        public void IdCheck(IGameCustomerDal gameCustomerDal,GameCustomer gameCustomer)
        {
            gameCustomerDal.IdContol(gameCustomer);
            }
        public void Update(IGameCustomerDal gameCustomerDal)
        {
            gameCustomerDal.Update();
        }

        public void Register(IGameCustomerDal gameCustomerDal)
        {
            gameCustomerDal.Register();
                    }
        public void Delete(IGameCustomerDal gameCustomerDal)
        {
            gameCustomerDal.Delete();
        }
    }
    
}
