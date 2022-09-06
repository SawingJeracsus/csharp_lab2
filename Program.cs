using System;

namespace Program
{
    class App
    {
        static void Main()
        {
            var address = new Address("44220", "Ukraine", "Kyiv", "Lobachvskogo", "23a", "417");
            address.print();            

            var converter = new Converter(0.027, 0.03, 1.66);

            Console.WriteLine(converter.convertUan(100).toEur());

            var employee = new Employee("Andrii", "Polishchuk");

            Console.WriteLine(employee.getInfo(Employee.Role.manager, 2, 0.05));

            var user = new User("sawinjer", "Andrii", "Polishchuk", 18);

            Console.WriteLine(user.getInfo());
        }
    }
}
