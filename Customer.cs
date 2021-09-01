using System; 

class Customer 
	{
		string firstName; 
		string lastName; 
		int IdNumber;
		
		public Customer(string firstName, string lastName) 
		{
			this.firstName = firstName;
			this.lastName = lastName;
			 
		}

		public Customer(int Id) 
		{
			IdNumber = Id; 
		}
		public string getData() {
			Console.Write("First name:\t"); 
			firstName = Console.ReadLine(); 
			Console.Write("Last name:\t"); 
			lastName = Console.ReadLine(); 
			
			return $"{firstName} {lastName}";
		}
		
		public void setName() {
			Console.WriteLine($"Given name:\t {firstName} {lastName}");
		}

		public int getId() {
			System.Console.WriteLine("Enter your ID number, please.");
			Console.Write("ID number:\t"); 
			IdNumber = Convert.ToInt32(Console.ReadLine()); 

			return IdNumber;
		}
		public void setAddress() {
			System.Console.WriteLine($"Given number:\t {IdNumber}");
		}
	}