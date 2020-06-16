'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    /*
      Add altering commands here.
      Return a promise to correctly handle asynchronicity.
    */
    return queryInterface.bulkInsert('Book', [{
        title: 'The Little Prince',
        price: '50000',
        description: 'beautiful',
        type: 'Fairy Tale',
        quantity: '200',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      title: 'HTML for Dummies',
      price: '1000000',
      description: 'great',
      type: 'Scholarly Book',
      quantity: '200',
      createdAt: new Date(),
      updatedAt: new Date()
    }],{});
  },

  down: (queryInterface, Sequelize) => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.
      
    */
    return queryInterface.bulkDelete('Book', null, {});
  }
};
