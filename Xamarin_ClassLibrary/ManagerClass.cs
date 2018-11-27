                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_ClassLibrary
{
    public class ManagerClass
    {
        private readonly PrtClass[] prtClasses;
        int currentIndex = 0;
        private readonly int lastIndex;

        public ManagerClass()                                                                                                                       
        {
            prtClasses = InitApp();
            lastIndex = prtClasses.Length - 1;                                                                                                                   
        }

        private PrtClass[] InitApp()
        {
            var initApp = new PrtClass[]
            {
                new PrtClass()
                {
                    Title ="Anything You Want",
                    Description = "Too many people spend their life pursuing things that don’t actually make them happy." +
                    " When you make a business, you get to make a little universe where you create all the laws." +
                    " Never forget that absolutely everything you do is for your customers.",                                                                                                        
                    Image = "abook"
                },
                 new PrtClass()                                      
                {
                    Title ="A Short Guide to a Happy Life",
                    Description = " The only thing you have that nobody else has is control of your life." +
                    " The hardest thing of all is to learn to love the journey, not the destination." +
                    " Get a real life rather than frantically chasing the next level of success.",
                    Image = "ebook"
                },
                  new PrtClass()
                {                                          
                    Title ="The 10X Rule",
                    Description = "The 10X Rule says that 1) you should set targets for yourself that are"+
                    "10X greater than what you believe you can achieve and" +
                    " 2) you should take actions that are 10X greater than what you believe are necessary to achieve your goals.",
                    Image = "cbook"
                },
                   new PrtClass()
                {
                    Title ="A Technique for Producing Ideas",
                    Description = "The capacity to bring old elements into new combinations depends largely on your ability to see relationships." +
                    " All ideas follow a five-step process of 1) gathering material," +
                    "2) intensely working over the material in your mind, 3) stepping away from the problem",
                    Image = "dbook"
                },

            };

            return initApp;
        }


        public int Length
        {
            get { return prtClasses.Length; }
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if (currentIndex > 0)
                --currentIndex;
        }
        public void MoveNext()
        {
            if (currentIndex < prtClasses.Length - 1)
                ++currentIndex;
        }

        public void MoveTo(int position)
        {
            if (position >= 0 && position <= lastIndex)
                currentIndex = position;
            else
                throw new IndexOutOfRangeException(
                   String.Format("{0} is an invalid position. Must be between 0 and {1}", position, lastIndex));
        }

        public PrtClass Current
        {
            get { return prtClasses[currentIndex]; }
        }

        public Boolean CanMovePrev
        {
            get { return currentIndex > 0; }
        }

        public Boolean CanMoveNext
        {
            get { return currentIndex < lastIndex; }
        }
    }
}
