using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Order
    {
        private int _orderId;

        private int _userId;

        private DateTime _date;

        private int _customerId;

        private float _discount;

        private int _total;

        private bool _status;

        public Order(int orderId, int userId, DateTime date, int customerId, float discount, int total, bool status)
        {
            this.OrderId = orderId;
            this.UserId = userId;
            this.Date = date;
            this.CustomerId = customerId;
            this.Discount = discount;
            this.Total = total;
            this.Status = status;
        }

        public int OrderId { get => _orderId; set => _orderId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int UserId { get => _userId; set => _userId = value; }
        public float Discount { get => _discount; set => _discount = value; }
        public int Total { get => _total; set => _total = value; }
        public bool Status { get => _status; set => _status = value; }
    }
}
