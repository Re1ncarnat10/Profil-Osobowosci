using Microsoft.ML.Data;
using System.ComponentModel.DataAnnotations;

namespace Profil_Osobowosci.Models
{
    public class ModelInput
    {
        [LoadColumn(0)]
        [ColumnName(@"type")]
        public string Type { get; set; }

        [LoadColumn(1)]
        [ColumnName(@"posts")]
        public string Posts { get; set; }

    }
}


