const db = require("../models");
const sequelize = require("sequelize");
const User = db.User;
const Op = sequelize.Op;

module.exports.getAllUsers = (req, res) => {
  User.findAll()
    .then((books) => {
      res.status(200).json(books);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.searchUserByName = (req, res) => {
  const userName = req.params.name;
  User.findAll({
    where: {
      [Op.or]: [
        {
          firstName: {
            [Op.substring]: userName,
          },
        },
        {
          lastName: {
            [Op.substring]: userName,
          },
        },
      ],
    },
  })
    .then((user) => {
      if (!user) {
        res.status(400).json("Cannot find user");
      }
      res.status(200).json(user);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.addUser = (req, res) => {
  User.create({
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
    .catch((err) => res.status(500).json(err.message));
};

module.exports.updateUser = (req, res) => {
  User.findOne({
    where: {
      id: {
        [Op.substring]: req.body.id,
      },
    },
  })
    .then((user) => {
      if (!user) {
        res.status(400).json("Cannot find user");
      }
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
        .then((user) => res.status(200).json(user))
        .catch((err) => res.status(500).json(err.message));
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.deleteUserById = (req, res) => {
  const deletedUserId = req.params.userId;
  User.findOne({ where: { id: deletedUserId } })
    .then((user) => {
      if (!user) {
        res.status(400).json("Cannot find user");
      }
      return user.destroy();
    })
    .then((deletedUser) => {
      res.status(201).json(deletedUser);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};
