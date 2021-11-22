using System;

namespace TagHunter.Models
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string OfflineTimeEventsDirectory { get; set; }
        public string UserSessions { get; set; }
        public string UserStateDirectory { get; set; }
        public string UserSessionsDirectory { get; set; }
        public string Caminho { get; private set; }

        public Cliente(int id, string nome, string oTED, string uS, string uSD, string uSsD, string caminho)
        {
            Id = id;
            Nome = nome;
            OfflineTimeEventsDirectory = oTED == "" ? "nulo" : oTED;
            UserSessions = uS == "" ? "nulo" : uS;
            UserStateDirectory = uSD == "" ? "nulo" : uSD;
            UserSessionsDirectory = uSsD == "" ? "nulo" : uSsD;
            Caminho = caminho;
        }
        public override string ToString()
        {
            var log =
                $"Valores web.config ({Nome}[{Id}] - {DateTime.Now}):\n" +
                $"OfflineTimeEventsDirectory=\"{OfflineTimeEventsDirectory}\"\n" +
                $"UserSessions=\"{UserSessions}\"\n" +
                $"UserStateDirectory=\"{UserStateDirectory}\"\n" +
                $"UserSessionsDirectory=\"{UserSessionsDirectory}\"\n" +
                $"({Caminho})";
            return log;
        }
    }
}
