const db = require("../models");
const sequelize = require("sequelize");
const User = db.User;
const Op = sequelize.Op;

module.exports.getAllUsers = (req, res) => {
  User.findAll({
    attributes: [
      "id",
      "firstname",
      "lastname",
      "phone",
      "dateOfBirth",
      "email",
      "address",
      "isFemale",
      "idCard",
    ],
  }).then(function (books) {
    res.status(200).json(books);
  });
};

module.exports.searchUserById = (req, res) => {
  const userId = req.params.id;
  User.findOne({
    attributes: [
      "id",
      "firstname",
      "lastname",
      "phone",
      "dateOfBirth",
      "email",
      "address",
      "isFemale",
      "idCard",
    ],
    where: {
      id: {
        [Op.substring]: userId,
      },
    },
  })
    .then(function (user) {
      if (user) {
        res.status(200).json(user);
        return;
      }
      res.status(200).json("Cannot find user");
      return;
    })
    .catch(function (error) {
      res.status(400).json({
        message: error,
      });
      return;
    });
};

module.exports.addUser = (req, res) => {
  const user = User.create({
    firstName: req.body.firstName,
    lastName: req.body.lastName,
    phone: req.body.phone,
    dateOfBirth: req.body.dateOfBirth,
    email: req.body.email,
    address: req.body.address,
    isFemale: req.body.isFemale,
    idCard: req.body.idCard,
  })
    .then((user) => res.status(200).json(user))
    .catch((err) => res.status(400).json(err.message));
};

module.exports.updateUser = function (req, res) {
  User.findOne({
    attributes: [
      "id",
      "firstname",
      "lastname",
      "phone",
      "dateOfBirth",
      "email",
      "address",
      "isFemale",
      "idCard",
    ],
    where: {
      id: {
        [Op.substring]: req.body.id,
      },
    },
  })
    .then(function (user) {
      user
        .update({
          firstName: req.body.firstName,
          lastName: req.body.lastName,
          phone: req.body.phone,
          dateOfBirth: req.body.dateOfBirth,
          email: req.body.email,
          address: req.body.address,
          isFemale: req.body.isFemale,
          idCard: req.body.idCard,
        })
        .then((user) => res.status(200).send(user))
        .catch((err) => res.status(400).send(err.message));
    })
    .catch((err) => res.status(400).send(err.message));
};
