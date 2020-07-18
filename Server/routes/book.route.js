const bookController = require("../controllers/book.controller");
const express = require("express");
const router = express.Router();

router.get("/", bookController.getAllBooks);

router.post("/search", bookController.searchBooks);

router.get("/count", bookController.getBookCount);

router.get("/bestSeller", bookController.getBestSeller);

router.post("/add", bookController.addBook);

router.put("/update", bookController.updateBook);

router.delete("/delete", bookController.deleteBookById);

router.get("/available", bookController.getAvailableBooks);

router.post("/filter", bookController.filterByPrice);

router.get("/:id", bookController.getABook);

module.exports = router;
