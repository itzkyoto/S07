using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed = 5;
    void Start()
    {
        print(PlayerInputController.MoveInput);
    }
    private void OnEnable()
    {
        PlayerInputController.OnJump += JumpMecanic;
       
    }
    void Update()
    {
        MovementeMechanic();
    }

    public void MovementeMechanic()
    {
        Vector2 moveInput = PlayerInputController.MoveInput;

        Vector3 dir = new Vector3(moveInput.x, moveInput.y, 0);

        transform.position += dir * speed * Time.deltaTime;
    }
    public void JumpMecanic()
    {
        Debug.Log("salte");
    }
  
    public float speed => Speed;
}
