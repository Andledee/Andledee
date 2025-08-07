using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSWG_Character_Maker_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPersonality_Click(object sender, EventArgs e)
        {
            //This method is empty, nothing happens when the label is clicked.
        }

        private void genderButton_CheckedChanged(object sender, EventArgs e)
        {
            if (genderButton.Checked)
            {
                string[] genders = { "Cis Male", "Cis Female", "Trans Male", "Trans Female", "Non-Binary", "Genderfluid" };
                Random random = new Random();
                string randomGender = genders[random.Next(genders.Length)]; // generates a random index from 0 to genders.Length - 1, accesses the array at that index
                txtGender.Text = randomGender; //Set the text box
            }
            else
            {
                string input = txtGender.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter a gender or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userGender = input;
                }
            }
        }

        private void nameButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!nameButton.Checked)
            {
                string input = txtName.Text.Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    string userName = input;
                    // Do something with userName if needed
                }
                // else: textbox is empty and checkbox is unchecked — do nothing
            }
            else // Randomize a name
            {
                string gender = txtGender.Text.Trim().ToLower(); // Normalize input

                string[] maleNames = {"Boxers", "Jockstrap", "Condom", "Codpiece", "Loincloth", "Kilt", "Necktie", "Bowtie", "Trunks", "Namba",
                "Mankini"};
                string[] femaleNames = { "Bralette", "Brazier", "Bustier", "Daisy Duke", "Babydoll", "Negligee", "Teddy", "Miniskirt" };
                string[] neutralNames = {"Shorts", "Tank", "Camisole", "Thong", "Cincher", "Tights", "Hipster", "Fishnets",
                "Leather", "Socks", "Silk", "Belt", "Harness", "Suspenders", "Cuffs", "Ascot", "Cravat", "Binder", "Latex",
                "Bikini", "Choker", "Pantyhose", "Ribbon", "Velvet", "Satin", "Spandex", "Straps", "Thigh-High", "Anklet", "Bracelet",
                "Skimpy", "Shades", "Heels", "Boots", "Sandals", "Gloves", "Brooch", "Beret", "Scarf", "Beanie", "Girdle",
                "Chemise", "Bloomer", "Pantaloons", "Denim", "Scrunchie"};

                string[] pool;

                // Choose name pool based on gender
                if (gender == "Cis Male" || gender == "Trans Male")
                {
                    pool = maleNames.Concat(neutralNames).ToArray();
                }
                else if (gender == "Cis Female" || gender == "Trans Female")
                {
                    pool = femaleNames.Concat(neutralNames).ToArray();
                }
                else
                {
                    pool = neutralNames;
                }

                Random random = new Random();
                string randomName = pool[random.Next(pool.Length)];
                txtName.Text = randomName;
            }
        }

        private void colorButton_CheckedChanged(object sender, EventArgs e)
        {
            if (colorButton.Checked)
            {
                string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple", "Orange", "Pink", "Black", "White", "Gray" };
                string[] colors2 = { "Crimson", "Azure", "Emerald", "Gold", "Violet", "Coral", "Magenta", "Charcoal", "Ivory", "Slate", "Peach",
                "Maroon", "Lavender", "Turquoise", "Cyan", "Teal", "Navy"};
                Random random = new Random();
                string randomColor = colors[random.Next(colors.Length)]; // generates a random index from 0 to colors.Length - 1, accesses the array at that index
                randomColor += " / " + colors2[random.Next(colors2.Length)]; // adds a second random color from the second array
                txtColor.Text = randomColor; //Set the text box
            }
            else
            {
                string input = txtColor.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter a color or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userColor = input;
                    // You can use userColor elsewhere if needed
                }
            }
        }

        private void alignButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alignButton.Checked)
            {
                string[] alignments = { "Lawful Good", "Neutral Good", "Chaotic Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral",
                                        "Lawful Evil", "Neutral Evil", "Chaotic Evil" };
                Random random = new Random();
                string randomAlignment = alignments[random.Next(alignments.Length)]; // generates a random index from 0 to alignments.Length - 1, accesses the array at that index
                txtAlign.Text = randomAlignment; //Set the text box
            }
            else
            {
                string input = txtAlign.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter an alignment or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userAlignment = input;
                    // You can use userAlignment elsewhere if needed
                }
            }
        }

        private void speciesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (speciesButton.Checked)
            {
                string[] species = { "Human", "Angel", "Demon", "Ghost", "Hybrid" };
                //select a random species from the array
                Random random = new Random();
                string randomSpecies = species[random.Next(species.Length)]; // generates a random index from 0 to species.Length - 1, accesses the array at that index
                txtSpecies.Text = randomSpecies; //Set the text box

            }
            else // User didn't check the box to randomize a species
            {
                string input = txtSpecies.Text.Trim(); 
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter a species or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userSpecies = input;
                    // You can use userSpecies elsewhere if needed
                }
            }
        }

        private void likesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (likesButton.Checked)
            {
                string[] likes = { "Chocolate", "Coffee", "Tea", "Pizza", "Ice Cream", "Books", "Pop Music", "Country Music", "Nature", "Animals",
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
                "Spicy Food", "Hot Weather", "Cold Weather", "Rainy days", "Sunny days", "Cloudy days", "BBQ", "Wine", "Dubstep", "Hip Hop",
                "Billiards", "Darts", "Poker", "Chess", "Magic Tricks", "Origami", "Calligraphy", "Scrapbooking", "Model Building", "Blogging",
                "Scented Candles", "Dungeons and Dragons", "Sushi", "Astrology", "Shopping", "Amusement Parks", "Zoos & Aquariums",
                "Museums", "Concerts", "Festivals", "Parades", "Carnivals", "Superheroes", "Comics", "Horses", "Tax Evasion", "Rock Climbing",
                "Parkour", "Puns", "Pranks", "Archery", "Fencing", "Sailing", "Kayaking", "Canoeing", "Scuba Diving", "Solitude", "Thunderstorms",
                "Pumpkin Spice", "Bowling", "Arcade Games", "Ping-Pong"
                };

                Random random = new Random();
                //Select 3-5 random likes from the array
                int numberOfLikes = random.Next(3, 6); // Randomly choose between 3 and 5 likes
                List<string> selectedLikes = new List<string>();
                while (selectedLikes.Count < numberOfLikes)
                {
                    string randomLike = likes[random.Next(likes.Length)];
                    if (!selectedLikes.Contains(randomLike)) // Ensure no duplicates
                    {
                        selectedLikes.Add(randomLike);
                    }
                }
                txtLikes.Text = string.Join(", ", selectedLikes); //Set the text box with the selected likes

            }
            else // User didn't check the box to randomize likes
            {
                string input = txtLikes.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter likes or check the box to randomize them.");
                }
                else //User provided manual input
                {
                    string userLikes = input;
                    // You can use userLikes elsewhere if needed
                }
            }
        }

        private void dislikesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dislikesButton.Checked)
            {
                string[] dislikes = { "Chocolate", "Coffee", "Tea", "Politics", "Social Media", "Reading", "Pop Music", "Country Music", "Cold Weather", "Socializing",
                "Sports", "Art", "Technology", "Fashion", "Traveling", "Cooking", "Hot Weather", "Sand. It's course, rough, irritating, and gets everywhere.", "Children", "Bugs",
                "Dancing", "Hiking", "Fishing", "Camping", "Gardening", "Romcoms", "Poetry", "Sci-Fi", "Fantasy", "Taxes", "Slow Walkers", "Waiting in Lines",
                "Mystery movies", "Thrillers", "Adam Sandler", "Dramas", "Documentaries", "Anime", "Cartoons", "Dogs", "Cats", "Old People", "Loud Noises",
                "Classical Music", "Filth", "Fitness", "Yoga", "Meditation", "Fast Food", "DIY Projects", "Fighting", "Clowns", "The Government", "The 1%",
                "Snakes", "Spiders", "Hospitals", "Needles", "The Police", "The Dark", "Heights", "Public Speaking", "Crowds", "Being Alone", "Pineappe on Pizza",
                "Rats", "Math", "Hypocrites", "Liars", "Cheaters", "Betrayal", "Dishonesty", "Injustice", "Racism", "Sexism", "Homophobia", "Transphobia",
                "Ageism", "Ableism", "Classism", "Xenophobia", "Misogyny", "Toxic Masculinity", "Toxic Femininity", "Ignorance", "Arrogance", "Entitlement",
                "Greed", "Corruption", "Violence", "War", "Hate", "Bigotry", "Intolerance", "Discrimination", "Oppression", "Censorship", "Surveillance",
                "Consumerism", "Materialism", "Wastefulness", "Pollution", "Climate Change", "Environmental Destruction", "Wasting Time", "Deforestation",
                "Paparazzi", "Reality TV", "Public Bathrooms", "Traffic Jams", "Littering", "Smoking", "Alcohol", "Drugs", "Gambling", "Overpriced Goods",
                "Scams", "Spam Emails", "Telemarketers", "Robocalls", "Scammers", "Crowds", "Cyberbullying", "Online Trolls", "Comic Sans Font",
                "Emojis", "Themselves", "People Who Don't Use Turn Signals", "People Who Chew With Their Mouth Open", "People Who Talk During Movies",
                "People Who Don't Cover Their Mouth When They Cough", "People Who Don't Wash Their Hands", "Cilantro", "Small Talk", "Being Ignored",
                "Surprises", "Being Late", "Being Early", "Being Interrupted", "Being Judged", "Being Criticized", "Being Misunderstood", "Thunderstorms",
                "Cemeteries", "Facial Hair", "Body Hair", "Unsolicited Advice", "People Who Don't Respect Personal Space", "Mannequins", "Pumpkin Spice",
                "Salt & Vinegar Chips", "Compromising", "Mansplaining", "Sushi", "Spicy Food", "Rainy Days", "Cloudy Days", "BBQ", "Wine", "Dubstep", "Hip Hop",
                "Mushrooms"

                // Add more dislikes as needed
                };
                Random random = new Random();
                //Select 3-5 random dislikes from the array
                int numberOfDislikes = random.Next(3, 6); // Randomly choose between 3 and 5 dislikes
                List<string> selectedDislikes = new List<string>();
                while (selectedDislikes.Count < numberOfDislikes)
                {
                    string randomDislike = dislikes[random.Next(dislikes.Length)];
                    if (!selectedDislikes.Contains(randomDislike)) // Ensure no duplicates
                    {
                        selectedDislikes.Add(randomDislike);
                    }
                }
                txtDislikes.Text = string.Join(", ", selectedDislikes); //Set the text box with the selected dislikes
            }
            else // User didn't check the box to randomize dislikes
            {
                string input = txtDislikes.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter dislikes or check the box to randomize them.");
                }
                else //User provided manual input
                {
                    string userDislikes = input;
                    // You can use userDislikes elsewhere if needed
                }
            }
        }

        private void typeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (typeButton.Checked)
            {
                string[] types = {"Innocent", "Orphan", "Hero", "Villain", "Anti-Hero", "Sidekick", "Mentor", "Rogue", "Mystic", "Warrior", "Healer", "Trickster",
                    "Guardian", "Explorer", "Scholar", "Rebel", "Outcast", "Leader", "Follower", "Jester", "Bully", "Bureaucrat", "Thrill-Seeker", "Assassin",
                    "Martyr", "Savior", "Destroyer", "Creator", "Manipulator", "Peacemaker", "Conqueror", "Defender", "Avenger", "Visionary", "Dreamer",
                    "Inventor", "Artist", "Philosopher", "Scientist" };
                Random random = new Random();
                string randomType = types[random.Next(types.Length)]; // generates a random index from 0 to types.Length - 1, accesses the array at that index
                txtType.Text = randomType; //Set the text box
            }
            else
            {
                string input = txtType.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter a type or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userType = input;
                    // You can use userType elsewhere if needed
                }
            }
        }

        private void weaponButton_CheckedChanged(object sender, EventArgs e)
        {
            if (weaponButton.Checked)
            {
                string[] weapons = { "Sword", "Axe", "Bow", "Dagger", "Spear", "Staff", "Mace", "Crossbow", "Flail", "Whip", "Machete", "Boomerang",
                    "Hammer", "Katana", "Scythe", "Lance", "Halberd", "Trident", "Knife", "Rifle", "Gun", "Kama", "Sabre",
                    "Scimitar", "Sickle", "Rapier", "Shortsword", "Dagger", "Baseball Bat", "Chainsaw", "Sai", "Crowbar",
                    "Taser", "Club", "Shield", "Brass Knuckles", "Nunchaku", "Bo Staff", "Throwing Stars", "Chakram", "Sling" };
                Random random = new Random();
                string randomWeapon = weapons[random.Next(weapons.Length)]; // generates a random index from 0 to weapons.Length - 1, accesses the array at that index
                txtWeapon.Text = randomWeapon; //Set the text box

            }
            else
            {
                string input = txtWeapon.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter a weapon or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userWeapon = input;
                    // You can use userWeapon elsewhere if needed
                }
            }
        }

        private void personalityButton_CheckedChanged(object sender, EventArgs e)
        {
            if (personalityButton.Checked)
            {
                string[] goodTraits = {"Brave", "Compassionate", "Clever", "Loyal", "Charming", "Honest", "Creative", "Generous", "Wise", "Optimistic",
                "Empathetic", "Industrious", "Charismatic", "Courteous", "Intelligent", "Courageous", "Earnest",
                "Funny", "Reliable", "Neat", "Stable", "Energetic", "Adaptable", "Friendly", "Patient", "Respectful", "Thoughtful",
                "Trustworthy", "Understanding", "Witty", "Diligent", "Resourceful", "Sincere", "Supportive", "Tolerant", "Visionary",
                "Open-minded", "Passionate", "Analytical", "Artistic", "Humble", "Disciplined", "Innovative", "Insightful",
                "Perceptive", "Proactive", "Resilient", "Self-aware", "Pragmatic", "Forgiving", "Optimistic" };

                string[] neutralTraits = { "Curious", "Cautious", "Reserved", "Independent", "Introverted", "Extroverted", "Quirky", "Idealistic",
                "Ambitious", "Serious", "Silly", "Picky", "Mellow", "Practical", "Decisive", "Nonchalant", "Meticulous", "Outspoken", "Bold",
                "Emotional", "Calculating", "Shy", "Assertive", "Persistent", "Eccentric", "Skeptical"};

                string[] badTraits = {"Arrogant", "Impulsive", "Jealous", "Stubborn", "Cynical", "Deceitful", "Greedy", "Moody", "Reckless", "Vain",
                "Pessimistic", "Aloof", "Aggressive", "Apathetic", "Manipulative", "Lazy", "Critical", "Dimwitted", "Bossy",
                "Careless", "Cynical", "Defensive", "Childish", "Naive", "Short-tempered", "Jealous", "Controlling", "Obnoxious",
                "Sloppy", "Inflexible", "Selfish", "Dishonest", "Unreliable", "Disrespectful", "Arrogant", "Overconfident", "Indecisive",
                "Untrustworthy", "Vindictive", "Hypocritical", "Egotistical", "Conceited", "Gullible", "Overbearing",
                "Disorganized", "Unmotivated", "Resentful", "Impulsive", "Insecure", "Paranoid", "Overly critical", "Cowardly" };

                //Randomly select 1-3 good traits, 1-2 neutral traits, and 1-3 bad traits
                Random random = new Random();
                int numberOfGoodTraits = random.Next(1, 4); // Randomly choose between 1 and 3 good traits
                List<string> selectedGoodTraits = new List<string>();
                while (selectedGoodTraits.Count < numberOfGoodTraits)
                {
                    string randomGoodTrait = goodTraits[random.Next(goodTraits.Length)];
                    if (!selectedGoodTraits.Contains(randomGoodTrait)) // Ensure no duplicates
                    {
                        selectedGoodTraits.Add(randomGoodTrait);
                    }
                }
                // Randomly select 1-2 neutral traits
                int numberOfNeutralTraits = random.Next(1, 3); // Randomly choose between 1 and 2 neutral traits
                List<string> selectedNeutralTraits = new List<string>();
                while (selectedNeutralTraits.Count < numberOfNeutralTraits)
                {
                    string randomNeutralTrait = neutralTraits[random.Next(neutralTraits.Length)];
                    if (!selectedNeutralTraits.Contains(randomNeutralTrait)) // Ensure no duplicates
                    {
                        selectedNeutralTraits.Add(randomNeutralTrait);
                    }
                }
                int numberOfBadTraits = random.Next(1, 3); // Randomly choose between 1 and 3 bad traits
                List<string> selectedBadTraits = new List<string>();
                while (selectedBadTraits.Count < numberOfBadTraits)
                {
                    string randomBadTrait = badTraits[random.Next(badTraits.Length)];
                    if (!selectedBadTraits.Contains(randomBadTrait)) // Ensure no duplicates
                    {
                        selectedBadTraits.Add(randomBadTrait);
                    }
                }
                List<string> sections = new List<string>();

                if (selectedGoodTraits.Any())
                    sections.Add(string.Join(", ", selectedGoodTraits));

                if (selectedNeutralTraits.Any())
                    sections.Add(string.Join(", ", selectedNeutralTraits));

                if (selectedBadTraits.Any())
                    sections.Add(string.Join(", ", selectedBadTraits));

                txtPersonality.Text = string.Join(Environment.NewLine, sections);


            }
            else
            {
                string input = txtPersonality.Text.Trim();
                if (string.IsNullOrEmpty(input)) //User didn't provide input or check box
                {
                    //MessageBox.Show("Please enter a personality or check the box to randomize one.");
                }
                else //User provided manual input
                {
                    string userPersonality = input;
                    // You can use userPersonality elsewhere if needed
                }
            }
        }

        private void randSelectButton_Click(object sender, EventArgs e)
        {
            //This method is called when the "Randomize Selected" button is clicked.
            // It checks which checkboxes are checked and triggers their CheckedChanged events to randomize only those fields
            if (genderButton.Checked)
            {
                genderButton_CheckedChanged(sender, e);
            }
            if (nameButton.Checked)
            {
                nameButton_CheckedChanged(sender, e);
            }
            if (colorButton.Checked)
            {
                colorButton_CheckedChanged(sender, e);
            }
            if (alignButton.Checked)
            {
                alignButton_CheckedChanged(sender, e);
            }
            if (speciesButton.Checked)
            {
                speciesButton_CheckedChanged(sender, e);
            }
            if (likesButton.Checked)
            {
                likesButton_CheckedChanged(sender, e);
            }
            if (dislikesButton.Checked)
            {
                dislikesButton_CheckedChanged(sender, e);
            }
            if (typeButton.Checked)
            {
                typeButton_CheckedChanged(sender, e);
            }
            if (weaponButton.Checked)
            {
                weaponButton_CheckedChanged(sender, e);
            }
            if (personalityButton.Checked)
            {
                personalityButton_CheckedChanged(sender, e);
            }
        }

        private void randAllButton_Click(object sender, EventArgs e)
        {
            // This method is called when the "Randomize All" button is clicked.
            // It checks all the checkboxes and triggers their CheckedChanged events to randomize all fields.
            genderButton.Checked = true;
            nameButton.Checked = true;
            colorButton.Checked = true;
            alignButton.Checked = true;
            speciesButton.Checked = true;
            likesButton.Checked = true;
            dislikesButton.Checked = true;
            typeButton.Checked = true;
            weaponButton.Checked = true;
            personalityButton.Checked = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // This method is called when the "Reset" button is clicked.
            // It resets all text boxes and unchecks all checkboxes.
            txtGender.Clear();
            txtName.Clear();
            txtColor.Clear();
            txtAlign.Clear();
            txtSpecies.Clear();
            txtLikes.Clear();
            txtDislikes.Clear();
            txtType.Clear();
            txtWeapon.Clear();
            txtPersonality.Clear();
            genderButton.Checked = false;
            nameButton.Checked = false;
            colorButton.Checked = false;
            alignButton.Checked = false;
            speciesButton.Checked = false;
            likesButton.Checked = false;
            dislikesButton.Checked = false;
            typeButton.Checked = false;
            weaponButton.Checked = false;
            personalityButton.Checked = false;
        }
    }
}