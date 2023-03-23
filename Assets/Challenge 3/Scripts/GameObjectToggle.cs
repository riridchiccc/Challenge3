using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToToggle;
    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                objectToToggle.SetActive(!objectToToggle.activeSelf);
            }
        }

    
}
