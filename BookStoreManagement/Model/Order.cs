using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private int _id;

        private int _userId;

        private DateTime _orderDate;

        private int _customerId;

        private float _discount;

        private int _totalOrder;

        private bool _status;

        private OrderDetail _orderDetail;

        public Order(int orderId, int userId, DateTime date, int customerId, float discount, int total, bool status)
        {
            this.id = orderId;
            this.userId = userId;
            this.orderDate = date;
            this.customerId = customerId;
            this.discount = discount;
            this.totalOrder = total;
            this.status = status;
        }

        public int id { get => _id; set => _id = value; }
        public int customerId { get => _customerId; set => _customerId = value; }
        public DateTime orderDate { get => _orderDate; set => _orderDate = value; }
        public int userId { get => _userId; set => _userId = value; }
        public float discount { get => _discount; set => _discount = value; }
        public int totalOrder { get => _totalOrder; set => _totalOrder = value; }
        public bool status { get => _status; set => _status = value; }
        public OrderDetail OrderDetail { get => _orderDetail; set => _orderDetail = value; }
    }
}
