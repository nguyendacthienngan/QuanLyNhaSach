"use strict";

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.bulkInsert('Book', [{
        title: 'The Little Prince',
        author: 'Antoine de Saint-Exupéry',
        stock: 500,
        cost: 130000,
        price: 160000,
        description: 'beautiful',
        genre: 'Fairy Tale',
        releasedDate: new Date(2000,1,1),
        imageUrl: 'https://images-na.ssl-images-amazon.com/images/I/71QKDKxL-jL.jpg',
        createdAt: new Date(),
        updatedAt: new Date()
    }, {
      title: 'HTML for Dummies',
      author: 'Nguyễn Công Hoan',
        stock: 500,
        cost: 130000,
        price: '1000000',
        description: 'great',
        genre: 'Scholarly Book',
        releasedDate: new Date(2000,1,1),
        imageUrl: 'https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX397_BO1,204,203,200_.jpg',
        createdAt: new Date(),
        updatedAt: new Date()
    }],{});
  },

  down: (queryInterface, Sequelize) => {
    return queryInterface.bulkDelete("Book", null, {});
  },
};
