using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    //private SpriteRenderer spriteRenderer;

    //public Sprite[] sprites;

    //private int spriteIndex;

    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;

   /* private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
   */
   /* private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }
   */

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            birdRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        LogicScript.instance.gameOver();
        birdIsAlive = false;
    }

    /*private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
    */
}
