using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
    GameObject gameBoard;
    SpriteRenderer sprite;
    public Sprite[] tokens;
    bool is_available = true;

    private void OnMouseDown() {
        if (is_available && gameBoard != null && gameBoard.GetComponent<BoardScript>() != null) {
            int index = gameBoard.GetComponent<BoardScript>().ChangeToken();
            // Check if index is within bounds of the tokens array
            if (index >= 0 && index < tokens.Length) {
                sprite.sprite = tokens[index];
                is_available = false;
            } else {
                Debug.LogError("Token index out of bounds: " + index);
            }
        }
    }

    private void Awake() {
        sprite = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("BoardGame");
    }

    // Start is called before the first frame update
    private void Start()
    {
        sprite.sprite = null;
    }
}
