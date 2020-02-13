using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Iterations
{
    // Implementing IEnumerable makes Bouquet a collection type, thus can be used in iterations, just like any other collection.
    class Bouquet : IEnumerable
    {
        private List<Flower> flowers = new List<Flower>(capacity: 10);
        
        public void Add(Flower flower) { 
            if(flowers.Count >= flowers.Capacity) { throw new Exception("Bouquet Reached Maximum Limit"); }
            flowers.Add(flower);
        }

        // One way to iterate over flowers. Get Flower array
        public List<Flower> GetFlowers() { return flowers; }
        public IEnumerator GetEnumerator()
        {
            //return ((IEnumerable<Flower>)flowers).GetEnumerator();
            foreach(Flower flower in flowers)
            {
                yield return flower;
            }
        }
    }
}
