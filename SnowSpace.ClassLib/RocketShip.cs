namespace SnowSpace.ClassLib;

public class RocketShip
{
    private string name;
    private int numberOfFins;

    public RocketShip(string newName)
    {
        SetName(newName);
    }

    public void SetName(string newName)
    {
        if (newName != null)
        {
         this.name = newName;
        }
        else
        {
            throw new Exception("NO!");
        }
    }

    bool hasNumber(string s) 
    {
     if(s.Contains("\\[0-9]\\")) {
        return true;
     } else {
        return false;
     }
    }

    public string GetName()
    {
        return this.name;
    }

    public string Takeoff()
    {
        return "Bbbbbruugguooooooshsshsh";
    }
}
