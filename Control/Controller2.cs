﻿using AulaMVC01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVC01.Control
{
    public static class Controller2
    {
        ///////////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string[]> SelectAll(string table)
        {
            if (!string.IsNullOrEmpty(table))
            {
                return DBFunction.GenericSelectAll(table);
            }
            else
            {
                return new List<string[]>();
            }
        }

        public static List<string> SelectAllFree()
        {
            return DBFunction.GenericUnitSelect("idEstacionamento", "Estaciona", "Placa is null");

        }

        public static List<string> SelectAllOccupied()
        {
            return DBFunction.GenericUnitSelect("Placa", "Estaciona", "Placa is not null");
        }

        public static bool AtualizaEntrada(string placa, string horaEntrada, string vaga)
        {
            if (!string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(horaEntrada) && !string.IsNullOrEmpty(vaga))
            {
                return EstacionamentoDB.AtualizaEntrada(placa, horaEntrada, vaga);
            }
            else
            {
                return false;
            }

        }

        public static double AtualizaSaida(string placa, string horaSaida, bool lavou)
        {
            if (!string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(horaSaida))
            {
                List<string> horaE = DBFunction.GenericUnitSelect("HoraEntrada", "Estaciona", $"Placa = '{placa}'");

                double horaEntrada = -1;

                foreach (var item in horaE)
                {
                    horaEntrada = Convert.ToDouble(item);
                }

                if (horaEntrada == -1)
                {
                    // devolve -1 para a view avisar que deu ruim
                    return horaEntrada;
                }
                else
                {
                    // Calcula o valor
                    double valorFinal = (Convert.ToDouble(horaSaida) - horaEntrada) * 3.5;

                    if (lavou)
                    {
                        valorFinal += 60;
                    }
                    EstacionamentoDB.AtualizaSaida(placa);
                    return valorFinal;
                }
            }
            else
            {
                return -2;
            }



        }

    }



}
