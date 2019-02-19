using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public Image currentHealthbar;

    private float hitpoint = 150;
    private float maxHitpoint = 150;

    private void Start()
    {
        UpdateHealthbar();
    }

    public void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }
    public void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("Dead!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        UpdateHealthbar();
    }
   
}
