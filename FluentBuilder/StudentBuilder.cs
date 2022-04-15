namespace DesignPatterns
{

    public class StudentBuilder
    {
        private Student _student = new Student();

        public static StudentBuilder Init()
        {
            return new StudentBuilder();
        }

        public Student Build() => _student;

        public StudentBuilder SetName(string Name)
        {
            _student.Name = Name;
            return this;
        }

        public StudentBuilder SetAddress(string Address)
        {
            _student.Address = Address;
            return this;
        }

        public StudentBuilder SetAge(int Age)
        {
            _student.Age = Age;
            return this;
        }

        public StudentBuilder SetPSP(int PSP)
        {
            _student.PSP = PSP;
            return this;
        }

        public StudentBuilder SetCollege(string College)
        {
            _student.College = College;
            return this;
        }

        public StudentBuilder SetBatch(string Batch)
        {
            _student.Batch = Batch;
            return this;
        }
    }
}