using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorXML {

  internal class Xml : ObjectModel {

    protected override String Nome => "xml";

    public Xml(): base() { }

    public override String AsString() {
      String texto = "";
      foreach (Model elemento in Elementos) {
        texto += elemento.AsString();
      }
      return texto;
    }
  }
}
