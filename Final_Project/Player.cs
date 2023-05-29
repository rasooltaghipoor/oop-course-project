namespace Final_Project
{

    class Player : Member
    {
        private int number;  // شماره بازیکن
        private int gaols;  // تعداد گل زده
        private int contractValue;  // مبلغ قرارداد
        private string position; // پست بازیکن  Can be declared as Enum!

        public Player(string name, string national, int age, int number, int gaols, int contractValue, string position) : base(name, national, age)
        {
            this.number = number;
            this.gaols = gaols;
            this.contractValue = contractValue;
            this.position = position;
        }

        public override void Edit()
        {
            // TODO: Implement me!
        }

        public override string GetDataAsString()
        {
            return null;
            // TODO: Remove the above line and implement me!
        }

        public override void Print()
        {
            // TODO : Implement me!
        }
    }
}
