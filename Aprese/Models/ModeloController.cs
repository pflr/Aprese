using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aprese.Models
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Cliente : BaseModel
    {
        public Cliente(string NomeCliente, string Natureza, int CNPJ, int CPF)
        {
            this.NomeCliente = NomeCliente;
            this.Natureza = Natureza;
            this.CNPJ = CNPJ;
            this.CPF = CPF;
        }

        //[Required]
        public string Id { get; private set; }
        //[Required]
        public string NomeCliente { get; private set; }
        //[Required]
        public string Natureza { get; private set; }

        public int CNPJ { get; private set; }

        public int CPF { get; private set; }

        public Cidade clienteCidade { get; private set; }
        public Status clienteStatus { get; private set; }

    }

    public class Status : BaseModel
    {

        public Status(string Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }

        public string Id { get; private set; }
        public string Nome { get; private set; }
    }


    public class Estado : BaseModel
    {
        public Estado(string Id, string NomeEstado, string UF)
        {
            this.Id = Id;
            this.NomeEstado = NomeEstado;
            this.UF = UF;
        }

        //[Required]
        public string Id { get; private set; }
        //[Required]
        public string NomeEstado { get; private set; }
        //[Required]
        public string UF { get; private set; }
    }


    public class Cidade : BaseModel
    {
        public Cidade(string Id, string NomeCidade, string Natureza)   
        {
            this.NomeCidade = NomeCidade;
            this.Natureza = Natureza;
        }

        //[Required]
        public string Id { get; private set; }
        //[Required]
        public string NomeCidade { get; private set; }
        //[Required]
        public string Natureza { get; private set; }

        public Estado nomeEstado { get; private set; }

    }

    public class Usuario : BaseModel
    {
        public Usuario(string Id, string User, string Categoria, string Tipo)
        {
            this.Id = Id;
            this.User = User;
            this.Categoria = Categoria;
            this.Tipo = Tipo;
        }

        //[Required]
        public string Id { get; private set; }
        //[Required]
        public string User { get; private set; }
        //[Required]
        public string Tipo { get; private set; }

        public string Categoria { get; private set; }

    }


    //public class ModeloController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}