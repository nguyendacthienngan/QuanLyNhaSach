const BooksReceivedNoteController = require("../controllers/booksReceivedNote.controller");
const express = require("express");
const router = express.Router();

router.get("/", BooksReceivedNoteController.getAllBooksReceivedNote);
router.post("/add", BooksReceivedNoteController.addBooksReceivedNote);
router.post("/update", BooksReceivedNoteController.updateBooksReceivedNote);
router.delete("/delete", BooksReceivedNoteController.deleteBooksReceivedNote);

module.exports = router;
