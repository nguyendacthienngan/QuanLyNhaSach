using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Order
    {
        private int orderId;

        private int userId;

        private DateTime orderDate;

        private int customerId;

        private float discount;

        private int totalOrder;

        private bool status;

        public Order(int orderId, int userId, DateTime date, int customerId, float discount, int total, bool status)
        {
            this.OrderId = orderId;
            this.UserId = userId;
            this.OrderDate = date;
            this.CustomerId = customerId;
            this.Discount = discount;
            this.TotalOrder = total;
            this.Status = status;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public int UserId { get => userId; set => userId = value; }
        public float Discount { get => discount; set => discount = value; }
        public int TotalOrder { get => totalOrder; set => totalOrder = value; }
        public bool Status { get => status; set => status = value; }
    }
}
