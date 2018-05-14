using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AD.Models;

namespace AD.DAL
{
    public class ProjectInititializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var people = new List<People>
            {
                new People { PersonId= 1, FirstName="Willis", LastName="Tibbs", IsAuthorised=false, IsValid=true, IsEnabled= false },
                new People { PersonId= 2, FirstName="Sharon", LastName= "Halt", IsAuthorised=false, IsValid=false, IsEnabled= false},
                new People { PersonId= 3, FirstName="Patrick", LastName= "Kerr", IsAuthorised=false, IsValid=true, IsEnabled=true},
                new People { PersonId= 4, FirstName="Lilly", LastName= "Hale", IsAuthorised=false, IsValid=false, IsEnabled= false},
                new People { PersonId= 5, FirstName="Joel", LastName= "Daly", IsAuthorised=false, IsValid=true, IsEnabled=true},
                new People { PersonId= 6, FirstName="Imogen", LastName= "Kent", IsAuthorised=false, IsValid=false, IsEnabled= false},
                new People { PersonId= 7, FirstName="George", LastName= "Edwards", IsAuthorised=false, IsValid=true, IsEnabled=false},
                new People { PersonId= 8, FirstName="Gabriel", LastName= "Francis", IsAuthorised=false, IsValid=false, IsEnabled= false},
                new People { PersonId= 9, FirstName="Courtney", LastName= "Arnold", IsAuthorised=false, IsValid=true, IsEnabled=true},
                new People { PersonId= 10, FirstName="Brian", LastName= "Allen", IsAuthorised=false, IsValid=true, IsEnabled= true},
                new People { PersonId=11, FirstName= "Bo", LastName="Bob", IsAuthorised=true, IsValid=true, IsEnabled=false}
            };
            people.ForEach(p => context.Peoples.Add(p));
            context.SaveChanges();
            var colours = new List<Colours>
            {
                new Colours { ColourId=1, Name= "Red", IsEnabled=true}, 
                new Colours { ColourId=2, Name= "Green", IsEnabled= true}, 
                new Colours { ColourId=3, Name="Blue", IsEnabled=true}
            };
            colours.ForEach(p => context.Colours.Add(p));
            context.SaveChanges();

        }
    }
}