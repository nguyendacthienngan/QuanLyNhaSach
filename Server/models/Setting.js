const {
    DataTypes
  } = require('sequelize');
  
  module.exports = sequelize => {
    const attributes = {
      key: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      value: {
        type: DataTypes.INTEGER,
        allowNull: false,
      }
    };
    const options = {
      tableName: "Setting",
      comment: "",
      indexes: []
    };
    const Setting = sequelize.define("Setting", attributes, options);
    return Setting;
  };