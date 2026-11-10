
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorObject : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
    {
      SceneManager.LoadScene("Interior");
    }
}