using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MuseumApp
{
    public class AttractionScreenParameters : MonoBehaviour
    {
        public AttractionConfig attractionConfig;
        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

    }
}
