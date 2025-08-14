using System;

public class Customer
{
    private string _customerName;
    private Address _address;


   public Customer(string customerName, Address addres)
   {
     _customerName = customerName
     _address = address
   }

   public string LivesInUSA()
   {
      string country = "Country: "
      country += $"Lives in: {_address.getCountry()}";
      return country
   }

}    