// Objetivo: Rodar Um Servidor Web
// Servidor Web: Um Programa Que Executa Na Rede Local/Remota
// ... E Espera Por Requisições Externas
// ... Geralmente Responde com Arquivos HTML, CSS, JS, Imagens, etc (Páginas Web)

// Objeto De Configuração Do Servidor Web
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

WebApplication app = builder.Build();

// Executa O Servidor Web
app.Run();
