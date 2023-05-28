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

        public abstract void SaveToFile(string path);
        public abstract void LoadFromFile(string path);

    }
}
