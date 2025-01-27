using GeradorXML;


Xml xml = new Xml();

ObjectModel giovano = xml.AddObjeto("pessoa");
giovano.AddAtributo("nome", "giovano");
giovano.AddAtributo("foda", true);
giovano.AddAtributo("teste", null);
ObjectModel numerosMegasena = giovano.AddObjeto("megasena");
numerosMegasena.AddAtributo("Numero",10);
numerosMegasena.AddAtributo("Numero",26);
numerosMegasena.AddAtributo("Numero",29);
numerosMegasena.AddAtributo("Numero",33);
numerosMegasena.AddAtributo("Numero",52);
numerosMegasena.AddAtributo("Numero",58);
ObjectModel provas = xml.AddObjeto("provas");
ObjectModel provaPt = provas.AddObjeto("provaPort");
provaPt.AddAtributo("nome", "portugues");
provaPt.AddAtributo("nota", 9.5);
ObjectModel provaMat = provas.AddObjeto("ProvaMat");
provaMat.AddAtributo("nome", "matematica");
provaMat.AddAtributo("nota", 9);

Console.WriteLine(xml.AsString());

