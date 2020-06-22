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

        private DateTime _orderDate;

        private int _customerId;

        private float _discount;

        private int _totalOrder;

        private bool _status;

<<<<<<< Updated upstream
=======
        private OrderDetail _orderDetail;

>>>>>>> Stashed changes
        public Order(int orderId, int userId, DateTime date, int customerId, float discount, int total, bool status)
        {
            this.orderId = orderId;
            this.userId = userId;
            this.orderDate = date;
            this.customerId = customerId;
            this.discount = discount;
            this.totalOrder = total;
            this.status = status;
        }

<<<<<<< Updated upstream
        public int OrderId { get => orderId; set => orderId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public int UserId { get => userId; set => userId = value; }
        public float Discount { get => discount; set => discount = value; }
        public int TotalOrder { get => totalOrder; set => totalOrder = value; }
        public bool Status { get => status; set => status = value; }
=======
        public int orderId { get => _orderId; set => _orderId = value; }
        public int customerId { get => _customerId; set => _customerId = value; }
        public DateTime orderDate { get => _orderDate; set => _orderDate = value; }
        public int userId { get => _userId; set => _userId = value; }
        public float discount { get => _discount; set => _discount = value; }
        public int totalOrder { get => _totalOrder; set => _totalOrder = value; }
        public bool status { get => _status; set => _status = value; }
        public OrderDetail orderDetail { get => _orderDetail; set => _orderDetail = value; }
>>>>>>> Stashed changes
    }
}
