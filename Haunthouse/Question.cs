using System;
namespace MathTest
{

    public class Question
    {

        public enum calculationType
        {
            addition, 
            subtraction, 
            multiplication, 
            division

        }

        public Question next;
        public int id;
        public float firstNum, secNum;
        public float result;
        public bool answered;
        public int calculation;


        public Question(int id, float firstNum, float secNum, int cal){
            this.id = id;
            this.firstNum = firstNum;
            this.secNum = secNum;
            result = GetResult();
            answered = false;
            calculation = cal;
        }

        public calculationType GetCal()
        {
            
            switch (calculation)
            {
                case 1: return calculationType.addition;
                   
                case 2: return calculationType.subtraction;
                    
                case 3 : return calculationType.multiplication;
                    
                case 4: return calculationType.division;
                  
                default: return calculationType.addition;
            }
        }

        public float GetResult()
        {
            calculationType cal = GetCal();
            switch (cal)
            {
                case calculationType.addition:
                    return firstNum + secNum;
                case calculationType.subtraction:
                    return firstNum - secNum;
                case calculationType.multiplication:
                    return firstNum * secNum;
                case calculationType.division:
                    return firstNum / secNum;
            }
            return -1;  
        }

		public bool CompareAnswer(float answer)
		{
            return Math.Abs(answer - result) < 0.001f;
		}

        public void DisplayThis()
        {
            calculationType cal = GetCal();
            switch (cal){
				case calculationType.addition:
                    Console.WriteLine(firstNum.ToString() + " + " + secNum.ToString() +" = ");
                    break;
				case calculationType.subtraction:
					Console.WriteLine(firstNum.ToString() + " - " + secNum.ToString()+" = " );
                    break;
				case calculationType.multiplication:
					Console.WriteLine(firstNum.ToString() + " * " + secNum.ToString()+" = " );
                    break;
				case calculationType.division:
					Console.WriteLine(firstNum.ToString() + " / " + secNum.ToString()+" = ");
                    break;
			}
              
        }

    }
}