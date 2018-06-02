using System;
using System.Collections.Generic;

namespace cleaningsoftWebApp.Models
{
    public partial class CleanerDetail
    {
        public CleanerDetail()
        {
            CleaningTaskDetail = new HashSet<CleaningTaskDetail>();
        }

        public Guid Id { get; set; }
        public string CleanerDetailName { get; set; }
        public DateTime? CleanerDetailStartDate { get; set; }
        public Guid? CleaningWorkerTypeId { get; set; }

        public ICollection<CleaningTaskDetail> CleaningTaskDetail { get; set; }
    }
}
