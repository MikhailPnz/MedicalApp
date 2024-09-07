using System.Numerics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddMemoryCache();

//builder.Services.AddAutoMapper(typeof(HospitalAppMappingProfile));

//builder.Services.AddDbContext<HospitalAppContext>();

//builder.Services.AddTransient<IListEntityService<Doctor>, ListEntityService<Doctor>>();

//builder.Services.AddTransient<IDoctorService, DoctorService>();

//builder.Services.AddTransient<IListEntityService<Patient>, ListEntityService<Patient>>();

//builder.Services.AddTransient<IPatientService, PatientService>();

//builder.Services.AddTransient<INsiService, NsiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
