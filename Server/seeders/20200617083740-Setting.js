'use strict';

module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.bulkInsert('Setting', [{
      // Số lượng nhập tối thiểu
        key: 'Minium order quantity',
        value: 150,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        // Chỉ nhập sách có lượng tồn ít hơn 300 (Lượng tồn tối thiểu)
        key: 'Maximum level of inventory before inputting',
        value: 300,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        // Chỉ bán cho các khách nợ không quá 20k (Tiền nợ tối đa)
        key: 'Maximum level Of debt',
        value: 20000,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        //Đầu sách có lượng tồn sau khi bán ít nhất là 20 (lượng tồn tối thiểu)
        key: 'Minium level Of inventory after outputting',
        value: 20,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      {
        // Số tiền thu không được vượt quá số tiền khách hàng đang nợ
        // Value: Có sử dụng hay không: 0 là không sử dụng, 1 là sử dụng
        key: 'Receiving-money is lower or equal Customer Dept',
        value: 1,
        createdAt: new Date(),
        updatedAt: new Date()
      
      },
      ], {});
  },

  down: (queryInterface, Sequelize) => {
    
    return queryInterface.bulkDelete('Setting', null, {});
  }
};
