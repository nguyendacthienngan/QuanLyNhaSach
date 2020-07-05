"use strict";
module.exports = (sequelize, DataTypes) => {
  const options = {
    tableName: "Account",
    comment: "",
    indexes: [],
  };
  const Account = sequelize.define(
    "Account",
    {
      id: {
        type: DataTypes.INTEGER,
        allowNull: false,
        autoIncrement: true,
        primaryKey: true,
      },
      username: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      password: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      isAdmin: {
        type: DataTypes.BOOLEAN, //0: Admin, 1: Normal Employee
        allowNull: false,
      },
    },
    options
  );
  Account.associate = function (models) {
    Account.belongsTo(models.User, {
      foreignKey: "userID",
      as: "Users",
    });
  };
  return Account;
};
