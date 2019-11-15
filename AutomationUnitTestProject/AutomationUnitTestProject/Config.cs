

namespace AutomationUnitTestProject
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://accounts.google.com/signin";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "example@example.com";
                public static string Password = "12345";
            }

        }
    }
}
