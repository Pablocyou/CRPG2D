using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IsometricPlayerMovementController : MonoBehaviour
{

    public float movementSpeed = 1f;
    IsometricCharacterRenderer isoRenderer;
    public TMP_Text TextComponent;
    public GameObject ThoughtsGameObj;
    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }

    public void think(string bubble)
    {
        ThoughtsGameObj.SetActive(true);
        TextComponent.text = bubble;
        StartCoroutine(stopThoughts());
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);

        if (Input.GetButton("Fire1"))
        {
            var mousePos = Input.mousePosition;
            mousePos.x -= Screen.width / 2; mousePos.y -= Screen.height / 2;

            inputVector = new Vector2(mousePos.x, mousePos.y);
            inputVector = Vector2.ClampMagnitude(inputVector, 1);
        }

        Vector2 movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        isoRenderer.SetDirection(movement);
        rbody.MovePosition(newPos);
    }


    IEnumerator stopThoughts()
    {
        yield return new WaitForSeconds(4);
        TextComponent.text = "";
        ThoughtsGameObj.SetActive(true);
    }
}
