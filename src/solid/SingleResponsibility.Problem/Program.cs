using SingleResponsibility.Problem;

var orderService = new OrderService();
var order = new Order();

orderService.SaveOrder(order);