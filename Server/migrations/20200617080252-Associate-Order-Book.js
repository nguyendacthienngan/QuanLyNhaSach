'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable(
      'OrderDetail',
      {
        createdAt: {
          allowNull: false,
          type: Sequelize.DATE,
        },
        updatedAt: {
          allowNull: false,
          type: Sequelize.DATE,
          
        },
        orderID: {
          type: Sequelize.INTEGER,
          primaryKey: true,
          allowNull: false,
          references:{
            model: 'Order',
            key: 'id',
            allowNull: true,
            as: 'orderID'
          }
        },
        bookID: {
          type: Sequelize.INTEGER,
          allowNull: false,
          primaryKey: true,
          references:{
            model: 'Book',
            key: 'id',
            allowNull: true,
            as: 'bookID'
          }
        },
        quantity: {
          type: Sequelize.INTEGER,
          allowNull: false,
        },
        price: {
          type: Sequelize.DOUBLE,
          allowNull: false,
        },
        totalOrderDetail: {
          type: Sequelize.DOUBLE,
          allowNull: false,
        }
      }
    );
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable('OrderDetail');
  }
};
