
public class Zoo
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public double FoodSupply { get; set; }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return Animals;
    }

    public IEnumerable<Animal> GetAnimalsBySpecies(string species)
    {
        return Animals.Where(a => a.Species.Equals(species, StringComparison.OrdinalIgnoreCase));
    }

    public void IncreaseFoodSupply(double amount)
    {
        FoodSupply += amount;
    }

    public bool FeedAnimals()
    {
        double totalFoodNeeded = Animals.Sum(a => a.FoodConsumption);
        if (FoodSupply >= totalFoodNeeded)
        {
            FoodSupply -= totalFoodNeeded;
            return true;
        }
        return false;
    }
}
