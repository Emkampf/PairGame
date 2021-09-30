using MurderMysteryRepos;
using PairGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurderMystery_Console
{
    public class ProgramUI
    {
        
        public MysteryContent _killer = new MysteryContent();
        public void Run()
        {
  
            _killer.PickSuspect();
            MainMenu();
        }

        //Main Menu
        private void MainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Dr. Jamison Jamison was murdered tonight in his home during the middle of a dinner party. His butler, Martin, reported the crime. You have been called to help solve the mystery. The 4 guests of the dinner party have all been held for questioning, and the entire house has been opened up for you to investigate. Where would you like to start?\n" +
                    "1. Suspects\n" +
                    "2. Search the house.\n" +
                    "3. Make an accusation.\n" +
                    "4. Give up.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SuspectMenu();
                        break;
                    case "2":
                        RoomMenu();
                        break;
                    case "3":
                        MakeAnAccusation();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-4.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        //Character Menu
        private void SuspectMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("As you look around the main room, you see the five suspects that have been held on the premesis for questioning. Choose who you'd like to speak with first.\n" +
                    "1. Martin\n" +
                    "2. Karen\n" +
                    "3. Matthew\n" +
                    "4. Linda\n" +
                    "5. Peter\n" +
                    "6. Return to the main room.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        MartinMenu();
                        break;
                    case "2":
                        KarenMenu();
                        break;
                    case "3":
                        MatthewMenu();
                        break;
                    case "4":
                        LindaMenu();
                        break;
                    case "5":
                        PeterMenu();
                        break;
                    case "6":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-6.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        //Room Menu
        private void RoomMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Choose your destination. We need to search all the rooms for clues.\n" +
                    "1. Kitchen\n" +
                    "2. Living Room\n" +
                    "3. Shed\n" +
                    "4. Garage\n" +
                    "5. Dining Room\n" +
                    "6. Return to the main room.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Kitchen
                        break;
                    case "2":
                        //Living Room
                        break;
                    case "3":
                        //Shed
                        break;
                    case "4":
                        //Garage
                        break;
                    case "5": 
                        //Dining Room
                    case "6":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-5.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        //Make an accusation
        private void MakeAnAccusation()
        {
            bool isRunning = true;
            while (isRunning)
            {
                MysteryContent killer = new MysteryContent();
                {
                    Console.Clear();
                    Console.WriteLine("Have you gathered all the evidence? If you are ready, lets lock this criminal up. Enter the number of which suspect you think committed the crime.\n" +
                       "1. Martin\n" +
                       "2. Karen\n" +
                       "3. Matthew\n" +
                       "4. Linda\n" +
                       "5. Peter\n");
                    string userInput = Console.ReadLine();
                    int accusationSelect = int.Parse(userInput);
                    killer.OfficialAccusation = (Suspects)accusationSelect;
                    if (killer.OfficialAccusation == _killer.OfficialAccusation)
                    {
                        if (_killer.OfficialAccusation == Suspects.Martin)
                        {
                            Console.Clear();
                            Console.WriteLine("You did it! You found the killer.Great job!\n" + "\n" + "You're right. It was me. I'd had it with Jamison's antics. Paying every, other worker extra, except me. Even the kid's soccer coach got more money than me? Ridiculous. I've worked for this family since before he was born, and I couldn't take it any more! After our latest altercation about my wages, I wrote my resignation letter, but Jamison would not have. Therefore, I found the nearest object I could, and did what needed to be done.");
                            Console.ReadKey();
                        }
                        else if (_killer.OfficialAccusation == Suspects.Karen)
                        {
                            Console.Clear();
                            Console.WriteLine("You did it! You found the killer.Great job!\n" + "\n" + "Yep. That's right. I did it. I couldn't stand little Mrs.Jamison a second longer. When I approached her goodie two shoes husband about my complaints, he told me....ME to 'Calm down. It's only juice, Karen.' No ONE speaks to me like that *aggressive finger snapping*. Therefore, I took one of those cheap lamps from the living room....THAT'S RIGHT MRS.JAMISON, I KNOW WHERE YOU GOT THOSE...And beat the hell out of Jamison. Unfortunately, my plan didn't work, as you never even suspected his wife.");
                            Console.ReadKey();
                        }
                        else if (_killer.OfficialAccusation == Suspects.Matthew)
                        {
                            Console.Clear();
                            Console.WriteLine("You did it! You found the killer.Great job!\n" + "\n" + "It was me. Jamison told me he was going to be firing me at the end of the season and replacing me with Peter....which ultimately makes sense, but I was none the less furious about it. This was my main souce of income over the last 3 years, and I didn't want to go back to working an actual job. To be honest, I would've probably confessed within the week, anyway.");
                            Console.ReadKey();
                        }
                        else if (_killer.OfficialAccusation == Suspects.Linda)
                        {
                            Console.Clear();
                            Console.WriteLine("You did it! You found the killer.Great job!\n" + "\n" + "*Linda starts to sob uncontrollably*\n" + "IT WAS ME. IT WAS ME. OH GOD IT WAS ME. Jamison told me he was planning on investing in the latest crypto currency, FartLekCoin. FARTLEKCOIN, for Christ's sake. I simply could not let him go through with it, and was planning my resignation. However, I didn't want the family to suffer from this terrible investment, so I did the only thing that came to mind. Oh Jamison, I'm so sorry!");
                            Console.ReadKey();
                        }
                        else if (_killer.OfficialAccusation == Suspects.Peter)
                        {
                            Console.Clear();
                            Console.WriteLine("You did it! You found the killer.Great job!\n" + "\n" + "Oi! It was me. I cornered Jamison midway through the party to finally try to get through to him that I, not Matthew, needed to be the one coaching his son. Jamison, YET AGAIN, turned me down. Seeing as we were in the garage, I figured it was finally time to show him just how great at football I am. I placed me ball down, lined up me strike, and scored the best game winner of me life. I regret ");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        isRunning = false;
                        Console.Clear();
                        Console.WriteLine("You were wrong, the killer is still running loose. Keep investigating.");
                        Console.ReadKey();
                    }
                }
            }
        }

        //Character Menus
        private void MartinMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You approach Martin, the family butler.\n" +
                   "'How may I assist?' he asks.\n" +
                   "1. What were you doing leading up to the discovery of the body?\n" +
                   "2. How was your relationship with Dr. Jamison leading up to tonight?\n" +
                   "3. Out of the people here, who do you think is responsbile?\n" +
                   "4. Return to the other suspsects.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. What were you doing leading up to the discovery of the body?\n" + "\n" + "I was checking in with the kitchen staff, as Karen had asked me (for the 5th time in 45 minutes, mind you) how much longer it would be until dinner was prepared.\n" +
                            "Martin emphatically rolls his eyes\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. How was your relationship with Dr. Jamison leading up to tonight?\n" + "\n" + "Martin sighs\n" + "Dr. Jamison was a lovely man to work for. A fair man, and loyal to those who worked for him. However, he could be more than frugal, at times. Case in point: I had been trying to speak to him about raising my wages for the last few months, and he would continuously dodge the conversation. A shame that it is now one we will never have.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Out of the people here, who do you think is responsbile?\n" + "\n" + "I have never trusted Linda. I mean, seriously. Who puts pineapple on their pizza? Preposterous. Savage, really.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-4.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void KarenMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You approach Karen, the mother in charge of Dr.Jamison's son's soccer team carpool\n" +
                   "'If we don't speed this up, I'm gonna need to speak to the person in charge' she demands.\n" +
                   "1. What were you doing leading up to the discovery of the body?\n" +
                   "2. How was your relationship with Dr. Jamison leading up to tonight?\n" +
                   "3. Out of the people here, who do you think is responsbile?\n" +
                   "4. Return to the other suspsects.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. What were you doing leading up to the discovery of the body?\n" + "\n" + "Not that it is any of YOUR business, but I was waiting on my dinner. It had been hours, and the good for nothing kitchen staff was simply ignoring all of my requests. I was trying to find Dr.Jamison to file a complaint.\n" +
                            "Martin is still emphatically rolling his eyes\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. How was your relationship with Dr. Jamison leading up to tonight?\n" + "\n" + "Dr. Jamison? He was fine. Now his wife? Don't even get me started on her. I don't know many times I had to ask her to makesure to get the ORANGE-flavored juice for the team...ORANGE-FLAVORED...yet she continuously DOES NOT get that flavor. hmph the AUDACITY of some people.\n" + "\n" + "You swear that, for a breif moment, you hear a break in the crying, and instead a slight chuckle come from the direction of the newly-widowed Mrs.Jamison.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Out of the people here, who do you think is responsbile?\n" + "\n" + "Peter. It is OBVIOUSLY Peter. I gave him a fanny pack as his Secret Santa last year, and you know where I recently saw that fanny pack? AT MY LOCAL GOODWILL. Clearly someone that ungrateful would do something like this.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-4.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

            }

        }
       
        private void MatthewMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You approach Matthew, who had been invited as a 'Thank you' for all his hard work as the coach of Dr. Jamison's son's soccer team.\n" +
                   "'Any chance we can turn on the game while we wait?' he asks.\n" +
                   "1. What were you doing leading up to the discovery of the body?\n" +
                   "2. How was your relationship with Dr. Jamison leading up to tonight?\n" +
                   "3. Out of the people here, who do you think is responsbile?\n" +
                   "4. Return to the other suspsects.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. What were you doing leading up to the discovery of the body?\n" + "\n" + "I was in the backyard having a kick around with Jamison Jr. The kid has mad potential.\n" +
                            "\n" + "You notice Peter's eyes narrow at the sound of this.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. How was your relationship with Dr. Jamison leading up to tonight?\n" + "\n" + "Dr. Jamison was a-okay to me. He was paying me extra on the side to give J.J. additional soccer lessons. Can never complain about someone putting extra balls in the net, if you catch my drift.\n" + "\n" + "Martin is, once again, emphatically rolling his eyes.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Out of the people here, who do you think is responsbile?\n" + "\n" + "That butler has always shown me a yellow card every time I'm around. Probably because he's jealous of my quick feet. I always tell him that I'm happy to help him up the agility, but to no avail.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-4.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

            }

        }

        private void LindaMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You approach Linda, Dr. Jamison's trusted accountant of over 20 years.\n" +
                   "'I still can't believe it...' she mutters, as if in a daze, as you approach.\n" +
                   "1. What were you doing leading up to the discovery of the body?\n" +
                   "2. How was your relationship with Dr. Jamison leading up to tonight?\n" +
                   "3. Out of the people here, who do you think is responsbile?\n" +
                   "4. Return to the other suspsects.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. What were you doing leading up to the discovery of the body?\n" + "\n" + "Jamison and I had just finished going over the financial records of his new startup for the last quarter. Everything was as in order as ever. Since that didn't take very long, I was on my out to my car to put my things away before re-joining the party.\n" +
                            "\n" + "She shakes her head as if to say she is fully aware of how suspicuous that sounds\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. How was your relationship with Dr. Jamison leading up to tonight?\n" + "\n" + "I have been working for him for over twenty years. We obviously had our disagreements, over time, but that's to be expected when providing insight on money. Outside of our work-relationship, things were always peachy.\n" + "\n" + "You notice Mrs.Jamison is not too keen about Linda still being here.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Out of the people here, who do you think is responsbile?\n" + "\n" + "That annoyance Karen. She's always been trying to stick her nose all over this family's business for no reason other than to create gossip throughout the community. And also because she's constantly been trying to get Jamison to donate to her various pyramid schemes over the years.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-4.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

            }

        }

        private void PeterMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You approach Peter, Dr. Jamison's understudy.\n" + "'What do you want?' he coldly asks.\n" +
                   "1. What were you doing leading up to the discovery of the body?\n" +
                   "2. How was your relationship with Dr. Jamison leading up to tonight?\n" +
                   "3. Out of the people here, who do you think is responsbile?\n" +
                   "4. Return to the other suspsects.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. What were you doing leading up to the discovery of the body?\n" + "\n" + "Minding my business, as should you.\n" +
                            "\n" + "He lets out an annoyed grunt.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. How was your relationship with Dr. Jamison leading up to tonight?\n" + "\n" + "He was my teacher. I was studying under him through an internship at my university. It was fine. We got along. I learned.\n" + "\n" + "He maintains the same, annoyed tone throughout.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Out of the people here, who do you think is responsbile?\n" + "\n" + "That idiot Matthew. Can you believe Jamison would entrust that guy with coaching his son in football? I gew up in Liverpool, for Christ's sake. No matter how many times I offered, Jamison repeatedly kept Matthew as the boy's coach. A travesty.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice between 1-4.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;

                }
            }
        }
        private void KitchenResponse()
        {
            if (_killer.OfficialAccusation == Suspects.Martin)
            {
                Console.Clear();
                Console.WriteLine("You found a letter of resignation, but it is not signed.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Karen)
            {
                Console.Clear();
                Console.WriteLine("You find a box full of juice boxes. Upon further inspection, they appear to be orange flavored. Upon further inspection, you notice drops of blood on the plastic.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Matthew)
            {
                Console.Clear();
                Console.WriteLine("Kitchen looks clean. Besides those dishes your glad you dont have to worry about.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Linda)
            {
                Console.Clear();
                Console.WriteLine("You found a letter of resignation, but it is not signed.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Peter)
            {
                Console.Clear();
                Console.WriteLine("You found a letter of resignation, but it is not signed.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
        }
        private void LivingRoom()
        {
            if (_killer.OfficialAccusation == Suspects.Martin)
            {
                Console.Clear();
                Console.WriteLine("Nothing seems to be out of place.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Karen)
            {
                Console.Clear();
                Console.WriteLine("You notice a dust ring on one of the coffee tables, where it appears a lamp used to reside.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Matthew)
            {
                Console.Clear();
                Console.WriteLine("Looks good in here.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Linda)
            {
                Console.Clear();
                Console.WriteLine("You notice the pillow arrangement is not matched on one of the couches,  while all other couches are matching.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Peter)
            {
                Console.Clear();
                Console.WriteLine("Nothing seems to be out of place. Are the bears on?\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
        }
        private void Shed()
        {
            if (_killer.OfficialAccusation == Suspects.Martin)
            {
                Console.Clear();
                Console.WriteLine("You found a duster with its end sharpened, and is that blood?!\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Karen)
            {
                Console.Clear();
                Console.WriteLine("Looks like a regular shed. Nothing to see here.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Matthew)
            {
                Console.Clear();
                Console.WriteLine("The shed appears as if it's been rumanged through. Since your unfamilair with its contents, you arent sure if something is missing.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Linda)
            {
                Console.Clear();
                Console.WriteLine("Tools sitting in an orderly fashion.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Peter)
            {
                Console.Clear();
                Console.WriteLine(" The shed appears as if it's been rumanged through. Since your unfamilair with its contents, you arent sure if something is missing.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
        }
        private void Garage()
        {
            if (_killer.OfficialAccusation == Suspects.Martin)
            {
                Console.Clear();
                Console.WriteLine("Yep, there are cars in here...\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Karen)
            {
                Console.Clear();
                Console.WriteLine("You find upon inspecting the Jamison familys car, you notice Mrs. Jamison's car unlocked with a bloodied lamp hidden under soccer gear.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Matthew)
            {
                Console.Clear();
                Console.WriteLine("You notice a head sized dent in the hood of Mr. Jamisons Bentley.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Linda)
            {
                Console.Clear();
                Console.WriteLine("Yep, looks like a regular garage.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Peter)
            {
                Console.Clear();
                Console.WriteLine("After looking around the garage, you come across a soccer ball with blood on one side.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
        }
        private void DiningRoom()
        {
            if (_killer.OfficialAccusation == Suspects.Martin)
            {
                Console.Clear();
                Console.WriteLine("A serving tray has been flipped over, with all of its contents spilled onto the floor.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Karen)
            {
                Console.Clear();
                Console.WriteLine("You find left overs from dinner. *tummy rumbles, grabs roll*\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Matthew)
            {
                Console.Clear();
                Console.WriteLine("Upon close inspection, you find a bloodied hammer wrapped up in what looks to be an unused kitchen utensil set.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Linda)
            {
                Console.Clear();
                Console.WriteLine("You notice one of the seats has a pillow, it looks like this belongs elsewhere.\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
            else if (_killer.OfficialAccusation == Suspects.Peter)
            {
                Console.Clear();
                Console.WriteLine("You find left overs from dinner. *tummy rumbles, grabs roll*\n" + "\n" + "Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
    


