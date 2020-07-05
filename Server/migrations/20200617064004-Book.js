'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable('Book', 
    { 
        id: {
          allowNull: false,
          autoIncrement: true,
          primaryKey: true,
          type: Sequelize.INTEGER
        },
        title: {
          type: Sequelize.STRING,
          allowNull: false,
        },
        author: {
          type: Sequelize.STRING,
          allowNull: false,
        },
        stock: {
          type: Sequelize.DOUBLE,
          allowNull: false,
        },
        cost: {
          type: Sequelize.DOUBLE,
          allowNull: false,
        },
        price: {
          type: Sequelize.DOUBLE,
          allowNull: false,
        },
        description: {
          type: Sequelize.STRING,
          allowNull: true,
        },
        genre: {
          type: Sequelize.STRING,
          allowNull: false,
        },
        imageUrl: {
          allowNull: false,
          type: Sequelize.STRING
        },
        releasedDate: {
          allowNull: false,
          type: Sequelize.DATE
        },
        createdAt: {
          allowNull: false,
          type: Sequelize.DATE
        },
        updatedAt: {
          allowNull: false,
          type: Sequelize.DATE
        },
        deletedAt: {
          type: Sequelize.DATE,
        }
    }
    );
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable('Book');
  }
};
