﻿using System;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading the data from List database");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a List database");
        }
    }
}

