using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiveDayGameProject
{
    class GameIdentityManager : GameRegisterIdentityService
    {
        CheckGameService _checkGameService;

        
        public GameIdentityManager(CheckGameService checkGameService)
        {
            _checkGameService = checkGameService;
        }

        //register
        public void Register(GamerIdentityInfo gamerInfo)
        {
            if (_checkGameService.CheckIdentityGame(gamerInfo) == true)
            {
                Console.WriteLine("Kayıt işlemi Başarılı");
            }
        }

       


        //Login
        public void Login(GamerLoginInfo gamerLoginInfo)
        {
            if (_checkGameService.CheckLoginGame(gamerLoginInfo) ==  true)
            {
                Console.WriteLine("Oyun giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı Şifre veya E-posta adresi");

            }


        }





        //delete
        public void GamerDelete(GamerLoginInfo gamerLoginInfo)
        {
            if (_checkGameService.CheckLoginGame(gamerLoginInfo) == true)
            {
                Console.WriteLine(gamerLoginInfo.email + " Hesap Silme işlemi Başarılı");

                gamerLoginInfo.email = null;
                gamerLoginInfo.gamePassword = null;


            }
            else
            {
                Console.WriteLine("Oyuna giriş yapılmamış Hesap silme arayüzü kullanıcıya sunulamaz");

            }
        }





       
        //uptade
        public void Update()
        {
            Console.WriteLine("Güncelleme işlemi Başarılı");
        }


        //Sales
        public void Sales(GameSalesInfo gameSalesInfo, GamerLoginInfo gamerLoginInfo)
        {

            if (_checkGameService.CheckLoginGame(gamerLoginInfo) == true)
            {
                Console.WriteLine("Satış  başarılı");

    
                gamerLoginInfo.Games = gameSalesInfo.game1;
                Console.WriteLine(gamerLoginInfo.email +  " hesabınıza oyun eklendi = " + gamerLoginInfo.Games);
            }
            else
            {
                Console.WriteLine("Öncelikle Oyuna bilgirilerinizle giriş yapmalısınız");

            }

        }
    }
}
