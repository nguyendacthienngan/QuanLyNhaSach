const OrderController = require('../controllers/order.controller');
const express = require('express');
const router = express.Router();


router.get('/', OrderController.getOrders);

router.get('/total', OrderController.getTotalOrders);
router.post('/total/period', OrderController.getTotalOrdersInPeriod);
router.post('/total/month', OrderController.getTotalOrdersThisMonth);
router.post('/total/year', OrderController.getTotalOrdersThisYear);

router.post('/search', OrderController.searchOrder);
router.post('/filter', OrderController.filterByDate);

router.post('/add', OrderController.addOrder);
router.post('/update', OrderController.updateOrder);
router.delete('/delete/:id', OrderController.deleteOrder);

router.get('/max', OrderController.getMaxIDOrder); //?

router.get('/finalize', OrderController.finalizedOrder);
router.get('/abort', OrderController.abortedOrder);

router.get('/income/month', OrderController.getThisMonthIncome);
router.get('/income/year', OrderController.getYearIncome);



module.exports = router;