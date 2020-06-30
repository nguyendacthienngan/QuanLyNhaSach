const express = require("express");
const router = express.Router();
const db = require("../models");
const Account = db.Account;

const { body } = require("express-validator");

const authController = require("../controllers/auth.controller");

router.post("/login", authController.postLogin);
router.put("/signup", authController.signup);

module.exports = router;
