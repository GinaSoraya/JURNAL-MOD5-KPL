using System;
using System.Collections.Generic;

internal class program
{
    class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = c;
            Console.WriteLine(x + y + z);
        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDate = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDate.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDate[i]} AM");
            }
        }
    }
    static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<long>(13, 02, 22);
        SimpleDataBase<long> data = new SimpleDataBase<long>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
}
