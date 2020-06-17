const md5 = require('md5'); //md5 ánh xạ 1 - 1

const db = require("../models");
const sequelize = require('sequelize')

const Op = sequelize.Op;
const Account = db.Account
//Đăng nhập - kiểm tra thông tin tài khoản
module.exports.postLogin = function(req, res)
{
    var username_input = req.body.username;
    var password = req.body.password;
    Account.findOne({
        attributes: ['username', 'password', 'role', 'userID'],
        order:    ['username'],
        where: {
            username: username_input
          }})
          .then(function(user){
              if(user.password === password)
              {
                res.status(200).send({
                    message: "Success1",
                    
                  });
                return;
              }
              else if (user.password !== password)
              {
                res.status(400).send({
                    message: "Wrong Password"
                    });
                    return ;
              }
              else
              {
                res.status(400).send({
                    message: "User does not exist"
                    });
                    return ;
              }
          })
          .catch(function(error){
            res.status(400).send({
                message: "User does not exist"
                });
                return ;
          });
        
    // user.password : md5 hash of password in db
    //  password: input of user
    // Do chưa có mã hóa: var hashedPassword = md5(password);


    // Cookie
    //res.cookie('userID', user.id);
    
};


