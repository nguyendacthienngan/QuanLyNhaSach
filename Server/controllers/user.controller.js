const db = require("../models");
const sequelize = require("sequelize");
const User = db.User;
const Account = db.Account;
const Op = sequelize.Op;

module.exports.getAllUsers = (req, res, next) => {
  User.findAll({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "dateOfBirth",
      "email",
      "address",
      "isFemale",
      "idCard",
    ],
  })
    .then((books) => {
      res.status(200).json(books);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.searchUser = (req, res, next) => {
  const userInfo = req.body.info;
  User.findAll({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "dateOfBirth",
      "email",
      "address",
      "isFemale",
      "idCard",
    ],
    where: {
      [Op.or]: [
        {
          firstName: {
            [Op.substring]: userInfo,
          },
        },
        {
          lastName: {
            [Op.substring]: userInfo,
          },
        },
        {
          phone: {
            [Op.substring]: userInfo,
          },
        },
        {
          email: {
            [Op.substring]: userInfo,
          },
        },
        {
          address: {
            [Op.substring]: userInfo,
          },
        },
        {
          idCard: {
            [Op.substring]: userInfo,
          },
        },
      ],
    },
  })
    .then((user) => {
      res.status(200).json(user);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.addUser = (req, res, next) => {
  User.findOne({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
    ],
    where: {
      [Op.and]: [
        {
          firstName: {
            [Op.substring]: req.body.firstName,
          },
        },
        {
          lastName: {
            [Op.substring]: req.body.lastName,
          },
        },
        {
          phone: {
            [Op.substring]: req.body.phone,
          },
        },
        {
          address: {
            [Op.substring]: req.body.address,
          },
        },
      ],
    },
  })
    .then((user) => {
      if (user) {
        return res.status(400).json("This user already exists");
      }
      User.create({
        firstName: req.body.firstName,
        lastName: req.body.lastName,
        phone: req.body.phone,
        email: req.body.email,
        address: req.body.address,
        isFemale: req.body.isFemale,
        dateOfBirth: req.body.dateOfBirth,
        idCard: req.body.idCard,
      })
        .then((user) => {
          Account.create({
            username: req.body.username,
            password: req.body.password,
            isAdmin:  req.body.isAdmin,
            userID: user.id
          })
          .then((account) => {
            return res.status(200).json(account);
          })
          .catch((err) => {
            return res.status(400).json(err.message);
          });
        })
        .catch((err) => {
          if (!err.status) {
            err.statusCode = 500;
          }
          next(err);
        });
    })
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
      next(err);
    });
};

module.exports.updateUser = (req, res, next) => {
  User.findOne({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
    ],
    where: {
      id: req.body.id,
    },
  })
    .then((user) => {
      if (!user) {
        return res.status(400).json("This user does not exist!");
      }
      user
        .update({
          firstName: req.body.firstName,
          lastName: req.body.lastName,
          phone: req.body.phone,
          email: req.body.email,
          address: req.body.address,
          isFemale: req.body.isFemale,
        })
        .then((user) => res.status(200).json(user))
        .catch((err) => {
          if (!err.status) {
            err.statusCode = 500;
          }
          next(err);
        });
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.deleteUser = (req, res, next) => {
  const deletedUserId = req.body.id;
  User.findOne({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
    ],
    where: { id: deletedUserId },
  })
    .then((user) => {
      if (!user) {
        return res.status(400).json("This user does not exist!");
      }
      return user.destroy();
    })
    .then((deletedUser) => {
      res.status(201).json(deletedUser);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};
