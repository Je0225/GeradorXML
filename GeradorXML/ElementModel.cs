using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorXML {
  public class ElementModel : Model {

    public ElementModel(String nome, Object? value) : base(nome, value) {
      Nome = nome;
      Elementos = new List<ElementModel>();
    }

    private readonly List<String> Atributos = new List<String>();

    protected ElementModel(){}

    public void AddAtributo(String nome, Object valor) {
      Atributos.Add(EscreveAtributo(nome,valor));
    }

    private String EscreveAtributo(String nomeAtributo, Object? valorAtributo) {
      Object? valor = valorAtributo;
      switch (valor?.GetType().Name) {
        case null:
          valor = "null";
          break;
        case "DateTime":
          DateTime dateTime = (DateTime)valor;
          valor = dateTime.ToString("yyyyMMdd");
          break;
        case "DateOnly":
          DateOnly date = (DateOnly)valor;
          valor = date.ToString("yyyyMMdd");
          break;
        case "String":
          valor = $"{valor}";
          break;
        case "Double":
          valor = valor.ToString()?.Replace(",", ".");
          break;
        case "Boolean":
          valor = valor.ToString()?.ToLower();
          break;
      }
      return $"{nomeAtributo}=\"{valor}\"";
    }

    private String StringAtributos() {
      String atributos = "";
      foreach (String atributo in Atributos) {
        atributos += $" {atributo}";
      }
      return atributos ;
    }

    private String EscreveTiposGenericos() {
      Object? valor = Valor;
      switch (valor?.GetType().Name) {
        case null:
          valor = "null";
          break;
        case "DateTime":
          DateTime dateTime = (DateTime)valor;
          valor = dateTime.ToString("yyyyMMdd");
          break;
        case "DateOnly":
          DateOnly date = (DateOnly)valor;
          valor = date.ToString("yyyyMMdd");
          break;
        case "String":
          valor = $"{valor}";
          break;
        case "Double":
          valor = valor.ToString()?.Replace(",", ".");
          break;
        case "Boolean":
          valor = valor.ToString()?.ToLower();
          break;
      }
      return String.IsNullOrEmpty(Nome) ? valor?.ToString()! : $"<{Nome}{StringAtributos()}>{valor}</{Nome}>";
    }

    public override String AsString() {
      String texto = "";
      texto += $"<{Nome}{StringAtributos()}>";
      if (Elementos.Count == 0) {
        return  $"<{Nome}{StringAtributos()}/>";
      }
      foreach (ElementModel elemento in Elementos) {
        if (elemento.Valor != null) {
          texto += elemento.EscreveTiposGenericos();
        } else {
          texto += elemento.AsString();
        }
      }
      texto += $"</{Nome}>";
      return texto;
    }

  }
}
