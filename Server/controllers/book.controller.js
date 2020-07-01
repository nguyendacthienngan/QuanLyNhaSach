const db = require("../models");
const sequelize = require("sequelize");
const Book = db.Book;
const Op = sequelize.Op;

module.exports.getAllBooks = function (req, res) {
  Book.findAll({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "type",
    ],
  })
    .then((book) => res.status(200).send(book))
    .catch((error) => res.status(400).json(error.message));
};

module.exports.searchBooks = function (req, res) {
  const bookInfo = req.body.info; // {p: 'The'}
  Book.findAll({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "type",
    ],
    where: {
      [Op.or]: [
        {
          title: {
            [Op.substring]: bookInfo,
          },
        },
        {
          author: {
            [Op.substring]: bookInfo,
          },
        },
        {
          type: {
            [Op.substring]: bookInfo,
          },
        },
        {
          description: {
            [Op.substring]: bookInfo,
          },
        },
      ],
    },
  })
    .then((books) => res.status(200).json(books))
    .catch((error) => res.status(400).json(error.message));
};

module.exports.getBookCount = function (req, res) {
  // count => trả về number => k cho phép trả về nên bad request nên phải chuyển từ number sang string
  Book.count()
    .then((count) => res.status(200).json(count))
    .catch((error) => res.sendStatus(400).json(error.message));
};

module.exports.getBestSeller = function (req, res) {
  //  sequelize.query("SELECT TOP 1 B.title, SUM(C.quantity)" +
  //  " FROM(OrderDetail C JOIN Book B ON C.id = B.id) JOIN Order O ON C.id = O.id" +
  //  " WHERE MONTH(O.date) = MONTH(GETDATE()) AND YEAR(DATE) = YEAR(GETDATE())" +
  //  " GROUP BY B.id, title ORDER BY SUM(C.quantity) DESC")
  //     .then((book) => res.status(200).send(book))
  //     .catch((err) => res.status(400).send(err.message))
};

module.exports.addBook = function (req, res) {
  const inputTitle = req.body.title;
  const inputAuthor = req.body.author;
  const inputStock = req.body.stock;
  const inputCost = req.body.cost;
  const inputPrice = req.body.price;
  const inputDescription = req.body.description;
  const inputType = req.body.type;

  Book.findOne({
    where: {
      [Op.or]: [
        {
          title: inputTitle,
        },
        {
          author: inputAuthor,
        },
      ],
    },
  })
    .then((book) => {
      if (book) {
        res.status(400).json("This book already exists!");
      }
      Book.create({
        title: inputTitle,
        author: inputAuthor,
        stock: inputStock,
        cost: inputCost,
        price: inputPrice,
        description: inputDescription,
        type: inputType,
      })
        .then((book) => res.status(200).send(book))
        .catch((err) => {
          if (!err.status) err.statusCode = 500;
        });
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.updateBook = function (req, res) {
  const bookID = req.body.id; //params hay body
  const inputTitle = req.body.title;
  const inputAuthor = req.body.author;
  const inputStock = req.body.stock;
  const inputCost = req.body.cost;
  const inputPrice = req.body.price;
  const inputDescription = req.body.description;
  const inputType = req.body.type;
  Book.findOne({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "type",
    ],
    where: {
      id: {
        [Op.substring]: bookID,
      },
    },
  })
    .then(function (book) {
      book
        .update({
          title: inputTitle,
          author: inputAuthor,
          stock: inputStock,
          cost: inputCost,
          price: inputPrice,
          description: inputDescription,
          type: inputType,
        })
        .then((book) => {
          if (!book) {
            res.status(400).json("This book does not exist!");
          }
          res.status(200).json(book);
        })
        .catch((err) => {
          if (!err.status) err.statusCode = 500;
        });
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.deleteBookById = function (req, res) {
  const deletedBookId = req.body.id;
  Book.findOne({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "type",
    ],
    where: { id: deletedBookId },
  })
    .then((book) => {
      if (!book) {
        res.status(400).json("This book does not exist!");
      }
      return book.destroy();
    })
    .then((deletedBook) => {
      res.status(201).json(deletedBook);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.getAvailableBooks = (req, res) => {
  Book.findAll({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "type",
    ],
    where: {
      [Op.or]: [
        {
          stock: { [Op.gt]: 0 },
        },
      ],
    },
  })
    .then((books) => res.status(200).json(books))
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
    });
};

module.exports.filterByPrice = (req, res) => {
  const maxPrice = req.body.max || 0;
  const minPrice = req.body.min || 0;
  Book.findAll({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "type",
    ],
    where: {
      [Op.and]: [
        {
          price: {
            [Op.lt]: maxPrice,
          },
        },
        {
          price: {
            [Op.gt]: minPrice,
          },
        },
      ],
    },
  })
    .then((books) => res.status(200).json(books))
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
    });
};
