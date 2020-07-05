const { validationResult } = require("express-validator");
const bcrypt = require("bcryptjs");
const jwt = require("jsonwebtoken");
const sequelize = require("sequelize");
const Op = sequelize.Op;

const db = require("../models");
const Account = db.Account;

//Đăng nhập - kiểm tra thông tin tài khoản
module.exports.postLogin = (req, res, next) => {
  const username = req.body.username;
  const password = req.body.password;
  let loadedAccount;

  Account.findOne({ where: { username: username } })
    .then((account) => {
      //verify email
      if (!account) {
        const err = new Error("This username can not be found!");
        err.statusCode = 401;
        res.json(err.message);
        // throw err;
      }
      loadedAccount = account;
      return bcrypt.compare(password, account.password);
    })
    .then((isEqual) => {
      //verify password
      if (!isEqual) {
        const err = new Error("Wrong password!");
        err.statusCode = 401;
        res.json(err.message);
      }
      //use token
      const token = jwt.sign(
        {
          username: loadedAccount.username,
          userId: loadedAccount.id.toString(),
        },
        "helloeverybody",
        { expiresIn: "1h" }
      );
      res.status(200).json({
        message: "Login sucessfully",
        token: token,
        userId: loadedAccount.id,
      });
    })
    .catch((err) => {
      if (!err.statusCode) {
        statusCode = 500;
      }
      next(err);
    });
};

module.exports.signup = (req, res, next) => {
  const errors = validationResult(req);
  console.log(errors);
  if (!errors.isEmpty()) {
    const error = new Error("Validation failed =))!");
    error.statusCode = 422;
    error.data = errors.array();
    throw error;
  }

  const username = req.body.username;
  const password = req.body.password;
  const role = req.body.role;
  const userId = "1"; //SAI !

  bcrypt
    .hash(password, 12)
    .then((hashedPw) => {
      const account = new Account({
        password: hashedPw,
        username: username,
        role: role,
        userId: userId,
      });
      return account.save();
    })
    .then((result) => {
      res.statusCode = 201;
      console.log("Account created");
      res.json({ message: "Account created" });
    })
    .catch((err) => {
      if (!err.statusCode) {
        err.statusCode = 500;
      }
      next(err);
    });
};
