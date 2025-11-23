using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SafeCode : MonoBehaviour
{
    public GameObject Panel;
    public TextMeshProUGUI codeText;
    public Button OneBtn;
    public Button TwoBtn;
    public Button ThreeBtn;
    public Button FourBtn;
    public Button FiveBtn;
    public Button SixBtn;
    public Button SevenBtn;
    public Button EightBtn;
    public Button NineBtn;
    public Button ZeroBtn;

    string codeTextValue = "";

    public GameObject PortaCofre;
    public bool closed;
    public GameObject book;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Panel.SetActive(false);
        codeText.enabled = false;
        OneBtn.gameObject.SetActive(false);
        TwoBtn.gameObject.SetActive(false);
        ThreeBtn.gameObject.SetActive(false);
        FourBtn.gameObject.SetActive(false);
        FiveBtn.gameObject.SetActive(false);
        SixBtn.gameObject.SetActive(false);
        SevenBtn.gameObject.SetActive(false);
        EightBtn.gameObject.SetActive(false);
        NineBtn.gameObject.SetActive(false);
        ZeroBtn.gameObject.SetActive(false);

        PortaCofre.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        closed = true;
    }

    // Update is called once per frame
    void Update()
    {
        codeText.SetText(codeTextValue);

        if(codeTextValue == "7523")
        {
            Panel.SetActive(false);
            codeText.enabled = false;
            OneBtn.gameObject.SetActive(false);
            TwoBtn.gameObject.SetActive(false);
            ThreeBtn.gameObject.SetActive(false);
            FourBtn.gameObject.SetActive(false);
            FiveBtn.gameObject.SetActive(false);
            SixBtn.gameObject.SetActive(false);
            SevenBtn.gameObject.SetActive(false);
            EightBtn.gameObject.SetActive(false);
            NineBtn.gameObject.SetActive(false);
            ZeroBtn.gameObject.SetActive(false);

            PortaCofre.transform.rotation = Quaternion.Euler(-90f, 0f, -90f);
            closed = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit (string digit)
    {
        codeTextValue += digit;
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            if(closed == true)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Panel.SetActive(true);
                    codeText.enabled = true;
                    OneBtn.gameObject.SetActive(true);
                    TwoBtn.gameObject.SetActive(true);
                    ThreeBtn.gameObject.SetActive(true);
                    FourBtn.gameObject.SetActive(true);
                    FiveBtn.gameObject.SetActive(true);
                    SixBtn.gameObject.SetActive(true);
                    SevenBtn.gameObject.SetActive(true);
                    EightBtn.gameObject.SetActive(true);
                    NineBtn.gameObject.SetActive(true);
                    ZeroBtn.gameObject.SetActive(true);
                    

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    Time.timeScale = 0;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Destroy(book);
                }
                    
            }
        }
    }
}
