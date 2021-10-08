using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu_Manager : MonoBehaviour
{
    [SerializeField] private TMP_Text _bestScoreText;
    
    private void Start() {
        _bestScoreText.text = PlayerPrefs.GetInt("_bestScore").ToString();
    }
    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
