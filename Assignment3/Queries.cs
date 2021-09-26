using System;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> getWizardsByRowlingExt() => Wizard.Wizards.Value.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);

        public static IEnumerable<string> getWizardsByRowlingLinq()
        {
            var results = from wizard in Wizard.Wizards.Value
                          where wizard.Creator.Contains("Rowling")
                          select wizard.Name;

            return results;
        }

        public static int getFirstSithLordExt() => Wizard.Wizards.Value
                                                                 .Where(w => w.Name.StartsWith("Darth"))
                                                                 .OrderBy(w => w.Year)
                                                                 .Select(w => w.Year)
                                                                 .FirstOrDefault()
                                                                 .Value;

        public static int getFirstSithLordLinq()
        {
            var firstYear = (from wizard in Wizard.Wizards.Value
                       where wizard.Name.Contains("Darth")
                       orderby wizard.Year
                       select wizard.Year).First().Value;
            return firstYear;
        }

        public static IEnumerable<(string, int)> getUniqueHarryPotterWizardsExt() => Wizard.Wizards.Value
                                                                                                        .Where(w => w.Medium.Contains("Harry Potter"))
                                                                                                        .Select(w => (w.Name, w.Year.Value))
                                                                                                        .Distinct(); 
                                

        
        public static IEnumerable<(string, int)> getUniqueHarryPotterWizardsLinq() {
            // This is purely an exercise in doing as much with linq as possible. The sane approach would be to remove the group clause
            // Select the name and year and chain the distinct method on it
            var uniqueWizards = from w in Wizard.Wizards.Value
                                where w.Medium.Contains("Harry Potter")
                                group w by w.Name into g
                                select (g.Key, g.Select(g => g.Year).FirstOrDefault().Value);

            return uniqueWizards;
        }

        public static IEnumerable<string> getWizardNamesGroupedByCreatorExt() => Wizard.Wizards.Value
                                                                                            .OrderByDescending(w => w.Creator)
                                                                                            .ThenBy(w => w.Name)
                                                                                            .GroupBy(w => w.Creator).SelectMany(g => g.Select(w => w.Name));
        
        public static IEnumerable<string> getWizardNamesGroupedByCreaterLinq() 
        {
            var res = from w in Wizard.Wizards.Value
                      orderby w.Creator descending, w.Name
                      group w by new {w.Creator, w.Name} into g
                      select g.Key.Name; 
                             
            return res;           
        }
    }
}
