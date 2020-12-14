using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthCount : MonoBehaviour
{
    private Text HealthCount;
    // Start is called before the first frame update
    Health m_PlayerHealth;
    void Start()
    {
        HealthCount = this.GetComponent<Text>();
        PlayerCharacterController playerCharacterController = GameObject.FindObjectOfType<PlayerCharacterController>();
        DebugUtility.HandleErrorIfNullFindObject<PlayerCharacterController, PlayerHealthCount>(playerCharacterController, this);

        m_PlayerHealth = playerCharacterController.GetComponent<Health>();
        DebugUtility.HandleErrorIfNullGetComponent<Health, PlayerHealthCount>(m_PlayerHealth, this, playerCharacterController.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        int cH = (int)m_PlayerHealth.currentHealth;
        HealthCount.text = cH + "/" + m_PlayerHealth.maxHealth;
    }
}
