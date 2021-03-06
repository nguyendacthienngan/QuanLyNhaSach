const { DataTypes } = require("sequelize");

module.exports = (sequelize) => {
  const attributes = {
    orderDate: {
      type: DataTypes.DATE,
      allowNull: false,
    },
    discount: {
      type: DataTypes.DOUBLE,
      allowNull: false,
    },
    totalOrder: {
      type: DataTypes.DOUBLE,
      allowNull: false,
    },
    isPaid: {
      type: DataTypes.BOOLEAN,
      allowNull: false,
    },
    paidAmount: {
      type: DataTypes.DOUBLE
    },
  };
  const options = {
    tableName: "Order",
    comment: "",
    indexes: [],
    paranoid: true,
    timestamps: true
  };
  const Order = sequelize.define("Order", attributes, options);
  Order.associate = function (models) {
    Order.belongsTo(models.User, {
      foreignKey: "userID",
      as: "Users",
    });

    Order.belongsTo(models.Customer, {
      foreignKey: "customerID",
      as: "Customers",
    });

    Order.belongsToMany(models.Book, {
      through: "OrderDetail",
      as: "Books",
      foreignKey: "orderID",
      otherKey: "bookID",
    });
  };
  return Order;
};
