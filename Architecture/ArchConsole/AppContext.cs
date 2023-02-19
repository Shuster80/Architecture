using ArchConsole.Models;
using ArchConsole.Repositories;

namespace ArchConsole
{
    internal class AppContext
    {
        public User User { get; private set; }
        public Campaign Campaign { get; private set; }
        public AdGroup AdGroup { get; private set; }
        public Ad Ad { get; private set; }


        public void InitObjectsByUserId(int id)
        {
            InitUser(id);
            InitCampaign(User.Id);
            InitAdGroup(Campaign.Id);
            InitAd(AdGroup.Id);
        }

        public void InitUser(int id)
        {
            var userRepository = new UserRepository();
            User = userRepository.GetUser(id);
        }

        public void InitCampaign(int id)
        {
            var campaignRepository = new CampaignRepository();
            Campaign = campaignRepository.GetCampaign(id);
        }

        public void InitAdGroup(int id)
        {
            var adGroupRepository = new AdGroupRepository();
            AdGroup = adGroupRepository.GetAdGroup(id);
        }

        public void InitAd(int id)
        {
            var adRepository = new AdRepository();
            Ad = adRepository.GetAd(id);
        }

        public void Save()
        {
            var userRepository = new UserRepository();
            userRepository.Update(User);

            var campaignRepository = new CampaignRepository();
            campaignRepository.Update(Campaign);

            var adGroupRepository = new AdGroupRepository();
            adGroupRepository.Update(AdGroup);

            var adRepository = new AdRepository();
            adRepository.Update(Ad);
        }
    }
}
