using myapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HelloWorldSevice>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<AddNumbersService>(); 
builder.Services.AddScoped<MadLibService>(); 
builder.Services.AddScoped<OddOrEvenService>(); 
builder.Services.AddScoped<ReverseAlphaNumService>(); 
builder.Services.AddScoped<ReverseNumService>(); 
builder.Services.AddScoped<Magic8BallService>(); 
builder.Services.AddScoped<GuessItService>(); 
builder.Services.AddScoped<ResturantPickerService>(); 

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
