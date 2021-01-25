using System;
using System.Collections.Generic;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCustomer gameCustomer1 = new GameCustomer();
            gameCustomer1.Id = 432547543;
            gameCustomer1.FirstName = "kemal";
            gameCustomer1.LastName = "başaran";
            gameCustomer1.Password = "009966446_kml";
            gameCustomer1.BuyProduct = "God of War";
            gameCustomer1.ProductPrice = 320;

            GameCustomer gameCustomer2 = new GameCustomer();
            gameCustomer2.Id = 568930857;
            gameCustomer2.FirstName = "arif";
            gameCustomer2.LastName = "başaran";
            gameCustomer2.Password = "Zb.34564325";
            gameCustomer2.BuyProduct = "Red Dead Redemption 2";
            gameCustomer2.ProductPrice = 240;


            GameCustomerManager gameCustomerManager = new GameCustomerManager();
            
            
            Campaign campaign = new Campaign();
            campaign.CampaingName = "İlk giriş kampanyası %10";
            campaign.DisposableId = "45646fdsg55";

            Campaign campaign2 = new Campaign();
            campaign2.CampaingName = "İkincisi %50";
            campaign2.DisposableId = "a46843a2sf";

            Discount discount = new Discount();
            discount.Çarp(gameCustomer1.ProductPrice, gameCustomer2.ProductPrice, 10 , 50 );

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign); 



            List<Campaign> campaigns = new List<Campaign>() {campaign,campaign2 };

            ProductSalesManager productSalesManager = new ProductSalesManager();
            productSalesManager.Sales(gameCustomer1,campaigns);
        }
    }
}
