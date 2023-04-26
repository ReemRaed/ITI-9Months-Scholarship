using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class MockContext
    {
        public static List<Track> Tracks = new List<Track>
        {
            new Track() { Id = 1, Name = "SD", Description = "System Development" },
            new Track() { Id=2,Name="Java",Description="Mobile Native" },
            new Track() {Id=3,Name="AI",Description="Artifical Intelligence" },
            new Track() { Id=4,Name="MI",Description="Medical Informatics" },
        };
        public static List<Trainee> Trainees = new List<Trainee>
        {
            new Trainee() { ID=1,Name="Reem", Gender=Gender.Female,email="Reem@gmail.com", MobileNo="01098978651", IsGraduated=false,TrackId=1},
            new Trainee() { ID=2,Name="Ali", Gender=Gender.Male,email="Ali@gmail.com", MobileNo="01098978651", IsGraduated=false,TrackId=2},
            new Trainee() { ID=3,Name="Mohammed", Gender=Gender.Male,email="Mohammed@gmail.com", MobileNo="01098978651", IsGraduated=false,TrackId=3}

        };

    }
}
