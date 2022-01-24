using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttach : MonoBehaviour
{
    public GameObject hitPoint;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("1"))
        {
            CollectAnim.instance.ShowAnim();
            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;

            Instantiate(hitPoint, pos,rot );

        }
    }
}
