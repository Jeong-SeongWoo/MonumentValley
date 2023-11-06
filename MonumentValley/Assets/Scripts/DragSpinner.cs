using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


namespace MonumentValley
{
    // 마우스 클릭과 드래그에 따라 대상 변환을 회전할 수 있습니다.
    [RequireComponent(typeof(Collider))]

    public class DragSpinner : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public enum SpinAxis
        {
            X,
            Y,
            Z,
        }

        // transform to spin
        [SerializeField] 
    }
}
