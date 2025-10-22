using HealthMate.BLL.Manager.AccountManager;
using HealthMate.DAL.Data.DbHelper;
using HealthMate.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HealthMate.DAL.Reposatiries;
using Microsoft.Extensions.Options;
using HealthMate.BLL.Manager.UsersManager;
using HealthMate.BLL.Manager.PatientManager;
using HealthMate.DAL.Reposatiries.VerificationCodeRepo;
using HealthMate.DAL.Reposatiries.VerificationCodeRepos;
using HealthMate.DAL.Reposatiries.ApplicationUserRepos;
using HealthMate.BLL.Manager.AdminManager;
using HealthMate.DAL.Reposatiries.AdminRepos;
using HealthMate.BLL.Manager.ConditionManager;
using HealthMate.BLL.Manager.EncounterManager;
using HealthMate.BLL.Manager.ObservationManager;
using HealthMate.DAL.Reposatiries.HealthCareProviderRepos;
using HealthMate.BLL.Manager.HealthCareProviderManager;
using HealthMate.BLL.Manager.HealthRecordManager;
using HealthMate.DAL.Reposatiries.HealthRecordRepos;
using HealthMate.BLL.Services;
using HealthMate.BLL.Manager.LabTestManager;
using HealthMate.BLL.Manager.MedicalRecordManager;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using HealthMate.DAL.Reposatiries.PatientRepos;
using HealthMate.BLL.Manager.UtilityManager;
using HealthMate.DAL.Reposatiries.ObservationRepos;
using HealthMate.DAL.Reposatiries.ConditionRepos;
using HealthMate.BLL.Manager.DocumentManager;
using HealthMate.BLL.Manager.BodySiteManager;
using HealthMate.BLL.Manager.MachineLearningManager;
using HealthMate.BLL.Manager.DiseaseManager;
using HealthMate.BLL.Manager;
using HealthMate.BLL.Manager.MessageManager;
using HealthMate.DAL.Reposatiries.MessageRepos;
using HealthMate.BLL.Managers;
using HealthMate.DAL.Repositories.Interfaces;
using HealthMate.DAL.Repositories;
using HealthMate.BLL.Manager.SinaChatbot;

