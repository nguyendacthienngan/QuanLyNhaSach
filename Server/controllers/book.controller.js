const db = require("../models");
const sequelize = require('sequelize');
const Book = db.Book;
const Op = sequelize.Op;

module.exports.getAllBooks = function(req, res){
  Book.findAll()
    .then((book)=> res.status(200).send(book))
    .catch((error) => res.status(400).send(error.message))
}


module.exports.searchBook = function(req, res){
  const params = req.body.p; // {p: 'The'}
  
  Book.findOne({
      where : {
        [Op.or]: 
          [
            {
              title: {
              [Op.substring]: params
              }
            },
            {
              author: {
              [Op.substring]: params
              }
            },
            {
              stock: {
              [Op.substring]: params
              }
            },
            {
              cost: {
              [Op.substring]: params
              }
            },
            {
              price: {
              [Op.substring]: params
              }
            },
            {
              description: {
              [Op.substring]: params
              }
            },
            {
              type: {
              [Op.substring]: params
              }
            },
          ]
        }
      
    }).then((book) => res.status(200).send(book))
      .catch((error) => res.status(400).send(error.message))
}



module.exports.getBookCount = function(req, res){
  var bookID = req.params.id;
  //********** */
}

module.exports.getBestSeller = function(req, res){
   //********** */
}


module.exports.addBook = function(req, res){
  let inputTitle = req.body.title;
  let inputAuthor = req.body.author;
  let inputStock = req.body.stock;
  let inputCost = req.body.cost;
  let inputPrice = req.body.price;
  let inputDescription = req.body.description;
  let inputType = req.body.type;
  let book = Book.create(
    { 
      title: inputTitle,
      author: inputAuthor,
      stock: inputStock,
      cost: inputCost,
      price :inputPrice,
      description: inputDescription,
      type: inputType
    })
    .then(book =>res.status(200).send(book))
    .catch(err =>res.status(400).send(err.message))
    
    console.log(book instanceof Book); // kiểm tra có chạy đc hong
    console.log(book.author);
    console.log('New Book was saved to the database!');
}

module.exports.updateBook = function(req, res){
  let bookID = req.body.id;
  let inputTitle = req.body.title;
  let inputAuthor = req.body.author;
  let inputStock = req.body.stock;
  let inputCost = req.body.cost;
  let inputPrice = req.body.price;
  let inputDescription = req.body.description;
  let inputType = req.body.type;
  Book.findOne({
    where : {
      id: {
        [Op.substring]: bookID
      }
    }
  })
  .then(function(book)
  {
    book.update({
        title : inputTitle,
        author : inputAuthor,
        stock : inputStock,
        cost : inputCost,
        price : inputPrice,
        description : inputDescription,
        type : inputType
    })
    .then(book => res.status(200).send(book))
    .catch(err =>  res.status(400).send(err.message))
  })
  .catch(err =>  res.status(400).send(err.message));
}

module.exports.deleteBook = function(req, res){
  // let bookID = req.body.id;
  // Book.findOne({
  //   where : {
  //     id: {
  //       [Op.substring]: bookID
  //     }
  //   }
  // })
  // .then(book => book.destroy() )
  // .catch(err =>  res.status(400).send(err.message));
}