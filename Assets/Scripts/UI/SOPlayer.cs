using UnityEngine;

[CreateAssetMenu]
public class SOPlayer : ScriptableObject
{
    [Header("movement")]
    public float speed;
    public float walkspeed;
    public float runspeed;
    public float jumpforce;
}
