using System;

namespace C__Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Begin program with a shitty setting
            Console.WriteLine("You're walking through a dark void, when suddenly the area around you is lit up\n");
            Console.ReadKey();
            Console.WriteLine("You find yourself face-to-face with some ugly creature that looks like it wants to hurt you\n");
            Console.ReadKey();

            //Initialize variables
            double health = 10;
            int oppHealth = 20;
            int flee = 5;
            int crit = 10;
            int danceTruce = 0;
            int hugTruce = 0;
            int talkTruce = 0;
            int insult = 0;
            string action = "";
            string reason = "";
            Random rnd = new Random();

            //Encounter loop
            while (health > 0 && oppHealth > 0)
            {
                //Player's turn
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your health: " + health);
                Console.WriteLine("Attacker's health: " + oppHealth + "\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What will you do?\n");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fight");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Reason");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Run\n");

                //Reset text color to white
                Console.ForegroundColor = ConsoleColor.White;

                action = Console.ReadLine();

                Console.Write("\n");

                //Attack
                if (action == "Fight"){
                    if(danceTruce == 2){
                        Console.WriteLine("You approach the defeated dancer, spin around gracefully, then send your foot rocketing into their face\n");
                        oppHealth = 0;
                        Console.ReadKey();
                        break;
                    }
                    //Player attempts to hurt the attacker
                    int damage = rnd.Next(0 , 6);
                    crit = rnd.Next(0, 6);
                    //If player inflicts zero damage
                    if(damage == 0){
                        Console.WriteLine("The attacker stared at you strangely as you mindlessly punch the air");
                        Console.WriteLine("Your attack did literally nothing\n");
                    }
                    //If player inflicts minimal damage
                    else if(damage == 1){
                        Console.WriteLine("The attacker flinched slightly as your flicked them for ONE damage\n");
                    }
                    //If player inflicts maximum damage
                    else if(damage == 5){
                        Console.Write("With the power of your ");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("ANGEL ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("shining from within, you hurl youself at the attacker and inflict a METEORIC FIVE DAMAGE!\n");
                    }
                    else{
                        Console.WriteLine("You wound up and wacked your attacker for " + damage + " damage\n");
                    }
                    //If player lands a critical hit; doubles current damage value
                    if(crit == 5 && damage != 0){
                        Console.Write("Your ");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("ANGEL ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("charged you with energy and DOUBLED the force of your attack!\n");

                        damage *= 2;
                    }
                    oppHealth -= damage;

                    if(oppHealth <= 0){
                        break;
                    }
                }

                //Reason
                else if(action == "Reason"){
                    Console.WriteLine("How will you reason with the attacker?\n");

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Dance");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hug");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Talk");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Flip Off\n");

                    Console.ForegroundColor = ConsoleColor.White;

                    reason = Console.ReadLine();
                    Console.WriteLine();
                }
                //Run
                else if(action == "Run"){
                    flee = rnd.Next(0 , 5);
                    if(flee == 4){
                        Console.WriteLine("You cued the blinding floodlights, then used them as cover to gracefully escape\n");
                        break;
                    }
                    else{
                        Console.WriteLine("You quite literally come face-to-face with an insivible wall, and cannot escape\n");
                    }
                }
                //Perish
                else if(action == "Die"){
                    Console.WriteLine("Congatulations! You've found the secret fourth action!");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You submitted to the attacker and promptly reached ZERO health\n");
                    health = 0;
                    Console.ReadKey();
                    break;
                }

                //Wait before continuing
                Console.ReadKey();

                //Attacker's turn
                Console.ForegroundColor = ConsoleColor.White;

                //If player chooses to reason
                if(action == "Reason"){
                    //If "Dance" is selected
                    if(reason == "Dance"){
                        if(danceTruce == 0){
                            Console.WriteLine("You preform a jaw-dropping set of dance moves, topping it off with a spin, and a thumbs up");
                            Console.ReadKey();
                            Console.WriteLine("The attacker tilts their head, then busts out their own set of moves");
                            Console.ReadKey();
                            Console.WriteLine("They seem to want a dance off\n");
                            danceTruce += 1;
                            Console.ReadKey();
                        }
                        else if(danceTruce == 1){
                            Console.WriteLine("You drop to the ground and start spinning on your head, then handspring back onto your feet");
                            Console.ReadKey();
                            Console.WriteLine("Your opponent performs a disco, then slides on their knees before striking a pose");
                            Console.ReadKey();
                            Console.WriteLine("They seem to be getting tired\n");
                            danceTruce += 1;
                            Console.ReadKey();
                        }
                        else if(danceTruce == 2){
                            danceTruce += 1;
                            break;
                        }
                    }
                    //If "Hug" is selected
                    else if(reason == "Hug"){
                        Console.WriteLine("You walk over to the it with your arms wide open, and then give it a nice warm hug");
                        Console.ReadKey();
                        Console.WriteLine("You can feel the its aggression fade away as their body relaxes\n");
                        hugTruce += 1;
                        Console.ReadKey();
                        break;
                    }
                    //If "Talk" is selected
                    else if(reason == "Talk"){
                        if(talkTruce == 0){
                            Console.WriteLine("You ask the individual how their day has been so far");
                            Console.ReadKey();
                            Console.WriteLine("They look at you with confusion on their face, then mumble something\n");
                            talkTruce =+ 1;
                            Console.ReadKey();
                        }
                        else if(talkTruce == 1){
                            Console.WriteLine("You ask the individual out on a date");
                            Console.ReadKey();
                            Console.WriteLine("They freeze as their eyes widen and dilate to a point\n");
                            talkTruce += 1;
                            Console.ReadKey();
                        }
                        else if(talkTruce == 2){
                            Console.WriteLine("You tell the individual that you'd rather go on a date than fight\n");
                            Console.ReadKey();
                            Console.WriteLine("The individual suddenly looks less interested in fighting, and more interested in you");
                            talkTruce += 1;
                            Console.ReadKey();
                        }
                        else if(talkTruce == 3){
                            break;
                        }
                    }
                    //If "Flip Off" is selected
                    else if(reason == "Flip Off"){
                        if(insult == 0){
                            Console.WriteLine("You put on the nastiest face you can muster and hold up the most menacing middle finger ever");
                            Console.ReadKey();
                            Console.WriteLine("The creature, intimidated by your show of force is slightly reluctant to attack you as it shakes with fear");
                            health -= 0.5;
                            Console.ReadKey();
                            Console.WriteLine("You took 0.5 damage as it barely hits you with a shaky fist\n");
                            insult += 1;
                            Console.ReadKey();
                        }
                        else if(insult == 1){
                            Console.WriteLine("You turn around and hit the creature with the iconic double backflip: two middle fingers at once");
                            Console.ReadKey();
                            Console.WriteLine("It falls into disarray as it's filled with panic from such an incomprehenisble power move");
                            Console.ReadKey();
                            Console.WriteLine("The creature is paralyzed with fear, and is unable to attack you\n");
                            insult += 1;
                            Console.ReadKey();
                        }
                        else if(insult == 2){
                            break;
                        }
                    }    
                }
                //If the player chooses to fight
                else{
                    //Attacker attempts to hurt the player's ANGEL
                    int hit = rnd.Next(0 , 6);
                    if(hit == 0){
                        Console.WriteLine("You were hit with a facefull of wind from a crushing blow, which completely missed you\n");
                    }
                    else if(hit == 1){
                        Console.WriteLine("The attacker threw pollen at you, and you took ONE damage from all the sneezing\n");
                    }
                    else if(hit == 5){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were sent to another dimension as you were hit for a WHOPPING FIVE DAMAGE\n");
                    }
                    else{
                        Console.WriteLine("You were struck for " + hit + " damage!\n");
                    }
                    health -= hit;
                }
            }

            //Determine outcome

            //If player is able to flee the encounter
            if(flee == 4){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You can run, and let's hope you can hide just as well! You're safe, for now...");
            }
            //If player annihilates the attacker
            else if((health > 0 && oppHealth <= 0) || (oppHealth == 0 && danceTruce == 2)){
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Beams of light shoot out from the attacker before they EXPLODE in a flash of light!");
                Console.WriteLine("You suddenly awake from your nightmare, and see your mother staring down at you with concern");
            }
            //If player's ANGEL is shattered by the attacker
            else if(oppHealth > 0 && health <= 0){
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Your vision turns to the sky and everything fades to black as your ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ANGEL ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("is shattered into pieces");
                Console.Write("Somehere in the world lay your body, and pieces of your ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ANGEL ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("in the hands of a dark queen...");
            }
            //If player bests their opponent in a dance-off
            else if(danceTruce == 3){
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("The opponent, exhausted from dancing, flops onto the ground and falls fast asleep");
                Console.WriteLine("You gradually wake up from the strange dream you had, just as your mother dances in with a warm pie");
            }
            //If player hugs it out with their new friend
            else if(hugTruce == 1){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The thing, surprised, smiles as it hugs you back. Moments afterwards, it melts away into the air");
                Console.ReadKey();
                Console.WriteLine("The dark world slowly ripples and fades away as you wake up to your mother's warm embrace");
            }
            //If player asks out the individual
            else if(talkTruce == 3){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The individual pauses for a moment");
                Console.ReadKey();
                Console.WriteLine("They then run over and whisk you away towards a diner");
                Console.ReadKey();
                Console.WriteLine("You wake up to your mother roughly shaking you awake and demanding to know about the date you went on and with who");
                Console.ReadKey();
                Console.WriteLine("Uh oh, you were hoping she wouldn't find out about it");
            }
            //If player shows the timid creature who's the REAL alpha
            else if(insult == 2){
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("The terrified individual immediately takes off, shrieking with fear\n");
                Console.ReadKey();
                Console.WriteLine("It isn't long before it's enveloped by the surrounding darkness");
                Console.ReadKey();
                Console.WriteLine("Loud yelling startles you awake as your mother storms into your room...");
                Console.ReadKey();
                Console.WriteLine("She has an angry look on her face as she tells you that you're grounded for failing this week's math quiz");
            }

            //Wait before closing
            Console.ReadKey();
        }
    }
}
