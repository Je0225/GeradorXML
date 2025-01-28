using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorXML {
  public abstract class Model {

    protected virtual String? Nome { get; init; }

    public virtual Object? Valor { get; init; }

    protected List<ElementModel> Elementos { get; init; }

    protected Model(String nome, Object? valor) {
      Elementos = new List<ElementModel>();
      Nome = nome;
      Valor = valor;
    }

    protected Model() {
      Elementos = new List<ElementModel>();
    }

    public ElementModel AddElemento(String nome, Object? value = null) {
      ElementModel objeto = new ElementModel(nome, value);
      Elementos.Add(objeto);
      return objeto;
    }

    public abstract String AsString();

  }
}
