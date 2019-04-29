using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://telegrambotapp.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "testBot";
        
        public static string Key { get; set; }  = "697473126:AAHq2K_ugx5T_crqoZE7N-cTC1USZHH4adk";

    }
}