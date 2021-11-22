using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TagHunter.Models.Metodo
{
    public class Finder
    {
        public static List<Cliente> Load()
        {

            return Prepare(Hunt());
        }
        private static List<string> Hunt()
        {
            var Lista = new List<string>();
            string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "web.config", SearchOption.AllDirectories);
            foreach (var item in filePaths)
            {
                Lista.Add(item);
            }
            return Lista;
        }
        private static List<Cliente> Prepare(List<string> lista)
        {
            var listaClientes = new List<Cliente>();
            foreach (var caminho in lista)
            {
                if (!caminho.Contains("\\Server\\ApWebDispatcher\\.net"))
                    continue;
                using (var sr = new StreamReader(caminho))
                {
                    Regex oTED = new Regex(@"(?<=offlineTimeEventsDirectory="")[^""]*");
                    Regex uS = new Regex(@"(?<=userSessions="")[^""]*");
                    Regex uSD = new Regex(@"(?<=userStateDirectory="")[^""]*");
                    Regex uSsD = new Regex(@"(?<=userSessionsDirectory="")[^""]*");

                    var arquivo = sr.ReadToEnd();

                    Match matchOTED = oTED.Match(arquivo);
                    Match matchUS = uS.Match(arquivo);
                    Match matchUSD = uSD.Match(arquivo);
                    Match matchUSsD = uSsD.Match(arquivo);

                    var caminhoSplit = caminho.Split("APW_");
                    var clienteIndexFim = caminhoSplit[1].Split('\\')[0].Length;

                    var nome = caminhoSplit[1].Substring(0, clienteIndexFim);
                    var divisaoId = caminhoSplit[0].Split('C');

                    var id = int.Parse(divisaoId[divisaoId.Count()-1].Substring(0, 3));


                    var cliente = new Cliente(
                        id,
                        nome,
                        matchOTED.Value,
                        matchUS.Value,
                        matchUSD.Value,
                        matchUSsD.Value,
                        caminho
                        );
                    listaClientes.Add(cliente);
            }
            }
            return listaClientes;
        }
    }
}
