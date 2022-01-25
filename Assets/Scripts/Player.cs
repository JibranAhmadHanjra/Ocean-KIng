using UnityEngine;

public class Player : MonoBehaviour
{
    float rotationX = 0;
    float rotationY = 0;
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
    float y;
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
           
            // you might also have some rotation speed variable
           
                //rotationX += Input.GetAxis("Mouse X") * Time.deltaTime;
                //rotationX = Mathf.Clamp(rotationX, 60, -60);
                //rotationY += Input.GetAxis("Mouse X") * Time.deltaTime;
                //transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
                x = Input.GetAxis("Mouse X") * MouseSensitivity;
          //  transform.eulerAngles = new Vector3(0f, 180f, 0f);
            Debug.Log("x = " + x);
            //y = Mathf.Clamp(y,60,-60);
           // Vector3 rotationVector = new Vector3(0, 30, 0);
           //Quaternion rotation = Quaternion.Euler(rotationVector);
           if (transform.rotation.y <= 0.5&& transform.rotation.y >= -0.5)
          //      if (y<=0)
          //      {
          //          y -= 1;
          //      }
          //      if (y >= 0)
          //      {
          //      y += 1;
          //      }
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
