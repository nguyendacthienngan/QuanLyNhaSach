const express = require("express");
const router = express.Router();
const controller = require("../controllers/user.controller");

router.post("/add", controller.addUser);

router.post("/update", controller.updateUser);

router.get("/", controller.getAllUsers);

router.get("/:id", controller.searchUserById);

module.exports = router;
