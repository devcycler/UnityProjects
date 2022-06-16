using UnityEngine;

namespace BioSpectra.Scripts.Utility
{
    public static class CalculationHelper
    {
        public static float GetTravelTime(float direction, float current, float min, float max, float travelTime)
        {
            var a = max - min;
            var answer = current / a;
            if (direction < 0)
                answer *= travelTime;
            else
            {
                answer = (1 - answer);
                answer *= travelTime;
            }

            Debug.Log($"{answer}");
            return answer;
        }

        public static float GetSymmetricalHorizontalTravelTime(float direction, float current, float min, float max, float travelTime)
        {
            var answer = 0.0f;
            var a = max - min;
            var b = a / 2f;
            var percentage = current + b;
            if (direction < 0)
                answer = percentage * travelTime;
            else
                answer = (1 - percentage) * travelTime;
            Debug.Log($"{answer}");
            return answer;
        }
    }
}