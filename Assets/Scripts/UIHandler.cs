using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject previousButton;
    [SerializeField]
    private GameObject nextButton;

    public GameObject puzzleName;
    
    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private string EnglishName;
    [SerializeField]
    private string RussianName;

    private PuzzleHandler _puzzleHandler;

    private void OnEnable()
    {
        _puzzleHandler.onPlayerWin += ActivateUI;
    }

    private void Awake()
    {
        _puzzleHandler = FindFirstObjectByType<PuzzleHandler>();
    }

    private void Start()
    {
        puzzleName.GetComponent<Text>().text = (YG2.lang == "en") ? EnglishName : RussianName;

        previousButton.SetActive(false);
        nextButton.SetActive(false);
        puzzleName.SetActive(false);
        restartButton.SetActive(false);
    }

    private void OnDisable()
    {
        _puzzleHandler.onPlayerWin -= ActivateUI;
    }

    private void ActivateUI()
    {
        StartCoroutine(WaitToActivate());
    }

    private IEnumerator WaitToActivate()
    {
        yield return new WaitForSeconds(0.2f);

        yield return new WaitForSeconds(14);
        previousButton.SetActive(SceneManager.GetActiveScene().buildIndex > 1);
        nextButton.SetActive(SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1);

        restartButton.SetActive(true);
    }
}
