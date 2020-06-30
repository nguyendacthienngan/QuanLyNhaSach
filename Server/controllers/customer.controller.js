const db = require("../models");
const sequelize = require("sequelize");
const Customer = db.Customer;
const Op = sequelize.Op;

module.exports.getAllCustomers = (req, res) => {
  Customer.findAll().then((books) => {
    res.status(200).json(books);
  });
};

module.exports.searchCustomerByName = (req, res) => {
  var customerName = req.params.name;
  Customer.findAll({
    where: {
      [Op.or]: [
        {
          firstName: {
            [Op.substring]: customerName,
          },
        },
        {
          lastName: {
            [Op.substring]: customerName,
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
  Customer.findOne({ where: { id: deletedCustomerId } })
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
