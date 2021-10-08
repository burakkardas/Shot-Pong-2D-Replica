using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _settingsPanel;

    [Header("Texts")]
    [SerializeField] private TMP_Text[] _scoreTexts;
    [SerializeField] private TMP_Text _bestScoreText;

    [Header("Gameplay")]
    public int _score = 0;

    void Start()
    {
        Time.timeScale = 1;   
    }

    void Update()
    {
        for(int i = 0 ; i < _scoreTexts.Length; i++) {
            _scoreTexts[i].text = _score.ToString("00");
        }

        _bestScoreText.text = PlayerPrefs.GetInt("_bestScore").ToString();

        if(_score > PlayerPrefs.GetInt("_bestScore")) {
            PlayerPrefs.SetInt("_bestScore", _score);
        }
    }

    public void GameOver() {
        _gameOverPanel.SetActive(true);
        _gamePanel.SetActive(false);

        Time.timeScale = 0;
    }

    public void RestartGame() {
        SceneManager.LoadScene(1);
    }

    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
}
