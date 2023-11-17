using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork_14_Storage_system
{
    internal class DataStorage <T>
    {
        List<T> list = new List<T>();
     public void AddData(T data)
        { list.Add(data); }
     public void RemoveData(T data)
        { list.Remove(data); }
     public bool ContainsData(T data)
        { return list.Contains(data); }
     public void PrintData()
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }

    }
}
