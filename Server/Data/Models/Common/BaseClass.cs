using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models.Common
{
    public class BaseClass
    {
        [Key] public int Id { get; set; }

        public DateTime? DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}