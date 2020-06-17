using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Setting
    {
        public Setting(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        private string _key;

        private string _value;

        public string Key { get => _key; set => _key = value; }

        public string Value { get => _value; set => _value = value; }
    }
}
