using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Setting
    {
        private string _key;

        private string _value;

        private int _id;
        public Setting(int id, string key, string value)
        {
            this.id = id;
            this.key = key;
            this.value = value;
        }


        public int id { get => _id; set => _id = value; }
        public string key { get => _key; set => _key = value; }
        public string value { get => _value; set => this._value = value; }
    }
}
