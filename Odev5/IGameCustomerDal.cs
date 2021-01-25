using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface IGameCustomerDal
    {
        void Register();
        void Update();
        void Delete();
        

        void IdContol(GameCustomer gameCustomer);
           
    
    }
}
