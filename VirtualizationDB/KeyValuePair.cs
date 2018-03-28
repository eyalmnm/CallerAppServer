using System;
using System.Collections.Generic;
using System.Text;

namespace CallerAppServer.VirtualizationDB
{
    class KeyValuePair<K, V>
    {
        private K Key { get; set; }
        private V Value { get; set; }

        public KeyValuePair(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
