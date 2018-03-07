<Query Kind="Program">
  <Connection>
    <ID>28bf489a-42f6-4ca3-a747-9ca78e53168b</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>CadeMeuMedicoDB</Database>
  </Connection>
</Query>

void Main()
{
	CriarCidades();
	ListarCidades();

	var rioDeJaneiro = Cidades.FirstOrDefault(x => x.Nome == "Rio de Janeiro");
	ApagarCidade(rioDeJaneiro);
	ListarCidades();

	CriarMedicos();
	ListarMedicos();
}

public bool CidadeCadastrada(Cidade cidade)
{
	var cid = Cidades.FirstOrDefault(x => x.Nome.Contains(cidade.Nome));
	return cid != null;
}

public void CriarCidades()
{
	var lisboa = new Cidade
	{
		IDCidade = 1,
		Nome = "Lisboa"
	};
	if (!CidadeCadastrada(lisboa))
	{
		Cidades.InsertOnSubmit(lisboa);
	}

	var porto = new Cidade
	{
		IDCidade = 2,
		Nome = "Porto"
	};
	if (!CidadeCadastrada(porto))
	{
		Cidades.InsertOnSubmit(porto);
	}

	var rioDeJaneiro = new Cidade
	{
		IDCidade = 3,
		Nome = "Rio de Janeiro"
	};
	if (!CidadeCadastrada(rioDeJaneiro))
	{
		Cidades.InsertOnSubmit(rioDeJaneiro);
	}
	SubmitChanges();
}

public void ListarCidades()
{
	Cidades.Dump();
}

public void ApagarCidade(Cidade cidade)
{
	Cidades.DeleteOnSubmit(cidade);
	SubmitChanges();
}


public bool MedicoCadastrado(Medico medico)
{
	var resultado = Medicos.FirstOrDefault(x => x.Nome.Contains(medico.Nome));
	return resultado != null;
}


public void CriarMedicos()
{
	var doutorArmando = new Medico
	{
		IDMedico = 1,
		Nome = "Armando Nonato",
		Bairro = "Centro"
	};
	if (!MedicoCadastrado(doutorArmando))
	{
		Medicos.InsertOnSubmit(doutorArmando);
	}

	var doutorHaroldo = new Medico
	{
		IDMedico = 2,
		Nome = "Haroldo Soares",
		Bairro = "Alentejo",
		Cidade = Cidades.FirstOrDefault(x => x.Nome.Contains("Lisboa"))
	};
	if (!MedicoCadastrado(doutorHaroldo))
	{
		Medicos.InsertOnSubmit(doutorHaroldo);
	}

	SubmitChanges();
}

public void ListarMedicos()
{
	Medicos.Dump();
}

public void AdicionarMedico(Cidade cidade, Medico medico)
{
	//medico.Cidade = cidade;

	cidade.Medicos.Add(medico);
	SubmitChanges();
}