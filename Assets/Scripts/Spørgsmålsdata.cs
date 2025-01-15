
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "ScriptableObjects/Question", order = 1)]
public class Spørgsmålsdata : ScriptableObject
{
    public string question;
    public string category;
   
    public string[] answers;
}
