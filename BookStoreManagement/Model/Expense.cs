using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Expense
    {
        private int _id;

        private string _title;
        
        private float _amount;
        
        private DateTime _expenseDate;
        
        private string _description;
        public Expense(int id, string title, float amount, DateTime expenseDate, string description)
        {
            this.id = id;
            this.title = title;
            this.amount = amount;
            this.date = expenseDate;
            this.description = description;
        }


        public int id { get => _id; set => _id = value; }
        public string title { get => _title; set => _title = value; }
        public float amount { get => _amount; set => _amount = value; }
        public DateTime date { get => _expenseDate; set => _expenseDate = value; }
        public string description { get => _description; set => _description = value; }
    }
}
