'use strict';
module.exports = (sequelize, DataTypes) => {
  const options = {
    tableName: "Book", // QUAN TRỌNG!!
    comment: "",
    indexes: []
  };
  const Book = sequelize.define('Book', {
    title: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    author: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    stock: {
      // Số lượng hàng còn trong kho
      type: DataTypes.DOUBLE,
      allowNull: false,
    },
    cost: {
      // Giá mua
      type: DataTypes.DOUBLE,
      allowNull: false,
    },
    price: {
      // Giá bán
      type: DataTypes.DOUBLE,
      allowNull: false,
    },
    description: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    type: {
      type: DataTypes.STRING,
      allowNull: false,
    }
  }, options);
  Book.associate = function (models) {
      Book.belongsToMany(models.Order, {
        through: 'OrderDetail',
        foreignKey: 'bookID',
        as: 'Orders'
      })
  }
  return Book;
};