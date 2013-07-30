using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Comum.Models
{
    [Serializable]
    public class LogExceptionModel
    {
        public List<LogDados> lLogException = new List<LogDados>();
    }

    public class LogDados
    {
        public int? idLogErro { get; set; }
        public string xEmpresa { get; set; }
        public string xFormulario { get; set; }
        public string xAcao { get; set; }
        public string xMessage { get; set; }
        public string xInner { get; set; }
        public string xDetalhes { get; set; }
        public DateTime dtOcorrencia { get; set; }
    }
}
