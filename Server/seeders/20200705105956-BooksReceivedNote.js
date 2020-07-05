'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.bulkInsert('BooksReceivedNote', [{
        bookID: 2,
        receivedDate: new Date(2020,1,1),
        quantity: 3,
        cost: 80000,
        createdAt: new Date(),
        updatedAt: new Date()
      },
      {
        bookID: 1,
        receivedDate: new Date(2020,1,2),
        quantity: 3,
        cost: 80000,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      ], {});
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.bulkDelete('BooksReceivedNote', null, {});
  }
};
