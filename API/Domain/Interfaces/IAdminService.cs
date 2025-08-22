using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domain.DTOs;
using minimal_api.Domain.Entities;

namespace minimal_api.Domain.Interfaces
{
    public interface IAdminService
    {
        Admin? Login(LoginDTO loginDTO);
        Admin Incluir(Admin admin);
        Admin? BuscaPorId(int id);
        List<Admin> Todos(int? pagina);
    }
}