using ArchConsole.BLL;

namespace ArchConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userId = 1;

            // Получаем в объёт все данные, с которыми нужно будет работать на протяжении всего приложения.
            var appContext = new AppContext();
            appContext.InitObjectsByUserId(userId);


            var campaignExecutor = new CampaignExecutor(appContext.Campaign);
            campaignExecutor.DoSomething();

            var adGroupExecutor = new AdGroupExecutor(appContext.AdGroup);
            adGroupExecutor.DoSomething();

            var adExecutor = new AdExecutor(appContext.Ad);
            adExecutor.DoSomething();

            // Сохраняем все изменения
            appContext.Save();

        }
    }
}
