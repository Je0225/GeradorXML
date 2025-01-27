using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorXML {
  public abstract class Model {

    protected virtual String? Nome { get; init; }

    protected String Abertura => $"<{Nome}>";

    protected String Fechamento => $"</{Nome}>";

    protected List<Model> Elementos { get; init; }

    protected Model(String nome, Object valor) {
      Elementos = new List<Model>();
      Nome = nome;
    }

    protected Model(String nome) {
      Elementos = new List<Model>();
      Nome = nome;
    }

    protected Model() {
      Elementos = new List<Model>();
    }

    public void AddAtributo(String nome, Object value) {
      PropertyModel property = new PropertyModel(nome, value);
      Elementos.Add(property);
    }

    public ObjectModel AddObjeto(String nome) {
      ObjectModel objeto = new ObjectModel(nome);
      Elementos.Add(objeto);
      return objeto;
    }

    public abstract String AsString();

  }
}
