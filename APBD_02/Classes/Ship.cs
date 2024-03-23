namespace APBD_02.Classes;

public class Ship
{
    private List<Container> Containers { get; }
    private double MaxSpeed { get; set; }
    private double MaxLoadWeight { get; }
    private int MaxContainerAmount { get; }

    public Ship(int maxContainerAmount, double maxLoadWeight, double maxSpeed, params Container[] containers) {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxLoadWeight = maxLoadWeight;
        MaxContainerAmount = maxContainerAmount;
        for (int i = 0; i < int.Min(maxContainerAmount,Containers.Count); i++) {
            Containers.Add(containers[i]);
        }
    }

    public double TotalWeight() {
        double ret = 0;
        foreach (Container cnt in Containers) {
            ret += cnt.LoadMass;
        }
        return ret;
    }

    public double UnloadShip() {
        double d = TotalWeight();
        Containers.Clear();
        return d;
    }

    public void SwapContainer(int ID, Container cnt) {
        UnloadContainer(Containers.Find(c => { return c.ID == ID; }));
        AddContainer(cnt);
    }

    public void MoveToAnotherShip(Ship ship, Container cnt) {
        UnloadContainer(cnt);
        ship.AddContainer(cnt);
    }
    public void AddContainer(params Container[] containers) {
        if (Containers.Count >= MaxContainerAmount) {
            Console.WriteLine("Container cannot be added; max capacity reached");
            return;
        }
        foreach (Container cnt in containers) {
            Containers.Add(cnt);
        }
    }

    public void UnloadContainer(Container cnt) {
        Containers.Remove(cnt);
    }

    public override string ToString() {
        string str =
            $@"{GetType().Name}  -- Containers: {Containers.Count}, Weight: {TotalWeight()}, MaxLoad: {MaxLoadWeight}, MaxSpd: {MaxSpeed}
Contents: 
";
        foreach (var container in Containers) {
            str += container + "\n";
        }

        return str;
    }
}