using System;
using System.Linq;

namespace CSharpChallenges.CodeWars
{
    public static class BookSeller
    {
        public static string BookSummary(string[] bookStockLabels, string[] categoryRequests)
        {
            var eitherEnumerableAreEmpty = bookStockLabels.Length == 0 || categoryRequests.Length == 0;
            if (eitherEnumerableAreEmpty)
            {
                return string.Empty;
            }

            var categorySummations = bookStockLabels.Select(label => new Book(label))
                .GroupBy(book => book.Category, book => book.Quantity)
                .ToDictionary(g => g.Key, g => g.Sum());

            return string.Join(" - ", categoryRequests.Select(category =>
            {
                int count = 0;
                categorySummations.TryGetValue(category, out count);
                return $"({category} : {count})";
            }));
        }

        private class Book
        {
            public string Category { get; }
            public int Quantity { get; }

            public Book(string label)
            {
                var codeAndQuantity = label.Split(' ');

                Category = codeAndQuantity[0].Substring(0, 1);
                Quantity = Convert.ToInt32(codeAndQuantity[1]);
            }
        }
    }
}