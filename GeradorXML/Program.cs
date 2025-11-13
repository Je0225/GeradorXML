using GeradorXML;

Xml xml = new Xml();

ElementModel teste = xml.AddElemento("exemplo");
ElementModel jeni = xml.AddElemento("pessoa");
jeni.AddAtributo("ID", 10);
ElementModel atrib = jeni.AddElemento("nome", "Jeni");
atrib.AddAtributo("dev", "backend");
jeni.AddElemento("devDelphi", true);
jeni.AddElemento("elementoNulo", null);
jeni.AddElemento("elementoVazio");
ElementModel numerosMegasena = jeni.AddElemento("numerosMegasena");
numerosMegasena.AddElemento("numero",10);
numerosMegasena.AddElemento("numero",26);
numerosMegasena.AddElemento("numero",29);
numerosMegasena.AddElemento("numero",33);
numerosMegasena.AddElemento("numero",52);
numerosMegasena.AddElemento("numero",58);
ElementModel provas = xml.AddElemento("provas");
ElementModel provaPt = provas.AddElemento("provaPortugues");
provaPt.AddElemento("nome", "portugues");
provaPt.AddElemento("nota", 9.5);
ElementModel provaMat = provas.AddElemento("ProvaMatematica");
provaMat.AddElemento("nome", "matematica");
provaMat.AddElemento("nota", 9);

Console.WriteLine(xml.AsString());

