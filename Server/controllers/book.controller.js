const db = require("../models");
const sequelize = require("sequelize");
const Book = db.Book;
const Op = sequelize.Op;

module.exports.getAllBooks = function (req, res, next) {
  Book.findAll({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "genre",
      "releasedDate",
      "imageUrl"
    ],
  })
    .then((book) => res.status(200).json(book))
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
      next(err);
    });
};

module.exports.searchBooks = function (req, res, next) {
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
      "genre",
      "releasedDate",
      "imageUrl"
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
          genre: {
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
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getBookCount = function (req, res, next) {
  // count => trả về number => k cho phép trả về nên bad request nên phải chuyển từ number sang string
  Book.count()
    .then((count) => res.status(200).json(count))
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
      next(err);
    });
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
  const inputGenre = req.body.genre;
  const inputReleasedDate = req.body.releasedDate;
  const inputImageUrl = req.body.imageUrl;
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
        return res.status(400).json("This book already exists!");
      }
      Book.create({
        title: inputTitle,
        author: inputAuthor,
        stock: inputStock,
        cost: inputCost,
        price: inputPrice,
        description: inputDescription,
        genre: inputGenre,
        releasedDate: inputReleasedDate,
        imageUrl: inputImageUrl
      })
        .then((book) => res.status(200).json(book))
        .catch((err) => {
          if (!err.status) err.statusCode = 500;
          next(err);
        });
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.updateBook = function (req, res, next) {
  const bookID = req.body.id; //params hay body
  const inputTitle = req.body.title;
  const inputAuthor = req.body.author;
  const inputStock = req.body.stock;
  const inputCost = req.body.cost;
  const inputPrice = req.body.price;
  const inputDescription = req.body.description;
  const inputGenre = req.body.genre;
  const inputReleasedDate = req.body.releasedDate;
  const inputImageUrl = req.body.imageUrl;
  Book.findOne({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "genre",
      "releasedDate",
      "imageUrl"
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
          genre: inputGenre,
          releasedDate: inputReleasedDate,
          imageUrl: inputImageUrl
        })
        .then((book) => {
          if (!book) {
            return res.status(400).json("This book does not exist!");
          }
          res.status(200).json(book);
        })
        .catch((err) => {
          if (!err.status) err.statusCode = 500;
          next(err);
        });
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.deleteBookById = function (req, res, next) {
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
      "genre",
      "releasedDate",
      "imageUrl"
    ],
    where: { id: deletedBookId },
  })
    .then((book) => {
      if (!book) {
        return res.status(400).json("This book does not exist!");
      }
      return book.destroy();
    })
    .then((deletedBook) => {
      res.status(201).json(deletedBook);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getAvailableBooks = (req, res, next) => {
  Book.findAll({
    attributes: [
      "id",
      "title",
      "author",
      "stock",
      "cost",
      "price",
      "description",
      "genre",
      "releasedDate",
      "imageUrl"
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
      next(err);
    });
};

module.exports.filterByPrice = (req, res, next) => {
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
      "genre",
      "releasedDate",
      "imageUrl"
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
      next(err);
    });
};
