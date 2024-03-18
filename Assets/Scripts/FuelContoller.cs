using UnityEngine;
using UnityEngine.UI;

public class FuelContoller : MonoBehaviour
{
    public static FuelContoller Instance { get; private set; }

    [SerializeField] private Image fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float fuelDrainSpeed = 1f;
    [SerializeField] private float maxFuelAmout = 200f;
    [SerializeField] private Gradient fuelGradient;

    private float currentFuelAmount;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        currentFuelAmount = maxFuelAmout;
        UpdateUI();
    }

    private void Update()
    {
        currentFuelAmount -= Time.deltaTime * fuelDrainSpeed;
        UpdateUI();

        if (currentFuelAmount <= 0f)
            GameManage.instance.GameOver();
    }

    private void UpdateUI()
    {
        fuelImage.fillAmount = (currentFuelAmount / maxFuelAmout);
        fuelImage.color = fuelGradient.Evaluate(fuelImage.fillAmount);
    }
}