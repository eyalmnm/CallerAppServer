using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Utils
{
    public class DictionaryUtils
    {

        public static void ReadDictionaryData(Dictionary<String, String> data)
        {
            foreach (KeyValuePair<String, String> item in data)
            {
                Console.WriteLine($"key: {item.Key} value: {item.Value}");
            }
        }
    }
}