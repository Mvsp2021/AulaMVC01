using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVC01.Model
{
    public static class EstacionamentoDB
    {
        private static SqlConnection Connection { get; set; } = DBFunction.Connection;

        public static bool AtualizaEntrada(string placa, string horaEntrada, string vaga)
        {

            // {Convert.ToDouble(horaEntrada).ToString(CultureInfo.InvariantCulture)}
            // Serve para trasnformar o numero com , em numero com .
            string update = $"UPDATE dbo.Estaciona Set Placa = '{placa}', HoraEntrada = {Convert.ToDouble(horaEntrada).ToString(CultureInfo.InvariantCulture)} WHERE idEstacionamento = {vaga}";

            DBFunction.GenericExecute(update);
            return true;

        }

        public static bool AtualizaSaida(string placa)
        {
            string update = $"UPDATE dbo.Estaciona Set Placa = null, HoraEntrada = 0 WHERE Placa = '{placa}'";
            DBFunction.GenericExecute(update);
            return true;

        }

    }
}
