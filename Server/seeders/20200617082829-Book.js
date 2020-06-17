'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.bulkInsert('Book', [{
        title: 'The Little Prince',
        author: 'Antoine de Saint-Exupéry',
        stock: 500,
        cost: 130000,
        price: 160000,
        description: 'beautiful',
        type: 'Fairy Tale',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      title: 'HTML for Dummies',
      author: 'Nguyễn Công Hoan',
        stock: 500,
        cost: 130000,
      price: '1000000',
      description: 'great',
      type: 'Scholarly Book',
      createdAt: new Date(),
      updatedAt: new Date()
    }],{});
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.bulkDelete('Book', null, {});
  }
};
