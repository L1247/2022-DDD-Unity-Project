#region

using AutoBot.Utilities.Extensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#endregion

namespace ActorMovement.Prototype.Script
{
    internal enum MovementState
    {
        None , Idle , Moving
    }

    public class ActorMovementPrototype : MonoBehaviour
    {
    #region Private Variables

        private MovementState state;

        private Vector2 direction;

        [SerializeField]
        private TMP_Text textState;

        [SerializeField]
        private Button buttonMoveByDirection;

        [SerializeField]
        private Button buttonStop;

        [SerializeField]
        private Button buttonChangeDirection;

        [SerializeField]
        private SpriteRenderer spriteRenderer;

    #endregion

    #region Unity events

        private void Start()
        {
            direction = Vector2.right;
            ChangeState(MovementState.Idle);
            buttonMoveByDirection.BindClick(MoveByDirection);
            buttonChangeDirection.BindClick(ChangeDirection);
            buttonStop.BindClick(Stop);
        }

    #endregion

    #region Private Methods

        private void ChangeDirection()
        {
            Debug.Log("Action - ChangeDirection");
            direction = direction == Vector2.right ? Vector2.left : Vector2.right;
            HandleDirectionChange();
        }

        private void ChangeState(MovementState newState)
        {
            state = newState;
            HandleStatChange();
        }

        private void HandleDirectionChange()
        {
            Debug.Log($"Current Direction: {direction}");
            var flipX = direction == Vector2.left;
            spriteRenderer.flipX = flipX;
        }

        private void HandleStatChange()
        {
            Debug.Log($"CurrentState: {state}");
            var isMoving = state == MovementState.Moving;
            buttonStop.gameObject.SetActive(isMoving);

            textState.text = state.ToString();
        }

        private void MoveByDirection()
        {
            Debug.Log("Action - MoveByDirection");
            transform.position += new Vector3(direction.x , direction.y , 0);
            ChangeState(MovementState.Moving);
        }

        private void Stop()
        {
            Debug.Log("Action - Stop");
            ChangeState(MovementState.Idle);
        }

    #endregion
    }
}