using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Game_2D
{
    class Program
    {
        static float playerHealth;
        static int playerStrength;
        static int playerDefence;
        static int playerLuck;
        static int playerSpeed;
        static string playerName;

        static float monsterHealth = 20;
        static int monsterStrength = 5;
        static int monsterDefence = 5;
        static int monsterLuck = 5;
        static int monsterSpeed = 2;
        static string monsterName = "Leviticus the Demeantor";
        // player and monster variables. 
       
        // "static" allows our variables to be accessed through whole program as an object.
            // objects are already loaded into the program when "static".  
                  // "static" variables are global variables (objects).
        
        static void Main(string[] args)
        {
            Console.WriteLine(" A ferocious monster by the name of " + (monsterName) + " has a value of different characteristics " );
            Console.WriteLine(" Type attack to inflict damage off of " + monsterName);
            Console.WriteLine(" Type defend to take up half the damage consumed by " + monsterName);
            Console.ReadLine();


            bool gameExit = false;                                 
            // allows us to start a new combat at the end of a combat. 
            

            CreatePlayer();
            
            
            
            while(!gameExit)
            // allows us to process a new combat multiple times 
            {
            CombatGen(out gameExit);
            ProcessCombatGen();
        }
    }
    
        static void CreatePlayer()
        {
            playerHealth = 20;
            playerStrength = 5;
            playerDefence = 5;
            playerLuck = 5;
            playerSpeed = 2;
            Console.WriteLine("What's your name?");
            playerName = Console.ReadLine();
        }

        static void LoadNewMonster()
        {
            monsterHealth = 10;
            monsterStrength = 5;
            monsterDefence = 5;
            monsterLuck = 5;
            monsterSpeed = 2;
            monsterName = "Leviticus the Demeantor";
        }

        static void CombatGen(out bool gameExit)                                     // when next combat starts, new monster will be loaded
        {
            LoadNewMonster();
            gameExit = false;
        }

        static void ProcessCombatGen()
        {
            while (monsterHealth > 0 && playerHealth > 0)
            {
                string playerStance;
                string playerAction;

                Console.WriteLine("Please input your stance");                        // player stance and attack 
                playerStance = Console.ReadLine();

                Console.WriteLine("Please input your action");
                playerAction = Console.ReadLine();

                if (playerStance == "attack" && playerAction == "assault")
                {
                    Console.WriteLine("You attack the monster with all your strength");
                    float extraDamage = (playerStrength * 1.5f) * rand.Next(0, playerLuck) * 0.01f;
                    monsterHealth -= ((playerStrength * 1.5f) + extraDamage) - monsterDefence;

                }
                if (playerStance == "defend" && playerAction == "assault")
                {

                    monsterHealth -= (playerStrength * 0.75f) - monsterDefence;
                }

                if (playerStance == "defend" && playerAction == "defend")                       // monster stance and attack
                {
                    Console.WriteLine("Swords of yours are raised , prepare to parray!");
                    float extraDamage = (monsterStrength * 0.9f) * rand.Next(0, monsterLuck) * 0.01f;
                    playerHealth -= ((monsterStrength * 0.75f) + extraDamage) - playerDefence;
                }

                if (playerStance == "attack" && playerAction == "defend")
                {
                    Console.Writeline("You raise your sword upwards, and prepare to parray!");
                    float extraDamage = (monsterStrength * 0.9f) * rand.Next(0, MonsterLuck) * 0.01f;
                    playerHealth -= ((monsterStrength * 0.9f) + extraDamage) - playerDefence;
                }

                Console.WriteLine("monster health : " + monsterHealth);
                Console.WriteLine("players health : " + playerHealth);

            }
            if (playerHealth <= 0)
            {
                Console.WriteLine(playerName + " Died");
                Console.ReadLine();
                // return 0;      

            }

            else if (monsterHealth <= 0)
            {

                Console.WriteLine(monsterName + " Died and Perished! Congrats!!");
                Console.ReadLine();
                //  return 0;

            }

             // if both player and user <= 0 then both have perished                               

            else if (monsterHealth <= 0 && playerHealth <= 0)
            // && connects boolean statements
            {

                Console.WriteLine(" Both have perished. Till Fate meet again! ");
                Console.ReadLine();
                // return 0;
            }

        }
    

    
                }
    }
    





       
   

