const BookController = require('../controllers/book.controller');
const express = require('express');
const router = express.Router();


router.get('/', BookController.getAllBooks);
router.post('/', BookController.addBook);
router.get('/:id', BookController.getABook);
router.put('/:id', BookController.updatedBook);
router.delete('/:id', BookController.deleteBook);

module.exports = router;