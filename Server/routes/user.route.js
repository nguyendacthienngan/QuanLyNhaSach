const express = require("express");
const router = express.Router();
const controller = require("../controllers/user.controller");

router.post("/add", controller.addUser);

router.put("/update", controller.updateUser);

router.get("/", controller.getAllUsers);

router.post("/search", controller.searchUser);

router.delete("/delete", controller.deleteUser);

// router.delete("")

module.exports = router;
