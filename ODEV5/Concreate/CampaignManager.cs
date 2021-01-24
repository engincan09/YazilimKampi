using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concreate
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            
            Console.WriteLine("Kampanya Oluşturuldu!" + " " + campaign.Title);
            campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
           
            Console.WriteLine("Kampanya Silindi" + " " + campaign.Title);
            campaigns.Remove(campaign);
        }
        

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi!" + " " + campaign.Title);
        }
    }
}
