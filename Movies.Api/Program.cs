using Movies.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddSystemConfiguration();
builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddConfiguredSwaggerGen(builder.Configuration);
builder.Services.AddCorsHeaders(builder.Configuration);
builder.Services.AddControllerConfiguration();
builder.Services.AddDependencyConfiguration();
builder.Services.AddAutoMappersDynamic();
builder.Services.AddErrorHandlerMiddleware();
builder.Services.AddRazorPages();


var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();
app.UseConfiguredCors();
app.UseRouting();
app.UseErrorHandlerMiddleware();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseConfiguredSwagger();

app.Run();