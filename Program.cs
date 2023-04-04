namespace EmployeePayrollDB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll !");
            EmpolyeeRepo employeeRepo = new EmpolyeeRepo();

            EmployeeModel employeeModel = new EmployeeModel();

            employeeModel.EmployeeName = "Kundan Kumar";
            employeeModel.PhoneNumber = "123456789";
            employeeModel.Address = "Motihari";
            employeeModel.Department = "software";
            employeeModel.Gender = 'M';
            employeeModel.BasePay = 220000.00;
            employeeModel.Deductions = 100.00;
            employeeModel.TaxablePay = 250.00;
            employeeModel.Tax = 300.00;
            employeeModel.NetPay = 21000.00;
            employeeModel.City = "Motihari";
            employeeModel.Country = "India";

            //employeeRepo.AddEmployee(employeeModel);

            employeeRepo.GetAllEmployee();



        }
    }
}