using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]

    public class NecoException : Exception
    {
        public List<Error> Errors { get; private set; }

            public NecoException(List<Error> errors) 
            {
            this.Errors = errors;
            }

        //Daqui para baixo é apenas código que o proprio VS gera
        //pra gente poder utilizar esta exceção
            public NecoException(string message) : base(message) { }
            public NecoException(string message, Exception inner) : base(message, inner) { }
            protected NecoException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
