const AccountController = require("../controllers/account.controller");
const express = require("express");
const router = express.Router();

router.get("/", AccountController.getAllAccounts);
router.post("/update", AccountController.updateAccount);

module.exports = router;
