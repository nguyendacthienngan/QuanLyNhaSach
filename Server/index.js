const express = require("express");
const bodyParser = require("body-parser");
const app = express();
const port = 8080;
const db = require("./models/index");
const bookRoutes = require("./routes/book.route");
const authRoute = require("./routes/auth.route");
const userRoute = require("./routes/user.route");
const orderRoute = require("./routes/order.route");
const customerRoute = require("./routes/customer.route");
const accountRoute = require("./routes/account.route");
const booksReceivedNoteRoute = require("./routes/booksReceivedNote.route");

// Để có req.body
app.use(bodyParser.json()); // for parsing application/json
app.use(bodyParser.urlencoded({ extended: true })); // for parsing application/x-www-form-urlencoded

app.use("/book", bookRoutes);
app.use("/auth", authRoute);
app.use("/user", userRoute);
app.use("/order", orderRoute);
app.use("/customer", customerRoute);
app.use("/account", accountRoute);
app.use("/booksReceivedNote", booksReceivedNoteRoute);
//Test
app.get("/", function (req, res) {
  res.send("Welcome to this API.");
});
// when a random route is inputed
//   app.get('*', (req, res) => res.status(200).send({
//     message: 'Welcome to this API.'
//   }));
app.listen(port, () => {
  console.log(`Server is running on port ${port}.`);
});
