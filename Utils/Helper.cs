using System;

namespace store.Utils
{
    public class Helper
    {
        public static string randomUserAvatar(){
            string folder = "/public/avatar";
            string[] avatars = {"vit01.jpg", "vit02.jpg", "vit03.jpg", "vit04.jpg", "vit05.jpg",
                                "vit06.jpg", "vit07.jpg", "vit08.jpg", "vit09.jpg", "vit10.jpg",
                                "vit11.jpg", "vit12.jpg", "vit13.jpg", "vit14.jpg", "vit15.jpg",
                                };
            Random random = new Random();
            int randomNumber = random.Next(15);
            return folder + "/" + avatars[randomNumber];
        }
    }
}