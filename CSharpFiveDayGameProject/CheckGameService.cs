using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFiveDayGameProject
{
    interface CheckGameService
    {
       bool CheckIdentityGame(GamerIdentityInfo gamerInfo);
       bool CheckLoginGame(GamerLoginInfo gamerLoginInfo);
       
    }
}
