using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private float coins = 0;
    public AudioSource coinsAudio;
    public Text coinText0, coinText1;

    private void Start()
    {
        coins = PlayerPrefs.GetFloat("coins");
        coinText0.text = "Coins: " + coins;
        coinText1.text = "Coins: " + coins;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinsAudio.Play();
            coins += PlayerPrefs.GetFloat("pumpingСoins");
            PlayerPrefs.SetFloat("coins", coins);
            coinText0.text = "Coins: " + coins;
            coinText1.text = "Coins: " + coins;
        }
    }
}