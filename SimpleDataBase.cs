using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210014
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase() 
        { 
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T item)
        {
            storedData.Add(item);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData() 
        {
            for (int index = 0; index < storedData.Count; index++)
            {
                Console.WriteLine("Data " + (index + 1) + " berisi: " + storedData[index] + ", yang disimpan pada waktu UTC: " + inputDates[index].ToString());
            }
        }   
    }
}
