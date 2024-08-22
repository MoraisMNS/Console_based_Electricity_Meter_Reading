// See https://aka.ms/new-console-template for more information

using Sample_Project;

Console.WriteLine("Enter your First Name");
string? firstName = Console.ReadLine();

Console.WriteLine("Enter your Last Name");
string? lastName = Console.ReadLine();

Console.WriteLine("Enter your Id No");
string? idNo = Console.ReadLine();

Console.WriteLine("Enter your Phone No");
string? phoneNo = Console.ReadLine();

Users user = new Users(firstName,lastName,idNo,phoneNo);

Console.WriteLine("Enter the Initial unit");
int initialUnit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the final unit");
int finalUnit = Convert.ToInt32(Console.ReadLine());

Bill bill = new Bill(initialUnit,finalUnit);
bill.CalculateBill();
bill.DisplayBill(user);





