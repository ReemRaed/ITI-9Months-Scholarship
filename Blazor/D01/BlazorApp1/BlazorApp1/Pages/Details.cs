using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace BlazorApp1.Pages
{
    public partial class Details
    {

        [Parameter]
        public int ID { get; set; }

        public Trainee CurTrainee{ get; set; }

        public string TrackName { get; set; }

        protected override Task OnInitializedAsync()
        {
            CurTrainee = MockContext.Trainees.FirstOrDefault(em => em.ID == ID);
            var Track = MockContext.Tracks.FirstOrDefault(e => e.Id == CurTrainee.TrackId);
            TrackName = Track.Name;

            return base.OnInitializedAsync();
        }
    }
}
