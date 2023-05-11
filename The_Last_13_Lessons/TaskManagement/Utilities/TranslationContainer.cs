using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;

namespace TaskManagement.Utilities
{
    public class TranslationContainer
    {
        public TranslationContainer(TranslationKey key, string azerbaijani, string russian, string english)
        {
            Key = key;
            Azerbaijani = azerbaijani;
            Russian = russian;
            English = english;
        }

        public TranslationKey Key { get; set; }
        public string Azerbaijani { get; set; }
        public string Russian { get; set; }
        public string English { get; set; }

    }
}
