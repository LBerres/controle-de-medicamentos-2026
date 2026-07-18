// Objetivo: Rodar Um Servidor Web
// Servidor Web: Um Programa Que Executa Na Rede Local/Remota
// ... E Espera Por Requisições Externas
// ... Geralmente Responde com Arquivos HTML, CSS, JS, Imagens, etc (Páginas Web)

// Objeto De Configuração Do Servidor Web
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Habilitar o MVC (Model - View - Controller) Para Que O Servidor Web Entenda Requisições HTTP
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

// Middlewares: Funções Que Executam À Cada Requisições e Respostas
app.UseRouting();
app.MapDefaultControllerRoute(); // {controller=Home}/{action=Index}/{id?}


// Executa O Servidor Web
app.Run();
