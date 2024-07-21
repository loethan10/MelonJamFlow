using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class L2 : MonoBehaviour
{
    //[SerializeField] private string newGameLevel = "Level1";
    [SerializeField] public WordBank wordBank = null;
    [SerializeField] public Typer typer = null;
    [SerializeField] public Text wordOutput = null;

    public void NextRoundL2(){
        wordBank.level1Done = false;
        wordBank.level++;
        wordBank.walk = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 0f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR2(){
        wordBank.level1Done = false;
        wordBank.level++;
        wordBank.walk = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 0f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }
    public void NextRoundL3(){
        wordBank.level2Done = false;
        wordBank.level++;
        wordBank.lie = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 0f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR3(){
        wordBank.level2Done = false;
        wordBank.level++;
        wordBank.lie = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 0f, 0f);
        //SceneManager.LoadScene(newGameLevel);
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
