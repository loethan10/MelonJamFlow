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
                "I love my dog."
            };
            break;
            
        case 2:
            originalWords = new List<string>(){
                "This is now level 2.", "I am so very freaky.", "Happy birthday!", "Adrian Bilawalla <3"
            };
            break;
            
        case 3:
            originalWords = new List<string>(){
                "Level 3", "Test"
            };
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
            levelDone = true;
        }

        return newWord;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
