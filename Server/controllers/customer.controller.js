const db = require("../models");
const sequelize = require("sequelize");
const Customer = db.Customer;
const Op = sequelize.Op;

module.exports.getAllCustomers = (req, res, next) => {
  Customer.findAll({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
      "isMember"
    ],
  })
    .then((books) => {
      res.status(200).json(books);
    })
    .catch((err) => {
      if (!err.status) {
        err.statusCode = 500;
      }
      next(err);
    });
};

module.exports.searchCustomer = (req, res, next) => {
  var customerInfo = req.body.info;
  Customer.findAll({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
      "isMember"
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
    .then((customers) => {
      res.status(200).json(customers);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};

module.exports.addCustomer = (req, res, next) => {
  Customer.findOne({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
      "isMember"
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
    .then((customer) => {
      if (customer) {
        return res.status(400).json("This customer already exists");
      }
      Customer.create({
        firstName: req.body.firstName,
        lastName: req.body.lastName,
        phone: req.body.phone,
        email: req.body.email,
        address: req.body.address,
        isFemale: req.body.isFemale,
        isMember: req.body.isMember
      })
        .then((customer) => res.status(200).json(customer))
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

module.exports.updateCustomer = (req, res, next) => {
  Customer.findOne({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
      "isMember"
    ],
    where: {
      id: req.body.id,
    },
  })
    .then((customer) => {
      if (!customer) {
        return res.status(400).json("This customer does not exist!");
      }
      customer
        .update({
          firstName: req.body.firstName,
          lastName: req.body.lastName,
          phone: req.body.phone,
          email: req.body.email,
          address: req.body.address,
          isFemale: req.body.isFemale,
          isMember: req.body.isMember
        })
        .then((customer) => res.status(200).json(customer))
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

module.exports.deleteCustomer = (req, res, next) => {
  const deletedCustomerId = req.body.id;
  Customer.findOne({
    attributes: [
      "id",
      "firstName",
      "lastName",
      "phone",
      "email",
      "address",
      "isFemale",
      "isMember"
    ],
    where: { id: deletedCustomerId },
  })
    .then((customer) => {
      if (!customer) {
        return res.status(400).json("This customer does not exist!");
      }
      return customer.destroy();
    })
    .then((deletedCustomer) => {
      res.status(201).json(deletedCustomer);
    })
    .catch((err) => {
      if (!err.status) err.statusCode = 500;
      next(err);
    });
};
