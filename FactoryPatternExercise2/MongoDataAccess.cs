using System;
namespace FactoryPatternExercise2
{
    public class MongoDataAccess: IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading the data from Mongo database");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a Mongo database");
        }
    }
}

