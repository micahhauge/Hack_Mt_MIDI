using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.code
{
   
    class ScoresText : MonoBehaviour
    {
        Text text;
        public static uint Num;
        void Start()
        {
            Num = 0;
            text = GetComponent<Text>();

            text.text = "Score : " + Num;
        }

        // Update is called once per frame
        void Update()
        {

            text.text = "Score: " + Num;
        }
    }
}
