using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSWG_Character_Maker
{
    internal class PSWG_Char_Maker
    {
        //Pick_Gender method randomly picks a gender, unless the user specifies one.
        static string Pick_Gender(string specifiedGender = null)
        {
            string characterGender = null;

            // Create list of valid options
            List<string> validOptions = new List<string> { "A", "B", "C", "D", "E", "F" };

            while (characterGender == null)
            {
                string genderChoice = specifiedGender?.ToUpper(); //Convert to uppercase so lowercase is a valid input

                // If no valid pre-specified gender, ask user
                if (string.IsNullOrEmpty(genderChoice) || !validOptions.Contains(genderChoice))
                {
                    Console.WriteLine("Would you like a cis male (A), cis female (B), trans male (C), trans female (D), gender nonbinary (E), or would you like a random selection (F)?");
                    Console.Write("Please enter your choice: ");
                    genderChoice = Console.ReadLine().Trim().ToUpper();
                }

                switch (genderChoice)
                {
                    case "A":
                        characterGender = "Cis Male";
                        break;
                    case "B":
                        characterGender = "Cis Female";
                        break;
                    case "C":
                        characterGender = "Trans Male";
                        break;
                    case "D":
                        characterGender = "Trans Female";
                        break;
                    case "E":
                        characterGender = "Gender Nonbinary";
                        break;
                    case "F":
                        List<string> genderOptions = new List<string>
                {
                    "Cis Male",
                    "Cis Female",
                    "Trans Male",
                    "Trans Female",
                    "Gender Nonbinary"
                };
                        Random random = new Random();
                        int index = random.Next(genderOptions.Count);
                        characterGender = genderOptions[index];
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.\n");
                        specifiedGender = null; // clear specifiedGender for next loop
                        break;
                }
            }

            return characterGender;
        }

        static string Pick_Name(string gender, string specifiedName = null)
        {
            Console.WriteLine("\nDo you have a name picked out, or would you like one chosen for you?");
            Console.Write("Please enter your choice (or leave blank for random): ");
            specifiedName = Console.ReadLine()?.Trim();

            string characterName = specifiedName;

            if (string.IsNullOrEmpty(characterName))
            {
                List<string> masculineOrNeutralNames = new List<string>
        {
            "Boxers", "Shorts", "Tank", "Thong", "Cincher", "Tights", "Hipster", "Bikini", "Fishnets", "Leather", "Socks", "Silk",
            "Belt", "Harness", "Suspenders", "Trunks", "Loincloth", "Codpiece", "Cuffs", "Kilt", "Necktie", "Ascot", "Cravat", "Bowtie", "Binder",
            "Choker", "Satin", "Velvet", "Spandex"
        };

                List<string> feminineNames = new List<string>
        {
            "Bralette", "Brazier", "Bustier", "Daisy Duke", "Latex", "Camisole", "Chemise", "Teddy", "Babydoll", "Thigh-High",
            "Pantyhose", "Ribbon", "Negligee", "Choker", "Satin", "Velvet", "Shorts", "Tank", "Thong", "Cincher", "Tights", "Hipster",
            "Bikini", "Socks", "Silk", "Leather", "Fishnets"
        };

                List<string> sourceList = (gender == "Cis Male" || gender == "Trans Male" || gender == "Gender Nonbinary")
                    ? masculineOrNeutralNames
                    : feminineNames;

                Random random = new Random();
                characterName = sourceList[random.Next(sourceList.Count)];
            }

            return characterName;
        }

        //Pick_Color_Scheme method randomly picks a color scheme, unless the user specifies one.
        static string Pick_Color_Scheme(string specifiedColorScheme = null)
        {
            Console.WriteLine("\nDo you have a color scheme picked out, or would you like one picked for you?");
            Console.Write("Please enter your choice (or leave blank for random): ");
            specifiedColorScheme = Console.ReadLine()?.Trim();

            string characterColorScheme = specifiedColorScheme;
            if (string.IsNullOrEmpty(characterColorScheme))
            {
                List<string> colorsOne = new List<string>
                {
                    "Red", "Crimson", "Maroon", "Blue", "Green", "Yellow", "Purple", "Pink", "Orange", "Black", "White", "Gray",
                    "Cyan", "Magenta", "Teal", "Lavender", "Gold", "Silver", "Bronze", "Navy", "Olive", "Coral", "Turquoise", "Fuchsia",
                    "Violet", "Indigo", "Beige", "Brown", "Peach", "Mint", "Plum", "Aqua", "Lime", "Charcoal", "Ivory"
                };
                List<string> colorsTwo = new List<string>
                {
                    "Red", "Crimson", "Maroon", "Blue", "Green", "Yellow", "Purple", "Pink", "Orange", "Black", "White", "Gray",
                    "Cyan", "Magenta", "Teal", "Lavender", "Gold", "Silver", "Bronze", "Navy", "Olive", "Coral", "Turquoise", "Fuchsia",
                    "Violet", "Indigo", "Beige", "Brown", "Peach", "Mint", "Plum", "Aqua", "Lime", "Charcoal", "Ivory"
                };
                Random random = new Random();
                // Randomly select two colors from the lists
                string colorOne = colorsOne[random.Next(colorsOne.Count)];
                string colorTwo = colorsTwo[random.Next(colorsTwo.Count)];
                // Ensure the two colors are not the same
                while (colorOne == colorTwo)
                {
                    colorTwo = colorsTwo[random.Next(colorsTwo.Count)];
                }
                characterColorScheme = $"{colorOne} and {colorTwo}";
                return characterColorScheme;

            }
            return characterColorScheme;
        }

        //Pick_Alignment method randomly picks an alignment, unless the user specifies one.
        //Alignment is a combination of Lawful/Chaotic and Good/Evil, resulting in 9 possible alignments.
        static string Pick_Alignment(string specifiedAlignment = null)
        {
            Console.WriteLine("\nDo you have an alignment in mind, or would you like one picked for you?");
            Console.Write("Please enter your choice (or leave blank for random): ");
            specifiedAlignment = Console.ReadLine()?.Trim();

            string characterAlignment = specifiedAlignment;
            if (string.IsNullOrEmpty(characterAlignment))
            {
                List<string> alignments = new List<string>
                {
                    "Lawful Good", "Neutral Good", "Chaotic Good",
                    "Lawful Neutral", "True Neutral", "Chaotic Neutral",
                    "Lawful Evil", "Neutral Evil", "Chaotic Evil"
                };
                Random random = new Random();
                characterAlignment = alignments[random.Next(alignments.Count)];
            }
            return characterAlignment;
        }

        //Pick_Species method randomly picks a species, unless the user specifies one.
        //Species can be angel, demon, human, or ghost. 
        static string Pick_Species(string specifiedSpecies = null)
        {
            Console.WriteLine("\nDo you have a species in mind, or would you like one picked for you?");
            Console.Write("Please enter your choice (or leave blank for random): ");
            specifiedSpecies = Console.ReadLine()?.Trim();
            string characterSpecies = specifiedSpecies;
            if (string.IsNullOrEmpty(characterSpecies))
            {
                List<string> speciesOptions = new List<string> { "Angel", "Demon", "Human", "Ghost" };
                Random random = new Random();
                characterSpecies = speciesOptions[random.Next(speciesOptions.Count)];
            }
            return characterSpecies;
        }

        //Pick_Character_Type method randomly picks a character archetype, unless the user specifies one.
        static string Pick_Character_Type(string specifiedCharacterType = null)
        {
            Console.WriteLine("\nDo you have a character type in mind, or would you like one picked for you?");
            Console.Write("Please enter your choice (or leave blank for random): ");
            specifiedCharacterType = Console.ReadLine()?.Trim();
            string characterType = specifiedCharacterType;
            if (string.IsNullOrEmpty(characterType))
            {
                List<string> characterTypes = new List<string>
                {
                    "Innocent", "Orphan", "Hero", "Villain", "Anti-Hero", "Sidekick", "Mentor", "Rogue", "Mystic", "Warrior", "Healer", "Trickster",
                    "Guardian", "Explorer", "Scholar", "Rebel", "Outcast", "Leader", "Follower", "Jester", "Bully", "Bureaucrat", "Thrill-Seeker", "Assassin",
                    "Martyr", "Savior", "Destroyer", "Creator", "Manipulator", "Peacemaker", "Conqueror", "Defender", "Avenger", "Visionary", "Dreamer",
                    "Inventor", "Artist", "Philosopher", "Scientist"
                };
                Random random = new Random();
                characterType = characterTypes[random.Next(characterTypes.Count)];
            }
            return characterType;
        }

        //Personality_Traits method randomly picks a set of 6 personality traits, unless the user specifies them.
        //3 are selected from a list of "positive" traits, 3 are selected from negative traits. 
        static List<string> Personality_Traits()
        {
            List<string> positiveTraits = new List<string>
            {
                "Brave", "Compassionate", "Clever", "Loyal", "Charming", "Honest", "Creative", "Generous", "Wise", "Optimistic",
                "Empathetic", "Industrious", "Charismatic", "Courteous", "Intelligent", "Ambitious", "Courageous", "Earnest",
                "Funny", "Reliable", "Neat", "Stable", "Energetic", "Adaptable", "Friendly", "Patient", "Respectful", "Thoughtful",
                "Trustworthy", "Understanding", "Witty", "Diligent", "Resourceful", "Sincere", "Supportive", "Tolerant", "Visionary",
                "Open-minded", "Passionate", "Practical", "Analytical", "Artistic", "Humble", "Disciplined", "Innovative", "Insightful",
                "Perceptive", "Proactive", "Resilient", "Self-aware", "Strategic", "Team-oriented", "Versatile"
            };

            List<string> negativeTraits = new List<string>
            {
                "Arrogant", "Impulsive", "Jealous", "Stubborn", "Cynical", "Deceitful", "Greedy", "Moody", "Reckless", "Vain",
                "Pessimistic", "Aloof", "Aggressive", "Apathetic", "Manipulative", "Lazy", "Critical", "Dimwitted", "Bossy",
                "Careless", "Cynical", "Defensive", "Childish", "Naive", "Short-tempered", "Jealous", "Controlling", "Obnoxious",
                "Sloppy", "Inflexible", "Selfish", "Dishonest", "Unreliable", "Disrespectful", "Arrogant", "Overconfident", "Indecisive",
                "Untrustworthy", "Vindictive", "Hypocritical", "Egotistical", "Conceited", "Gullible", "Skeptical", "Overbearing",
                "Disorganized", "Unmotivated", "Resentful", "Impulsive", "Insecure", "Paranoid", "Overly critical"
            };

            Random rand = new Random();

            // Helper function to get N unique random elements from a list
            List<string> GetRandomTraits(List<string> source, int count)
            {
                return source.OrderBy(x => rand.Next()).Take(count).ToList();
            }

            List<string> selectedPositive = GetRandomTraits(positiveTraits, 3);
            List<string> selectedNegative = GetRandomTraits(negativeTraits, 3);

            List<string> combined = selectedPositive.Concat(selectedNegative).ToList();

            return combined;
        }

        //Pick_Weapon method randomly picks a weapon, unless the user specifies one.
        static string Pick_Weapon(string specifiedWeapon = null)
        {
            Console.WriteLine("\nDo you have a weapon in mind, or would you like one picked for you?");
            Console.Write("Please enter your choice (or leave blank for random): ");
            specifiedWeapon = Console.ReadLine()?.Trim();
            string characterWeapon = specifiedWeapon;
            if (string.IsNullOrEmpty(characterWeapon))
            {
                List<string> weapons = new List<string>
                {
                    "Sword", "Axe", "Bow", "Dagger", "Spear", "Staff", "Mace", "Crossbow", "Flail", "Whip", "Machete", "Boomerang",
                    "Hammer", "Katana", "Scythe", "Lance", "Halberd", "Trident", "Knife", "Rifle", "Gun", "Kama", "Sabre",
                    "Scimitar", "Sickle", "Rapier", "Shortsword", "Dagger", "Baseball Bat", "Chainsaw", "Sai", "Crowbar",
                    "Taser", "Club", "Shield", "Brass Knuckles", "Nunchaku", "Bo Staff", "Throwing Stars", "Chakram", "Sling",
                };
                Random random = new Random();
                characterWeapon = weapons[random.Next(weapons.Count)];
            }
            return characterWeapon;
        }


        //pick_Likes method has a list of things to like and dislike. It creates 2 lists: likes and dislikes list, selecting 3 items each randomly
        //from the things list. Returns both lists. 
        static (List<string> likes, List<string> dislikes) Pick_Likes()
        {
            List<string> things = new List<string>
            {
                "Chocolate", "Coffee", "Tea", "Pizza", "Ice Cream", "Books", "Pop Music", "Country Music", "Nature", "Animals",
                "Sports", "Art", "Technology", "Fashion", "Traveling", "Cooking", "Baking", "Gaming", "Photography",
                "Dancing", "Hiking", "Fishing", "Camping", "Gardening", "Romcoms", "Action Movies", "Sci-Fi", "Fantasy",
                "Mystery movies", "Thrillers", "Comedys", "Dramas", "Documentaries", "Anime", "Cartoons", "Dogs", "Cats",
                "Classical Music", "Makeup", "Fitness", "Yoga", "Meditation", "Crafting", "DIY Projects", "Fighting", "Board Games",
                "Puzzles", "Knitting", "Sewing", "Woodworking", "Metalworking", "Pottery", "Martial Arts", "Swimming", "Bugs", "Snakes",
                "Spiders", "Birdwatching", "Astronomy", "History", "Philosophy", "Psychology", "Economics", "Politics", "Mathematics",
                "Physics", "Chemistry", "Biology", "Geology", "Linguistics", "Sociology", "Anthropology", "Archaeology", "Architecture",
                "Engineering", "Robotics", "Clowns", "Horror", "Gambling", "Spiders", "Alcohol", "Junk Food", "Fast Food", "Photography",
                "Sweets", "Reading", "Writing", "Poetry", "Theater", "Parties", "Clubbing", "Metal Music", "Drag", "Cooking", "Baking",
                "Rock and Roll", "Jazz", "Blues", "Folk Music", "World Music", "Reality TV", "Singing", "Playing an Instrument", "Volleyball",
                "Basketball", "Soccer", "Baseball", "Tennis", "Golf", "Skateboarding", "Surfing", "Snowboarding", "Skiing", "Ice Skating",
                "Rollerskating", "Hockey", "Rugby", "Cricket", "Lacrosse", "Coding", "Boxing", "Wrestling", "Gymnastics", "Healthy Food",
                "Spicy Food", "Hot weather", "Cold weather", "Rainy days", "Sunny days", "Cloudy days", "BBQ", "Wine", "Dubstep", "Hip Hop",
                "Billiards", "Darts", "Poker", "Chess", "Magic Tricks", "Origami", "Calligraphy", "Scrapbooking", "Model Building", "Blogging",
                "Scented Candles", "Dungeons and Dragons", "Sushi", "Astrology", "Shopping", "Amusement Parks", "Zoos & Aquariums",
                "Museums", "Concerts", "Festivals", "Parades", "Carnivals", "Superheroes", "Comics", "Horses"
            };

            Random random = new Random();
            List<string> likes = things.OrderBy(x => random.Next()).Take(3).ToList(); // Randomly select 3 likes
            List<string> dislikes = things.Except(likes).OrderBy(x => random.Next()).Take(3).ToList(); // Randomly select 3 dislikes from the remaining items

            return (likes, dislikes); // Returning a tuple
        }


        //Print_Character method prints the character details to the console.
        static void Print_Character(string characterName, string characterGender, string characterColorScheme, string characterAlignment, string characterSpecies, string characterType, List<string> personalityTraits, string characterWeapon, List<string> likes, List<string> dislikes)
        {
            Console.WriteLine("\nCharacter Details:");
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Gender: {characterGender}");
            Console.WriteLine($"Color Scheme: {characterColorScheme}");
            Console.WriteLine($"Alignment: {characterAlignment}");
            Console.WriteLine($"Species: {characterSpecies}");
            Console.WriteLine($"Character Type: {characterType}");
            Console.WriteLine("Personality Traits: " + string.Join(", ", personalityTraits));
            Console.WriteLine($"Weapon: {characterWeapon}");
            Console.WriteLine("Likes: " + string.Join(", ", likes));
            Console.WriteLine("Dislikes: " + string.Join(", ", dislikes));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the PSWG Character Maker!");
            Console.WriteLine("You can specify certain attributes or let the program choose for you.\n");

            // Call methods to pick attributes and print character details
            string characterGender = Pick_Gender();
            string characterName = Pick_Name(characterGender);
            string characterColorScheme = Pick_Color_Scheme();
            string characterAlignment = Pick_Alignment();
            string characterSpecies = Pick_Species();
            string characterType = Pick_Character_Type();
            List<string> personalityTraits = Personality_Traits();
            string characterWeapon = Pick_Weapon();
            (List<string> likes, List<string> dislikes) = Pick_Likes();

            // Print the character details by calling Print_Character method
            // Print the character details initially
            Print_Character(characterName, characterGender, characterColorScheme, characterAlignment, characterSpecies, characterType, personalityTraits, characterWeapon, likes, dislikes);

            bool madeEdits = false;
            string editChoice;

            do
            {
                Console.Write("\nWould you like to edit any attributes? (yes/no) ");
                editChoice = Console.ReadLine()?.Trim().ToLower();

                while (editChoice == "yes")
                {
                    Console.WriteLine("\nWhich attribute would you like to edit?");
                    Console.WriteLine("A: Name  B: Gender  C: Color Scheme  D: Alignment  E: Species");
                    Console.WriteLine("F: Character Type  G: Personality Traits  H: Weapon  I: Likes/Dislikes");
                    Console.Write("Enter your choice here: ");
                    string attributeChoice = Console.ReadLine()?.Trim().ToUpper();

                    switch (attributeChoice)
                    {
                        case "A":
                            characterName = Pick_Name(characterGender);
                            madeEdits = true;
                            break;
                        case "B":
                            characterGender = Pick_Gender(characterGender);
                            madeEdits = true;
                            break;
                        case "C":
                            characterColorScheme = Pick_Color_Scheme();
                            madeEdits = true;
                            break;
                        case "D":
                            characterAlignment = Pick_Alignment();
                            madeEdits = true;
                            break;
                        case "E":
                            characterSpecies = Pick_Species();
                            madeEdits = true;
                            break;
                        case "F":
                            characterType = Pick_Character_Type();
                            madeEdits = true;
                            break;
                        case "G":
                            personalityTraits = Personality_Traits();
                            madeEdits = true;
                            break;
                        case "H":
                            characterWeapon = Pick_Weapon();
                            madeEdits = true;
                            break;
                        case "I":
                            (likes, dislikes) = Pick_Likes();
                            madeEdits = true;
                            break;
                        default:
                            Console.WriteLine("\nInvalid input! Press A to try again, or B to cancel editing.");
                            string continueChoice = Console.ReadLine()?.Trim().ToUpper();
                            if (continueChoice == "A") continue;
                            else editChoice = "no";
                            break;
                    }

                    if (editChoice == "yes")
                    {
                        Console.WriteLine("\nWould you like to edit another attribute? (yes/no)");
                        editChoice = Console.ReadLine()?.Trim().ToLower();
                    }
                }

            } while (editChoice == "yes");

            // Only print the summary if edits were made
            if (madeEdits)
            {
                Console.WriteLine("\nHere is your updated character:");
                Print_Character(characterName, characterGender, characterColorScheme, characterAlignment, characterSpecies, characterType, personalityTraits, characterWeapon, likes, dislikes);
            }

            // Play again logic
            Console.Write("\nWould you like to play again from the beginning? (Yes or no) ");
            string playAgainChoice = Console.ReadLine()?.Trim().ToLower();
            if (playAgainChoice == "yes")
            {
                Console.WriteLine();
                Main(args); // Restart the program
            }
            else if (playAgainChoice == "no")
            {
                Console.WriteLine("\nThank you for using the PSWG Character Maker! Goodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Exiting the program.");
            }
        }
    }
}
