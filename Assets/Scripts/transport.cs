using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transport : MonoBehaviour
{
    [SerializeField]
    int numEscena;
    
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player"){
            SceneManager.LoadScene(numEscena);
        }
    }
}
