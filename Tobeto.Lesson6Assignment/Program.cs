using Tobeto.Lesson6Assignment;

CoffeeOrder coffeeOrder = new CoffeeOrder("espresso","orta");
coffeeOrder.RemoveExstra("buz");
coffeeOrder.AddExstra("süt");
coffeeOrder.AddExstra("şeker");
coffeeOrder.OrderDetails();