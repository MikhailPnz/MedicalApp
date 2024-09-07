using MedicalApp.Services.Interfaces;
using System.Numerics;

namespace MedicalApp.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly HospitalAppContext _context;
        private readonly IListEntityService<Doctor> _listDoctorService;
        private readonly IMapper _mapper;

        public DoctorService(
            HospitalAppContext context,
            IListEntityService<Doctor> listDoctorService,
            IMapper mapper)
        {
            _context = context;
            _listDoctorService = listDoctorService;
            _mapper = mapper;
        }
    }
}
