using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HLP.Comum.Models
{
    public class InfoFieldModel
    {
        public string TABLE_QUALIFIER { get; set; }
        public string TABLE_OWNER { get; set; }
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public string DATA_TYPE { get; set; }
        /// <summary>
        /// TIPO DO COMPONENTE
        /// </summary>
        public string TYPE_NAME { get; set; }
        /// <summary>
        /// MAXLENGTH
        /// </summary>
        public string PRECISION { get; set; }
        public string LENGTH { get; set; }
        /// <summary>
        /// DECIMAL PLACES
        /// </summary>
        public string SCALE { get; set; }
        public string RADIX { get; set; }
        /// <summary>
        /// 0 = TRUE || 1 = FALSE
        /// </summary>
        public string NULLABLE { get; set; }
        public string REMARKS { get; set; }
        public string COLUMN_DEF { get; set; }
        public string SQL_DATA_TYPE { get; set; }
        public string SQL_DATETIME_SUB { get; set; }
        public string CHAR_OCTET_LENGTH { get; set; }
        public string ORDINAL_POSITION { get; set; }
        public string IS_NULLABLE { get; set; }
        public string SS_DATA_TYPE { get; set; }

        /// <summary>
        /// Campo é obrigatório ?
        /// </summary>
        /// <returns>SIM / NÃO</returns>
        public string GetObrigatoriedade()
        {
            return this.NULLABLE == "0" ? "SIM" : "NÃO";
        }

        public decimal GetMaxLeghtToNumericUpDown()
        {
            return Convert.ToDecimal(("").PadLeft((Convert.ToInt32(this.PRECISION) - Convert.ToInt32(this.SCALE)), '9'));
        }

        public int GetMaxLenghtNormal()
        {
            return Convert.ToInt32((Convert.ToDecimal(this.PRECISION) - Convert.ToDecimal(this.SCALE)));
        }
    }
}
