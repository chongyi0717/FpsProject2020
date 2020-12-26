using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthCount : MonoBehaviour
{
    private Image HealthIm;
    Color g = new Color((79/255f),(255/255f),(141/255f),(255/255f));
    Color o = new Color((249 / 255f), (255 / 255f), (0 / 255f), (255 / 255f));
    Color y = new Color((255 / 255f), (160 / 255f), (79 / 255f), (255 / 255f));
    Color r = new Color((255 / 255f), (29 / 255f), (0 / 255f), (255 / 255f));
    // Start is called before the first frame update
    Health m_PlayerHealth;
    void Start()
    {
        HealthIm = this.GetComponent<Image>();
        PlayerCharacterController playerCharacterController = GameObject.FindObjectOfType<PlayerCharacterController>();
        DebugUtility.HandleErrorIfNullFindObject<PlayerCharacterController, PlayerHealthCount>(playerCharacterController, this);

        m_PlayerHealth = playerCharacterController.GetComponent<Health>();
        DebugUtility.HandleErrorIfNullGetComponent<Health, PlayerHealthCount>(m_PlayerHealth, this, playerCharacterController.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        int cH = (int)m_PlayerHealth.currentHealth;
        int type = 0;
        if (cH >= 0*m_PlayerHealth.maxHealth)
            HealthIm.color = r;
        if (cH >= 0.25*m_PlayerHealth.maxHealth)
            HealthIm.color = y;
        if (cH >= 0.50*m_PlayerHealth.maxHealth)
            HealthIm.color = o;
        if (cH >= 0.75*m_PlayerHealth.maxHealth)
            HealthIm.color = g;
    }
}
