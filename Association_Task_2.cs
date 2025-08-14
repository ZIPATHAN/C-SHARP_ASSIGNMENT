using System.Threading.Channels;

namespace Association
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Customer()
        {
            
        }

        public Customer(int id, string name, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Customer [Id : {this.Id}, Name : {this.Name}, Gender : {this.Gender}]";
        }
    }

    class Account
    {
        public int Id { get; set; }

        public Customer cust {  get; set; } = new Customer { Id = 123, Name = "Pratham", Gender = "Male"};

        public double Balance { get; set; }

        public Account()
        {
             
        }

        public Account(int id, Customer customer, double balance)
        {
            this.Id = id;
            this.cust = customer;
            this.Balance = balance;            
        }

        public double Deposit(double amt)
        {
            return this.Balance += amt;
        }

        public double Withdraw(double amt)
        {
            if (amt < this.Balance - 500)
            {
                return this.Balance -= amt;
            }
            else
            {
                Console.WriteLine("Insufficient balance. Minimum balance of 500 must be maintained");
                return this.Balance;
            }
        }
        public override string ToString()
        {
            return $"Account [Id : {this.Id}, {this.cust}, Balance : {this.Balance}]";
        }
    }

    class Association2
    {
       public static void Main(string[] args)
        {
            Account ac = new Account { Id = 1001, Balance = 12000 };
            Console.WriteLine(ac);
            Console.WriteLine(ac.Deposit(1000));
            //Console.WriteLine(ac.Withdraw(11400));
            Console.WriteLine(ac);
        }
    }
}
