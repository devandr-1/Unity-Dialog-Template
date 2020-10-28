using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField]
    [TextArea(14, 10)]
    string storyText;

    public string GetStateStory()
    {
        return storyText;
    }
}
