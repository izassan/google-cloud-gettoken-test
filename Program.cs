using Google.Apis.Auth.OAuth2;

class MainClass
{
    static void Main()
    {
        try{
            GoogleCredential credential = GoogleCredential.GetApplicationDefault();
            ICredential icred = credential.UnderlyingCredential;
            string token = icred.GetAccessTokenForRequestAsync().Result;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("start getting credential");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"token: {token}");
        }catch(Exception e){
            Console.WriteLine($"{e.Message}");
            Console.WriteLine($"{e.StackTrace}");
        }finally{
            Console.ResetColor();
            Console.WriteLine("finish");
        }
    }
}
