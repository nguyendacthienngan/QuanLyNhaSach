'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    /*
      Add altering commands here.
      Return a promise to correctly handle asynchronicity.
    */
    return queryInterface.bulkInsert('User', [{
      firstName: 'Ngân',
      lastName: 'Nguyễn',
      username: 'admin',
      password: 'admin',
      dateOfBirth: new Date(2000,4,15),
      isFemale: true,
      phoneNumber: 1234567,
      idCard: 123321,
      email: 'nguyendacthienngan@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }], {});
  },

  down: (queryInterface, Sequelize) => {
    /*
      Add reverting commands here.
      Return a promise to correctly handle asynchronicity.
      
    */
    return queryInterface.bulkDelete('User', null, {});
  }
};
