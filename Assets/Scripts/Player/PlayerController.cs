using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float hareket = 1f;
    public float ziplama = 4f;
    private bool ziplasinMi = true;
    private bool egildiMi = true;
    private BoxCollider2D boxCollider2d;
    private float orijinalYukseklik;



    private SpriteRenderer spriteRenderer;
    public Animator animator;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        boxCollider2d = GetComponent<BoxCollider2D>();
        orijinalYukseklik = boxCollider2d.size.y;
    }
    private void Update()
    {
        // animator.SetFloat("Speed", Mathf.Abs(hareket));

        if (Input.GetKeyDown(KeyCode.A))
        {
            hareketeGec(Vector3.left);
           //  animator.Play("Playeridle");
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            hareketeGec(Vector3.right);
            // animator.Play("Playeridle");

        }

        if (ziplasinMi && Input.GetKeyDown(KeyCode.W))
        {
            zipla();
        }

        if (Input.GetKey(KeyCode.S))
        {
            egildiMi = true;
            animator.SetBool("egildimi", true);
            // animator.Play("Playerchurc");
            egil();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            egildiMi = false;
            animator.SetBool("egildimi", false);
            Duzel();
        }
        
    }

    void hareketeGec(Vector3 yon)
    {
        transform.Translate(yon * hareket);
        if (yon.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (yon.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    void zipla()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * ziplama, ForceMode2D.Impulse);
        ziplasinMi = false; // tekrar zıplamaması için
    }

    void egil()
    {
        boxCollider2d.size = new Vector2(boxCollider2d.size.x, orijinalYukseklik / 2f);
    }

    void Duzel()
    {
        boxCollider2d.size = new Vector2(boxCollider2d.size.x, orijinalYukseklik);
    }

    public void egildi(bool _egildimi)
    {
        animator.SetBool("egildimi", _egildimi);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Duvar")
        {
            ziplasinMi = true;
           // Debug.Log("karakterdustuuu");
        }
    }

}
