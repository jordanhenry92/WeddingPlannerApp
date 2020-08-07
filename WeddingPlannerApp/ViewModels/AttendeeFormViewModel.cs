using System.Collections.Generic;
using WeddingPlannerApp.Models;

namespace WeddingPlannerApp.ViewModels
{
    public class AttendeeFormViewModel
    {
        public Attendee Attendee { get; set; }
        public IEnumerable<Role> Roles { get; set; }
    }
}