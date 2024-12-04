namespace LinqOrdering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            var numbers = new List<int> { 9, 2, 44, 3, 5, 78, 22 };

            var orderedNumbers = numbers.OrderByDescending(c => c);

            foreach (var number in orderedNumbers)
            {
                //Console.WriteLine(number);
            }
            #endregion

            #region ex2
            var people = new[]
              {
                new { Name = "Alice", Age = 25 },
                new { Name = "Bob", Age = 30 },
                new { Name = "Alice", Age = 22 }
            };

            var sortedPeople = people.OrderBy(p => p.Name).ThenByDescending(c => c.Age);

            foreach (var person in sortedPeople)
            {
                //Console.WriteLine($"{person.Name} - {person.Age}");
            }
            #endregion

            #region ex3
            var words = new[] { "apple", "banana", "cherry" };

            var sortedWords = words.Reverse();

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
            #endregion
        }
    }
}
