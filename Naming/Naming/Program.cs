using System.Data;

namespace Naming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1; //Buradaki x ...... için kullanılmıştır.
            int y = 2;

            int d = 150; //Buradaki d, müşterinin sisteme kayıt olduğundan bu yana geçen gün sayısıdır.
            int daysSinceUserCreated = 150;
            int kullaniciKaydindanBeriGecenGun = 250;
            //bool banuAlkan = false;

            //Kısaltma kullanırken birden fazla anlama gelmediğine emin olun:
            var horsePwr = 20;
            //Değişkeniniz bir koleksiyon ise, günlük hayattaki gibi (çoğul eki kullanarak) tanımlayın.
            var books = new List<string>();

            var bookList = new List<string>();

            //Bir instance oluşturuyorsanız, Kompleks tipin adını instance'da geçirin:
            Random randomNumberGenerator = new Random();
            DataTable customersTable = new DataTable();

            int age = 43;
            bool isConnected = true;
            bool isCheckedByUser = false;

            //Karakter benzeşiminden KAÇININ (Önceki yazılımcı olduğunuzda pek de dua almayacağınız garanti):
            var o = 0;
            var l = 1;

            if (o == l)
            {
                o = 1;
            }








        }

        static List<int[]> cells = new List<int[]>();
        static List<int[]> getFlaggedCellsOnGameboard()
        {
            List<int[]> flaggedCells = new List<int[]>();
            //foreach (var cell in cells)
            //{
            //    if (cell[0] == CellStates.Flagged)
            //    {
            //        flaggedCells.Add(cell);
            //    }
            //}
            return flaggedCells.Where(cell => cell[0] == CellStates.Flagged).ToList();


            //return flaggedCells;
        }



    }

    public class CellStates
    {
        public const int Empty = 0;
        public const int Flagged = 4;
    }

    public enum CellState
    {
        Empty = 0,
        Flagged = 4

    }
}