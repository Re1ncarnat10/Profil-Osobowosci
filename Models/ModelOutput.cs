using Microsoft.ML.Data;
using System.ComponentModel.DataAnnotations;

namespace Profil_Osobowosci.Models
{
    public class ModelOutput
    {
        [ColumnName(@"type")]
        public uint Type { get; set; }

        [ColumnName(@"posts")]
        public string Posts { get; set; }

        [ColumnName(@"PredictedLabel")]
        public string PredictedLabel { get; set; }

        [ColumnName(@"Score")]
        public float[] Score { get; set; }

    }
}



