using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour
{
    public int roomType; //roomA is 0, roomB is 1
    public GameObject roomA;
    public GameObject roomB;
    int roomLength =5;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
            openNextRoom();
    }

    void openNextRoom()
    {
        float nextRoom=Random.Range(0, 2);
            if(nextRoom>2)
                createNewRoom(roomA);
    }
    float nextRoom = Random.Range(0, 2);
            if(nextRoom>2)
    }

void creatNewRoom(GameObject roomToCreate)
    {
    object.Instantiate(roomToCreate, transform.parent.traslation.position + (nextRoomDir.x * roomLlength.0. nextRoomDir.y*roomDir), transform.parent.rotation);
    }

}
