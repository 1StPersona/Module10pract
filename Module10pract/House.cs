using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10pract
{
    public class House
    {
        private List<IPart> parts = new List<IPart>();

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void ShowParts()
        {
            Console.WriteLine("House parts:");
            foreach (var part in parts)
            {
                Console.WriteLine(part.Name);
            }
        }
    }
}
