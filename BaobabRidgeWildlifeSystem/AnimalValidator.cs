using System.Text.RegularExpressions;

namespace BaobabRidgeWildlifeSystem
{
    // the input checks for an animal, used by both the Add and Update screens
    // every method gives back an error message, or "" if the value is fine
    public static class AnimalValidator
    {
        // id should look like WR-1234
        public static string CheckId(string id)
        {
            if (!Regex.IsMatch(id, @"^WR-[0-9]{4}$"))
            {
                return "Animal ID must be 'WR-' followed by 4 digits (e.g. WR-1001).";
            }
            return "";
        }

        // name is required, 1-30 characters, no '|'
        public static string CheckName(string name)
        {
            if (name.Length < 1 || name.Length > 30 || name.Contains("|"))
            {
                return "Name is required (1-30 characters) and cannot contain '|'.";
            }
            return "";
        }

        // species is required, 1-30 characters, no '|'
        public static string CheckSpecies(string species)
        {
            if (species.Length < 1 || species.Length > 30 || species.Contains("|"))
            {
                return "Species is required (1-30 characters) and cannot contain '|'.";
            }
            return "";
        }

        // age must be a whole number from 0 to 100
        public static string CheckAge(string ageText)
        {
            if (!int.TryParse(ageText, out int age) || age < 0 || age > 100)
            {
                return "Age must be a whole number between 0 and 100.";
            }
            return "";
        }

        // recovery score must be a whole number from 0 to 100
        public static string CheckScore(string scoreText)
        {
            if (!int.TryParse(scoreText, out int score) || score < 0 || score > 100)
            {
                return "Recovery Score must be a whole number between 0 and 100.";
            }
            return "";
        }
    }
}
