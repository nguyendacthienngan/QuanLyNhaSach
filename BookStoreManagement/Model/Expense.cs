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
        
        private DateTime _date;
        
        private string _description;
        public Expense(int id, string title, float amount, DateTime date, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Amount = amount;
            this.Date = date;
            this.Description = description;
        }


        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public float Amount { get => _amount; set => _amount = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
