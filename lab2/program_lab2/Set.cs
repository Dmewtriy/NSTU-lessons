using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace program_lab2
{
    internal class Set<T> : IEnumerable<T>
    {
        private List<T> value;
        public IEnumerator<T> GetEnumerator() => value.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Set()
        {
            value = new List<T>();
        }

        public void Add(T _value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(_value));
            }
            if (!value.Contains(_value))
            {
                value.Add(_value);
            }
        }

        public void Remove(T _value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(_value));
            }
            if (!value.Contains(_value))
            {
                throw new KeyNotFoundException($"Элемент {_value} не найден в множестве");
            }
            value.Remove(_value);
        }

        public int Count
        {
            get { return value.Count; }
        }

        public bool Contains(T _value)
        {
            return value.Contains(_value);
        }

        public void Union(Set<T> other)
        {
            foreach (T _value in other.value)
            {
                Add(_value);
            }
        }

        public void Intersection(Set<T> other)
        {
            value = value.Intersect(other.value).ToList();
        }

        public void Difference(Set<T> other)
        {
            value = value.Except(other.value).ToList();
        }

        public bool Subset(Set<T> other)
        {
            return !value.All(_value => other.Contains(_value));
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            Set<T> result = new Set<T>();
            foreach (T value in set1.value)
            {
                result.Add(value);
            }
            foreach (T value in set2.value)
            {
                result.Add(value);
            }
            return result;
        }

        public static Set<T> operator +(Set<T> set, T value)
        {
            Set<T> result = new Set<T>();
            foreach (T val in set.value)
            {
                result.Add(val);
            }
            result.Add(value);
            return result;
        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            Set<T> result = new Set<T>();
            foreach (T value in set1.value)
            {
                if (set2.Contains(value))
                {
                    result.Add(value);
                }
            }
            return result;
        }

        public static explicit operator int(Set<T> set)
        {
            return set.value.Count;
        }

        public static bool operator true(Set<T> set)
        {
            return set.value.Count <= 20;
        }

        public static bool operator false(Set<T> set)
        {
            return set.value.Count > 20;
        }

        public override string ToString()
        {
            return string.Join(", ", value);
        }

        
    }
}
