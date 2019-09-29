using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class weapon : MonoBehaviour
{
   // public Rigidbody2D rb;
   // public Rigidbody2D hook;

  //  public float releaseTime = .15f;
   // public float maxDragDistance = 2f;

   //the start angle
    //the weapon==>arrow/red ball/blue ball
    ///public GameObject nextBall;

    //private bool isPressed = false;


    public float offset;

    public GameObject projectile;
   // public GameObject shotEffect;
    public Transform shotPoint;
    //public Animator camAnim;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Update()
    {
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
               // Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                //camAnim.SetTrigger("shake");
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
    /*  if (isPressed)
      {
          Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

          if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
              rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
          else
              rb.position = mousePos;
      }*/
//}

    /*void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }
    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(2f);

        if (nextBall != null)
        {
            nextBall.SetActive(true);
        }
        else
        {
            enemy.EnemiesAlive = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }*/

}
