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
            }else{
                originalWords.Add("My parents were disappointed.");
            }
            if(walk){
                originalWords.Add("I beat Will in a race today.");
                originalWords.Add("Want to be friends?");
            }else{
                originalWords.Add("Will didn’t want to be my friend.");
                originalWords.Add("I like science.");
                originalWords.Add("I’m going to read my book inside");
            }
            break;
            
        case 4:
            originalWords = new List<string>(){
                "Level 4", "Cuatro", "QUATRO"
            };
            break;
            
        case 5:
            originalWords = new List<string>(){
                "Level 5", "EASTER EGG"
            };
            break;
            
        case 6:
            originalWords = new List<string>(){
                "Level 6", "666 is devil's number, very bad"
            };
            break;
            
        case 7:
            originalWords = new List<string>(){
                "Level 7", "muy caliente", "gasto gasto lang nang pera"
            };
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
