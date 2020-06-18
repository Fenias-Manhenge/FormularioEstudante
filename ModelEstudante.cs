using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OleDb;

namespace FormularioEstudante
{
    class ModelEstudante
    {
        private string nome, turma, contacto;
        private int codigo;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetTurma()
        {
            return turma;
        }

        public void SetTurma(string turma)
        {
            this.turma = turma;
        }

        public string GetContacto()
        {
            return contacto;
        }

        public void SetContacto(string contacto)
        {
            this.contacto = contacto;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public ModelEstudante(int codigo, string nome, string turma, string contacto)
        {
            this.nome = nome;
            this.turma = turma;
            this.contacto = contacto;
            this.codigo = codigo;
        }

        public ModelEstudante()
        {

        }
        
        
    }
}
