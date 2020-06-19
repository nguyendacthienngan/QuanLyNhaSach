const db = require("../models");
const sequelize = require('sequelize');
const Order = db.Order;
const Op = sequelize.Op;

// Total 
module.exports.getOrders = function(req, res){
    Order.findAll()
    .then((orders)=> res.status(200).send(orders))
    .catch((error) => res.status(400).send(error.message))
}

module.exports.getTotalOrders = function(req, res){
    Order.count()
    .then((total)  => res.status(200).send(total.toString()))
    .catch((error)  => res.sendStatus(400).send(error.message))
}

module.exports.getTotalOrdersInPeriod = function(req, res){
    const dateFrom = req.body.dateFrom;
    const dateTo = req.body.dateTo;
    Order.count({
        where: {
            [Op.between] : [dateFrom, dateTo]
        }
    }) 
    .then((total)  => res.status(200).send(total.toString()))
    .catch((error)  => res.sendStatus(400).send(error.message))
}


module.exports.getTotalOrdersThisMonth = function(req, res){
    const month = req.body.month;
    const year = req.body.year;
    Order.count({
        where: {
            $and: [
                sequelize.where(sequelize.fn('month', sequelize.col("orderDate")), month),
                sequelize.where(sequelize.fn('year', sequelize.col("orderDate")), year),
                    // Chưa test, chưa chắc lắm
              ]
        }
    }) 
    .then((total)  => res.status(200).send(total.toString()))
    .catch((error)  => res.sendStatus(400).send(error.message))
}

module.exports.getTotalOrdersThisYear = function(req, res){
    const year = req.body.year;
    Order.count({
        where: {
            // Chưa test, chưa chắc lắm
            $where : [sequelize.where(sequelize.fn('year', sequelize.col("orderDate")), year)]
        }
    }) 
    .then((total)  => res.status(200).send(total.toString()))
    .catch((error)  => res.sendStatus(400).send(error.message))
}
// Search & Filter
module.exports.searchOrder = function(req, res){

}


module.exports.filterByDate = function(req, res){
    
}


module.exports.addOrder = function(req, res){
    
}

module.exports.updateOrder = function(req, res){
    
}

module.exports.deleteOrder = function(req, res){
    //Chưa làm
}

module.exports.getMaxIDOrder = function(req, res){
    // ????
}

module.exports.finalizedOrder = function(req, res){
    
}

module.exports.abortedOrder = function(req, res){
    
}


// INCOME
module.exports.getThisMonthIncome = function(req, res){
    
}

module.exports.getYearIncome = function(req, res){
    
}
