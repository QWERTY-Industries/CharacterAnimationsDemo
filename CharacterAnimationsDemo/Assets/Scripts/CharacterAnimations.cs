using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    Animator animator;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Animations.Enable();
        playerInputActions.Animations.Walk.performed += Walk_performed;
        playerInputActions.Animations.Run.performed += Run_performed;
        playerInputActions.Animations.Idle.performed += Idle_performed;
        playerInputActions.Animations.Attack.performed += Attack_performed;
        playerInputActions.Animations.Exit.performed += Exit_performed;

        animator = GetComponent<Animator>();
    }

    private void OnDisable()
    {
        playerInputActions.Animations.Walk.performed -= Walk_performed;
        playerInputActions.Animations.Run.performed -= Run_performed;
        playerInputActions.Animations.Idle.performed -= Idle_performed;
        playerInputActions.Animations.Attack.performed -= Attack_performed;
        playerInputActions.Animations.Exit.performed -= Exit_performed;
    }

    private void OnDestroy()
    {
        playerInputActions.Animations.Walk.performed -= Walk_performed;
        playerInputActions.Animations.Run.performed -= Run_performed;
        playerInputActions.Animations.Idle.performed -= Idle_performed;
        playerInputActions.Animations.Attack.performed -= Attack_performed;
        playerInputActions.Animations.Exit.performed -= Exit_performed;
    }

    private void Exit_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Application.Quit();
    }

    private void Attack_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        animator.SetTrigger("Attack");
    }

    private void Idle_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        animator.SetTrigger("Idle");
    }

    private void Run_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        animator.SetTrigger("Run");
    }

    private void Walk_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        animator.SetTrigger("Walk");
    }
}
