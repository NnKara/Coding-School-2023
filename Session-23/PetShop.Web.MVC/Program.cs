using PetShop.EF.Repository;
using PetShop.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<EntityInterface<Customer>, CustomerRepo>();
//builder.Services.AddScoped<EntityInterface<Customer>, MockRepoCustomers>();
builder.Services.AddScoped<EntityInterface<Employee>, EmployeeRepo>();
builder.Services.AddScoped<EntityInterface<Employee>, MockRepoEmployees>();
builder.Services.AddScoped<EntityInterface<Pet>, PetRepo>();
builder.Services.AddScoped<EntityInterface<PetFood>, PetFoodRepo>();
builder.Services.AddScoped<EntityInterface<Transaction>, TransactionRepo>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
