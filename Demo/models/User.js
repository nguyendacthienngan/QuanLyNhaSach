const {
    DataTypes
  } = require('sequelize');
  
  module.exports = sequelize => {
    const attributes = {
      id: {
        type: DataTypes.INTEGER,
        allowNull: false,
        defaultValue: "nextval(\"Users_id_seq\"::regclass)",
        comment: null,
        primaryKey: true,
        field: "id",
        autoIncrement: false
      },
      firstName: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "firstName",
        autoIncrement: false
      },
      lastName: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "lastName",
        autoIncrement: false
      },
      username: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "username",
        autoIncrement: false
      },
      password: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "password",
        autoIncrement: false
      },
      dateOfBirth: {
        type: DataTypes.DATE,
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "dateOfBirth",
        autoIncrement: false
      },
      isFemale: {
        type: DataTypes.BOOLEAN,
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "isFemale",
        autoIncrement: false
      },
      phoneNumber: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "phoneNumber",
        autoIncrement: false
      },
      idCard: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "idCard",
        autoIncrement: false
      },
      email: {
        type: DataTypes.CHAR(255),
        allowNull: true,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "email",
        autoIncrement: false
      },
      createdAt: {
        type: DataTypes.DATE,
        allowNull: false,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "createdAt",
        autoIncrement: false
      },
      updatedAt: {
        type: DataTypes.DATE,
        allowNull: false,
        defaultValue: null,
        comment: null,
        primaryKey: false,
        field: "updatedAt",
        autoIncrement: false
      }
    };
    const options = {
      tableName: "User",
      comment: "",
      indexes: []
    };
    const User = sequelize.define("User", attributes, options);
    return User;
  };