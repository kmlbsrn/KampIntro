using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class CampaignManager
    {
    public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi!" + campaign.CampaingName);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi : "+campaign.CampaingName);
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampnya güncellendi"+campaign.CampaingName);
        }
    }
}
