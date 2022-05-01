﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; } 

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Obrigatório informar a descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int KM { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de Combustível")]
        [Required(ErrorMessage = "Obrigatório informar o tipo do combustível!")]
        public TipoCombustivel Tipo { get; set; }

        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}