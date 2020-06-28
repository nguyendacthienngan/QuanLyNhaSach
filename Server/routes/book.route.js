const BookController = require("../controllers/book.controller");
const express = require("express");
const router = express.Router();

router.get("/", BookController.getAllBooks);
router.post("/search", BookController.searchBook);

router.get("/get/count", BookController.getBookCount);
router.get("/get/bestSeller", BookController.getBestSeller);

router.post("/add", BookController.addBook);
router.post("/update", BookController.updateBook);
router.delete("/delete/:bookId", BookController.deleteBookById);

module.exports = router;
