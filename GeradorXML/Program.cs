using GeradorXML;


Xml xml = new Xml();

ElementModel teste = xml.AddElemento("teste");
ElementModel giovano = xml.AddElemento("pessoa");
giovano.AddAtributo("ID", 10);
ElementModel atrib = giovano.AddElemento("nome", "giovano");
atrib.AddAtributo("dev", "delphi");
giovano.AddElemento("foda", true);
giovano.AddElemento("teste", null);
giovano.AddElemento("outroTeste");
ElementModel numerosMegasena = giovano.AddElemento("megasena");
numerosMegasena.AddElemento("Numero",10);
numerosMegasena.AddElemento("Numero",26);
numerosMegasena.AddElemento("Numero",29);
numerosMegasena.AddElemento("Numero",33);
numerosMegasena.AddElemento("Numero",52);
numerosMegasena.AddElemento("Numero",58);
ElementModel provas = xml.AddElemento("provas");
ElementModel provaPt = provas.AddElemento("provaPort");
provaPt.AddElemento("nome", "portugues");
provaPt.AddElemento("nota", 9.5);
ElementModel provaMat = provas.AddElemento("ProvaMat");
provaMat.AddElemento("nome", "matematica");
provaMat.AddElemento("nota", 9);

Console.WriteLine(xml.AsString());

