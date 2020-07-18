const express = require("express");
const router = express.Router();
const customerController = require("../controllers/customer.controller");

router.post("/add", customerController.addCustomer);

router.put("/update", customerController.updateCustomer);

router.get("/", customerController.getAllCustomers);

router.post("/search/", customerController.searchCustomer);

router.delete("/delete", customerController.deleteCustomer);

router.get("/:id", customerController.getACustomer);

module.exports = router;
