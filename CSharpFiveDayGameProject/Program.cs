using System;

namespace CSharpFiveDayGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckGameService checkGameService = new CheckGameManager();

            // kayit için gereken kimlik doğrulaması bilgileri
            GamerIdentityInfo gamerInfo1 = new GamerIdentityInfo();
            gamerInfo1.FirstName = "emre";
            gamerInfo1.LastName = "ruşen";
            gamerInfo1.BirtYear = 2002;
            gamerInfo1.IdentityNumber = 111000;


       
            //Oyuna giriş için oyun şifre e posta doğrulama bilgisi
            GamerLoginInfo gamerLoginInfo = new GamerLoginInfo();
            gamerLoginInfo.gamePassword = "123";
            gamerLoginInfo.email = "@outlook.com";


            //Oyun satış ve kimliğe tanımlama işlemi 
            GameSalesInfo gameSalesInfo = new GameSalesInfo();
            gameSalesInfo.game1 = "PUBG";
      





            GameRegisterIdentityService gameLoginService = new GameIdentityManager(checkGameService);
            //gameLoginService.Sales(gameSalesInfo,gamerLoginInfo);
            gameLoginService.GamerDelete(gamerLoginInfo);
    


        }
    }
}
