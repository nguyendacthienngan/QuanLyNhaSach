const BookController = require("../controllers/book.controller");
const express = require("express");
const router = express.Router();

router.get("/", BookController.getAllBooks);

router.post("/search", BookController.searchBooks);

router.get("/count", BookController.getBookCount);

router.get("/bestSeller", BookController.getBestSeller);

router.post("/add", BookController.addBook);

router.put("/update", BookController.updateBook);

router.delete("/delete", BookController.deleteBookById);

router.get("/available", BookController.getAvailableBooks);

router.post("/filter", BookController.filterByPrice);

module.exports = router;
