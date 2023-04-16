using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        /* CLIENTES - Nesse trecho do código são criadas as instâncias
        de clientes. Os clientes são criados respeitando os parâmetros 
        solicitados no construtor que está no model Cliente. */
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        

        /* No código abaixo é criada uma lista chamada listaClientes para 
        os objetos clientes e em seguida todos os clientes criados anteriormente 
        são adicionados a essa lista.*/
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        /* O Viewbag funciona como uma "bolsa" para os dados. Com esse recurso 
        você consegue envia os dados para as views. No código abaixo a listaClientes 
        está sendo preparada para ser usada na View que vai exxibir os dados. */
        ViewBag.listaClientes = listaClientes;



        /* FORNECEDORES - Nesse trecho do código são criadas as instâncias
        de fornecedores. Os fornecedores são criados respeitando os parâmetros 
        solicitados no construtor que está no model Cliente. */
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        /* No código abaixo é criada uma lista chamada listaFornecedores 
        para os objetos fornecedores e em seguida todos os fornecedores 
        criados anteriormente são adicionados a essa lista.*/
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        /* O Viewbag funciona como uma "bolsa" para os dados. Com esse recurso 
        você consegue envia os dados para as views. No código abaixo a listaFornecedores 
        está sendo preparada para ser usada na View que vai exxibir os dados. */
        ViewBag.listaFornecedores = listaFornecedores;



        /* A linha abaixo vem por default nessa função. Ela retorna 
        para a view com todas as informações que enviamos. */
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
