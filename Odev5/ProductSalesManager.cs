using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class ProductSalesManager
    {
        public void Sales(GameCustomer gameCustomer, List<Campaign> campaigns)
        {
            Console.WriteLine("Satış gerçekleşti!!  "+" Oyun : "+gameCustomer.BuyProduct+ " Alan kişi :"+gameCustomer.FirstName+","+gameCustomer.LastName);
            Console.WriteLine("------------KAMPANYALAR----------------");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaingName);
            }
        }
    }
}
