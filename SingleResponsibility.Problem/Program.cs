// See https://aka.ms/new-console-template for more information

using SingleResponsibility.Problem;

var orderService = new OrderService();
var order = new Order();

orderService.SaveOrder(order);