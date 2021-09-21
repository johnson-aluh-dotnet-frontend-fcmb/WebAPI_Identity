using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAuth.Model
{
    public class Question
    {
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string OptionA { get; set; }

        [Column(TypeName = "text")]
        public string OptionB { get; set; }

        [Column(TypeName = "text")]
        public string OptionC { get; set; }

        [Column(TypeName = "text")]
        public string OptionD { get; set; }

        [StringLength(20)]
        public string Answer { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string Authoriser { get; set; }

        public int? CategoryId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Entry { get; set; }

        public int? AnswerTime { get; set; }

        [Column(TypeName = "text")]
        public string Explanation { get; set; }

        public int? DiagramId { get; set; }

        public int? ReferenceNo { get; set; }

        public int? Score { get; set; }

        [StringLength(50)]
        public string supevisorId { get; set; }

        public int? ClassId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string DocumentGroupCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        public int? ApprovalLevel { get; set; }
        public int? MaxApprovalLevel { get; set; }
        [Key]
        [StringLength(50)]
        public string LogReferenceCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(50)]
        public string TableId { get; set; }
        [StringLength(50)]
        public string ModuleCode { get; set; }
        [StringLength(50)]
        public string ChannelCode { get; set; }
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string KeyCheck { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CBT_Answers> cbt_Answer { get; set; }

        //public virtual cbt_Categories cbt_Categories { get; set; }

        //public virtual cbt_Class cbt_Class { get; set; }

        //public virtual cbt_Diagrams cbt_Diagrams { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CBT_QuestionSet> cbt_QuestionSet { get; set; }
    }
}
