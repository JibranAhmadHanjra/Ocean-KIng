using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   // public PlayerMovement playerMovement;
   // public PathFollower pathTofollow;
    bool notHappen=true;
    private void Awake()
    {


       //jb GameController.instance.player.GetComponentInParent<Animator>().enabled = false;
       // playerMovement.enabled = false;
        //pathTofollow.enabled = false;
       //jb  GameController.instance.player.GetComponent<Player>().enabled = false;


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
    {//jb
        //if (GameController.instance.timeClass[GameController.instance.currentLevel].time<=3f&& notHappen==true)
        //{
        //    Allinvokes();
          
        //    notHappen = false;
        //    //GameController.instance.countDown.text = GameController.instance.timeClass[GameController.instance.currentLevel].time.ToString();
        //}
     
       
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
      //  AllinvokesStart();
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
   
    public void StartGame()
    {
        //if (GameController.instance.startGame == true)
        //{//
      //  GameController.instance.player.GetComponentInParent<Animator>().enabled = true;
        //GameController.instance.player.GetComponent<Player>().enabled = true;

      //  playerMovement.enabled = true;
       // pathTofollow.enabled = true;
         
            
        //}


    }
    IEnumerator SpeedPlayer()
    {
        yield return new WaitForSeconds(0f);
       // playerMovement.ChangeSpeed(1);
          yield return new WaitForSeconds(1f);
      //  playerMovement.ChangeSpeed(7);

        yield return new WaitForSeconds(2f);
       // playerMovement.ChangeSpeed(10);


        StopCoroutine(SpeedPlayer());
       
    }
    //Start Coundown
  

}
