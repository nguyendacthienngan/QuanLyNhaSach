using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDetail
    {
        private int orderId;

        private int bookId;

        private int quantity;

        private int price;

        private int totalOrderDetail;

        public OrderDetail(int orderId, int bookId, int quantity, int price, int totalOrderDetail)
        {
            this.OrderId = orderId;
            this.BookId = bookId;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalOrderDetail = totalOrderDetail;
        }


        public int OrderId { get => orderId; set => orderId = value; }
        public int BookId { get => bookId; set => bookId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int TotalOrderDetail { get => totalOrderDetail; set => totalOrderDetail = value; }
    }
}
