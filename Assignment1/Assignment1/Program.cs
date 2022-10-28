using Assignment1;

Console.WriteLine("TCS");
TCS tcsTemp = new TCS(1, "Boomer", "Tech", "Dev", 1000);
Console.WriteLine("PF: " + tcsTemp.EmployeePF());
Console.WriteLine("Leave: " + tcsTemp.LeaveDetails());
Console.WriteLine("Gratuity: " + tcsTemp.gratuityAmount(8, 1000));

Console.WriteLine("--------------------");
Console.WriteLine("WellsFargo");
WellsFargo wfTemp = new WellsFargo(1, "Boomer", "Tech", "Dev", 1000);
Console.WriteLine("PF: " + wfTemp.EmployeePF());
Console.WriteLine("Leave: " + wfTemp.LeaveDetails());
Console.WriteLine("Gratuity: " + wfTemp.gratuityAmount(8, 1000));
