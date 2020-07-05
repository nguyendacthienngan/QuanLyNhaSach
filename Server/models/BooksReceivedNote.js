"use strict";
module.exports = (sequelize, DataTypes) => {
  const options = {
    tableName: "BooksReceivedNote",
    comment: "",
    indexes: [],
    timestamps: true,
    paranoid: true,
  };
  const BooksReceivedNote = sequelize.define(
    "BooksReceivedNote",
    {
      receivedDate: {
        type: DataTypes.DATE,
        allowNull: false,
        primaryKey:true, // Cần k?
      },
      quantity: {
        type: DataTypes.INTEGER,
        allowNull: false,
      },
      cost: {
        type: DataTypes.DOUBLE,
        allowNull: false,
      },
    },
    options
  );
  BooksReceivedNote.associate = function (models) {
    BooksReceivedNote.belongsTo(models.Book, {
      foreignKey: "bookID",
      primaryKey:true,
      as: "Books",
    });
  }
  return BooksReceivedNote;
};
