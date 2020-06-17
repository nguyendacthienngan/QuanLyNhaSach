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

        private int _total;

        public OrderDetail(int orderId, int bookId, int quantity, int price, int total)
        {
            this.OrderId = orderId;
            this.BookId = bookId;
            this.Quantity = quantity;
            this.Price = price;
            this.Total = total;
        }


        public int OrderId { get => _orderId; set => _orderId = value; }
        public int BookId { get => _bookId; set => _bookId = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int Price { get => _price; set => _price = value; }
        public int Total { get => _total; set => _total = value; }
    }
}
