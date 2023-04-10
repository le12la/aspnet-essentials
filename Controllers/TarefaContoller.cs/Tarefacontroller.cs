using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;
public class tarefacontroller:Controller {


// view = página web (site)
//funções
public IActionResult Index(){

    ViewData["cabecalho"] = "tarefa diária";
    ViewData["titulo"] = "planejar aula senai";
    ViewData["descricao"] = "criar nova PEUC";
    return View();
 }

}