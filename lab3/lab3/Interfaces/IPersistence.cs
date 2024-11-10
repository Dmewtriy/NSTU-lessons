using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Interfaces
{
    internal interface IPersistence<T>
    {
        void SaveToJson(T entity);
        List<T> LoadFromJson();

    }
}
