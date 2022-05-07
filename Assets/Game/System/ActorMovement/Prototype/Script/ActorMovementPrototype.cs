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

        [SerializeField]
        private TMP_Text textState;

        [SerializeField]
        private Button buttonMove;

        [SerializeField]
        private Button buttonStop;

    #endregion

    #region Unity events

        private void Start()
        {
            ChangeState(MovementState.Idle);
            buttonMove.BindClick(MoveToward);
            buttonStop.BindClick(Stop);
        }

    #endregion

    #region Private Methods

        private void ChangeState(MovementState newState)
        {
            state = newState;
            HandleStatChange();
        }

        private void HandleStatChange()
        {
            textState.text = state.ToString();
        }

        private void MoveToward()
        {
            transform.position += transform.right;
            ChangeState(MovementState.Moving);
        }

        private void Stop()
        {
            ChangeState(MovementState.Idle);
        }

    #endregion
    }
}