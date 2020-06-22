using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class OrderDetail
    {
        private int _orderId;

        private int _bookId;

        private int _quantity;

        private int _price;

        private int _totalOrderDetail;

        public OrderDetail(int orderId, int bookId, int quantity, int price, int totalOrderDetail)
        {
            this.orderId = orderId;
            this.bookId = bookId;
            this.quantity = quantity;
            this.price = price;
            this.totalOrderDetail = totalOrderDetail;
        }


        public int orderId { get => _orderId; set => _orderId = value; }
        public int bookId { get => _bookId; set => _bookId = value; }
        public int quantity { get => _quantity; set => _quantity = value; }
        public int price { get => _price; set => _price = value; }
        public int totalOrderDetail { get => _totalOrderDetail; set => _totalOrderDetail = value; }
    }
}
