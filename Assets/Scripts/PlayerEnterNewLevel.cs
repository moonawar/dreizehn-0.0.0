using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterNewLevel : MonoBehaviour
{
    private Rigidbody2D body;
    private PlayerMovement pMovementScript;
    [SerializeField] private new Vector2 initialForce;
    public BoxCollider2D portalCollider;
    
    private void Awake(){
        body = GetComponent<Rigidbody2D>();
        pMovementScript = GetComponent<PlayerMovement>();
        portalCollider = GameObject.Find("Portal").GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        pMovementScript.enabled = false;
        portalCollider.enabled = false;
        body.AddForce(initialForce);
    }
    // Update is called once per frame
    void Update()
    {
    
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        pMovementScript.enabled = true;
        portalCollider.enabled = true;
    }
}
