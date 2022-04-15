namespace DesignPatterns
{
    public class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone mobileFactory)
        {
            smartPhone = mobileFactory.GetSmartPhone();
            normalPhone = mobileFactory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetModelDetails();
        }
        
        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetModelDetails();
        }
    }
}