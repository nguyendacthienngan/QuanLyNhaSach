"use strict";

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.bulkInsert(
      "Order",
      [
        {
          userId: 1,
          customerId: 1,
          orderDate: new Date(),
          discount: 0.1,
          totalOrder: 10000,
          status: 0,
          createdAt: new Date(),
          updatedAt: new Date(),
        },
        {
          userId: 2,
          customerId: 3,
          orderDate: new Date(),
          discount: 0.2,
          totalOrder: 12000,
          status: 1,
          createdAt: new Date(),
          updatedAt: new Date(),
        },
      ],
      {}
    );
  },

  down: (queryInterface, Sequelize) => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.

      Example:
      return queryInterface.bulkDelete('People', null, {});
    */
  },
};
