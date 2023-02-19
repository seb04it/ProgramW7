
using Klasy;

User user1 = new User("Seba", "Masło1");
User user2 = new User("Szymon", "Masło2");
User user3 = new User("Michał", "Masło3");
User user4 = new User("Miłosz", "Masło4");

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(-10);

var result = user1.Result;
Console.WriteLine(result);