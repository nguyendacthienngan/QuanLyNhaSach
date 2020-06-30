const db = require("../models");
const sequelize = require("sequelize");
const Customer = db.Customer;
const Op = sequelize.Op;

module.exports.getAllCustomers = function (req, res) {
  Customer.findAll({
    attributes: [
      "id",
      "firstname",
      "lastname",
      "phone",
      "email",
      "address",
      "isFemale",
    ],
  }).then(function (books) {
    res.status(200).json(books);
  });
};

module.exports.searchCustomerById = function (req, res) {
  var customerId = req.params.customer;
  Customer.findOne({
    attributes: [
      "id",
      "firstname",
      "lastname",
      "phone",
      "email",
      "address",
      "isFemale",
    ],
    where: {
      id: customerId,
    },
  })
    .then(function (customer) {
      if (customer) {
        res.status(200).json(customer);
        return;
      }
      res.status(200).json("Cannot find customer");
      return;
    })
    .catch(function (error) {
      res.status(400).send({
        message: error,
      });
      return;
    });
};

module.exports.addCustomer = (req, res) => {
  const customer = Customer.create({
    firstName: req.body.firstName,
    lastName: req.body.lastName,
    phone: req.body.phone,
    email: req.body.email,
    address: req.body.address,
    isFemale: req.body.isFemale,
  })
    .then((customer) => res.status(200).json(customer))
    .catch((err) => res.status(400).json(err.message));
};

module.exports.updateCustomer = function (req, res) {
  Customer.findOne({
    attributes: [
      "id",
      "firstname",
      "lastname",
      "phone",
      "email",
      "address",
      "isFemale",
    ],
    where: {
      id: {
        [Op.substring]: req.body.id,
      },
    },
  })
    .then(function (customer) {
      customer
        .update({
          firstName: req.body.firstName,
          lastName: req.body.lastName,
          phone: req.body.phone,
          email: req.body.email,
          address: req.body.address,
          isFemale: req.body.isFemale,
        })
        .then((customer) => res.status(200).send(customer))
        .catch((err) => res.status(400).send(err.message));
    })
    .catch((err) => res.status(400).send(err.message));
};
