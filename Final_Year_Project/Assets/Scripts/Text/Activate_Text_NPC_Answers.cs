using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Text_NPC_Answers : MonoBehaviour
{
    public NPC_Dialogue NPC_Dialogue;
    public Detective_Talks Detective_Talks;
    private bool NPCInZone;


    // Start is called before the first frame update
    void Start()
    {
        //Detective_Talks = FindObjectOfType<Detective_Talks>();
        //NPC_Dialogue = FindObjectOfType<NPC_Dialogue>();
        NPCInZone = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (NPCInZone == true && NPC_Dialogue.NPCIsTalking == true)
        {
            CallText();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collision");
        if (other.tag == "Detective")
        {
            NPCInZone = true;

        }
    }

    private void CallText()
    {
        NPC_Dialogue.NPCTalks();
        NPC_Dialogue.NPCIsTalking = false;
    }
}
