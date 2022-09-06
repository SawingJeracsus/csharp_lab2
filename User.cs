using System;

class User
{
    string login; 
    string name;
    string surname;

    int age;

    readonly DateTime dateOfCreation;

    public User(string login, string name, string surname, int age)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;

        this.dateOfCreation = DateTime.Now;
    }

    public string getInfo() {
        return $"{login} {name} {surname} {age}. Registered: {this.dateOfCreation.ToString()}";
    }
}

