using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiveDayGameProject
{
    class CheckGameManager : CheckGameService
    {


        public bool CheckIdentityGame(GamerIdentityInfo gamerInfo)
        {

            if (gamerInfo.FirstName == "emre" && gamerInfo.LastName == "ruşen" && gamerInfo.BirtYear == 2002 && gamerInfo.IdentityNumber == 111000)
            {
                Console.WriteLine("Kimlik Doğrulaması doğru");
                return true;
            }
            else
            {
                Console.WriteLine("Böyle bir kişi bulunamadı");
                return false;

            }

        }

        public bool CheckLoginGame(GamerLoginInfo gamerLoginInfo)
        {

            if (gamerLoginInfo.gamePassword == "123" && gamerLoginInfo.email == "@outlook.com")
            {
                return true;
            }
            else
            {
                return false;

            }

        }


  


     
    }
}
