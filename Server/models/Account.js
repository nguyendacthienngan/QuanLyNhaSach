'use strict';
module.exports = (sequelize, DataTypes) => {
  const options = {
    tableName: "Account", // QUAN TRỌNG!!
    comment: "",
    indexes: []
  };
  const Account = sequelize.define('Account', {
    username: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    password: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      role: {
          type: DataTypes.INTEGER,
          allowNull: false,
        }
  }, options);
  Account.associate = function(models)
  {
      Account.belongsTo(models.User, {
          foreignKey: 'userID', 
          as: 'Users'
      })
  };
  return Account;
};