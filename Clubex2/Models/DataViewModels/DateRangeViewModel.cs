using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models.DataViewModels
{
    public class DateRangeViewModel
    {
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
