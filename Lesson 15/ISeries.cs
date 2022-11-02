using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int step;// Объявляем переменную шаг и здесь храним его
        int startValue;//Объявляем стартовое значение и здесь храним его
        int currentValue;//Объявляем текущее значение и здесь храним его
        public int GetNext()// Возвращает следующее число ряда
        {
            currentValue += step;
            return currentValue;
        }

        public void Reset()//Сброс до начального значения
        {
            currentValue = startValue;
        }

        public void SetStart(int x)// Устанавливает начальное значение
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(int s)// Устанавливает шаг
        {
            step = s;
        }
    }
        class GeomProgression : ISeries
        {
            int step;
            int startValue;
            int currentValue;
            public int GetNext()
            {
                currentValue *= step;
                return currentValue;
            }

            public void Reset()
            {
                currentValue = startValue;
            }

            public void SetStart(int x)
            {
                startValue = x;
                currentValue = startValue;
            }
            public void SetStep(int s)
            {
                step = s;
            }
        }
    }

   

