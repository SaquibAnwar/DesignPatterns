using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            goto Adapter;
            #region CreationalDesignPatterns
            #region Singleton Pattern
            Console.WriteLine("Let's start with the Singleton pattern!");

            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance\n");
            }

            Console.WriteLine("Let's start with the ThreadSafeSingleton pattern!");

            ThreadSafeSingleton ts1 = ThreadSafeSingleton.Instance;
            ThreadSafeSingleton ts2 = ThreadSafeSingleton.Instance;
            // Test for same instance
            if (ts1 == ts2)
            {
                Console.WriteLine("Objects are the same instance\n");
            }
            #endregion

        
            #region Fluent Builder
            Student student = Student.GetBuilder().SetName("Saquib")
                .SetCollege("SRM").Build();

            System.Console.WriteLine("Student Name : " + student.Name);
            System.Console.WriteLine("Student College : " + student.College);
            #endregion
        
        
            #region Factory Pattern

            ICardFactory cardFactory = null;
            // System.Console.WriteLine("Enter the card you would like to opt: ");
            // string card = Console.ReadLine();
            string card = "Titanium";

            switch(card.ToLower())
            {
                case "moneyback":
                    cardFactory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    cardFactory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    cardFactory = new PlatinumFactory(1000000, 10000);
                    break;
            }

            CreditCard creditCard = cardFactory.GetCreditCard();
            System.Console.WriteLine("\nYour Card Details are as follows:\n");
            System.Console.WriteLine($"Card Type: {creditCard.CardType}\nCard Limit: {creditCard.CardLimit}\nAnnualCharges: {creditCard.AnnualCharges}");
            //Console.ReadKey();
            #endregion
        
        
            #region  Abstract Factory Design Pattern

            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            System.Console.WriteLine("\n****************** Nokia *********************");
            System.Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            System.Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            System.Console.WriteLine("****************** Samsung *********************");
            System.Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            System.Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            #endregion
        
        
            #region Prototype Design Pattern
            
            Developer dev = new Developer();
            dev.Name = "Saquib";
            dev.Designation = "Integration Engineer";
            dev.TechStack = "C#";
            dev.YOE = 3;

            Developer devCopy = dev.Clone() as Developer;
            devCopy.Name = "Vipul";

            System.Console.WriteLine(dev.GetDetails());
            System.Console.WriteLine(devCopy.GetDetails());


            ProgramManager pm = new ProgramManager();
            pm.Name = "Tiffany";
            pm.Designation = "Junior PM";
            pm.YOE = 3;

            ProgramManager pmCopy = pm.Clone() as ProgramManager;
            pmCopy.Name = "Jeff";

            System.Console.WriteLine(pm.GetDetails());
            System.Console.WriteLine(pmCopy.GetDetails());
            System.Console.WriteLine(pm.GetDetails());


            #endregion
            #endregion
        
            #region StructuralDesignPattern


            #region Adapter Design Pattern

            System.Console.WriteLine("\nAdapter Design Pattern");
            IPaymentAdapter paymentAdapter = new PayUPaymentAdapter();
            SwiggyPayment swiggyPayment = new SwiggyPayment(paymentAdapter);
            swiggyPayment.MakePayment();

            #endregion

            #region Decorator Design Pattern

            System.Console.WriteLine("\nDecorator Design Pattern");
            IPizza nonVegPizza = new CheezeTopping(
                new ChickenTopping(
                    new CheezeTopping(
                        new SauceTopping(
                            new PizzaBase()
                        )
                    )
                )
            );
            System.Console.WriteLine("\nChicken Pizza");
            System.Console.WriteLine("Composition: " +nonVegPizza.GetComposition());
            System.Console.WriteLine("Cost: " + nonVegPizza.GetCost());

            System.Console.WriteLine("\nVeg Pizza");
            IPizza vegPizza = new CheezeTopping(
                new PaneerTopping(
                    new CheezeTopping(
                        new SauceTopping(
                            new PizzaBase()
                        )
                    )
                )
            );
            
            System.Console.WriteLine("Composition: " + vegPizza.GetComposition());
            System.Console.WriteLine("Cost: "+ vegPizza.GetCost());

            #endregion
            
            #region Flyweight Design Pattern
            System.Console.WriteLine("\nFlyweight Design Pattern");

            ShapeObjectFactory shapeObjectFactory = new ShapeObjectFactory();

            IShape shape = shapeObjectFactory.GetShape("Rectangle");
            shape.Print();
            shape = shapeObjectFactory.GetShape("Rectangle");
            shape.Print();
            shape = shapeObjectFactory.GetShape("Rectangle");
            shape.Print();

            shape = shapeObjectFactory.GetShape("Circle");
            shape.Print();
            shape = shapeObjectFactory.GetShape("Circle");
            shape.Print();
            shape = shapeObjectFactory.GetShape("Circle");
            shape.Print();

            int numberOfObjects = shapeObjectFactory.TotalObjectsCreated;
            System.Console.WriteLine($"\nTotal no. of objects created: {numberOfObjects}");

            #endregion
            #endregion
        
        
            #region Behavioural Design Pattern
            Adapter:

            System.Console.WriteLine("\nObserver Design Pattern");
            Subject subject = new Subject();
            ObserverOne observerOne = new ObserverOne();
            subject.Attach(observerOne);

            ObserverTwo observerTwo = new ObserverTwo();
            subject.Attach(observerTwo);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.Detach(observerTwo);
            subject.SomeBusinessLogic();
            #endregion
        
        }
    }
}
