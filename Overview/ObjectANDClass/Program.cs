// See https://aka.ms/new-console-template for more information


using ObjectANDClass;

CustomFile file = new CustomFile();
file.Title = "Config";

CustomFile users = new CustomFile();
users.Title = "Participants";

CustomFile another = new CustomFile();
another = users;
another.Title = "Another File";

Console.WriteLine(users.Title);
