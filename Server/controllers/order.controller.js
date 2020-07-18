const db = require("../models");
const sequelize = require("sequelize");
const { body } = require("express-validator");
const Order = db.Order;
const Book = db.Book;
const Customer = db.Customer;
const User = db.User;
const OrderDetail = db.OrderDetail;
const Op = sequelize.Op;

// Total
module.exports.getOrders = function (req, res) {
  Order.findAll({
    attributes: [
      "id",
      "orderDate",
      "discount",
      "totalOrder",
      "userID",
      "customerID",
    ],
  })
    .then((orders) => res.status(200).json(orders))
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getTotalOrders = function (req, res) {
  Order.count()
    .then((total) => res.status(200).json(total.toString()))
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getTotalOrdersInPeriod = function (req, res) {
  const dateFrom = req.body.dateFrom;
  const dateTo = req.body.dateTo;
  Order.count({
    where: {
      [Op.between]: [dateFrom, dateTo],
    },
  })
    .then((total) => res.status(200).json(total.toString()))
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getTotalOrdersThisMonth = function (req, res) {
  const month = req.body.month;
  const year = req.body.year;
  Order.count({
    where: {
      $and: [
        sequelize.where(
          sequelize.fn("month", sequelize.col("orderDate")),
          month
        ),
        sequelize.where(sequelize.fn("year", sequelize.col("orderDate")), year),
        // Chưa test, chưa chắc lắm
      ],
    },
  })
    .then((total) => res.status(200).json(total.toString()))
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getTotalOrdersThisYear = function (req, res) {
  const year = req.body.year;
  Order.count({
    where: {
      // Chưa test, chưa chắc lắm
      $where: [
        sequelize.where(sequelize.fn("year", sequelize.col("orderDate")), year),
      ],
    },
  })
    .then((total) => res.status(200).json(total.toString()))
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};
// Search & Filter
module.exports.searchOrder = function (req, res) {};

module.exports.filterByDate = function (req, res) {};

module.exports.addOrder = function (req, res) {
  console.log(req.body.books);
  let TotalOrder = 0;
  req.body.books.forEach((book) => {
    TotalOrder += book.quantity * book.price;
  });
  customer = Customer.findOne({
    where: { id: parseInt(req.body.customerID) },
  }).then((customer) => {
    if (!customer) {
      return res.status(400).json("Không tồn tại khách hàng");
    }
    isUserAvailable = User.findOne({
      where: { id: parseInt(req.body.userID) },
    })
      .catch((err) => {
        if (!err.status) err.statusCode = 500;
        next(err);
      })
      .then((user) => {
        if (!user) {
          return res.status(400).json("Không tồn tại nhân viên");
        }
        const savedOrder = Order.create({
          userID: req.body.userID,
          customerID: req.body.customerID,
          status: req.body.status,
          totalOrder: TotalOrder,
          discount: req.body.discount,
          orderDate: new Date(),
        })
          .catch((err) => res.status(400).json(err.message))
          .then((order) => {
            var promise = [];
            req.body.books.forEach((item) => {
              promise.push(
                Book.findOne({
                  where: { id: parseInt(item.id) },
                }).then((book) => {
                  if (!book) {
                    return res.status(400);
                  }
                  //   // THÊM THUỘC TÍNH QUANTITY  THÌ SẼ DÙNG DÒNG NÀY ĐỂ KIỂM TRA CÓ CÒN ĐỦ TRG KHO KHÔNG
                  //   // if (item.quantity > book.quantity){
                  //   //   return res.status(400);
                  //   // }
                  OrderDetail.create({
                    orderID: order.id,
                    bookID: item.id,
                    quantity: item.quantity,
                    price: item.price,
                    totalOrderDetail: item.quantity * item.price,
                  });
                })
              );
            });

            return Promise.all(promise);
          })
          .then((result) => {
            res.status(200).json("Lưu thành công");
          })
          .catch((err) => {
            if (!err.status) err.statusCode = 500;
            next(err);
          });
      });
  });
};

module.exports.updateOrder = function (req, res) {};

module.exports.deleteOrder = function (req, res) {
  //Chưa làm
};

module.exports.getMaxIDOrder = function (req, res) {
  // ????
};

module.exports.finalizedOrder = function (req, res) {};

module.exports.abortedOrder = function (req, res) {};

// INCOME
module.exports.getThisMonthIncome = function (req, res) {};

module.exports.getYearIncome = function (req, res) {};

module.exports.getAnOrder = function (req, res, next) {
  Order.findOne({
    where: {
      id: req.params.if,
    },
  })
    .then((order) => {
      res.status(200).json(order);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};
