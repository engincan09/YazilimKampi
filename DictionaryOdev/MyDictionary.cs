using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    public class MyDictionary<TKey,TValue>
    {
        TValue[] items;
        public MyDictionary()
        {
            items = new TValue[0];
        }
    }
}
