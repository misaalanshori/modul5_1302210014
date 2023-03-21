namespace modul5_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<double> dataAngka = new SimpleDataBase<double>();
            dataAngka.AddNewData(13.0);
            dataAngka.AddNewData(02.0);
            dataAngka.AddNewData(21.0);
            dataAngka.PrintAllData();
        }
    }
}