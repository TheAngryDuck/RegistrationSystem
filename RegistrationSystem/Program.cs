using Microsoft.EntityFrameworkCore;
using RegistrationSystemDataLayer;
using RegistrationSystem.Utils;
using Syncfusion.Blazor;
using RegistrationSystemDataLayer.Interface;
using RegistrationSystemDataLayer.Repository;
using RegistrationSystemDataLayer.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<RegistrationSystemContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IEventRepository, EventRepository>();
builder.Services.AddTransient<IParticipantRepository, ParticipantRepository>();
builder.Services.AddTransient<IParticipantInEventRepository, ParticipantInEventRepository>();
builder.Services.AddTransient<IPaymentMethodRepository, PaymentMethodRepository>();
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<IParticipantService, ParticipantService>();
builder.Services.AddTransient<IPaymentMethodService, PaymentMethodService>();
builder.Services.AddTransient<IParticipantInEventService, ParticipantInEventService>();
builder.Services.AddSingleton<EventUtils, EventUtils>();
builder.Services.AddSyncfusionBlazor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
