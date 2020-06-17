'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    /*
      Add altering commands here.
      Return a promise to correctly handle asynchronicity.
    */
    return queryInterface.bulkInsert('Customer', [{
      firstName: 'Vàng',
      lastName: 'Tân',
      isFemale: false,
      phone: '1234567',
      address: '1 Nguyễn Trãi Q1',
      email: 'toantan@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      firstName: 'Bách',
      lastName: 'Nguyễn',
      isFemale: false,
      phone: '1234567',
      address: '2 Lê Lợi Q1',
      email: 'bachnguyen@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }], {});
  },

  down: (queryInterface, Sequelize) => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.
      
    */
    return queryInterface.bulkDelete('Customer', null, {});
  }
};
