using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private int portalToLevel;
    [SerializeField] private int currentLevel;
    private PlayerMovement pMovementScript;
    
    private void Start() {
        pMovementScript = GetComponent<PlayerMovement>();    
    }

    private void OnCollisionEnter2D(Collision2D target) {
        pMovementScript.isFloating = false;
        
        if( target.gameObject.tag == "LoseTrigger"){
            SceneManager.LoadScene(currentLevel);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if( other.gameObject.tag == "Portal"){
            SceneManager.LoadScene(portalToLevel);
        }
        else if ( other.gameObject.tag == "RestartTrigger"){
            SceneManager.LoadScene(currentLevel);
        }
    }
}
