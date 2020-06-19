const express = require("express");
const router = express.Router();
const controller = require("../controllers/user.controller");
// Đây là cánh cửa bước vào căn phòng của User, trong cánh cửa này sẽ có thêm 4 cánh cửa nữa
// Từ user đến add hoặc getAllusers 

router.post("/add", controller.addUser);

router.post("/update", controller.updateUser);
// Ở đây /update trong route này có nghĩa là http://localhost:8080/user/update 
//Sẽ có 2 phương thức mọi người cần lưu ý: GET và POST  để khi tạo request nhé !
router.get("/", controller.getAllUsers);

router.get("/:id", controller.searchUserById);

module.exports = router;
