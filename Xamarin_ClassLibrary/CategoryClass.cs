using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_ClassLibrary
{
   public class CategoryClass
    {
        public string Title { get; internal set; }
        public string Description { get; internal set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
