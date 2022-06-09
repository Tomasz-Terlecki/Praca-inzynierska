namespace NetCoreTest_test.Models
{
    public class Expense : BaseModel
    {
        private decimal _amount;

        public decimal Amount
        {
            get => _amount;
            set => _amount = Math.Round(value, 2);
        }
    }
}