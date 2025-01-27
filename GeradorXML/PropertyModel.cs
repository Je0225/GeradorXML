using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorXML {
  public sealed class PropertyModel : Model{

    private object Valor { get; }

    public PropertyModel(String nome, Object valor)
      : base(nome, valor) {
      Nome = nome;
      Valor = valor;
      Elementos = new List<Model>();
    }

    public override String AsString() {
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
          valor = $"\"{valor}\"";
          break;
        case "Double":
          valor = valor.ToString()?.Replace(",", ".");
          break;
        case "Boolean":
          valor = valor.ToString()?.ToLower();
          break;
      }
      return String.IsNullOrEmpty(Nome) ? valor?.ToString()! : $"<{Nome}>{valor}</{Nome}>";
    }
  }
}
