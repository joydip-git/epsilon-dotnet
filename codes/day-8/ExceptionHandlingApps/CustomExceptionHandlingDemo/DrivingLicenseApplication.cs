namespace CustomExceptionHandlingDemo
{
    class DrivingLicenseApplication
    {
        string name;
        int age;

        public DrivingLicenseApplication()
        {

        }

        public DrivingLicenseApplication(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 18)
                {
                    //AgeLessThanEighteenException ex = new AgeLessThanEighteenException("age can't be less than 18 for availing driving license");
                    AgeLessThanEighteenException ex = new AgeLessThanEighteenException();
                    throw ex;
                }
                else
                    age = value;
            }
        }
    }
}
