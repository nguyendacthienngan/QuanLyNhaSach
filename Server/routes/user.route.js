const express = require("express");
const router = express.Router();
const userController = require("../controllers/user.controller");

router.post("/add", userController.addUser);

router.put("/update", userController.updateUser);

router.get("/", userController.getAllUsers);

router.post("/search", userController.searchUser);

router.delete("/delete", userController.deleteUser);

router.get("/:id", userController.getAnUser);

module.exports = router;
