namespace MVCLearnCore.Models
{
    public class Employee
    {
        #region properties

        public string Code { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }

        private string Password { get; set; }



        #endregion

        #region Method

        public int Syntax()
        {
            return 5;
        }
        public int Syntax(string? x, string y, int num)
        {
            return num;
        }
        #endregion
    }
}
