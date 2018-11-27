using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_ClassLibrary
{
   public class CategoryManager
    {
        private readonly CategoryClass[] categoryClasses;
        int currentIndex = 0;
        private readonly int lastIndex;

        public CategoryManager()
        {
            categoryClasses = InitCategory();
            lastIndex = categoryClasses.Length - 1;
        }

        private CategoryClass[] InitCategory()
        {
            var initCategory = new CategoryClass[]
            {
                new CategoryClass()
                {
                    Title ="Category 1",
                    Description = "This is book category 1",
                    
                },
                 new CategoryClass()
                {
                    Title ="Category 2",
                    Description = "This is book category 2",
                   
                },
                  new CategoryClass()
                {
                    Title ="Category 3",
                    Description = "This is book category 3",
                    
                },
                 

            };

            return initCategory;
        }


        public int Length
        {
            get { return categoryClasses.Length; }
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
            if (currentIndex < categoryClasses.Length - 1)
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

        public CategoryClass Current
        {
            get { return categoryClasses[currentIndex]; }
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

