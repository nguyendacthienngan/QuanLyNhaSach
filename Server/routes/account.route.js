const accountController = require("../controllers/account.controller");
const express = require("express");
const router = express.Router();

router.get("/", accountController.getAllAccounts);
router.post("/update", accountController.updateAccount);
router.get("/:id", accountController.getAnAccount);

module.exports = router;
