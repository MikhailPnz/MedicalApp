using MedicalApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicalApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : Controller
    {
        private IDoctorService DoctorService { get; }

        public DoctorController(IDoctorService doctorService)
        {
            DoctorService = doctorService;
        }
    }
}
