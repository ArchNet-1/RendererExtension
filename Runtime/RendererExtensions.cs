// ArchNet · Renderer Extension
// Tells whether a screen point, or objects of the scene, are inside a UI rectangle.
// Works with every canvas mode: pass the canvas camera for Screen Space - Camera / World Space.
// Docs: https://archnet-plateform.fr/#RendererExtension

using System.Collections.Generic;
using UnityEngine;

namespace ArchNet.Extension
{
    public static class RendererExtension
    {
        /// <summary>True when the screen point (e.g. a pointer position) is inside the rectangle.</summary>
        public static bool ContainsScreenPoint(this RectTransform rect, Vector2 screenPoint, Camera uiCamera = null) =>
            RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint, uiCamera);

        /// <summary>True when the object, seen by the scene camera, appears inside the rectangle.</summary>
        public static bool ContainsWorldPoint(this RectTransform rect, Vector3 worldPoint, Camera sceneCamera, Camera uiCamera = null) =>
            rect.ContainsScreenPoint(RectTransformUtility.WorldToScreenPoint(sceneCamera, worldPoint), uiCamera);

        /// <summary>True when at least one of the objects appears inside the rectangle.</summary>
        public static bool ContainsAny(this RectTransform rect, IEnumerable<Transform> targets, Camera sceneCamera, Camera uiCamera = null)
        {
            foreach (Transform target in targets)
            {
                if (target != null && rect.ContainsWorldPoint(target.position, sceneCamera, uiCamera)) return true;
            }
            return false;
        }

        /// <summary>True when every object appears inside the rectangle.</summary>
        public static bool ContainsAll(this RectTransform rect, IEnumerable<Transform> targets, Camera sceneCamera, Camera uiCamera = null)
        {
            foreach (Transform target in targets)
            {
                if (target != null && !rect.ContainsWorldPoint(target.position, sceneCamera, uiCamera)) return false;
            }
            return true;
        }
    }
}
