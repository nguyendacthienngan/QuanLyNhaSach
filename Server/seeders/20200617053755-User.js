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
      dateOfBirth: new Date(2000,4,15),
      isFemale: true,
      phone: '1234567',
      address: '1 Nguyễn Trãi Q1',
      idCard: '123321',
      email: 'nguyendacthienngan@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      firstName: 'Hiếu',
      lastName: 'Trương',
      dateOfBirth: new Date(2000,5,15),
      isFemale: false,
      phone: '1234567',
      address: '2 Lê Lợi Q1',
      idCard: '123321',
      email: 'finn@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      firstName: 'Chương',
      lastName: 'Tăng',
      dateOfBirth: new Date(2000,4,23),
      isFemale: false,
      phone: '1234567',
      address: '3 Cống Quỳnh Q1',
      idCard: '123321',
      email: 'chuong@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      firstName: 'Dón',
      lastName: 'Chung',
      dateOfBirth: new Date(2000,4,5),
      isFemale: true,
      phone: '1234567',
      address: '4 Lê Hồng Phong Q5',
      idCard: '123321',
      email: 'donchung@gmail.com',
      createdAt: new Date(),
      updatedAt: new Date()
    }, {
      firstName: 'Tiên',
      lastName: 'Bảo Bảo',
      dateOfBirth: new Date(2000,21,12),
      isFemale: true,
      phone: '1234567',
      address: '5 Lê Lai Q3',
      idCard: '123321',
      email: 'tienbaobao@gmail.com',
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
