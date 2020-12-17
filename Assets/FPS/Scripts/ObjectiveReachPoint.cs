using UnityEngine;

[RequireComponent(typeof(Objective), typeof(Collider))]


public class ObjectiveReachPoint : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    [Tooltip("Visible transform that will be destroyed once the objective is completed")]
    public Transform destroyRoot;

    Objective m_Objective;

    void Awake()
    {
        m_Objective = GetComponent<Objective>();
        DebugUtility.HandleErrorIfNullGetComponent<Objective, ObjectiveReachPoint>(m_Objective, this, gameObject);

        if (destroyRoot == null)
            destroyRoot = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (m_Objective.isCompleted)
            return;
        
        var player = other.GetComponent<PlayerCharacterController>();
        // test if the other collider contains a PlayerCharacterController, then complete
        if (player != null)
        {
            m_Objective.CompleteObjective(string.Empty, string.Empty, "Objective complete : " + m_Objective.title);

            // destroy the transform, will remove the compass marker if it has one
            Destroy(destroyRoot.gameObject);
            GameObject[] obj = GameObject.FindGameObjectsWithTag("Zombie");
            for (int i = 0; i < obj.Length; i++)
            {
                var m_EnemyController = obj[i].GetComponent<EnemyController>();
                m_EnemyController.m_NavMeshAgent.enabled = false;


            }
        door.transform.position = new Vector3(5.575121f, 2.195581f, 14.44748f);
        door.transform.eulerAngles = new Vector3(0.95f, 3.729f, 6.166f);
        }
    }
}