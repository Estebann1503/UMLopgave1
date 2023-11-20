using PizzaStore;

Pizza pizza1 = new Pizza(1, "Salami", "Tomato, Cheese, Salami", 75);
Pizza pizza2 = new Pizza(2, "Kødsovs", "Tomato, Cheese, kødsovs", 125);
Pizza pizza3 = new Pizza(3, "Klaus", "Tomato, Cheese, Pepperoni, Cocktailpølser, Gorgonzola", 95);

Kunde kunde1 = new Kunde("Thomas", "77889911");
Kunde kunde2 = new Kunde("Julie", "22334455");
Kunde kunde3 = new Kunde("Fie", "77881122");
double totalPrice;


//ordre 1

Ordre ordre1 = new Ordre(pizza1, kunde1);

ordre1.TilføjLevering();
totalPrice = ordre1.CalculateTotalPrice();

Console.WriteLine($"Ordre 2: {ordre1.pizza.Navn}, {ordre1.Kunde.Navn}, {totalPrice} kr.");

//Ordre 2

Ordre ordre2 = new Ordre(pizza2, kunde2);

totalPrice = ordre2.CalculateTotalPrice();

Console.WriteLine($"Ordre 1: {ordre2.pizza.Navn}, {ordre2.Kunde.Navn}, {totalPrice} kr.");