using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_standard : MonoBehaviour
{
    Quaternion _rot;
    bool _direc = false;
    public int Amount;
    private void Start()
    {
        
        _rot = transform.rotation;
    }
    void Update()
    {
        FishForward();
    }

    void FishForward()
    {
        transform.Translate(1 * Time.deltaTime, 0, 0);
        //FishRot();
    }
    void FishRot()
    {
        if (_rot.y > .5)
            _direc = true;
        if (_rot.y < -.5)
            _direc = false;

        if (_direc)
            _rot.y -= Time.deltaTime;
        else
            _rot.y += Time.deltaTime;
        transform.rotation = _rot;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Debug.Log("colision");
           this.gameObject.SetActive(false);
            GameController.instance.fishes += 1;
            if (GameController.instance.fishes == 0)
            {
                //GameController.instance.fish2.SetActive(true);
                Instantiate(GameController.instance.fish1);
                GameController.instance.fishes += 1;

            }
            if (GameController.instance.fishes==1)
            {
                //GameController.instance.fish2.SetActive(true);
                Instantiate(GameController.instance.fish2);
                GameController.instance.fishes += 1;

            }
            else if (GameController.instance.fishes == 2)
            {                //GameController.instance.fish2.SetActive(true);
                Instantiate(GameController.instance.fish3);
                GameController.instance.fishes += 1;
                PlayerPrefs.DeleteKey("fishes");
            }

        }
    }
   
}
