﻿namespace zimmers.Entities
{
    public class User
    {
        static int id = 1;
        public int Id { get; private set; }
        public int Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Bank_account { get; set; }
        //public DateOnly Date_registration { get; set; }

        public DateTime Date_registration { get; set; }
        public int Max_amount_per_night { get; set; }
        public int Num_of_persons { get; set; }
        public int Num_of_orders { get; set; }
        public User()
        {
            Id = id;
            id++;
        }
        public User(User u)
        {
            Id = id;
            id++;
            //this.Id = u.Id;
            this.Tz = u.Tz;
            this.Name = u.Name;
            this.Address = u.Address;
            this.Phone = u.Phone;
            this.Bank_account = u.Bank_account;
            this.Date_registration = u.Date_registration;
            this.Max_amount_per_night = u.Max_amount_per_night;
            this.Num_of_persons = u.Num_of_persons;
            this.Num_of_orders = u.Num_of_orders;
        }
        //public User(int id, int tz, string name, string address, int phone, string bank_account, DateTime date_registration, int max_amount_per_night, int num_of_persons, int num_of_orders)
        //{
        //    Id = id;
        //    Tz = tz;
        //    Name = name;
        //    Address = address;
        //    Phone = phone;
        //    Bank_account = bank_account;
        //    Date_registration = date_registration;
        //    Max_amount_per_night = max_amount_per_night;
        //    Num_of_persons = num_of_persons;
        //    Num_of_orders = num_of_orders;
        //}
    }
}