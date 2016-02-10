using Nancy;
using PetList.Objects;
using System.Collections.Generic;

namespace PetList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Pet> allPets = Pet.GetAll();
        return View["index.cshtml", allPets];
      };
      Post["sleep_add/{id}"] = parameters => {
        Pet.Time();
        Pet.Find(parameters.id).SleepAdd();
        List<Pet> allPets = Pet.GetAll();
        return View["index.cshtml", allPets];
      };
      Post["feed_add/{id}"] = parameters => {
        Pet.Time();
        Pet.Find(parameters.id).FeedAdd();
        List<Pet> allPets = Pet.GetAll();
        return View["index.cshtml", allPets];
      };
      Post["happiness_add/{id}"] = parameters => {
        Pet.Time();
        Pet.Find(parameters.id).HappinessAdd();
        List<Pet> allPets = Pet.GetAll();
        return View["index.cshtml", allPets];
      };
    }
  }
}
