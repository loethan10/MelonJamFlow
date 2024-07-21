using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordBank : MonoBehaviour
{
    public int level = 1; 
    public List<string> originalWords = new List<string>();
    private List<string> workingWords = new List<string>();
    public bool levelDone = false;
    
    public bool level1Done = false;
    public bool level2Done = false;
    public bool level3Done = false;
    public bool level4Done = false;
    public bool level5Done = false;
    public bool level6Done = false;
    public bool level7Done = false;
    public bool level8Done = false;
    public bool level9Done = false;
    public bool level10Done = false;
    public bool level11Done = false;

    public bool walk = false;
    public bool lie = false;
    public bool fight = false;
    public bool Nat = false; 
    public bool stay = false;
    public bool college = false;
    public bool party = false;
    public bool propose = false;
    public bool Melissa = false;
    public bool move = false;

    public bool Tom = false;
    public bool Will = false;

    void Start(){
        //workingWords.AddRange(originalWords);
        //Shuffle(originalWords); 
        //ConvertToLower(workingWords);
    }

    public void levelChecker(int level){
        switch (level) {
        case 1:
            //originalWords.Add("I love my dog.");
            originalWords = new List<string>(){
                "wah-wah", "goo goo ga ga"
            };
            break;
            
        case 2:
            if (walk){
                originalWords = new List<string>(){
                    "Dad was proud of me!", "Mom didn't see me walk.", "Legos hurt."
                };
            } else {
                originalWords = new List<string>(){
                    "Dad carried me around today.", "I want to go outside."
                };
            }
            originalWords.Add("I befriended a girl named Natalie.");
            originalWords.Add("I like to eat cake.");
            break;
            
        case 3:
            originalWords = new List<string>(){
                "Mom and dad adopted us a dog!"
            };
            
            if(lie){    
                originalWords.Add("My parents grounded me.");
            } else{
                originalWords.Add("My parents were disappointed.");
            }
            if(walk){
                originalWords.Add("I beat Will in a race today.");
                originalWords.Add("Want to be friends?");
                Will = true;
            } else{
                originalWords.Add("Will didn't want to be my friend.");
                originalWords.Add("I like science.");
                originalWords.Add("I'm going to read my book inside");
                Will = false; 
            }
            break;
            
        case 4:
            originalWords = new List<string>(){
                "I won the Spelling Bee!", "What's for lunch?", "Wanna be friends?"
            };
            if (!walk){
                originalWords.Add("I started playing Pokemon.");
            }
            if (fight) {
                originalWords.Add("Tom beat me to a pulp.");
                if (walk){
                    originalWords.Add("Will and I became best friends.");
                    Will = true;
                } else {
                    originalWords.Add("My parents took me to the ER for my broken arm.");
                } 
            } else {
                originalWords.Add("Will left me for the bully, Tom");
                Will = false; 
            }
            break;
            
        case 5:
            originalWords = new List<string>(){
                "My teacher is threatening to fail me if I don't study.", "The flu sucks... cough cough", "Think about me, needing espresso!"
            };
            if (Nat){
                originalWords.Add("I love you.");
                originalWords.Add("Our friendship is getting awkward.");
                originalWords.Add("Why did Natalie get so mad when I asked about periods?");
            } else {
                originalWords.Add("Natalie and I stopped talking.");
                originalWords.Add("I miss Natalie; we used to hang out so much.");
                originalWords.Add("Jasmine is so beautiful.");
            }
            break;
            
        case 6:
            originalWords = new List<string>(){
                "I am a coffee addict.", "I'm so bad at Smash Bros.", "It's my dad's birthday today!", "My homies want In-N-Out.", "Lake Tahoe was fun."
            };
            if (stay){
                if (Nat){
                    originalWords.Add("Natalie told me we should break up.");
                    originalWords.Add("Nat wanted to focus on studies; maybe I should, too.");
                } else {
                    originalWords.Add("Natalie slapped Jasmine today! HUH!?");
                    originalWords.Add("Jasmine and I are drifting.");
                }
            } else {
                if (Nat){
                    originalWords.Add("Nat and I broke up due to distance.");
                } else {
                    originalWords.Add("Jasmine cheated on me...");
                    if (Will){
                        Will = false;
                        originalWords.Add("Will and I stopped talking.");
                        originalWords.Add("Will started hooking up with Jasmine.");
                    }
                }
            }

            if (walk && !fight && stay){
                originalWords.Add("Ran into Tom today. We're cool and homies now!");
                Tom = true;
            }
            if (!Nat){
                originalWords.Add("I broke up with Jasmine. She was really weird.");
            }
            if (walk){
                originalWords.Add("I joined the football team today!");
            } else {
                originalWords.Add("I joined the robotics team today!");
                originalWords.Add("I caught a Snorlax! Best day ever!");
                originalWords.Add("Shake it off- shake it off!");
            }
            break;
            
        case 7:
            originalWords = new List<string>(){
                "I heard Paris is nice this time of year.", "I love the Yankees.", "Wonder how Matt and Ale are doing now?", "My mom got a promotion!", "Our dog died..."
            };
            if (college){
                originalWords.Add("I started seeing this nice girl, Patricia.");
                originalWords.Add("I love microbiology.");
                originalWords.Add("Benched 225 today.");
                originalWords.Add("It's getting so stressful.");
                originalWords.Add("UGHHH FINALS");
                originalWords.Add("#BRUINS");
                if (Tom) {
                    originalWords.Add("Tom somehow became my gymbro?");
                    originalWords.Add("Tom and I are rooming together next year.");
                } else {
                    originalWords.Add("My roommate Demarie is looking cute.");
                    originalWords.Add("Demarie is the best gymbro ever!");
                } 
            } else {
                originalWords.Add("Welp, college isn't for everyone.");
                originalWords.Add("Time to look for a job.");
                originalWords.Add("I wonder what college would've been like.");
                originalWords.Add("Should I start gambling?");
            }

            if (walk){
                originalWords.Add("Jackson, James, Yvette, and I went to Joshua tree to hike!");
                originalWords.Add("I love hiking!");
            } else {
                originalWords.Add("I joined a Pokemon Go club!");
            }

            if (lie){
                originalWords.Add("I had to cheat on my final to pass.");
            } else {
                originalWords.Add("I failed a class; lowkey should've cheated.");
            }
            break; 

        case 8:
            originalWords = new List<string>(){
                "I got disqualified from a Hackathon", "Bird watching is interesting.", "I sprained my ankle.", "I heard Sarah got pregnant."
            };
            if (party){
                if (college){
                    originalWords.Add("UCLA IS SO MUCH FUN");
                    originalWords.Add("My mom was upset that I joined a frat");
                } else {
                    originalWords.Add("Mel, Juni, and I are gonna go bar hopping!");
                    originalWords.Add("I should start a podcast!");
                }
            } else {
                if (college){
                    originalWords.Add("Gotta lock in for these finals.");
                    originalWords.Add("Why can't I integrate derivatives properly!?");
                    originalWords.Add("I'm so scared of failing a class.");
                } else {
                    originalWords.Add("I wonder why I have no friends.");
                    originalWords.Add("Why can't I pull?");
                    originalWords.Add("Oh, I should pirate some movies.");
                }
            }
            
            if (college && !Tom){
                originalWords.Add("Demarie highkey looking mega jacked.");
            }
            break;
        
        case 9:
            originalWords = new List<string>(){
                "I'm worried about marriage.", "This is the woman of my dreams.", "Stranger Things is such a great show.", "Billy Joel <3"
            };
            if (propose){
                originalWords.Add("Bea said YES!");
                originalWords.Add("Bea makes the best mashed potatoes.");
            } else {
                originalWords.Add("Bea proposed to me today!");
            }

            if (college){
                originalWords.Add("Working as a microbiologist is such hard work.");
                originalWords.Add("Thank goodness for my college degree.");
                originalWords.Add("I should be paid more.");
            } else {
                originalWords.Add("My mom asked when she could retire.");
                originalWords.Add("Bea wants me to get a job.");
                originalWords.Add("I ran into Noe and Jairo at the local pub today!");
                originalWords.Add("Flipping burgers at McDonalds is boring.");
            }

            if (Tom){
                originalWords.Add("Tom's parents keep trying to feed me.");
                originalWords.Add("Tom's fiance is so funny. He's great for him.");
            } else {
                originalWords.Add("Demarie's fiance of all people was TOM!");
                originalWords.Add("Demarie and Tom are great for each other!");
            }

            if (Will && !Nat && !stay){
                originalWords.Add("Will and I reconnected. I've forgiven him.");
                originalWords.Add("OH MY GOD! THEY KILLED KENNY! YOU BASTARDS!");
            }

            if (!walk){
                originalWords.Add("Bea has a crippling addiction to Pokemon; my kind of gal.");
                originalWords.Add("Bea takes such good care of me.");
            } else {
                originalWords.Add("I take good care of Bea.");
            }
            break;
        
        case 10:
            originalWords = new List<string>(){
                "I will always love who you are.", "Wow! Another kid!", "NFTs are scams!", "Panda Express tastes great."
            };
            if (Melissa){
                originalWords.Add("Bea was annoyed because I named our son Melissa, haha!");
                originalWords.Add("Melissa lost his first tooth!");
                originalWords.Add("Melissa and his friends had a sleepover.");
                
            } else {
                originalWords.Add("Welp, too late to change her name. Our daughter's name is now Michael.");
                originalWords.Add("Michael lost her first tooth!");
                originalWords.Add("Michael and her friends had a sleepover.");
            }

            if (walk){
                originalWords.Add("Ran 8 miles straight today!");
                originalWords.Add("Feeling like A-Train!");
                if (Melissa){
                    originalWords.Add("I wonder when Melissa will start walking. He's so energetic.");
                } else {
                    originalWords.Add("I wonder when Michael will start walking. She's so energetic.");
                } 
            } else {
                originalWords.Add("My knees hurt so much.");
                originalWords.Add("Feeling like Sisyphus.");
                if (Melissa){
                    originalWords.Add("I wonder when Melissa will stop crawling. He seems so tired.");
                } else {
                    originalWords.Add("I wonder when Michael will stop crawling. She seems so tired.");
                } 
            }
            break;

        case 11:
            originalWords = new List<string>(){
                "I love my life. No regrets.", "Dad passed today. We're devastated, but pushing through.", "We adopted a dog, Shiloh!", "Mmm... water."
            };
            if (move){
                originalWords.Add("I love France.");
                if (Melissa){
                    originalWords.Add("Melissa shoved his sibling onto the street.");
                    originalWords.Add("I think Melissa is upset by the move.");
                } else {
                    originalWords.Add("Michael shoved her sibling onto the street.");
                    originalWords.Add("I think Michael is upset by the move.");
                }
            } else {
                originalWords.Add("I love the US.");
                if (Melissa){
                    originalWords.Add("Melissa bought me flowers today! He's such a sweet little girl.");
                } else {
                    originalWords.Add("Michael bought me flowers today! She's such a sweet little girl.");
                }
            }
            if (walk){
                originalWords.Add("Can't stop working, must keep working.");
                originalWords.Add("I'm scared to die working.");
                if (move){
                    originalWords.Add("Ate a croissant today.");
                    originalWords.Add("Microbiology in 21st century France is awesome.");
                } else {
                    originalWords.Add("Are bread today.");
                    originalWords.Add("Capitalism needs to be re-evaluated.");
                }
            } else {
                originalWords.Add("I can't wait to enjoy my retirement with Bea and the kids.");
                originalWords.Add("Pokemon GoFest is in 3 days!");
                if (move){
                    originalWords.Add("Ate a baguette today.");
                    originalWords.Add("We're going to watch Ed Sheeran live!");
                } else {
                    originalWords.Add("Ate a donut today.");
                    originalWords.Add("NASCAR is pretty fun to watch! Circles and circles!");
                }
            }
            if (Tom){
                originalWords.Add("Tom and his new husband Benji are great babysitters.");
            } else {
                originalWords.Add("Demarie and Tom are having a rough patch.");
            }

            if (Will){
                originalWords.Add("Will and Juni invited us to their summertime yacht!");
            }
            break;

        default:    
            break;
        }

        Shuffle(originalWords);
        
    }

    private void Shuffle(List<string> list){
        for (int i = 0; i < list.Count; i++){
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random]; 
            list[random] = temporary; 
        }
    }

    private void ConvertToLower(List<string> list){

    }

    public string GetWord(){
        string newWord = string.Empty; 

        if (originalWords.Count != 0){
            newWord = originalWords.Last();
            originalWords.Remove(newWord);
        } else {
            switch(level){
                case 1:
                    level1Done = true;
                    break;
                case 2:
                    level2Done = true;
                    break;
                case 3:
                    level3Done = true;
                    break;
                case 4:
                    level4Done = true;
                    break;
                case 5:
                    level5Done = true;
                    break;
                case 6:
                    level6Done = true;
                    break;               
                case 7:
                    level7Done = true;
                    break;
                case 8:
                    level8Done = true;
                    break;
                case 9:
                    level9Done = true;
                    break;
                case 10:
                    level10Done = true;
                    break;
                case 11:
                    level11Done = true;
                    break;
                default:
                    levelDone = true;
                    break;
            }
        }

        return newWord;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
