namespace Final_Project
{
    abstract class Member
    {
        protected string name;
        protected string nationalCode;
        protected int age;

        public Member(string name, string national, int age)
        {
            this.name = name;
            this.nationalCode = national;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        // You can use following line to get a private variable value instead of above function (GetName)
        //public string Name => name;

        public abstract void Edit();
        public abstract string GetDataAsString();  // مقادیر متغیرهای کلاس را به عنوان یک رشته بر می گرداند
        public abstract void Print();

    }
}
