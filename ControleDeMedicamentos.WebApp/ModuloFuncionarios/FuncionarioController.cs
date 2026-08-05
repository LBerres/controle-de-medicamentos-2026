using ControleDeMedicamentos.WebApp.Compartilhado.Arquivos;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeMedicamentos.WebApp.ModuloFuncionarios;

public sealed class FuncionarioController : Controller
{

    private readonly RepositorioFuncionarioEmArquivo repositorioFuncionario;

    public FuncionarioController()
    {
        ContextoJson contextoJson = new ContextoJson();

        contextoJson.Carregar();

        repositorioFuncionario = new RepositorioFuncionarioEmArquivo(contextoJson);
    }
    [HttpGet]
    public ActionResult Listar()
    {
        List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();

        List<ListarFuncionarioViewModel> viewModels = new List<ListarFuncionarioViewModel>();

        foreach (Funcionario f in funcionarios)
        {
            // Records São Imutáveis, Ou Seja, Seus Valores Não Podem Ser Alterados Depois De Criados
            ListarFuncionarioViewModel vm = new ListarFuncionarioViewModel(f.Id, f.Nome, f.Telefone);
            viewModels.Add(vm);
        }

        return View(viewModels);
    }

    [HttpGet]
    public ActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Cadastrar(CadastrarFuncionarioViewModel cadastrarVm)
    {
        Funcionario funcionario = new Funcionario(cadastrarVm.Nome, cadastrarVm.Telefone, cadastrarVm.Cpf);

        repositorioFuncionario.Cadastrar(funcionario);

        return RedirectToAction(nameof(Listar));
    }
}
