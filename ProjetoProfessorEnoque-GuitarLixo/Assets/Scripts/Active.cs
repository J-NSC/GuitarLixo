using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private KeyCode key;
    private bool ativado = false;
    [SerializeField]
    private GameObject nota; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key) && ativado){
            Destroy(nota);
        }   
    }

    private void OnTriggerEnter2D(Collider2D other) {
        ativado = true;
        if(other.gameObject.tag == "nota"){
            nota = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        ativado = false;
    }
}
