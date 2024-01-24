using NutrinfoWeb.Models;

namespace NutrinfoWeb.Services
{
    public interface IBerriaService
    {
        Task<Berria> BerriaSortu(Berria berria);
    }
}
