using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading;

namespace AnagramSolver
{
    public class Program
    {
        private static readonly DataTable dataTable = new();
        private static List<string> permutations = [];
        private static int resultCount;
        private static readonly SQLiteConnection sqlite = new("Data Source=" + System.IO.Path.GetFullPath(@"..\..\..\db\Dictionary.db"));
        private static readonly List<Thread> workerThreads = [];

        public static void Main()
        {
            Console.WriteLine("Welcome to the Anagram Solver!");
            Console.WriteLine("******************************");
            Console.WriteLine();
            Console.WriteLine("An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.");
            Console.WriteLine();
            Console.Write("Please enter your word or phrase (up to 9 characters): ");

            var entry = Console.ReadLine();

            HandleEntry(entry);
            Console.ReadLine();
        }

        private static void HandleEntry(string entry)
        {
            if (entry.Length < 2)
            {
                Console.WriteLine("You cannot enter fewer than 2 characters. Press enter to exit");
            }
            else if (entry.Length > 9)
            {
                Console.WriteLine("You cannot enter more than 9 characters. Press enter to exit");
            }
            else
            {
                Console.WriteLine("Running...");
                Console.WriteLine();

                // Run anagram solver
                RunAnagramSolver(entry.ToLower());
                if (resultCount == 0)
                {
                    Console.WriteLine("There were no anagrams for that word or phrase");
                }

                Console.WriteLine();
                Console.WriteLine("Done");
                Console.WriteLine("Press enter to exit.");
            }
        }

        private static void RunAnagramSolver(string entry)
        {
            char[] entryLetters = entry.ToCharArray();
            permutations = Permutation.GetPermutations(entryLetters, 0, entryLetters.Length - 1);

            sqlite.Open();  //Initiate connection to the db

            FillDataTable(entryLetters, entry);
            OutputResults();

            sqlite.Close(); // Close connection
        }

        private static void FillDataTable(char[] entryLetters, string entry)
        {
            // Remove duplicate letters to avoid duplicate queries
            char[] uniqueEntryLetters = entryLetters.Distinct().ToArray();

            foreach (char entryLetter in uniqueEntryLetters)
            {
                Thread thread = new(() =>
                {
                    lock (dataTable)
                    {
                        SQLiteCommand sqliteCommand = GetWordsByLetter(entryLetter, entry);
                        SQLiteDataAdapter sqliteDataAdapter = new(sqliteCommand);
                        sqliteDataAdapter.Fill(dataTable); //fill the datasource
                    }
                });

                workerThreads.Add(thread);
                thread.Start();
            }

            // Wait for all the threads to finish so that the results list is populated.
            // If a thread is already finished when Join is called, Join will return immediately.
            foreach (Thread thread in workerThreads)
            {
                thread.Join();
            }
        }

        private static void OutputResults()
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var word = (string)dataTable.Rows[i]["word"];
                var lowerCaseWord = char.ToLowerInvariant(word[0]) + word[1..];

                for (int j = 0; j < permutations.Count; j++)
                {
                    if (permutations[j] == lowerCaseWord)
                    {
                        resultCount++;
                        Console.WriteLine(permutations[j]);
                    }
                }
            }
        }

        private static SQLiteCommand GetWordsByLetter(char letter, string entry)
        {
            SQLiteCommand sqliteCommand = sqlite.CreateCommand();

            try
            {
                sqliteCommand.CommandText = @"
                    SELECT DISTINCT
                        word
                    FROM
                        entries
                    WHERE
                        word
                    LIKE
                        ?
                    AND
                        LENGTH(word) = ?
                    AND
                        LENGTH(word) > 1";

                SQLiteParameter letterParam = new()
                {
                    Value = letter + "%"
                };
                sqliteCommand.Parameters.Add(letterParam);

                SQLiteParameter lengthParam = new()
                {
                    Value = entry.Length
                };
                sqliteCommand.Parameters.Add(lengthParam);
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex);
            }

            return sqliteCommand;
        }
    }
}