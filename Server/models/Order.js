const {
    DataTypes
  } = require('sequelize');
  
  module.exports = sequelize => {
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
      status: {
        type: DataTypes.INTEGER,
        allowNull: false,
      }
    };
    const options = {
      tableName: "Order",
      comment: "",
      indexes: []
    };
    const Order = sequelize.define("Order", attributes, options);
    Order.associate = function(models){
        Order.hasMany(models.User, {
            foreignKey: "userID",
            as: 'Users'
        });

        Order.hasMany(models.Customer, {
            foreignKey: "customerID",
            as: 'Customers'
        });

        Order.belongsToMany(models.Book, 
        { 
            through: 'OrderDetail', 
            foreignKey: 'orderID', 
            as: 'Books'
        });
    };
    return Order;
  };