using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Expense
    {
        private int id;

        private string title;
        
        private float amount;
        
        private DateTime expenseDate;
        
        private string description;
        public Expense(int id, string title, float amount, DateTime expenseDate, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Amount = amount;
            this.Date = expenseDate;
            this.Description = description;
        }


        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public float Amount { get => amount; set => amount = value; }
        public DateTime Date { get => expenseDate; set => expenseDate = value; }
        public string Description { get => description; set => description = value; }
    }
}
