using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>(){
        "I love my dog.", "I love my dad.", "I love my mom.", "I am an ABG."
    };

    private List<string> workingWords = new List<string>();

    private void Awake(){
        workingWords.AddRange(originalWords);
        Shuffle(workingWords); 
        //ConvertToLower(workingWords);
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

        if (workingWords.Count != 0){
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }

        return newWord;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
