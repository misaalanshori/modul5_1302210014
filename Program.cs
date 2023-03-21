namespace modul5_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hasil penjumlahan dari 13 + 02 + 21 adalah " + Penjumlahan.JumlahTigaAngka<double>(13.0, 02.0, 21.0));
            SimpleDataBase<double> dataAngka = new SimpleDataBase<double>();
            dataAngka.AddNewData(13.0);
            dataAngka.AddNewData(02.0);
            dataAngka.AddNewData(21.0);
            dataAngka.PrintAllData();
        }
    }
}