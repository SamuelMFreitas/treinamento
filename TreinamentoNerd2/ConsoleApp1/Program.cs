namespace EFCCoreTutorialsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                //criar BD se não existir
                context.Database.EnsureCreated();

                //Criar uma identidade de objeto
                var grade01 = new Grade() { GradeName = "Curso C# .Net" };
                var student = new student() { FirstName = "Pinóquio", LastName = "Silveirinha", Grade = grade01);}


        }
    }
}