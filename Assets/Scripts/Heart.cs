using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart : MonoBehaviour
{
    private int HP_Active = 1;
    public GameObject heart0, heart1, heart2, heart3, heart4;
    public GameObject DeadPanel;
    void Start()
    {
        HP_Active = PlayerPrefs.GetInt("HP_Active");
        mySwitch(HP_Active);
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Plat")
        {
            Destroy(other.gameObject);
            HP_Active--;
            mySwitch(HP_Active);
            if (HP_Active <= 0)
            {
                DeadPanel.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
    public void mySwitch(int HP_Active)
    {
        switch (HP_Active)
        {
            case 0:
                heart0.SetActive(false);
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                break;
            case 1:
                heart0.SetActive(true);
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                break;
            case 2:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                break;
            case 3:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                heart4.SetActive(false);
                break;
            case 4:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(false);
                break;
            case 5:
                heart0.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(true);
                break;
        }
    }
}
