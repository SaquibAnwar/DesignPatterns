namespace DesignPatterns
{
    public class Developer : IEmployee
    {
        public string TechStack { get; set; }
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
            return $"\nDeveloper:\nName: {Name}\nDesignation: {Designation}\nYOE: {YOE}\nTechStack: {TechStack}";
        }
    }
}