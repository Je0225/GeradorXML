using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorXML {
  public class ObjectModel : Model {

    public ObjectModel(String nome) : base (nome){
      Nome = nome;
      Elementos = new List<Model>();
    }

   protected ObjectModel():base(){}

    public override String AsString() {
      String texto = "";
      texto += Abertura;
      foreach (Model elemento in Elementos) {
        texto += elemento.AsString();
      }
      texto += Fechamento;
      return texto;
    }

  }
}
