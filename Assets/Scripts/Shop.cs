using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text Coins;
    public Button HP_update, coin_update, speed_update;
    public Text HP_update_text, coin_update_text, speed_update_text;
    public Text HP_price, coin_price, speed_price;
    private float HP_cost = 10f, coin_cost = 10f, speed_cost = 10f;

    void Start()
    {
        if (!PlayerPrefs.HasKey("coins")) PlayerPrefs.SetFloat("coins", 0);

        if (!PlayerPrefs.HasKey("pumpingСoins") || PlayerPrefs.GetFloat("pumpingСoins") == 0) PlayerPrefs.SetFloat("pumpingСoins", 1f);
        if (!PlayerPrefs.HasKey("speed") || PlayerPrefs.GetFloat("speed") == 0) PlayerPrefs.SetFloat("speed", 50f);
        if (!PlayerPrefs.HasKey("HP_Active") || PlayerPrefs.GetInt("HP_Active") == 0) PlayerPrefs.SetInt("HP_Active", 1);

        if (!PlayerPrefs.HasKey("HP_runs")) PlayerPrefs.SetInt("HP_runs", 0);
        if (!PlayerPrefs.HasKey("coin_runs")) PlayerPrefs.SetInt("coin_runs", 0);
        if (!PlayerPrefs.HasKey("speed_runs")) PlayerPrefs.SetInt("speed_runs", 0);

    }
    void Update()
    {
        Coins.text = "Coins: " + PlayerPrefs.GetFloat("coins");
        switch (PlayerPrefs.GetInt("HP_runs"))
        {
            case 0:
                HP_price.text = "Cost: 10 coins";
                HP_cost = 10f;
                break;
            case 1:
                HP_price.text = "Cost: 25 coins";
                HP_cost = 25f;
                break;
            case 2:
                HP_price.text = "Cost: 50 coins";
                HP_cost = 50f;
                break;
            case 3:
                HP_price.text = "Cost: 100 coins";
                HP_cost = 100f;
                break;
            case 4:
                HP_update_text.text = "Full update";
                HP_price.text = "Full update";
                HP_update.interactable = false;
                break;
        }
        switch (PlayerPrefs.GetInt("coin_runs"))
        {
            case 0:
                coin_price.text = "Cost: 10 coins";
                coin_cost = 10f;
                break;
            case 1:
                coin_price.text = "Cost: 25 coins";
                coin_cost = 25f;
                break;
            case 2:
                coin_price.text = "Cost: 50 coins";
                coin_cost = 50f;
                break;
            case 3:
                coin_price.text = "Cost: 100 coins";
                coin_cost = 100f;
                break;
            case 4:
                coin_update_text.text = "Full update";
                coin_price.text = "Full update";
                coin_update.interactable = false;
                break;
        }
        switch (PlayerPrefs.GetInt("speed_runs"))
        {
            case 0:
                speed_price.text = "Cost: 10 coins";
                speed_cost = 10f;
                break;
            case 1:
                speed_price.text = "Cost: 25 coins";
                speed_cost = 25f;
                break;
            case 2:
                speed_price.text = "Cost: 50 coins";
                speed_cost = 50f;
                break;
            case 3:
                speed_price.text = "Cost: 100 coins";
                speed_cost = 100f;
                break;
            case 4:
                speed_price.text = "Full update";
                speed_update_text.text = "Full update";
                speed_update.interactable = false;
                break;
        }
    }
    public void HP_update_down()
    {
        if (PlayerPrefs.GetFloat("coins") >= HP_cost && PlayerPrefs.GetInt("HP_runs") < 4)
        {
            PlayerPrefs.SetFloat("coins", PlayerPrefs.GetFloat("coins") - HP_cost);
            PlayerPrefs.SetInt("HP_runs", PlayerPrefs.GetInt("HP_runs") + 1);

            PlayerPrefs.SetInt("HP_Active", PlayerPrefs.GetInt("HP_Active") + 1);
        }
    }
    public void coin_update_down()
    {
        if (PlayerPrefs.GetFloat("coins") >= coin_cost && PlayerPrefs.GetInt("coin_runs") < 4)
        {
            PlayerPrefs.SetFloat("coins", PlayerPrefs.GetFloat("coins") - coin_cost);
            PlayerPrefs.SetInt("coin_runs", PlayerPrefs.GetInt("coin_runs") + 1);

            PlayerPrefs.SetFloat("pumpingСoins", PlayerPrefs.GetFloat("pumpingСoins") + 0.25f);
        }
    }
    public void speed_update_down()
    {
        if (PlayerPrefs.GetFloat("coins") >= speed_cost && PlayerPrefs.GetInt("speed_runs") < 4)
        {
            PlayerPrefs.SetFloat("coins", PlayerPrefs.GetFloat("coins") - speed_cost);
            PlayerPrefs.SetInt("speed_runs", PlayerPrefs.GetInt("speed_runs") + 1);

            PlayerPrefs.SetFloat("speed", PlayerPrefs.GetFloat("speed") + 15f);
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HP_update_text.text = "Update";
        HP_update.interactable = true;
        coin_update_text.text = "Update";
        coin_update.interactable = true;
        speed_update_text.text = "Update";
        speed_update.interactable = true;

        if (!PlayerPrefs.HasKey("pumpingСoins") || PlayerPrefs.GetFloat("pumpingСoins") == 0) PlayerPrefs.SetFloat("pumpingСoins", 1f);
        if (!PlayerPrefs.HasKey("speed") || PlayerPrefs.GetFloat("speed") == 0) PlayerPrefs.SetFloat("speed", 50f);
        if (!PlayerPrefs.HasKey("HP_Active") || PlayerPrefs.GetInt("HP_Active") == 0) PlayerPrefs.SetInt("HP_Active", 1);
    }
}