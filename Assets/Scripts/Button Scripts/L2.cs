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
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR2(){
        wordBank.level1Done = false;
        wordBank.level++;
        wordBank.walk = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL3(){
        wordBank.level2Done = false;
        wordBank.level++;
        wordBank.lie = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR3(){
        wordBank.level2Done = false;
        wordBank.level++;
        wordBank.lie = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL4(){
        wordBank.level3Done = false;
        wordBank.level++;
        wordBank.fight = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR4(){
        wordBank.level3Done = false;
        wordBank.level++;
        wordBank.fight = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL5(){
        wordBank.level4Done = false;
        wordBank.level++;
        wordBank.Nat = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR5(){
        wordBank.level4Done = false;
        wordBank.level++;
        wordBank.Nat = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL6(){
        wordBank.level5Done = false;
        wordBank.level++;
        wordBank.stay = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR6(){
        wordBank.level5Done = false;
        wordBank.level++;
        wordBank.stay = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL7(){
        wordBank.level6Done = false;
        wordBank.level++;
        wordBank.college = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR7(){
        wordBank.level6Done = false;
        wordBank.level++;
        wordBank.college = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL8(){
        wordBank.level7Done = false;
        wordBank.level++;
        wordBank.party = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR8(){
        wordBank.level7Done = false;
        wordBank.level++;
        wordBank.party = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL9(){
        wordBank.level8Done = false;
        wordBank.level++;
        wordBank.propose = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR9(){
        wordBank.level8Done = false;
        wordBank.level++;
        wordBank.propose = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL10(){
        wordBank.level9Done = false;
        wordBank.level++;
        wordBank.Melissa = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR10(){
        wordBank.level9Done = false;
        wordBank.level++;
        wordBank.Melissa = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundL11(){
        wordBank.level10Done = false;
        wordBank.level++;
        wordBank.move = true;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void NextRoundR11(){
        wordBank.level10Done = false;
        wordBank.level++;
        wordBank.move = false;

        wordBank.levelChecker(wordBank.level);
        typer.SetCurrentWord();
        RectTransform rt = wordOutput.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(250f, 150f, 0f);
        //SceneManager.LoadScene(newGameLevel);
    }

    public void FinishGame(){
        
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
