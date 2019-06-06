using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Conversation Data", menuName = "Tutorial/Conversation Data", order = 1)]
public class ConversationData : ScriptableObject {
    public List<SpeakerData> list;
}