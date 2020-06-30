const express = require("express");
const router = express.Router();
const controller = require("../controllers/customer.controller");

router.post("/add", controller.addCustomer);

router.put("/update", controller.updateCustomer);

router.get("/", controller.getAllCustomers);

router.get("/search/:info", controller.searchCustomerByInfo);

router.delete("/delete/:customerId", controller.deleteCustomerById);

module.exports = router;
