using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation.Examples;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public PlayerMovement playerMovement;
   // public PathFollower pathTofollow;
    bool notHappen=true;
    private void Awake()
    {


        GameController.instance.player.GetComponentInParent<Animator>().enabled = false;
        playerMovement.enabled = false;
        //pathTofollow.enabled = false;
        GameController.instance.player.GetComponent<Player>().enabled = false;


        //// GameController.instance.timeClass[GameController.instance.currentLevel].time = 0;
        // // Time.timeScale = 0;
        // GameController.instance.GetComponent<RemainingTimer>().enabled = false;

    }
    private void Start()
    {
        
        //GameController.instance.GetComponent<RemainingTimer>().enabled = false;
        //playerMovement.enabled = false;
        //pathTofollow.enabled = false;
    }
    private void Update()
    {
        if (GameController.instance.timeClass[GameController.instance.currentLevel].time<=3f&& notHappen==true)
        {
            Allinvokes();
          
            notHappen = false;
            //GameController.instance.countDown.text = GameController.instance.timeClass[GameController.instance.currentLevel].time.ToString();
        }
     
       
    }
    public void Allinvokes()
    {
        Invoke("OffCountdown",1.8f);
        Invoke("count1", 1.5f);
        Invoke("count2", 0.8f);
        Invoke("count3", 0.1f);
    }
    public void Play()
    {
        Time.timeScale = 1f;
        Invoke("StartGame", 2.5f);
        AllinvokesStart();
        //GameController.instance.GetComponent<RemainingTimer>().enabled = true;

        ////StartCoroutine(CountDown());
        //playerMovement.enabled = true;
        //pathTofollow.enabled = true;
        //Allinvokes();


    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void Unpause()
    {
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void count1()
    {
        GameController.instance.c1.gameObject.SetActive(true);


        GameController.instance.c2.gameObject.SetActive(false);
        GameController.instance.c3.gameObject.SetActive(false);
    }
    public void count2()
    {
        GameController.instance.c1.gameObject.SetActive(false);
        GameController.instance.c2.gameObject.SetActive(true);
        GameController.instance.c3.gameObject.SetActive(false);
    }
    public void count3()
    {
        GameController.instance.c1.gameObject.SetActive(false);
        GameController.instance.c2.gameObject.SetActive(false);
        GameController.instance.c3.gameObject.SetActive(true);
    }
    public void OffCountdown()
    {
        GameController.instance.startGame = true;

        GameController.instance.c1.gameObject.SetActive(false);
        GameController.instance.c2.gameObject.SetActive(false);
        GameController.instance.c3.gameObject.SetActive(false);

    }

    public void OnStart()
    {
        Allinvokes();
    }
    public void StartGame()
    {
        //if (GameController.instance.startGame == true)
        //{//
        GameController.instance.player.GetComponentInParent<Animator>().enabled = true;
        GameController.instance.player.GetComponent<Player>().enabled = true;

        playerMovement.enabled = true;
       // pathTofollow.enabled = true;
         
            
        //}


    }
    IEnumerator SpeedPlayer()
    {
        yield return new WaitForSeconds(0f);
        playerMovement.ChangeSpeed(1);
          yield return new WaitForSeconds(1f);
        playerMovement.ChangeSpeed(7);

        yield return new WaitForSeconds(2f);
        playerMovement.ChangeSpeed(10);


        StopCoroutine(SpeedPlayer());
       
    }
    //Start Coundown
    public void countS1()
    {
        GameController.instance.S1.gameObject.SetActive(true);
        GameController.instance.S2.gameObject.SetActive(false);
        GameController.instance.S3.gameObject.SetActive(false);
    }
    public void countS2()
    {
        GameController.instance.S1.gameObject.SetActive(false);
        GameController.instance.S2.gameObject.SetActive(true);
        GameController.instance.S3.gameObject.SetActive(false);
    }
    public void countS3()
    {
        GameController.instance.S1.gameObject.SetActive(false);
        GameController.instance.S2.gameObject.SetActive(false);
        GameController.instance.S3.gameObject.SetActive(true);
    }
    public void OffCountdownstart()
    {
        GameController.instance.startGame = true;

        GameController.instance.S1.gameObject.SetActive(false);
        GameController.instance.S2.gameObject.SetActive(false);
        GameController.instance.S3.gameObject.SetActive(false);

    }
    public void AllinvokesStart()
    {
        Invoke("OffCountdownstart", 1.8f);
        Invoke("countS1", 1.5f);
        Invoke("countS2", 0.8f);
        Invoke("countS3", 0.1f);
    }

}
