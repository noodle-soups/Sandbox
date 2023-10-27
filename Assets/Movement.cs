using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
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
