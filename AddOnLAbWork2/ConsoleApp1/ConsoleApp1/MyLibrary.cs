using AddOnLabWork1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyLibrary<Tkey, Tvalue> : IDictionary<Tkey, Tvalue>
        where Tkey: class
        where Tvalue: class 
    {
        SortedSet<Tkey> KeysOfItems;
        SortedDictionary<Tkey, Tvalue> Items;

        public MyLibrary()
        {
            KeysOfItems = new SortedSet<Tkey>();
            Items = new SortedDictionary<Tkey, Tvalue>();
        }
        
        public bool IsReadOnly { get { return false; } }

        public bool IsFixedSize { get { return false; } }

        public int Count
        {
            get
            {
                return KeysOfItems.Count();
            }
        }

        public void Clear()
        {
            KeysOfItems.Clear();
            Items.Clear();
        }

        public DictionaryEntry[] CopyToArray()
        {
            DictionaryEntry[] NewArr = new DictionaryEntry[Count];
            int i = -1;
            foreach (Tkey key in KeysOfItems)
            {
                i++;
                NewArr[i].Key = key;
                NewArr[i].Value = Items[key];
                
            }
            return NewArr;
        }

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();



        ICollection<Tkey> IDictionary<Tkey, Tvalue>.Keys
        {
            get
            {
                Tkey[] ArrayOfKey = new Tkey[KeysOfItems.Count()];
                KeysOfItems.CopyTo(ArrayOfKey);
                return ArrayOfKey;
            }
        }

        ICollection<Tvalue> IDictionary<Tkey, Tvalue>.Values
        {
            get
            {
                Tvalue[] ArrayOfValue = new Tvalue[KeysOfItems.Count()];
                int i = 0;
                foreach (Tkey key in KeysOfItems)
                {
                    ArrayOfValue[i++] = Items[key];
                }
                return ArrayOfValue;
            }
        }

        public Tvalue this[Tkey key]
        {
            get
            {
                return Items[key];
            }

            set
            {
                if (ContainsKey(key))
                    Items[key] = value;
                else
                    Add(key, value);
            }
        }

        public bool ContainsKey(Tkey key)
        {
            return KeysOfItems.Contains(key);
        }

        public void Add(Tkey key, Tvalue value)
        {
            if (!KeysOfItems.Contains(key))
            {
                KeysOfItems.Add(key);
                Items.Add(key, value);
            }
            else
            {

            }
        }

        public bool Remove(Tkey key)
        {
            if (KeysOfItems.Contains(key))
            {
                KeysOfItems.Remove(key);
                Items.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryGetValue(Tkey key, out Tvalue value)
        {
            if (ContainsKey(key))
            {
                value = Items[key];
                return true;
            }
            else
            {
                value = null;
                return false;
            }
        }

        public void Add(KeyValuePair<Tkey, Tvalue> item)
        {
            Add(item.Key, item.Value);
        }

        public bool Contains(KeyValuePair<Tkey, Tvalue> item)
        {
            if (KeysOfItems.Contains(item.Key) && Items[item.Key] == item.Value)
                return true;
            else
                return false;
        }

        public void CopyTo(KeyValuePair<Tkey, Tvalue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<Tkey, Tvalue> item)
        {
            if (Contains(item))
            {
                return Remove(item.Key);
            }
            else
                return false;
        }

        //public IEnumerator<KeyValuePair<Tkey, Tvalue>> GetEnumerator() => ((IDictionary)this).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IDictionary)this).GetEnumerator();

        public IDictionaryEnumerator GetEnumerator() => new LibraryEnumerator(this);

        IEnumerator<KeyValuePair<Tkey, Tvalue>> IEnumerable<KeyValuePair<Tkey, Tvalue>>.GetEnumerator() => throw new NotImplementedException(); 

        private class LibraryEnumerator : IDictionaryEnumerator 
        {
            int Index = -1;
            DictionaryEntry[] Items;

            public LibraryEnumerator(MyLibrary<Tkey, Tvalue> ML)
            {
                Items = ML.CopyToArray();
            }

            public object Key
            {
                get
                {
                    return Items[Index].Key;
                }
            }

            public object Value
            {
                get
                {
                    return Items[Index].Value;
                }
            }

            public DictionaryEntry Entry
            {
                get
                {
                    return (DictionaryEntry)Current;
                }
            }

            public object Current
            {
                get
                {
                    return Items[Index];
                }
            }

            public bool MoveNext()
            {
                if (Index < Items.Length - 1)
                {
                    Index++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                Index = -1;
            }
        }
    } 
}
