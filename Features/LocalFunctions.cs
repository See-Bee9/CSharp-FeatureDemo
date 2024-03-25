namespace Feature_Demo.Features
{
    public class LocalFunctions 
    {
        public void Demo(TextWriter outStream)
        {
            var random = new Random();

            var number = random.Next();

            
            PrintRandomNumber();
            
            return;

            void PrintRandomNumber() 
                => outStream.WriteLine(number);

        }
    }
}