using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RFC.Models
{
    public class CreateNew
    {
        public long ID { get; set; }
        [Required]
        [DisplayName("Priority")]
        public Priority Priority { get; set; }


        [Required]
        [DisplayName("Description of change")]
        public string ChangeDescription { get; set; }


        [Required]
        [DisplayName("What is the reason for change?")]
        public string ReasonForChange { get; set; }


        [Required]
        [DisplayName("System affected:")]
        public Product Product { get; set; }


        [Required]
        [DisplayName("How is the system being altered?")]
        public string SystemAffected { get; set; }


        [Required]
        [DisplayName("What customers could potentially be impacted by this change ")]
        public string customers { get; set; }

        [Required]
        public string CustomersAffected { get; set; }


        [Required]
        [DisplayName("Will this change cause an impact to service?")]
        public bool ServiceImpact { get; set; }


        [Required]
        [DisplayName("What is the risk of implementing this change?")]
        public string RiskOfChange { get; set; }


        [Required]
        [DisplayName("What is the risk of NOT implementing this change?")]
        public string RiskNoChange { get; set; }


        [Required]
        [DisplayName("How will the changes be verified after the implementation?")]
        public string VerifyAfter { get; set; }


        [DisplayName("What is the rollback plan, in the event the change has undesired effects?")]
        [Required]
        public string RollBackPlan { get; set; }


        [Required]
        [DisplayName("When is the change required by?")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }


        [Required]
        [DisplayName("Why is this due date required?")]
        public string WhyDueDate { get; set; }


        [Required]
        [DisplayName("Who will be performing the change?")]
        public string WhoPerforming { get; set; }

        public RequestStatus Approved { get; set; }
    }
}
