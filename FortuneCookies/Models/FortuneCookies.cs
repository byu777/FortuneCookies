using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortuneCookies.Models
{
    public class FortuneCookies
    {
        static List<string> Cookies = new List<string>
        {
            "You are going to get married!",
            "You will find a new job!",
            "You will make new friends!",
            "You will be successful!",
            "You will make a lot of money"
        };

        public static string getCookie()
        {

            var random = new Random();
            int index = random.Next(Cookies.Count);
            return Cookies[index];

        }
    }
}
