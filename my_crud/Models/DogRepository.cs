using System.Collections.Generic;

namespace my_crud.Models

{
    public class DogRepository
    {
        public static List<Dog> dogs = new List<Dog>();

        public DogRepository()
        {
            if (dogs.Count == 0)
                Fill();
        }

        public void Fill(){

        }

        public void Delete(int id)
        {
            dogs.Remove(dogs.Find(x=>x.id==id));
        }

        public void Create(Dog dog)
        {
            dogs.Add(dog);
        }

        public void Update(Dog dog)
        {
            Delete(dog.id);
            Create(dog);
        }

        public Dog GetById(int id)
        {
            return dogs.Find(x=>x.id==id);
        }
        public List<Dog> GetAll()
        {
            return dogs;
        }
    }
}