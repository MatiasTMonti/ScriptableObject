using UnityEngine;
using TMPro;

public class Datos : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Click click;
    [SerializeField] private TextMeshProUGUI nombre;
    [SerializeField] private TextMeshProUGUI description;

    private void OnMouseDown()
    {
        ShowText();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            panel.SetActive(true);
        }
    }

    public void ShowText()
    {
        nombre.text = click.nombre;
        description.text = click.descriptrion;
    }
}
