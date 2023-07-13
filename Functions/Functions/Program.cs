namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sayı tahmin oyunu:
             *   1. 1-100 arasında rastgele bir sayı seç.
             *   2. Kullanıcıdan sayıyı tahmin etmesini iste.
             *   3. Tahmin ile tutulan sayıyu karşılaştır.
             *      - Tahmin > tutulan ise "Aşağı"
             *      - Tahmin < tutulan     "Yukarı"
             *      - eşitse "Bildiniz"
             *   4. Bilemediyse 2.adıma dön
             *   5. Oyunu bitir.
             */
            int target = getRandomNumber(min: 1, max: 100);
            string compareResult = string.Empty;
            do
            {
                int suggest = getSuggestedNumberFromUser();
                compareResult = compareSuggestAndTarget(suggest, target);
                Console.WriteLine(compareResult);
            } while (compareResult != GameResults.Equal);
        }



        private static int getRandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }
        private static int getSuggestedNumberFromUser()
        {
            Console.Write("Sayıyı tahmin edin:");
            return int.Parse(Console.ReadLine());
        }
        private static string compareSuggestAndTarget(int suggest, int target)
        {
            if (suggest > target)
            {
                return GameResults.Down;
            }
            else if (suggest < target)
            {
                return GameResults.Up;
            }
            return GameResults.Equal;
        }

    }

    public class GameResults
    {
        public const string Down = "Aşağı";
        public const string Up = "Yukarı";
        public const string Equal = "Bildiniz";
    }


}