namespace HealthMate
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			
			builder.Services.AddCors(options => {
				options.AddPolicy("HealthmateWebsite", policy => {
					//policy.WithOrigins("http://localhost:3000")
					//	  .AllowAnyHeader()
					//	  .AllowAnyMethod()
					//	  .AllowCredentials();
					policy.AllowAnyOrigin()
					.AllowAnyHeader()
					.AllowAnyMethod();
				});
			});

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddScoped<IGenericRepository<Admin>,GenericRepository<Admin>>();
			builder.Services.AddScoped<IGenericRepository<HealthCareProvider>, GenericRepository < HealthCareProvider >> ();
			builder.Services.AddScoped<IGenericRepository<VerificationCode>,GenericRepository<VerificationCode>>();
			builder.Services.AddScoped<IGenericRepository<Animal>, GenericRepository<Animal>>();
			builder.Services.AddScoped<IGenericRepository<Patient>, GenericRepository<Patient>>();
			builder.Services.AddScoped<IGenericRepository<Condition>, GenericRepository<Condition>>();
			builder.Services.AddScoped<IGenericRepository<Encounter>,GenericRepository<Encounter>>();
			builder.Services.AddScoped<IGenericRepository<Observation>,GenericRepository<Observation>>();
			builder.Services.AddScoped<IGenericRepository<LabTest>,GenericRepository<LabTest>>();
			builder.Services.AddScoped<IGenericRepository<LabTestResult>,GenericRepository<LabTestResult>>();
			builder.Services.AddScoped<IGenericRepository<Prescription>,GenericRepository<Prescription>>();
			builder.Services.AddScoped<IGenericRepository<Medicine>,GenericRepository<Medicine>>();
			builder.Services.AddScoped<IGenericRepository<MedicalImage>,GenericRepository<MedicalImage>>();
			builder.Services.AddScoped<IGenericRepository<PatientMedicine>,GenericRepository<PatientMedicine>>();
			builder.Services.AddScoped<IGenericRepository<BodySite>,GenericRepository<BodySite>>();	
			builder.Services.AddScoped<IGenericRepository<Disease>,GenericRepository<Disease>>();
			

			builder.Services.AddScoped<IVerificationCodeRepo, VerificationCodeRepo>();
			builder.Services.AddScoped<IApplicationUserRepo, ApplicationUserRepo>();
			builder.Services.AddScoped<IAdminRepo, AdminRepo>();
			builder.Services.AddScoped<IHealthCareProviderRepo, HealthCareProviderRepo>();	
			builder.Services.AddScoped<IHealthRecordRepo, HealthRecordRepo>();
			builder.Services.AddScoped<ILabTestAttributeRepo,LabTestAttributeRepo>();
			builder.Services.AddScoped<IPatientRepo,PatientRepo>();
			builder.Services.AddScoped<IObservationRepo,ObservationRepo>();
			builder.Services.AddScoped<IConditionRepo,ConditionRepo>();
			builder.Services.AddScoped<IValidationRepo, ValidationRepo>();
			builder.Services.AddScoped<IMedicineRepo, MedicineRepo>();
			builder.Services.AddScoped<IReporterRepo, ReporterRepo>();
			builder.Services.AddScoped<IMessageRepo,MessageRepo>();
			builder.Services.AddScoped<IMentalHealthAssessmentRepo,MentalHealthAssessmentRepository>();
			
			
			
			builder.Services.AddScoped<IEmailService, EmailService>();
			builder.Services.AddScoped<IUserManager, UserManager>();
			builder.Services.AddScoped<IPatientManager, PatientManager>();
			builder.Services.AddScoped<IAccountManager, AccountManager>();
			builder.Services.AddScoped<IAdminManager, AdminManager>();
			builder.Services.AddScoped<IConditionManager, ConditionManager>();
			builder.Services.AddScoped<IEncounterManager, EncounterManager>();
			builder.Services.AddScoped<IObservationManager, ObservationManager>();
			builder.Services.AddScoped<IHealthCareProviderManager, HealthCareProviderManager>();
			builder.Services.AddScoped<IHealthRecordManager, HealthRecordManager>();
			builder.Services.AddScoped<ILabTestManager,LabTestManager>();
			builder.Services.AddScoped<IRecordImageManager,RecordImageManager>();
			//builder.Services.AddScoped<IPatientManager,PatientManager>();
			builder.Services.AddScoped<IUtilityManager,UtilityManager>();
			builder.Services.AddScoped<IDocumentManager, DocumentManager>();
			builder.Services.AddScoped<IBodySiteManager, BodySiteManager>();
			builder.Services.AddScoped<IMachineLearningManager,MachineLearningManager>();
			builder.Services.AddScoped<IDiseaseManager,DiseaseManager>();
			builder.Services.AddScoped<IReporter,Reporter>();
			builder.Services.AddScoped<IMessageManager,MessageManager>();
			builder.Services.AddScoped<IMentalHealthAssessmentManager,MentalHealthAssessmentManager>();

			builder.Services.AddScoped<IFileService,FileService>();

			// register sina chatbot
			builder.Services.AddScoped<ContextBuilder>();
			builder.Services.AddScoped<PromptResolver>();
			builder.Services.AddScoped<SinaManager>();
			// register gemini client
			builder.Services.AddHttpClient<GeminiClient>();
			builder.Services.Configure<GeminiConfig>(builder.Configuration.GetSection("Gemini"));

			
			builder.Services.AddDbContext<HealthMateContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("HostingConnection"))); // for sequential

			builder.Services.AddDbContextFactory<HealthMateContext>(options =>
    		options.UseSqlServer(builder.Configuration.GetConnectionString("HostingConnection")),ServiceLifetime.Scoped); // for parallel 

			builder.Services.AddIdentity<ApplicationUser,IdentityRole>(Options => {
				//Options.Password.RequiredLength = 10;
				//Options.Password.RequireLowercase = true;
				//Options.Password.RequireUppercase = true;
				Options.Password.RequireDigit = false;
				Options.User.RequireUniqueEmail = true;
			}).AddEntityFrameworkStores<HealthMateContext>().AddDefaultTokenProviders();
			

			

			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = builder.Configuration["Jwt:Issuer"],
					ValidAudience = builder.Configuration["Jwt:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
				};
			});

			builder.Services.AddAuthorization(Options => {
				Options.AddPolicy("PatientOnly",policy => policy.RequireRole("Patient"));
				Options.AddPolicy("AdminOnly",policy => policy.RequireRole("Admin"));
				Options.AddPolicy("HealthCareProviderOnly",policy => policy.RequireRole("HealthCareProvider"));
				Options.AddPolicy("PatientOrHealthCareProvider",policy => policy.RequireRole("Patient","HealthCareProvider"));
			});


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseStaticFiles();
			
			app.UseHttpsRedirection();

			app.UseCors("HealthmateWebsite");

			app.UseAuthentication();

			app.UseAuthorization();

			


			app.MapControllers();

			app.Run();
		}
	}
}
