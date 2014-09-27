namespace SalaryCalculator
{
    public class Salary
    {
        public string employeeName { get; set; }

        public double basicAmount { get; set; }

        public double houseRentPercent {private get; set; }

        public double medicalAllowancePercent {private get; set; }

       

        private double GetMedicalAllowance()
        {
            return (basicAmount*houseRentPercent)/100;
        }

        private double GetHouseRent()
        {
            return (basicAmount * medicalAllowancePercent) / 100;
        }

        public double GetTotal()
        {
            
            return basicAmount + GetHouseRent() + GetMedicalAllowance();
        }
    }
}