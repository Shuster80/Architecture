using ArchConsole.Models;

namespace ArchConsole.BLL
{
    internal class CampaignExecutor
    {
        private Campaign _campaign;

        public CampaignExecutor(Campaign campaign)
        {
            _campaign = campaign;
        }

        public void DoSomething()
        {
            // Что-то делаем с объектом
        }
    }
}
