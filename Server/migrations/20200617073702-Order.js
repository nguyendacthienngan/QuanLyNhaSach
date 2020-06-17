'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable('Order', 
    {
      id: {
        allowNull: false,
        autoIncrement: true,
        primaryKey: true,
        type: Sequelize.INTEGER
      },
      orderDate: {
        type: Sequelize.DATE,
        allowNull: false,
      },
      discount: {
        type: Sequelize.DOUBLE,
        allowNull: true,
      },
      totalOrder: {
        type: Sequelize.DOUBLE,
        allowNull: false,
      },
      status: {
        type: Sequelize.INTEGER,
        allowNull: false,
      },
      userID : {
        type: Sequelize.INTEGER,
        references:{
          model: 'User',
          key: 'id',
          allowNull: false,
          as: 'userID'
        },
        onDelete: 'SET NULL'
      },
        customerID : {
          type: Sequelize.INTEGER,
          references:{
            model: 'Customer',
            key: 'id',
            allowNull: false,
            as: 'customerID'
          },
          onDelete: 'SET NULL'
        },
      createdAt: {
        allowNull: false,
        type: Sequelize.DATE
      },
      updatedAt: {
        allowNull: false,
        type: Sequelize.DATE
      }
    });
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable('Order');
  }
};
