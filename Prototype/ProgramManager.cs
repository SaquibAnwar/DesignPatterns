namespace DesignPatterns
{
    public class ProgramManager : IEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int YOE { get; set; }

        public IEmployee Clone()
        {
            //Shallow Copy
            return (IEmployee)MemberwiseClone();
            
            //DeepCopy
            //return (IEmployee)this.Clone();
        }

        public string GetDetails()
        {
            return $"\nProgram Manager:\nName: {Name}\nDesignation: {Designation}\nYOE: {YOE}\n";
        }
    }
}  