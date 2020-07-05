'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.bulkInsert('Account', [{
        username: 'heoboi',
        password: '123',
        isAdmin: true, // Admin
        userID: 1,
        createdAt: new Date(),
        updatedAt: new Date()
      },
      {
        username: 'hieu_truong',
        password: '456',
        isAdmin: false, // Employee
        userID: 2,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        username: 'khanh_chuong',
        password: '456',
        isAdmin: false, // Employee
        userID: 3,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        username: 'don_chung',
        password: '789',
        isAdmin: false, // Employee
        userID: 4,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        username: 'tien_bao',
        password: 'vang',
        isAdmin: false, // Employee
        userID: 5,
        createdAt: new Date(),
        updatedAt: new Date()
      
      }], {});
  },

  down: (queryInterface, Sequelize) => {
    
    return queryInterface.bulkDelete('Account', null, {});
  }
};
