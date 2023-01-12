using System;
using System.Collections.Generic;
using System.Reflection;
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
            new List<System.Drawing.Image>();

        public System.Drawing.Image this[int id] => cardImages[id];

        public CardImagesList()
        {
            Type tCardImages = typeof(CardImages);
            PropertyInfo[] imageMembers = tCardImages.GetProperties();
            foreach (var img in imageMembers)
            {
                cardImages.Add((System.Drawing.Image)img.GetValue(null));
            }
            var imgClone = new List<System.Drawing.Image>(cardImages);
            imgClone.AddRange(new List<System.Drawing.Image>(cardImages));
            imgClone.Shuffle();
            cardImages = new List<global::System.Drawing.Image>(imgClone);
        }
    }
}
