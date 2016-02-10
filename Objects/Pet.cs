using System.Collections.Generic;

namespace PetList.Objects
{
  public class Pet
  {
    private int _id;
    private string _name;
    private int _sleep;
    private int _food;
    private int _happiness;

    private static List<Pet> _petList = new List<Pet>
    {

      new Pet()
      {
        _id = 1,
        _name = "one",
        _sleep = 100,
        _food = 100,
        _happiness = 100
      },
      new Pet()
      {
        _id = 2,
        _name = "two",
        _sleep = 100,
        _food = 100,
        _happiness = 100
      },
      new Pet()
      {
        _id = 3,
        _name = "three",
        _sleep = 100,
        _food = 100,
        _happiness = 100
      }

    };
    // public Pet (string name, int sleep, int food, int happiness)
    // {
    //   _name = name;
    //   _sleep = sleep;
    //   _food = food;
    //   _happiness = happiness;
    //   _petList.Add(this);
    //   _id = _petList.Count;
    // }
    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void SetSleep(int newSleep)
    {
      _sleep = newSleep;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetHappiness()
    {
      return _happiness;
    }
    public void SetHappiness(int newHappiness)
    {
      _happiness = newHappiness;
    }
    public static List<Pet> GetAll()
    {
      return _petList;
    }
    public static Pet Find(int searchId)
    {
      return _petList[searchId - 1];
    }
    public static List<Pet> Time(){
      foreach(Pet member in _petList)
      {
        member._sleep = member._sleep - 5;
        member._food = member._food - 5;
        member._happiness = member._happiness - 5;
      }
      return _petList;

    }
    public void SleepAdd(){
      _sleep +=10;
    }
    public void FeedAdd(){
      _food +=10;
    }
    public void HappinessAdd(){
      _happiness +=10;
    }

  }
}
