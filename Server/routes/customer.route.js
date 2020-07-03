const express = require("express");
const router = express.Router();
const controller = require("../controllers/customer.controller");

router.post("/add", controller.addCustomer);

router.put("/update", controller.updateCustomer);

router.get("/", controller.getAllCustomers);

router.post("/search/", controller.searchCustomer);

router.delete("/delete", controller.deleteCustomer);

module.exports = router;
