using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Assignment4_GameProject
{
    public class Score
    {
        public void Show(float x)
        {
            Text.Color = Color.Black;
            Text.Draw("SCORE: " + x + "", 225, 14);
        }
        public void Time(float x)
        {
            Text.Color = Color.Black;
            Text.Draw("TIME: " + x + "", 225, 42);
        }
        public void Increase(float x, float scoreIncreaseBy)
        {
            x = x + scoreIncreaseBy;
        }
    }
}
