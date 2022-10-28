namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a database. list, sql, or mongo.");
            var userInput = Console.ReadLine();

            IDataAccess dataBase = DataAccessFactory.GetDataAccessType(userInput);

            Console.WriteLine(dataBase.LoadData);
            Console.WriteLine(dataBase.SaveData);
        } 
    }
}
