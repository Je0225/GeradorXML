namespace GeradorXML {

  internal class Xml : ElementModel {

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
