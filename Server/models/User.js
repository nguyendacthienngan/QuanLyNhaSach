const { DataTypes } = require("sequelize");

module.exports = (sequelize) => {
  const attributes = {
    firstName: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    lastName: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    phone: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    idCard: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    email: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    dateOfBirth: {
      type: DataTypes.DATE,
      allowNull: false,
    },
    address: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    isFemale: {
      type: DataTypes.BOOLEAN,
    },
  };
  const options = {
    tableName: "User",
    comment: "",
    indexes: [],
    timestamps: true,
    paranoid: true,
  };
  const User = sequelize.define("User", attributes, options);
  return User;
};
