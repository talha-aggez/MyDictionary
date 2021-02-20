using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryExample
{
    public class DictionaryExample<TKey , TValue >
    {
        TKey[] _key;
        TValue[] _value;
        public DictionaryExample()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempKey = _key;
            TValue[] tempValue = _value;

            _value = new TValue[_value.Length + 1];
            _key = new TKey[_key.Length + 1];

            for(int i = 0; i < tempKey.Length; i++)
            {
                _value[i] = tempValue[i];
                _key[i] = tempKey[i];
            }
            _value[_value.Length - 1] = value;
            _key[_key.Length - 1] = key;
        }
        public void List()
        {
            for(int i = 0; i < _value.Length; i++)
            {
                Console.WriteLine("{0}, {1}",_key[i],_value[i]);
            }
        }
    }
}
