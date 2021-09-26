using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Should_return_wizards_created_by_rowling_ext()
        {
            IEnumerable<string> expectedNames = new[] { "Neville Longbottom", "Harry Potter", "Harry Potter", "Ron Weasley", "Hermione Granger", "Salazar Slytherin", "Helga Hufflepuff", "Padma Partil" };

            Assert.Equal(expectedNames, Queries.getWizardsByRowlingExt());
        }

        [Fact]
        public void Should_return_wizards_created_by_rowling_linq()
        {
            IEnumerable<string> expectedNames = new[] { "Neville Longbottom", "Harry Potter", "Harry Potter", "Ron Weasley", "Hermione Granger", "Salazar Slytherin", "Helga Hufflepuff", "Padma Partil" };
            Assert.Equal(expectedNames, Queries.getWizardsByRowlingLinq());
        }

        [Fact]
        public void Should_return_first_sith_lord_year_ext()
        {
            Assert.Equal(1977, Queries.getFirstSithLordExt());
        }

        [Fact]
        public void Should_return_first_sith_lord_year_linq()
        {
            int expectedYear = 1977;
            Assert.Equal(expectedYear, Queries.getFirstSithLordLinq());
        }

        [Fact]
        public void Should_return_unique_list_of_wizards_from_harry_potter_books_ext()
        {
            IEnumerable<(string, int)> expectedTuples = new[] { ("Neville Longbottom", 1997), ("Harry Potter", 1997), ("Ron Weasley", 1997), ("Hermione Granger", 1997), ("Salazar Slytherin", 1997), ("Helga Hufflepuff", 1997), ("Padma Partil", 1997) };
            Assert.Equal(expectedTuples, Queries.getUniqueHarryPotterWizardsExt());
        }

        [Fact]
        public void Should_return_unique_list_of_wizards_from_harry_potter_books_linq()
        {
            var expected = new[] { ("Neville Longbottom", 1997), ("Harry Potter", 1997), ("Ron Weasley", 1997), ("Hermione Granger", 1997), ("Salazar Slytherin", 1997), ("Helga Hufflepuff", 1997), ("Padma Partil", 1997) };

            Assert.Equal(expected, Queries.getUniqueHarryPotterWizardsLinq());
        }

        [Fact]
        public void Should_return_wizard_names_grouped_and_sorted_by_creator_then_wizard_name_ext()
        {
            var expected = new[] { "Hester Shaw",
                                    "Gandalf the Gray",
                                    "Sauron",
                                    "Harry Potter",
                                    "Harry Potter",
                                    "Helga Hufflepuff",
                                    "Hermione Granger",
                                    "Neville Longbottom",
                                    "Padma Partil",
                                    "Ron Weasley",
                                    "Salazar Slytherin",
                                    "Darth Maul",
                                    "Darth Vader",
                                    "Luke Skywalker",
                                    "Jaina Proudmore" };

            Assert.Equal(expected, Queries.getWizardNamesGroupedByCreatorExt());
        }

        [Fact]
        public void Should_return_wizard_names_grouped_and_sorted_by_creator_then_wizard_name_linq()
        {
            var expectedNames = new[] { "Hester Shaw",
                                    "Gandalf the Gray",
                                    "Sauron",
                                    "Harry Potter",
                                    "Helga Hufflepuff",
                                    "Hermione Granger",
                                    "Neville Longbottom",
                                    "Padma Partil",
                                    "Ron Weasley",
                                    "Salazar Slytherin",
                                    "Darth Maul",
                                    "Darth Vader",
                                    "Luke Skywalker",
                                    "Jaina Proudmore" };
            Assert.Equal(expectedNames, Queries.getWizardNamesGroupedByCreaterLinq());
        }

    }
}
