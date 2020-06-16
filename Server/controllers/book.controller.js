const db = require("../models");
const sequelize = require('sequelize');
const Book = db.Book;
const Op = sequelize.Op;

module.exports.getAllBooks = function(req, res){
  Book.findAll()
    .then(function(books){
        res.status(200).send(books);
    })
    .catch(function(error){
      res.status(400).send({
          message: error
          });
          return ;
    });
}


module.exports.getABook = function(req, res){
  var bookTitle = req.params.book;
  Book.findOne({
      where : {
        title: {
          [Op.substring]: bookTitle
        }
      }
    }).then(function(book)
      {
        if (book)
        {
          res.status(200).send(book);
          return;
        }
        res.status(200).send('Cannot find book');
        return;
      })
      .catch(function(error){
        res.status(400).send({
          message: error
          });
        return;
      })
}