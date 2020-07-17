const orderController = require("../controllers/order.controller");
const express = require("express");
const router = express.Router();

router.get("/", orderController.getOrders);

router.get("/total", orderController.getTotalOrders);
router.post("/total/period", orderController.getTotalOrdersInPeriod);
router.post("/total/month", orderController.getTotalOrdersThisMonth);
router.post("/total/year", orderController.getTotalOrdersThisYear);

router.post("/search", orderController.searchOrder);
router.post("/filter", orderController.filterByDate);

router.post("/add", orderController.addOrder);
router.post("/update", orderController.updateOrder);
router.delete("/delete/:id", orderController.deleteOrder);

router.get("/max", orderController.getMaxIDOrder); //?

router.get("/finalize", orderController.finalizedOrder);
router.get("/abort", orderController.abortedOrder);

router.get("/income/month", orderController.getThisMonthIncome);
router.get("/income/year", orderController.getYearIncome);

router.get("/:id", orderController.getAnOrder);

module.exports = router;
