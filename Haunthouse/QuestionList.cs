using System;
namespace MathTest
{
    public class QuestionList
    {
        public Question head;
      //  public Ghost currentQuestion;

        public QuestionList(Question head){
            this.head = head;
            head.answered = true;
          
        }

		public void SetNext(Question next)
		{
            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = next;
		}

		public Question Find(int id)
		{
			var current = head;

			while (current.id != id)
			{
				current = current.next;
			}

			return current;
		}

		public void DisplayAll()
		{
			var current = head;
            while (true)
            {
                Console.WriteLine(current.id.ToString() +" "+current.answered + " "+ current.firstNum.ToString() + " "+ current.secNum.ToString());
                if (current.next == null)
                {
                    break;
                }
				current = current.next;
			}
		}

        public Question GetCurrent()
        {
            var current = head;
            while (true)
            {
                if (current.answered == false)
                {
                    return current;
                }

                current = current.next;

            }
        }

        public void DisplayNext()
        {
            //var current = GetCurrent();
            //while (true){
            //    if (current.answered == true && current.next.answered == false){
            //        current
            //    }
                
            //}
        }


        public void Display(){
            
        }


       


    }
}
