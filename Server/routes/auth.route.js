const express = require("express");
const router = express.Router();
const db = require("../models");
const Account = db.Account;

const { body } = require("express-validator");

const authController = require("../controllers/auth.controller");

router.post("/login", authController.postLogin);
router.put(
  "/signup",
  [
    body("email")
      .isEmail()
      .withMessage("Please enter a valid email.")
      .custom((value, { req }) => {
        return User.findOne({ where: { email: value } }).then((userDoc) => {
          if (userDoc) {
            return Promise.reject("E-Mail address is already exists!");
          }
        });
      })
      .normalizeEmail(),
    body("password").trim().isLength({ min: 5 }),
    body("username").trim().not().isEmpty(),
  ],
  authController.signup
);

module.exports = router;
