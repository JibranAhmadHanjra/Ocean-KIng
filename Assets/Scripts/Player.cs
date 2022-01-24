using UnityEngine;

public class Player : MonoBehaviour
{
    protected Vector3 _LocalRotation;
    protected float _CameraDistance = 10f;

    public float MouseSensitivity = 4f;
    public float ScrollSensitvity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;

    public bool CameraDisabled = true;
    public bool RotationDisabled = false;
    bool _temp = false;

    void Start()
    {
        _setRots();
    }
    float x;
    
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _temp = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _temp = false;
        }
        if (_temp)
        {
            x = Input.GetAxis("Mouse X") * MouseSensitivity;
            Debug.Log("x = " + x);
            if(transform.rotation.y <= .5 && transform.rotation.y >= -.5)
            transform.Rotate(0, x, 0);
        }
        //Actual Camera Rig Transformations
        //Quaternion QT = Quaternion.Euler(0, -_LocalRotation.y, 0);
        //transform.rotation = Quaternion.Lerp(transform.rotation, QT, Time.deltaTime * OrbitDampening);
    }
    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, 5f);
           // gameObject.GetComponent<Rigidbody>().AddForce(-5,0,0);
        }
        //else if(Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 0);
        //}
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position -= new Vector3(0, 0,5f);
            //gameObject.GetComponent<Rigidbody>().AddForce(5, 0, 0);
        }
        //else if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 0);
        //}
    }
    public void _setRots()
    {
        _LocalRotation.x = -41.5f;
        _LocalRotation.y = -11.8f;
    }
}
