using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiveDayGameProject
{
    interface GameRegisterIdentityService
    {
        void Register(GamerIdentityInfo gamer);
        void Login(GamerLoginInfo gamerLoginInfo);
        void Update();
        void GamerDelete(GamerLoginInfo gamerLoginInfo);
        void Sales(GameSalesInfo gameSalesInfo, GamerLoginInfo gamerLoginInfo);
    }
}
