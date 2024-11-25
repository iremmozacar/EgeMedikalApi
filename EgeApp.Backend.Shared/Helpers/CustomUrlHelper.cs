﻿namespace EgeApp.Backend.Shared.Helpers
{
    public static class CustomUrlHelper
    {
        public static string GetUrl(string name)
        {
            //name: Tam Otomatik Immobile ICARDİ
            string result = name;
            result = result.Replace("İ", "i");
            result = result.Replace("I", "i");
            result = result.Replace("ı", "i");

            result = result.ToLower();//tam otomatik immobbile icardi

            result = result.Replace("ş", "s");
            result = result.Replace("ç", "c");
            result = result.Replace("ğ", "g");
            result = result.Replace("ü", "u");
            result = result.Replace("ö", "o");

            result = result.Replace(",", "");
            result = result.Replace(".", "");
            result = result.Replace("?", "");
            result = result.Replace(")", "");
            result = result.Replace("(", "");
            result = result.Replace("[", "");
            result = result.Replace("]", "");
            result = result.Replace("&", "");
            result = result.Replace("%", "");
            result = result.Replace("+", "");

            result = result.Replace(" ", "-");

            return result;

        }
    }
}
