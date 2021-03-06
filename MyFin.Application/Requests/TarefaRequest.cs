﻿using System;
using MyFin.Domain.Models;

namespace MyFin.Application.Requests
{
    public class TarefaRequest
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public object PontosPrevistos { get; set; }
        public object PontosRealizados { get; set; }

        public decimal? Valor { get; set; }
        public ContaRequest Conta { get; set; }
        public DateTime? DataVcto { get; set; }
        public DateTime? DataPgto { get; set; }

        public bool Concluido { get; set;}

        public Tarefa ToModel(int? id = null)
        {
            if (id.HasValue)
            {
                return new Tarefa(id.Value,
                                  this.Descricao,
                                  this.Data,
                                  this.PontosPrevistos,
                                  this.PontosRealizados,
                                  this.Valor,
                                  this.Conta?.ToModel(),
                                  this.DataVcto,
                                  this.DataPgto,
                                  this.Concluido);
            }

            return new Tarefa(this.Descricao,
                              this.Data,
                              this.PontosPrevistos,
                              this.PontosRealizados,
                              this.Valor,
                              this.Conta?.ToModel(),
                              this.DataVcto,
                              this.DataPgto,
                              this.Concluido);            
        } 
    }
}
