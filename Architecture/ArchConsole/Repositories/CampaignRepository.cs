using ArchConsole.Models;
using System;

namespace ArchConsole.Repositories
{
    internal class CampaignRepository
    {
        public Campaign GetCampaign(int id)
        {
            return new Campaign { Id = id, Name = "Campaign" };
        }

        internal void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
