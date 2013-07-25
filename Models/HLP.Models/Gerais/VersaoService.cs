using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Gerais
{
    public class VersaoService
    {
        public string RetornaVersaoMaior(params string[] sVersoes)
        {
            VersaoModel vModel = null;
            List<VersaoModel> lVersaoModel = new List<VersaoModel>();

            foreach (string item in sVersoes)
            {
                vModel = new VersaoModel();
                vModel.c1 = Convert.ToInt32(item.Split('.')[0]);
                vModel.c2 = Convert.ToInt32(item.Split('.')[1]);
                vModel.c3 = Convert.ToInt32(item.Split('.')[2]);
                vModel.c4 = Convert.ToInt32(item.Split('.')[3]);
                lVersaoModel.Add(vModel);
            }

            vModel = new VersaoModel();
            vModel = lVersaoModel.OrderByDescending(i => i.c1).OrderByDescending(i => i.c2).OrderByDescending(
                i => i.c3).OrderByDescending(i => i.c4).FirstOrDefault();

            return vModel.c1 + "." + vModel.c2 + "." + vModel.c3 + "." + vModel.c4;
        }
    }
}
