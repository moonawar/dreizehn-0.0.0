using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpstrength;
    public bool isFloating;

    private void Awake(){
        body = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, body.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space) && !isFloating){
            body.velocity = new Vector2(body.velocity.x, jumpstrength*speed);
            isFloating = true;
        }
    }
}
