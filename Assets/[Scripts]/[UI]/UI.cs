using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText = default;
    [SerializeField] private Image healthBar;
    [SerializeField] private GameObject gotHitScreen;

    private FirstPersonController fpsController;

    private void OnEnable()
    {
        FirstPersonController.OnDamage += UpdateHealth;
        FirstPersonController.OnHeal += UpdateHealth;
    }

    private void OnDisable()
    {
        FirstPersonController.OnDamage -= UpdateHealth;
        FirstPersonController.OnHeal -= UpdateHealth;
    }

    private void Start()
    {
        fpsController = transform.Find("/-- Player --/FirstPersonController").GetComponent<FirstPersonController>();
        UpdateHealth(100);
    }

    private void UpdateHealth(float currentHealth)
    {
        float healthPercentage = currentHealth / fpsController.maxHealth;

        healthText.text = currentHealth.ToString("00");
        healthBar.fillAmount = healthPercentage;

        var color = gotHitScreen.GetComponent<Image>().color;
        color.a = 1f - healthPercentage;

        gotHitScreen.GetComponent<Image>().color = color;
    }
}