using System;
using System.Collections.Generic;

namespace cleaningsoftWebApp.Models
{
    public partial class CleaningTaskDetail
    {
        public Guid Id { get; set; }
        public Guid? CleanerDetailId { get; set; }
        public string CleaningTaskTaskDetail { get; set; }
        public string CleaningTaskName { get; set; }
        public int? CleaningTaskDetailId { get; set; }
        public Guid? CleaningTaskAssignedById { get; set; }
        public Guid? CleaningTaskDifficultyId { get; set; }
        public Guid? CleaningTaskTypeId { get; set; }

        public CleanerDetail CleanerDetail { get; set; }
    }
}
