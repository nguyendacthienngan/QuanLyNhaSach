using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Setting
    {
        private string key;

        private string value;

        private int id;
        public Setting(int id, string key, string value)
        {
            this.Id = id;
            this.Key = key;
            this.Value = value;
        }


        public int Id { get => id; set => id = value; }
        public string Key { get => key; set => key = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
