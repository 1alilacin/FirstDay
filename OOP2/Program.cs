// See https://aka.ms/new-console-template for more information
using OOP2;

RealCustomer realCustomer = new RealCustomer();
realCustomer.Id = 1;
realCustomer.CustomerNumber = "12345";
realCustomer.Name = "Melike";
realCustomer.Surname = "Öztekin";
realCustomer.IdNumber = "12345678910";

//Kodlama.io
CompanyCustomer companyCustomer = new CompanyCustomer();
companyCustomer.Id = 2;
companyCustomer.CustomerNumber = "23456";
companyCustomer.CompanyName = "Kodlama.io";
companyCustomer.FeeNumber = "987654321";

//GercekMusteri - CompanyCustomer 
//Musteri çeşitleri - bunlar birbirine benzeyen iki farklı tiptir- asla birbirinin yerine kullanılamazlar.)
//SOLID in L harfi "birbirine benziyor diye birbirinin yerine kullanma.!!

Customer customer3 = new RealCustomer();
Customer customer4 = new CompanyCustomer();
//Biryerde new (ref.no) varsa bu bellekteki bir referans numarası demektir.
//Musteri classı musteri3 ve musteri4 un referansını tutuyor.
//Yani hem GercekMusteri hem de  CompanyCustomer referanslarını tutar.

CustomerManager customerManager = new CustomerManager();
customerManager.Add(realCustomer);
customerManager.Add(companyCustomer);
customerManager.Add(customer4);
customerManager.Add(customer3);
customerManager.Add(customer3);