const express = require("express");
const router = express.Router();
const controller = require("../controllers/customer.controller");

router.post("/add", controller.addCustomer);

router.post("/update", controller.updateCustomer);

router.get("/", controller.getAllCustomers);

router.get("/:customer", controller.searchCustomerById);

module.exports = router;
