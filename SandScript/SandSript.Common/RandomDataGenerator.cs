namespace SandSript.Data.Common
{
    using System;

    public class RandomDataGenerator : IRandomGenerator
    {
        public const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private Random random;

        public RandomDataGenerator()
        {
            random = new Random();
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max);
        }

        public string GetRandomString(int length)
        {
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = Letters[this.GetRandomNumber(0, Letters.Length - 1)];
            }

            return new string(result);
        }

        public string GetRandomStrigWithRandomLen(int min, int max)
        {
            return GetRandomString(GetRandomNumber(min, max));
        }
    }
}
