const db = require("../models");
const sequelize = require("sequelize");
const Account = db.Account;
const User = db.User;
const Op = sequelize.Op;

module.exports.getAllAccounts = function (req, res, next) {
  Account.findAll({
    attributes: ["id", "username", "password", "isAdmin", "userID"],
  })
    .then((account) => res.status(200).json(account))
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
      next(err);
    });
};
module.exports.updateAccount = function (req, res) {
  const inputUsername = req.body.username;
  const inputPassword = req.body.password;
  const inputIsAdmin = req.body.isAdmin;
  const inputUserID = req.body.userID;
  User.findOne({
    attributes: ["id"],
    where: {
      id: inputUserID,
    },
  })
    .then((user) => {
      if (!user) {
        return res.status(400).json("Cannot find User");
      }
      Account.findOne({
        attributes: ["id", "username", "password", "isAdmin"],
        where: {
          userID: user.id,
        },
      })
        .then((account) => {
          if (!account) {
            return res.status(400).json("Cannot find Account");
          }
          account
            .update({
              username: inputUsername,
              password: inputPassword,
              isAdmin: inputIsAdmin,
            })
            .then((result) => {
              return res.status(200).json(result);
            })
            .catch((err) => {
              if (!err.status) err.statusCode = 500;
              next(err);
            });
        })
        .catch((err) => {
          if (!err.status) err.statusCode = 500;
          next(err);
        });
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.getAnAccount = (req, res, next) => {
  Account.findOne({
    where: {
      id: req.params.id,
    },
  })
    .then((account) => {
      res.status(200).json(account);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};
