using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [Header ("Options")] [SerializeField] GameObject optionsBtn;
    [Header ("Quit Game")] [SerializeField] GameObject quitGameBtn;
    [Header ("Language")] [SerializeField] GameObject languageBtn;
    [Header ("English")] [SerializeField] GameObject englishBtn;
    [Header ("Portuguese")] [SerializeField] GameObject portugueseBtn;

    // Start is called before the first frame update
    void Start()
    {
        DisableAll ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnglishClick() {
        DisableAll ();
    }

    public void OnPortugueseClick() {
        DisableAll ();
    }

    public void OnOptionsClick() {
        quitGameBtn.SetActive (true);
        languageBtn.SetActive (true);
    }

    public void OnQuitGame() {
        //Leave the game
        DisableAll ();
    }

    public void OnLanguageClick() {
        englishBtn.SetActive (true);
        portugueseBtn.SetActive (true);
    }

    public void DisableAll() {      
        quitGameBtn.SetActive (false);
        languageBtn.SetActive (false);
        englishBtn.SetActive (false);
        portugueseBtn.SetActive (false);
    }



}
