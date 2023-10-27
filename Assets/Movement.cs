using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float moveSpeed = 3f;
    float moveSpeedFast = 6f;
    float moveSpeedSlow = 1f;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Speed Boost - Fast" && moveSpeed != moveSpeedFast)
        {
            moveSpeed = moveSpeedFast;
            Debug.Log("Speed Fast!");
        }

        if (other.tag == "Speed Boost - Slow" && moveSpeed != moveSpeedSlow)
        {
            moveSpeed = moveSpeedSlow;
            Debug.Log("Speed Slow!");
        }
    }



    // Update is called once per frame
    void Update()
    {
        
        float inputMoveHorizontal = Input.GetAxis("Horizontal");
        float inputMoveVertical = Input.GetAxis("Vertical");

        var moveVector = new Vector3(inputMoveHorizontal, inputMoveVertical, 0);

        if (moveVector.sqrMagnitude > 1)
        {
            moveVector.Normalize();
        }

        var moveAmount = moveVector * moveSpeed * Time.deltaTime;

        transform.Translate(moveAmount);

    }
}
