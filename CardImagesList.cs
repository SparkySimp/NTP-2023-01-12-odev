using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_2023_01_12_odev
{
    public static class Shuffler
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    public class CardImagesList
    {
        List<System.Drawing.Image> cardImages = 
            new List<System.Drawing.Image> 
            { CardImages.Img1, CardImages.Img2, CardImages.Img3, CardImages.Img4,
                CardImages.Img5, CardImages.Img6, CardImages.Img7, CardImages.Img8 };

        public System.Drawing.Image this[int id] => cardImages[id];

        public CardImagesList()
        {
            cardImages.Shuffle();
        }
    }
}
