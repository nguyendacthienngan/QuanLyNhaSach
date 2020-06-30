const express = require("express");
const router = express.Router();
const controller = require("../controllers/user.controller");

router.post("/add", controller.addUser);

router.put("/update", controller.updateUser);

router.get("/", controller.getAllUsers);

router.get("/search/:info", controller.searchUserByInfo);

router.delete("/delete/:userId", controller.deleteUserById);

// router.delete("")

module.exports = router;
