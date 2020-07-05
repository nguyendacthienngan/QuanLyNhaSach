"use strict";

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable("Order", {
      id: {
        allowNull: false,
        autoIncrement: true,
        primaryKey: true,
        type: Sequelize.INTEGER,
      },
      orderDate: {
        type: Sequelize.DATE,
        allowNull: false,
      },
      discount: {
        type: Sequelize.DOUBLE,
        allowNull: false,
      },
      totalOrder: {
        type: Sequelize.DOUBLE,
        allowNull: false,
      },
      paidAmount: {
        type: Sequelize.DOUBLE
      },
      isPaid: { // BOOLEAN hay BOOL
        type: Sequelize.BOOLEAN,
        allowNull: false,
      },
      userID: {
        type: Sequelize.INTEGER,
        references: {
          model: "User",
          key: "id",
          allowNull: false,
          as: "userID",
        },
      },
      customerID: {
        type: Sequelize.INTEGER,
        references: {
          model: "Customer",
          key: "id",
          allowNull: false,
          as: "customerID",
        },
      },
      createdAt: {
        allowNull: false,
        type: Sequelize.DATE,
      },
      updatedAt: {
        allowNull: false,
        type: Sequelize.DATE,
      },
      deletedAt: {
        type: Sequelize.DATE,
      },
    });
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable("Order");
  },
};
