using System;

namespace CastleMod
{
    internal class Globalization
    {
        public static Random rand = new Random();
        public const string Chars = "abcdefghijkmnopqrstuvwxyz1234567890"; //too lazy to add capitals i'll just add them at random during string gen [lower_hex + 0x20]
    }
}