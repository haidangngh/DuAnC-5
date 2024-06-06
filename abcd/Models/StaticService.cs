using System.ComponentModel.DataAnnotations.Schema;

namespace abcd.Models
{
    public static class StaticService
    {
        static List<string>  listImg = new List<string>() {
            "img/iphone-15-pro-max_3.webp" ,
            "img/nubia-neo-5g_2_1.webp" ,
            "img/oppo-reno-11-f-xanh-2.webp" ,
            "img/samsung-galaxy-z-flip-5-256gb_1_5.webp" ,
            "img/tecno-pova-5_2_.webp" ,
            "img/xiaomi-redmi-note-12-pro-5g.webp" ,
        };

        public static string RandomImg ()
        {
            return listImg[new Random().Next(0, listImg.Count)];
        }
    
    }
}
