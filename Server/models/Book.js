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
    price: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    description: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    quantity: {
      type: DataTypes.INTEGER,
      allowNull: false,
    },
    type: {
      type: DataTypes.STRING,
      allowNull: false,
    }
  }, options);
  return Book;
};