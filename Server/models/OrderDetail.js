const {
    DataTypes
  } = require('sequelize');
  
  module.exports = sequelize => {
    const attributes = {
      quantity: {
        type: DataTypes.INTEGER,
        allowNull: false,
      },
      price: {
        type: DataTypes.DOUBLE,
        allowNull: false,
      },
      totalOrderDetail: {
        type: DataTypes.DOUBLE,
        allowNull: false,
      }
    };
    const options = {
      tableName: "OrderDetail",
      comment: "",
      indexes: []
    };
    const OrderDetail = sequelize.define("OrderDetail", attributes, options);
    return OrderDetail;
  };