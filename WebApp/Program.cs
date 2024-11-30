var builder = WebApplication.CreateBuilder(args);

//Step 3: Dependency injection of MapControllerRoute
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Step 4: Bootstrap, will be able to go into wwwrooot to locate the static file that is requested
app.UseStaticFiles();

//we need to add the routing capabilities(it maps the request to the method inside the controller)
//Step1: enable MVC framework
app.UseRouting();

//Step2: maps the http request to the particular action method
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();