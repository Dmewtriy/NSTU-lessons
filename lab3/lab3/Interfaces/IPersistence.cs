using System.Collections.Generic;

namespace lab3.Interfaces
{
    internal interface IPersistence<T>
    {
        void SaveToJson(T entity);
        List<T> LoadFromJson();

    }
}
