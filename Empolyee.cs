class Employee
{
    public enum Role
    {
        worker,
        manager,
        boss
    }

    string name;
    string surname;

    public Employee(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public double getSalaryValue(Role role, int experience, double percentageOfTaxLevy)
    {
        var taxLevy = 1 - percentageOfTaxLevy;

        switch (role)
        {
            case Role.worker:
                return (15000 + 1000 * experience) * taxLevy;
            case Role.manager:
                return (20000 + 1200 * experience) * taxLevy;
            case Role.boss:
                return (35000 + 2000 * experience) * taxLevy;
        }

        return 0;
    }

    public string getInfo(Role role, int experience, double percentageOfTaxLevy)
    {
        return $"{this.surname} {this.name} {role} {this.getSalaryValue(role, experience, percentageOfTaxLevy)}";
    }
}

