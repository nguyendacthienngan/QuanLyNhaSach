const db = require("../models");
const sequelize = require("sequelize");
const Customer = db.Customer;
const Op = sequelize.Op;

module.exports.getAllCustomers = (req, res) => {
  Customer.findAll().then((books) => {
    res.status(200).json(books);
  });
};

module.exports.searchCustomerByInfo = (req, res) => {
  var customerInfo = req.params.info;
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
    where: {
      [Op.or]: [
        {
          firstName: {
            [Op.substring]: customerInfo,
          },
        },
        {
          lastName: {
            [Op.substring]: customerInfo,
          },
        },
        {
          phone: {
            [Op.substring]: customerInfo,
          },
        },
        {
          email: {
            [Op.substring]: customerInfo,
          },
        },
        {
          address: {
            [Op.substring]: customerInfo,
          },
        },
      ],
    },
  })
    .then((customer) => {
      if (!customer) {
        res.status(400).json("Cannot find customer");
      }
      res.status(200).json(customer);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
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

module.exports.updateCustomer = (req, res) => {
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
    .then((customer) => {
      customer
        .update({
          firstName: req.body.firstName,
          lastName: req.body.lastName,
          phone: req.body.phone,
          email: req.body.email,
          address: req.body.address,
          isFemale: req.body.isFemale,
        })
        .then((customer) => res.status(200).json(customer))
        .catch((err) => res.status(400).json(err.message));
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};

module.exports.deleteCustomerById = (req, res) => {
  const deletedCustomerId = req.params.customerId;
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
    where: { id: deletedCustomerId },
  })
    .then((customer) => {
      return customer.destroy();
    })
    .then((deletedCustomer) => {
      res.status(201).json(deletedCustomer);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
    });
};
