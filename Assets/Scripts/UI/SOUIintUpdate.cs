using TMPro;
using UnityEngine;

public class SOUIintUpdate : MonoBehaviour
{
    public SOint soInt;
    public TextMeshProUGUI uiTextValue;

    private void Update()
    {
        uiTextValue.text = soInt.Value.ToString();
    }
}
