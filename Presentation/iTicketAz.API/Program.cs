using iTicketAz.BLL;
using iTicketAz.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddFluentValidation();  // => BLL
builder.Services.AddBLLServices();
builder.Services.AddDALServices();
builder.WebHost.UseSentry(o =>
{
    o.Dsn = "https://6ec031634f4f47d7a5fb44d5674d0af2@o4504912081518592.ingest.sentry.io/4505070440415232";
    o.Debug = true;
    o.TracesSampleRate = 1.0;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRateLimiter();

app.UseSentryTracing();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
