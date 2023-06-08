# Mod 2 Week 5 Assessment

Start by Forking this repo.

## Questions (10 Points Possible)

1. In at least two sentences, how would you define what seed data is and why it's useful? (1 point possible)
    a. Seed data is usually an object instance of a model that is represented by strings, integers, booleans, etc. The data that is generated from a data seeder class can seed the database using the database context connection.    

1. Deleting a database column is a dangerous action, what might happen if you delete a column you didn't mean to? (1 point possible)
    a. If you delete a column in a database through ORM you'll first get a warning in your package manager console letting you know you are about to scaffold that collum from the database. If you proceed and delete a collum you didn't mean to you can use the previous migrations down method to revert the changes using the command 'Remove-Migration'. 

1. Write out at least 3 steps to describe the process of adding a new column to your database using entity framework. (1 point possible)
    a.  First, go to the class in Visual Studios and write the collum you would like to add as properties attached to the class. Secondly, you can then run the command 'add-migration' with a message after the command, to generate the migration file. Last you want to then run the command 'update database'  this will add the up method from your migration to your database. 

1. When I run `Update-Database`, which function in the migration is used `Up` or `Down`? (1 point possible)
    a. When you run Update-Database the up method is used, it uses Linq and custom in-line methods to translate our c# classes into database information. If I wanted to revert those changes I could use the 'Remove-Migration' command to run the down method.
    
1. When was Entity Framework Core version 7.0 released? As always, feel free to use google as a resource in answering this question. (1 point possible)
    a.  According to the Microsofts Entity Framework page Entity Framework Core version 7.0 was released in November 2022.

1. True or False: When using Entity Framework to create database tables for a many-to-many relationship, you must create a class to represent the join table? Explain your answer. (1 point possible)
    a.  False, you can choose to make a class when making a join table but if you choose not to EF core will handle the rest for you and make a join table in the database. 

1. Replace the ____________s with the code required to create the models required for the following entity relationship diagram. Don't worry about `Routeid` vs `RoutesId` and `Stopid` vs `StopsId`, either is fine. Also, no need to include the `terminus` column. (2 points possible)

<img width="600" alt="Stop and Route ERD" src="https://user-images.githubusercontent.com/11747682/228308854-d2328b8c-32d2-4eb9-aa0d-8a2b3d4c6bfa.png">

1. Replace the ____________s with the code required to create the models required for the following entity relationship diagram. Don't worry about `Routeid` vs `RoutesId` and `Stopid` vs `StopsId`, either is fine. Also, no need to include the `terminus` column. (2 points possible)

```C#
namespace BusTransitApp
    {
        public class Route
        {
            public int Id {get; set;}
            public float Flare {get; set;}
            public List<Stop> Stops;
        }
    }

namespace BusTransitApp
    {
        public class Stop
        {
            public int Id {get; set;}
	        public string Name {get; set;}
	        public List<Route> Routes;
        }
    }
```


1. Replace the _______________s with the code required to seed at least two `Route` objects and at least two `Stop` objects based on your models above. Make sure that there is a many-to-many relationship between your data. (2 points possible)

```C#
namespace BusTransitApp.Data
{
    public class DataSeeder
    {
        public static void SeedRoutesAndStops(BusTransitContext context)
        {
            if (!context.Route.Any())
            {
                 // Create Route instances
                Route route1 = new Route { Flare = 1.0 };
                Route route2 = new Route { Flare = 2.0 };

                 // Create Stop instances
                Stop stop1 = new Stop { Name = "Stop 1" };
                Stop stop2 = new Stop { Name = "Stop 2" };

                 // Making the many-to-many relationship 
                route1.Stops = new List<Stop> { stop1, stop2 };
                route2.Stops = new List<Stop> { stop1 };

                 // Making the many-to-many relationship between Stop and Route
                stop1.Routes = new List<Route> { route1, route2 };
                stop2.Routes = new List<Route> { route1 };

                 // Add the instances to the context using add range
                context.Route.AddRange(route1, route2);
                context.Stop.AddRange(stop1, stop2);
            }
           // Save changes to context
          context.SaveChanges();
        }
    }
}
```
## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a project that has already been set up using Entity Framework.

**Goal 1**: Create your concert database without changing the models. You will need to modify the project to include your specific postgress password, then create a migration, then update your database.

Delivarable: In your slack message to instructors, include a screenshot of the ERD for your concerts table in pgAdmin to show you have completed this step.

**Goal 2**: Add a performers table to your database. Implement a many-to-many relationship between concerts and performers. It's up to you what fields your performers table includes, but it should have at least 3 fields.

Deliverable: In your slack message to instructors, include a screenshot of the ERD for your concerts and performers tables in pgAdmin to show you have completed this step.

## Extra Challenge (0 Points Possible)

Add some seed data for performers and concerts.

## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
* Submit the link to your forked repository in the submission form posted in slack!
