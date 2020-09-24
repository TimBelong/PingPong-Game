using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{

    [SerializeField] private float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        letItFly();
    }

    void letItFly()
    {
        speed = Random.Range(4, 8);
        float randSc = Random.Range(0.25f, 1);
        transform.localScale = new Vector2(randSc, randSc);
        float x = Random.Range(-1, 1) == 0 ? -1 : 1;
        float y = Random.Range(-1, 1) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x * speed, y * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        reset();
    }

    public void reset ()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
