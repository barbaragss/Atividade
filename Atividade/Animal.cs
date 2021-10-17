using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class Animal
    {
        private String _tipo;
        private String _nome;
        
        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                this._nome = value;
            }
        }
        public String Tipo
        {
            get { return _tipo; }

            set
            {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    _tipo = value;
                }
                else
                {
                    this._tipo = "Peixe";
                }
            }
        }
    }
}
