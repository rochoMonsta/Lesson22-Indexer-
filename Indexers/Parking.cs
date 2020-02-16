using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Parking : IEnumerable
    {
        public string Name { get; set; }
        private List<Car> Cars = new List<Car>();
        private const int MAX_CARS_IN_PARKING = 100;
        public int Count => Cars.Count;
        public Car this[string number]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(number))
                    throw new ArgumentNullException(nameof(number), "Number is null or empty.");
                var car = Cars.FirstOrDefault(c => c.Number == number);
                if (car != null)
                    return car;
                return null;
            }
        }
        public Car this[int position]
        {
            get
            {
                if (position < Cars.Count)
                    return Cars[position];
                return null;
            }
        }
        public int AddCar (Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Car is nill or empty.");
            if (Cars.Count < MAX_CARS_IN_PARKING)
            {
                Cars.Add(car);
                return Cars.Count - 1;
            }
            return -1;
        }
        public void CarGoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentNullException(nameof(number), "Number is null or empty.");
            var car = Cars.FirstOrDefault(c => c.Number == number);
            if (car != null)
                Cars.Remove(car);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
    }
}
