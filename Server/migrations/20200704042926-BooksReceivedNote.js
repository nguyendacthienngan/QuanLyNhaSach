'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable("BooksReceivedNote", {
      receivedDate: {
        type: Sequelize.DATE,
        allowNull: false,
        primaryKey: true,
      },
      bookID: {
        type: Sequelize.INTEGER,
        references: {
          model: "Book",
          key: "id",
          allowNull: false,
          as: "bookID",
        },
        onDelete: "SET NULL",
      },
      quantity: {
        allowNull: false,
        type: Sequelize.INTEGER,
      },
      cost: {
        allowNull: false,
        type: Sequelize.DOUBLE,
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
      }
    });
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable("BooksReceivedNote");
  }
};
