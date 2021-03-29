using System.Collections.Generic;
using UnityEngine;

namespace ArchNet.Extension.Renderer
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [RENDERER] Extension Renderer 
    /// Manage tranform and rect transform
    /// author : LOUIS PAKEL
    /// </summary>
    public static class RendererExtension
    {

        /// <summary>
        /// Description : Check if a target is visible from a rendered list
        /// </summary>
        /// <param name="pRendererList"></param>
        /// <param name="pTarget"></param>
        /// <returns></returns>
        public static bool IsFullyVisible(List<Transform> pRendererList, RectTransform pTarget)
        {
            bool lResult = false;

            foreach (Transform lRenderer in pRendererList)
            {
                lResult = RectTransformUtility.RectangleContainsScreenPoint(pTarget, lRenderer.position, null);

                if(lResult == true)
                {
                    return lResult;
                }
            }

            return lResult;
        }

        /// <summary>
        /// Description : Check if a transform is in a rect tranform
        /// </summary>
        /// <param name="pRect"></param>
        /// <param name="pTarget"></param>
        /// <returns></returns>
        public static bool IsInRectTransform(RectTransform pRect, Vector3 pTarget)
        {
            bool lResult = false;

            lResult = RectTransformUtility.RectangleContainsScreenPoint(pRect, pTarget, null);

            if (lResult == true)
            {
                return lResult;
            }

            return lResult;
        }
    }
}
