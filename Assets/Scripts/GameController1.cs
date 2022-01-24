//using Facebook.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class LevelTime
{
    public float time;
}
public class GameController : MonoBehaviour
{
    public LevelTime[] timeClass;
    public Text timeTxT;
    public static GameController instance;
    public GameObject player;
    public bool isHitting=false;
    public GameObject imageFade;
    public GameObject RemainingtimeOFF;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
   // public Text countDown;
   
    public GameObject PrefabPos;
    public GameObject ScorePrefab10;
    public GameObject ScorePrefab15;
    public GameObject ScorePrefab20;
    //public GameObject WinParticles;

    //[Header("==============UI")]
    public GameObject WinPanel;
    public GameObject FailPanel;
    public Text levelNoText;
    public GameObject owchImg;
    public bool startGame=false;
    // public GameObject touchOnBoarding;

    [Header("==============Level")]
    public Transform allLevels;
    public bool isTest = false;
    public int testLevel = 0;
    public int currentLevel;
    public Text totalScoreTxT;
    public GameObject AddCoinsAnimation;
    public GameObject model;
    //  public GameObject modeltrans;
    public int levelScore;




    public int levelNo
    {
        get => !isTest ? PlayerPrefs.GetInt("feedyourpet_levelno", 0) : testLevel;
        set => PlayerPrefs.SetInt("feedyourpet_levelno", value);
    }

    public int totalscore
    {
        set => PlayerPrefs.SetInt("totalscore", value);
        get => PlayerPrefs.GetInt("totalscore", 0);
    }


    public bool gameStarted = false;



    private void Awake()
    {
        instance = this;
        EnableLevel();
        gameStarted = true;



        
    }
    private void Start()
    {
        Time.timeScale = 0;
    }

   

    void OnSkipLevel()
    {
        levelNo++;
        gameStarted = false;

    }

  


    void EnableLevel()
    {
        currentLevel = levelNo % allLevels.childCount;
        levelNoText.text = (levelNo+1).ToString();
        Transform level = allLevels.GetChild(levelNo % allLevels.childCount);
        level.parent = null;
        level.gameObject.SetActive(true);
        Destroy(allLevels.gameObject);



        //FB.LogAppEvent(
        //            "Level " + currentLevel + " Start",
        //            null,
        //            new Dictionary<string, object>()
        //            {
        //                { AppEventParameterName.Description, "Level Started" }
        //            });
        //Debug.Log(
        //    "You may see results showing up at https://www.facebook.com/analytics/"
        //    + FB.AppId);
    }



    public void LevelComplete()
    {
        if (!gameStarted)
            return;
        this.gameObject.GetComponent<RemainingTimer>().enabled = false;
       /* GameController.instance.*/startGame = false;
        levelNo++;
       
        StartCoroutine(ShowCompleteUI());
        
        gameStarted = false;
    }
    IEnumerator ShowCompleteUI()
    {
        yield return new WaitForSeconds(5f);
        // WinParticles.SetActive(true);
        //yield return new WaitForSeconds(2f);
        //particalcanvas.gameObject.SetActive(false);
        WinPanel.SetActive(true);

        //FB.LogAppEvent(
        //            "Level " + currentLevel + " Completed",
        //            null,
        //            new Dictionary<string, object>()
        //            {
        //                { AppEventParameterName.Description, "Level Completed" }
        //            });
        //Debug.Log(
        //    "You may see results showing up at https://www.facebook.com/analytics/"
        //    + FB.AppId);

    }

    public void LevelFail()
    {
        if (!gameStarted)
            return;

       // imageFade.gameObject.SetActive(false);
        StartCoroutine(ShowFailUI());
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        gameStarted = false;
        
        
    }

    IEnumerator ShowFailUI()
    {
      
        yield return new WaitForSeconds(3f);
        //particalcanvas.gameObject.SetActive(false);
        FailPanel.SetActive(true);

        //FB.LogAppEvent(
        //            "Level " + currentLevel + " Failed",
        //            null,
        //            new Dictionary<string, object>()
        //            {
        //                { AppEventParameterName.Description, "Level Failed" }
        //            });
        //Debug.Log(
        //    "You may see results showing up at https://www.facebook.com/analytics/"
        //    + FB.AppId);

    }


    public void Restart()
    {

        //FB.LogAppEvent(
        //            "Level " + currentLevel + " Restart",
        //            null,
        //            new Dictionary<string, object>()
        //            {
        //                { AppEventParameterName.Description, "Level Restarted" }
        //            });
        //Debug.Log(
        //    "You may see results showing up at https://www.facebook.com/analytics/"
        //    + FB.AppId);


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    

    

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }


    

    public void AddScore(int amount)
    {
       
      //GameObject scoreObject =  Instantiate(ScorePrefab);
      //  scoreObject.transform.SetParent(PrefabPos.transform);
      // scoreObject.transform.localPosition = Vector3.zero;
        if (amount==10)
        {
            GameObject scoreObject = Instantiate(ScorePrefab10);
            scoreObject.transform.SetParent(PrefabPos.transform);
            scoreObject.transform.localPosition = Vector3.zero;
        }  if (amount==15)
        {
            GameObject scoreObject = Instantiate(ScorePrefab15);
            scoreObject.transform.SetParent(PrefabPos.transform);
            scoreObject.transform.localPosition = Vector3.zero;
        }  if (amount==20)
        {
            GameObject scoreObject = Instantiate(ScorePrefab20);
            scoreObject.transform.SetParent(PrefabPos.transform);
            scoreObject.transform.localPosition = Vector3.zero;
           
        }            //scoreObject.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
                  //   Debug.Log("Score added: " + amount);
       
    }


}


