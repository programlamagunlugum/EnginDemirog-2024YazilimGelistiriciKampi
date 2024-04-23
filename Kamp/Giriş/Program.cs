// See https://aka.ms/new-console-template for more information
using Giriş.Business;
using Giris.DataAccess.Concretes;
using Giriş.Enities;
using Giris.Entities;

Console.WriteLine("Hello, World!");

Course course1 = new Course();
course1.Id = 1;
course1.Name = "c#";
course1.Prices = 10;
course1.Description = ".Net ...";

CourseManager courseManager = new(new CourseDal());
List<Course> courses=courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Prices);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdetity = "11111111111";
customer1.FirstName = "Sıla";
customer1.LastName = "Tekbaş";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdetity = "11111111111";
customer2.FirstName = "Sıla";
customer2.LastName = "Özçelik";
customer2.CustomerNumber = "1238856";

CoorporateCustomer customer3= new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "ProgramlamaGunlugum";
customer3.CustomerNumber = "1234596";
customer3.TaxNumber = "123589";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "abc";
customer4.CustomerNumber = "123454756";
customer4.TaxNumber = "123265589";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
foreach(BaseCustomer customer in customers)
{
   
    Console.WriteLine(customer.CustomerNumber);
}