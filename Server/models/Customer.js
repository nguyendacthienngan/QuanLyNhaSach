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
    email: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    address: {
      type: DataTypes.STRING,
      allowNull: false,
    },
    isFemale: {
      type: DataTypes.BOOLEAN,
      allowNull: false,
    },
    isMember: { 
      type: DataTypes.BOOLEAN,
      allowNull: false,
    },
  };
  const options = {
    tableName: "Customer",
    comment: "",
    indexes: [],
    timestamps: true,
    paranoid: true,
  };
  const Customer = sequelize.define("Customer", attributes, options);
  return Customer;
};
